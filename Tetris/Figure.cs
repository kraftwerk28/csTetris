using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
	public class Figure
	{
		public bool isCollided;
		public int posX, posY;
		public int shape;
		public int size;
		public int[,] grid;
		public bool can_fall;
		
		public Figure(int type, int rotation, int x, int y)
		{
			this.can_fall = false;
			this.isCollided = false;
			this.posX = x;
			this.posY = y;
			switch(type)
			{
				case 1:
					size = 3;
					grid = new int[,] { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 1, 0 } };
					break;
				case 2:
					size = 3;
					grid = new int[,] { { 0, 1, 2 }, { 4, 5, 0 }, { 0, 0, 0 } };
					break;
				case 3:
					size = 3;
					grid = new int[,] { { 0, 0, 0 }, { 3, 3, 0 }, { 0, 3, 3 } };
					break;
				case 4:
					size = 4;
					grid = new int[,] { { 0, 4, 0, 0 }, { 0, 4, 0, 0 }, { 0, 4, 0, 0 }, { 0, 4, 0, 0 } };
					break;
				case 5:
					size = 3;
					grid = new int[,] { { 0, 0, 0 }, { 5, 5, 5 }, { 5, 0, 0 } };
					break;
				case 6:
					size = 3;
					grid = new int[,] { { 6, 0, 0 }, { 6, 6, 6 }, { 0, 0, 0 } };
					break;
				case 7:
					size = 2;
					grid = new int[,] { { 7, 7 }, { 7, 7 } };
					break;
			}
			switch(rotation)
			{
				case 0:
					break;
				case 1:
					Rotate();
					break;
				case 2:
					Rotate();
					Rotate();
					break;
				case 3:
					Rotate();
					Rotate();
					Rotate();
					break;
				default:
					break;
			}
		}

		public void Rotate()
		{
			int[,] temp = new int[size, size];
			Array.Copy(grid, temp, size * size);
			for (int y = 0; y < this.size; y++)
			{
				for (int x = 0; x < this.size; x++)
				{
					grid[size - 1 - y, x] = temp[x, y];
				}
			}
		}

		public void Move(string dir)
		{
			switch(dir)
			{
				case "right":
					this.posX++;
					break;
				case "left":
					this.posX--;
					break;
				case "down":
					this.posY++;
					break;
				case "up":
					this.posY--;
					break;
			}
		}
	}
}
