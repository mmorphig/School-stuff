import turtle
import random
import math

# Initialiser la fenêtre
sc = turtle.Screen()
sc.setup(width=1000, height=1000)
sc.bgcolor("white")

# Initialiser la tortue
t = turtle.Turtle()
t.speed(0)
t.up()
t.hideturtle()

def carre(taille, couleur, position):
    x, y = position
    t.goto(x, y)
    t.color(couleur)
    t.begin_fill()

    # Dessin rapide du carré
    t.goto(x + taille, y)
    t.goto(x + taille, y + taille)
    t.goto(x, y + taille)
    t.goto(x, y)

    t.end_fill()

# Cette fonction pourrait dessiner tout rectangles de grandeurs variés
def rectangle(hauteur, largeur, couleur, position):
    x, y = position
    t.goto(x, y)
    t.color(couleur)
    t.begin_fill()

    # Dessin rapide du rectangle
    t.goto(x + largeur, y)
    t.goto(x + largeur, y + 2 * hauteur)
    t.goto(x, y + 2 * hauteur)
    t.goto(x, y)

    t.end_fill()


def cercle(taille, couleur, position, angle=360):
    x, y = position
    t.goto(x, y - taille / 2)
    t.down()
    t.color(couleur)
    t.begin_fill()

    # Dessin rapide du cercle
    t.circle(taille / 2, angle)

    t.end_fill()
    t.up()

def triangle(taille, couleur, position, angle=0):
    x, y = position
    t.goto(x, y)
    t.setheading(angle)
    t.color(couleur)
    t.begin_fill()

    # Calcul des sommets avec rotation
    x1, y1 = x + taille, y
    x2, y2 = x + taille / 2, y + (taille * (3**0.5)) / 2

    # Appliquer la rotation aux points
    def rotate(px, py, cx, cy, a):
        rad = math.radians(a)
        cos_a, sin_a = math.cos(rad), math.sin(rad)
        return (
            cx + (px - cx) * cos_a - (py - cy) * sin_a,
            cy + (px - cx) * sin_a + (py - cy) * cos_a
        )

    x1, y1 = rotate(x1, y1, x, y, angle)
    x2, y2 = rotate(x2, y2, x, y, angle)

    # Tracé du triangle avec `goto`
    t.goto(x1, y1)
    t.goto(x2, y2)
    t.goto(x, y)

    t.end_fill()

# Générer des positions aléatoires uniques
positions = []
for _ in range(1000): # Plus que 40, mais peut être facilement changer, avec seulement 40, les polygones génèrent en piles sur ces 40
    x = random.randint(-480, 450)
    y = random.randint(-480, 450)
    positions.append([x, y])

def dessiner(w,e):
    sc.tracer(0,0) # Augmente la vitesse du dessin beaucoups
    for _ in range(100):
      # Générer des valeurs aléatoires
      cote = random.randint(20, 80)
      cote2 = random.randint(20, 80) # Deuxiѐme coté, pour les rectangles
      angle = random.randint(0, 359)
      r, g, b = random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)
      couleur = [r, g, b]

      # Choisir une position unique
      pos = random.sample(positions, 1)[0]

      # Choisir une forme aléatoire
      a = random.randint(1, 4)
    
      if a == 1:
          triangle(cote, couleur, pos, angle)
      elif a == 2:
          cercle(cote, couleur, pos)
      elif a == 3:
          carre(cote, couleur, pos)
      elif a == 4:
          # Le random extra ici est pour minimiser le montant de rectangles qui sont plus haut que larges
          rectangle(cote / random.randint(1,3), cote2, couleur, pos) 
          
    sc.update()
    
for i in range(10): # dessine quelques-uns pour débuter
  dessiner(0,0)

# Associer le clic à la fonction dessiner
while True:
  sc.onclick(dessiner)

turtle.done()



