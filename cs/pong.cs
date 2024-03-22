using System;
using System.Threading;
using System.Diagnostics;

namespace Pong
{
  public static class Game
  {
		public static bool gameRunning = true;
		public static int Ballx = 20;
		public static int Bally = 20;
		public static int BallxVel = 2;
		public static int BallyVel = 1;
		public static int Player1y;
		public static int Player2y = 1;
		public static int Scorep1 = 0;
		public static int Scorep2 = 0;
		public static int Width = Console.BufferWidth-1;
		public static int Height = Console.BufferHeight-1;
		public static string tline;
		public static string bline = "Lower/enable \"Key repeat delay\" in yours OS' settings for a much better experince.";
		// Initialize variables 
		public static Random rnd = new Random();
		public static int originalRow;
	  public static int originalCol;
		public static void WriteAt(int x, int y, string toWrite){
			Console.SetCursorPosition(x, y);
			Console.Write(toWrite);
		}
		
		static void DrawScreen(){
			
			WriteAt(0,0, tline);
			WriteAt(0,Height, bline);
			//Creation of this string is in the Main() method
			
			WriteAt(Width/2, 0, "|");
			//Console.WriteLine();
			WriteAt(Width/2-Scorep1.ToString().Length, 0, Scorep1.ToString());
			WriteAt(Width/2+1, 0, Scorep2.ToString());
			
			//Draw top/bottom borders
	    originalRow = Console.CursorTop;
	    originalCol = Console.CursorLeft;
			
			for (int i = 0; i < 7; i++){
				WriteAt(0, Player1y + i, "⢸");
			}
			//Player 1
			for (int i = 0; i < 7; i++){
				WriteAt(Width, Player2y + i, "⡇");
			}
			//Player 2
			// Display Players (P1 is braille 4568 and P2 is 1237)
			WriteAt(Ballx-1, Bally, "⏺");
			// Display ball
		}
		static void Input(){
			while (Console.KeyAvailable){
				ConsoleKey key = Console.ReadKey(true).Key;
				switch (key)
			    {
				case ConsoleKey.W:
					if ((Player1y != 1)){
						Player1y -= 1;
					}
					break;
				case ConsoleKey.S:
					if (Player1y != Height-7){
						Player1y += 1;
					}
					break;
				/*
				key = Console.ReadKey(true).Key;
				switch (key){
				case ConsoleKey.UpArrow:
					if (Player2y != 0){
					Player2y -= 1;
					}
					break;
				case ConsoleKey.DownArrow:
					if (Player2y != Height-6)
					Player2y += 1;
					break;*/ // <- Don't use
				case ConsoleKey.Escape:
					gameRunning = false;
					break;
				case ConsoleKey.P:
					WriteAt(Width/2-5, Height/2, "PAUSED");
					Thread.Sleep(500);
					while (true){ // for some reason, didn't work as: while (Console.ReadKey(true).Key == ConsoleKey.P), but rhis works
						if (Console.ReadKey(true).Key == ConsoleKey.P){
							break;
						}
					}
					Console.Clear();
					DrawScreen();
					Thread.Sleep(500);
					break;
				}
			}
		}
		static void Player2(){// Movement of P2, some randomness so it is beatable
			/*for moving down->*/if ((Bally > Player2y+5) && (Player2y < Height-6)){
				if (Bally - Player2y-3 < 6){
					Player2y += rnd.Next(0,1);
				}else{
					Player2y += rnd.Next(1,3);
				}
			}/*for moving up->*/else if ((Bally < Player2y) && (Player2y > 1)){
				if (Bally - Player2y < 6){
					Player2y -= rnd.Next(1,2);
				}else{
					Player2y -= rnd.Next(4,5);
				}
			}
		}
		static void PointTo(int player)// getting points
		{
			if (player == 1){
				Scorep1 += 1;
			}else{
				Scorep2 +=1;
			}
			
			Ballx = Width/2+2;
			Bally = Height/2-1;
			BallxVel = 1;
			BallyVel = 1;
			WriteAt(Width/2-$"Player {player} got a point".Length/2+1, Height/2, $"Player {player} got a point");
			DrawScreen();
			Thread.Sleep(2000);
		}
		static void Main(string[] args){
			if ((Width < 80) || (Height < 28)){
				Console.WriteLine("Screen too small");
				gameRunning = false;
			}
			int FPS = 0;
			int Physclock = 0;
			int IncreaseBallSpeed = 0;
			Console.Clear();
			string[] splash = {
			"PPPPPPP    OOOOOO   NNN   NN   GGGGGG ",
			"PPP  PPP  OOO  OOO  NNNN  NN  GGG  GGG",
			"PPPPPPP   OO    OO  NN NN NN  GG      ",
			"PP        OO    OO  NN  NNNN  GG  GGGG",
			"PP        OOO  OOO  NN   NNN  GGG  GGG",
			"PP         OOOOOO   NN    NN   GGGGGG "};
			if (gameRunning == true){
				for (int i = 0; i < 6; i++){
					WriteAt(Width/2-19, Height/2-4+i, splash[i]);
				}
				WriteAt(Width/2-44, Height/2+3, "Generally works better on GNU/Linux Terminal Emulators (not tty) (PS and CMD have issues)");
				WriteAt(Width/2-4, Height/2+5, "mmorphig");
				Thread.Sleep(3000);
				
				tline = $"PONG {Width}x{Height}";
				for (int i = 0; i <= Width - $"PONG {Width}x{Height}".Length; i++){
					tline += "-";
				}
				for (int i = 0; i <= Width - 82; i++){
					bline += "-";
				}
				// Had this in a loop with the WriteAt() method writing every single dash individually, but doing this is probably faster and stops some flickering.
				Ballx = Width/2;
				Bally = Height/2;
				Player1y = (Height/2)-10;
				Player2y = (Height/2)-10;
				Console.Clear();
			}
			while (gameRunning == true){ // main game loop
				Stopwatch sw = new Stopwatch();
				sw.Start();
				tline = $"PONG {Width}x{Height} " + FPS + " FPS";
				for (int i = 0; i <= Width - ($"PONG {Width}x{Height}"+FPS+" FPS").Length-1; i++){
					tline += "-";
				}
				
				Console.CursorVisible = false;
				
				Input();
				
				Physclock += 1;
				IncreaseBallSpeed += 1;
				if (IncreaseBallSpeed == 400){
					IncreaseBallSpeed = 0; 
					if (BallxVel > 0){
						BallxVel += 1;
					}else{
						BallxVel -= 1;
					}
				}
				if (Physclock == 2){
					Physclock = 0;
					if ((Ballx + BallxVel) <= 0){
						if (Bally >= Player1y && Bally <= Player1y + 5){
							if (Bally-Player1y+3 < 0){
								BallxVel -= 2*BallxVel;
								BallyVel += rnd.Next(1,2);
							}else{
								BallxVel -= 2*BallxVel;
								BallyVel -= rnd.Next(1,2);
							}
						}else{
							PointTo(2);
						}
					}else if ((Ballx + BallxVel) >= Width){
						if (Bally >= Player2y && Bally <= Player2y + 5){
							if (Bally-Player2y+3 < 0){
								BallxVel -= 2*BallxVel;
								BallyVel += rnd.Next(1,2);
							}else{
								BallxVel -= 2*BallxVel;
								BallyVel -= rnd.Next(1,2);
							}
						}else{
							PointTo(1);
						}
					}
			
					if ((Bally + BallyVel < 0) || (Bally + BallyVel > Height)){
					BallyVel -= 2*BallyVel;
					}
			
					Ballx += BallxVel;
					Bally += BallyVel;
				}
				
				Player2();
				DrawScreen();
				Thread.Sleep(40); // Sleep helps against flicker and maximises the game speed (max of 25 fps)
				Console.Clear();
				sw.Stop();
				FPS = 1000/sw.Elapsed.Milliseconds;
			}
			Console.CursorVisible = true;
		}
  }
}
