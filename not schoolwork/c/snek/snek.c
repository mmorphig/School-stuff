#include <SDL2/SDL.h>
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define SCREEN_WIDTH 1600
#define SCREEN_HEIGHT 900
#define CELL_SIZE 20

/* 
 * Needs at least 90MB free RAM at 1600x900 & cell size 20, will vary depending on size (the snake length array is a bunch of it).
 * Also needs a graphical display, obviously for sdl2.
 * Written on Linux (I use Arch btw).
 */

// Define the direction of the snake
typedef enum {
  MOVEUP,
  MOVEDOWN,
  MOVELEFT,
  MOVERIGHT,
  NO
} Direction;

// Define the structure of a single cell in the game grid
typedef struct {
  int x, y;
} Cell;

typedef struct {
  int x, y;
  enum {NONE, HORIZONTAL, VERTICAL, UP, UPLEFT, LEFT, DOWNLEFT, DOWN, DOWNRIGHT, RIGHT, UPRIGHT} direction;
} SnakeCell;

// Function prototypes
void drawCell(SDL_Renderer *renderer, int x, int y, char color, char cellDirection, char prevDirection);
void drawGrid(SDL_Renderer *renderer);
void generateFood();
bool checkCollision(int x, int y);
void update(SDL_Renderer *renderer);
void handleInput(SDL_Event *event);

// Global variables
Direction direction[3];
SnakeCell snake[SCREEN_HEIGHT*SCREEN_WIDTH/CELL_SIZE]; // Max size of the snake
Cell food;
bool expandHeld = false;
int snakeLength = 100; // Initial length of the snake

int main() {
  SDL_Window *window = NULL;
  SDL_Renderer *renderer = NULL;
  SDL_Event event;
  bool running = true;
  
  // Initialize SDL
  if (SDL_Init(SDL_INIT_VIDEO) < 0) {
    printf("SDL could not initialize! SDL_Error: %s\n", SDL_GetError());
    return 1;
  }

  // Create window
  window = SDL_CreateWindow("Snake Game", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, SCREEN_WIDTH, SCREEN_HEIGHT, SDL_WINDOW_SHOWN);
  if (window == NULL) {
    printf("Window could not be created! SDL_Error: %s\n", SDL_GetError());
    return 1;
  }

  // Create renderer
  renderer = SDL_CreateRenderer(window, -1, SDL_RENDERER_ACCELERATED);
  if (renderer == NULL) {
    printf("Renderer could not be created! SDL_Error: %s\n", SDL_GetError());
    return 1;
  }
  
  // Set initial direction
  direction[2] = MOVERIGHT;

  // Set up initial position of the snake
  snake[0].x = SCREEN_WIDTH / (2 * CELL_SIZE);
  snake[0].y = SCREEN_HEIGHT / (2 * CELL_SIZE);

  // Seed the random number generator
  srand(time(NULL));

  // Generate initial food position
  generateFood();
  
  printf("Snake will use up to %luKiB of RAM\n", sizeof(snake)/1024);

  // Main loop
  while (running) {
    // Update the game
    update(renderer);
    
    // Clear the screen
    SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
    SDL_RenderClear(renderer);

    // Draw the game elements
    drawCell(renderer, food.x, food.y, 'r', NONE, NONE);
    drawCell(renderer, snake[0].x, snake[0].y, 'g', NONE, NONE);
    for (int i = 1; i < snakeLength; i++) {
      drawCell(renderer, snake[i].x, snake[i].y, 'g', snake[i].direction, snake[i-1].direction);
    }
    
    // Render to the screen
    SDL_RenderPresent(renderer);
    //SDL_Delay(100);
    if (expandHeld == true) {
      snakeLength++;
      expandHeld = false;
    }
    for (int i = 0; i <= 100; i++) {
      SDL_Delay(1);
      // Handle events (in this for loop, just in case, to avoid eating inputs)
      while (SDL_PollEvent(&event) != 0) {
        if (event.type == SDL_QUIT) {
          running = false;
        }
        handleInput(&event);
      }
    }
  }
  // Clean up
  SDL_DestroyRenderer(renderer);
  SDL_DestroyWindow(window);
  SDL_Quit();

  return 0;
}

// Draw a single cell at position (x, y)
// Italian string food below
void drawCell(SDL_Renderer *renderer, int x, int y, char color, char cellDirection, char prevDirection) {
  SDL_Rect cellRect;
  SDL_Rect secCellRect;
  if (color == 'g') {
    SDL_SetRenderDrawColor(renderer, 0, 255, 0, 255);
  } else if (color == 'r') {
    SDL_SetRenderDrawColor(renderer, 255, 0, 0, 255);
  } else {
    SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
  }
  if (cellDirection != prevDirection) {
    switch (cellDirection) {
      case UP:
        if (prevDirection == LEFT) {
          cellDirection = DOWNLEFT;
        } else if (prevDirection == RIGHT) {
          cellDirection = DOWNRIGHT;
        }
        break;
      case DOWN:
        if (prevDirection == LEFT) {
          cellDirection = UPLEFT;
        } else if (prevDirection == RIGHT) {
          cellDirection = UPRIGHT;
        }
        break;
      case LEFT:
        if (prevDirection == UP) {
          cellDirection = UPRIGHT;
        } else if (prevDirection == DOWN) {
          cellDirection = DOWNRIGHT;
        }
        break;
      case RIGHT:
        if (prevDirection == UP) {
          cellDirection = UPLEFT;
        } else if (prevDirection == DOWN) {
          cellDirection = DOWNLEFT;
        }
        break;
    }
  } else if (cellDirection == UP || cellDirection == DOWN){
      cellDirection = VERTICAL;
  } else if (cellDirection == RIGHT || cellDirection == LEFT) {
      cellDirection = HORIZONTAL;
  }
  
  int snakeWidth = CELL_SIZE/5; // Though this is called snake width, it's actually the amount removed from the snake
  if (cellDirection == HORIZONTAL) { // Draw the snake as horizontal
    SDL_Rect cellRect = { x * CELL_SIZE, y * CELL_SIZE + snakeWidth, CELL_SIZE, CELL_SIZE - (snakeWidth*2)};
  } else if (cellDirection == VERTICAL) { // Draw the snake as vertical
    SDL_Rect cellRect = { x * CELL_SIZE + snakeWidth, y * CELL_SIZE, CELL_SIZE - (snakeWidth*2), CELL_SIZE};
  } else if (cellDirection == UPLEFT) {
    SDL_Rect cellRect = { x * CELL_SIZE + snakeWidth, y * CELL_SIZE - snakeWidth, CELL_SIZE - (snakeWidth*2), CELL_SIZE};
    SDL_Rect secCellRect = { x * CELL_SIZE - snakeWidth, y * CELL_SIZE + snakeWidth, CELL_SIZE, CELL_SIZE - (snakeWidth*2)};
  } else if (cellDirection == DOWNLEFT) {
    SDL_Rect cellRect = { x * CELL_SIZE + snakeWidth, y * CELL_SIZE + snakeWidth, CELL_SIZE - (snakeWidth*2), CELL_SIZE};
    SDL_Rect secCellRect = { x * CELL_SIZE - snakeWidth, y * CELL_SIZE + snakeWidth, CELL_SIZE, CELL_SIZE - (snakeWidth*2)};
  } else if (cellDirection == DOWNRIGHT) {
    SDL_Rect cellRect = { x * CELL_SIZE + snakeWidth, y * CELL_SIZE + snakeWidth, CELL_SIZE - (snakeWidth*2), CELL_SIZE};
    SDL_Rect secCellRect = { x * CELL_SIZE + snakeWidth, y * CELL_SIZE + snakeWidth, CELL_SIZE, CELL_SIZE - (snakeWidth*2)};
  } else if (cellDirection == UPRIGHT) {
    SDL_Rect cellRect = { x * CELL_SIZE + snakeWidth, y * CELL_SIZE - snakeWidth, CELL_SIZE - (snakeWidth*2), CELL_SIZE};
    SDL_Rect secCellRect = { x * CELL_SIZE + snakeWidth, y * CELL_SIZE + snakeWidth, CELL_SIZE, CELL_SIZE - (snakeWidth*2)};
  } else if (cellDirection == NONE) {
    SDL_Rect cellRect = { x * CELL_SIZE, y * CELL_SIZE, CELL_SIZE, CELL_SIZE };
    SDL_Rect secCellRect = { x * CELL_SIZE, y * CELL_SIZE, CELL_SIZE, CELL_SIZE };
  }
  SDL_RenderFillRect(renderer, &cellRect);
  SDL_RenderFillRect(renderer, &secCellRect);
}

// Generate food at a random position
void generateFood() {
  food.x = rand() % (SCREEN_WIDTH / CELL_SIZE);
  food.y = rand() % (SCREEN_HEIGHT / CELL_SIZE);
  for (int i = 0; i < snakeLength; i++) {
    if (food.x == snake[i].x && food.y == snake[i].y) {
      generateFood();
    }
  }
}

// Check if there's a collision at position (x, y)
bool checkCollision(int x, int y) {
  for (int i = 1; i < snakeLength; i++) {
    if (snake[i].x == x && snake[i].y == y) {
      return true; // Hit the snake itself
    }
  }
  return false;
}

// Update the game state
void update(SDL_Renderer *renderer) {
    // Move the snake
    for (int i = snakeLength - 1; i > 0; i--) {
      snake[i].x = snake[i - 1].x;
      snake[i].y = snake[i - 1].y;
      snake[i].direction = snake[i-1].direction;
    }
    snake[1].direction = snake[0].direction;
    
    switch ((direction[1] == NO)? direction[0] : direction[1]) {
      case MOVEUP:
        snake[0].y -= 1;
        snake[0].direction = UP;
        break;
      case MOVEDOWN:
        snake[0].y += 1;
        snake[0].direction = DOWN;
        break;
      case MOVELEFT:
        snake[0].x -= 1;
        snake[0].direction = LEFT;
        break;
      case MOVERIGHT:
        snake[0].x += 1;
        snake[0].direction = RIGHT;
        break;
    }
    
    if (snake[0].x < 0 || snake[0].x >= SCREEN_WIDTH / CELL_SIZE || snake[0].y < 0 || snake[0].y >= SCREEN_HEIGHT / CELL_SIZE) {
      // Warping to the other side 
      if (snake[0].x<0){ // Horizontally
        snake[0].x = snake[0].x + (SCREEN_WIDTH / CELL_SIZE);
      } else if (snake[0].x>(SCREEN_WIDTH / CELL_SIZE - 1)){
        snake[0].x = snake[0].x - (SCREEN_WIDTH / CELL_SIZE);
      }
      if (snake[0].y<0){ // Vertically
        snake[0].y = snake[0].y + (SCREEN_HEIGHT / CELL_SIZE);
      } else if (snake[0].y>(SCREEN_HEIGHT / CELL_SIZE - 1)){
        snake[0].y = snake[0].y - (SCREEN_HEIGHT / CELL_SIZE);
      }
    }
  
    // Remove previous input from queue and put next input
    if (direction[2] != NO) {
      direction[0] = direction[1];
      direction[1] = direction[2];
      direction[2] = NO;
    } else if (direction[1] != NO) {
      direction[0] = direction[1];
      direction[1] = NO;
    }
    
    // Check for collisions
    if (checkCollision(snake[0].x, snake[0].y)) {
      for (int i = 0; i < 255; i+=5) {
        drawCell(renderer, food.x, food.y, 'r', NONE, NONE);
        drawCell(renderer, snake[0].x, snake[0].y, 'g', NONE, NONE);
        for (int i = 1; i < snakeLength; i++) {
          drawCell(renderer, snake[i].x, snake[i].y, 'g', snake[i].direction, snake[i-1].direction);
        }
        SDL_SetRenderDrawColor(renderer, i, 0, 0, 255);
        SDL_RenderPresent(renderer);
        SDL_Delay(20);
        SDL_RenderClear(renderer);
      }
      
      printf("Game Over!\n");
      printf("Score: %i \n", snakeLength-3); // -3 Because then it counts how much food obtained, not just the length (change this if you change the starting length)
      SDL_Delay(2000); // Wait for 2 seconds before exiting
      exit(0);
    }

    // Check if snake ate food
    if (snake[0].x == food.x && snake[0].y == food.y) {
      generateFood();
      expandHeld = true;
    }
  
}

// Handle user input
void handleInput(SDL_Event *event) {
  switch (event->type) {
    case SDL_KEYDOWN:
      switch (event->key.keysym.sym) {
        case SDLK_UP:
          if (direction[1] != MOVEDOWN && direction[0] != MOVEDOWN){
            if (direction[1] == NO) {
              direction[1] = MOVEUP;
            } else {
              direction[2] = MOVEUP;
            }
          }
          break;
        case SDLK_DOWN:
          if (direction[1] != MOVEUP && direction[0] != MOVEUP){
            if (direction[1] == NO) {
              direction[1] = MOVEDOWN;
            } else {
              direction[2] = MOVEDOWN;
            }
          }
          break;
        case SDLK_LEFT:
          if (direction[1] != MOVERIGHT && direction[0] != MOVERIGHT){
            if (direction[1] == NO) {
              direction[1] = MOVELEFT;
            } else {
              direction[2] = MOVELEFT;
            }
          }
          break;
        case SDLK_RIGHT:
          if (direction[1] != MOVELEFT && direction[0] != MOVELEFT){
            if (direction[1] == NO) {
              direction[1] = MOVERIGHT;
            } else {
              direction[2] = MOVERIGHT;
            }
          }
          break;
        default:
          break;
      }
      break;
  }
}
