using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Tetris
{
	public partial class Form1 : Form
	{
		public int score = 0;

		Random rand = new Random();

		public int nextfigure;

		public ImageList[] ImgLists = new ImageList[3];
		Bitmap bm1;
		Bitmap bm2;
		Graphics gr1;
		Graphics gr2;

		public int style = 0;

		Figure nxt_fg;

		Figure cur_fg;

		public static int[,] Matrix = new int[12, 24];


		public Form1()
		{
			InitializeComponent();
		}
		
		private void button1_Click(object sender, EventArgs e)
		{
			//cur_fg = new Figure(rand.Next(1, 3), rand.Next(0, 4), 2, 2);
		}
		
		private void timer1_Tick(object sender, EventArgs e)
		{
			Figure_Update();
		}
		
		#region my voids

		private void Matrix_Update()
		{
			for (int x = 0; x < Matrix.GetLength(0); x++)
			{
				for (int y = 2; y < Matrix.GetLength(1); y++)
				{
					ImgLists[style].Draw(gr1, 16 * x, 16 * (y - 3), Matrix[x, y]);
				}
			}
			pictureBox1.Image = bm1;
			label2.Text = score.ToString();
		}

		private void Matrix_Clean()
		{
			for (int x = 1; x < Matrix.GetLength(0) - 1; x++)
			{
				for (int y = 0; y < Matrix.GetLength(1); y++)
				{
					Matrix[x, y] = 0;
				}

			}
		}

		private void Figure_Update()
		{
			for (int x = 0; x < cur_fg.size; x++)
			{
				for (int y = 0; y < cur_fg.size; y++)
				{
					switch (cur_fg.grid[x, y])
					{
						case 1:
							ImgLists[style].Draw(gr1, 16 * x + 16 * cur_fg.posX, 16 * y + 16 * (cur_fg.posY - 3), 1);
							break;
						case 2:
							ImgLists[style].Draw(gr1, 16 * x + 16 * cur_fg.posX, 16 * y + 16 * (cur_fg.posY - 3), 2);
							break;
						case 3:
							ImgLists[style].Draw(gr1, 16 * x + 16 * cur_fg.posX, 16 * y + 16 * (cur_fg.posY - 3), 3);
							break;
						case 4:
							ImgLists[style].Draw(gr1, 16 * x + 16 * cur_fg.posX, 16 * y + 16 * (cur_fg.posY - 3), 4);
							break;
						case 5:
							ImgLists[style].Draw(gr1, 16 * x + 16 * cur_fg.posX, 16 * y + 16 * (cur_fg.posY - 3), 5);
							break;
						case 6:
							ImgLists[style].Draw(gr1, 16 * x + 16 * cur_fg.posX, 16 * y + 16 * (cur_fg.posY - 3), 6);
							break;
						case 7:
							ImgLists[style].Draw(gr1, 16 * x + 16 * cur_fg.posX, 16 * y + 16 * (cur_fg.posY - 3), 7);
							break;
						default:
							//imageList1.Draw(pictureBox1.CreateGraphics(), 16 * x + cur_fg.posX * 16 - 1, 16 * y + cur_fg.posY * 16 - 1, 4);
							break;
					}
				}
			}
			pictureBox1.Image = bm1;
		}

		private void min_Figure_Update()
		{
			for (int x = 0; x < 4; x++)
			{
				for (int y = 0; y < 4; y++)
				{
					ImgLists[style].Draw(gr2, 16 * x, 16 * y, 0);
				}
			}

			for (int x = 0; x < nxt_fg.size; x++)
			{
				for (int y = 0; y < nxt_fg.size; y++)
				{
					switch (nxt_fg.grid[x, y])
					{
						case 1:
							ImgLists[style].Draw(gr2, 16 * x, 16 * y, 1);
							break;
						case 2:
							ImgLists[style].Draw(gr2, 16 * x, 16 * y, 2);
							break;
						case 3:
							ImgLists[style].Draw(gr2, 16 * x, 16 * y, 3);
							break;
						case 4:
							ImgLists[style].Draw(gr2, 16 * x, 16 * y, 4);
							break;
						case 5:
							ImgLists[style].Draw(gr2, 16 * x, 16 * y, 5);
							break;
						case 6:
							ImgLists[style].Draw(gr2, 16 * x, 16 * y, 6);
							break;
						case 7:
							ImgLists[style].Draw(gr2, 16 * x, 16 * y, 7);
							break;
						default:
							ImgLists[style].Draw(gr2, 16 * x, 16 * y, 0);
							break;
					}
				}
			}
			pictureBox2.Image = bm2;
		}

		private void Check_Collision()
		{
			for(int x = 0; x < cur_fg.size; x++)
			{
				for (int y = 0; y < cur_fg.size; y++)
				{
					if (cur_fg.grid[x, y] != 0)
					{
						if (Matrix[x + cur_fg.posX, y + cur_fg.posY + 1] != 0)
						{
							cur_fg.can_fall = false;
							Bake();
							cur_fg = new Figure(nextfigure, rand.Next(4), 4, 0);
							nextfigure = rand.Next(1, 8);
							nxt_fg = new Figure(nextfigure, 0, 0, 0);
							min_Figure_Update();
							Check_GameOver();
						}

					}
				}
			}
		}

		private void Check_Side(string side)
		{
			switch (side)
			{
				case "right":
					for (int x = 0; x < cur_fg.size; x++)
					{
						for (int y = 0; y < cur_fg.size; y++)
						{
							if (cur_fg.grid[x, y] != 0)
							{
								if (Matrix[x + cur_fg.posX + 1, y + cur_fg.posY] != 0)
								{
									cur_fg.Move("left");
								}

							}
						}
					}
					break;

				case "left":
					for (int x = 0; x < cur_fg.size; x++)
					{
						for (int y = 0; y < cur_fg.size; y++)
						{
							if (cur_fg.grid[x, y] != 0)
							{
								if (Matrix[x + cur_fg.posX - 1, y + cur_fg.posY] != 0)
								{
									cur_fg.Move("right");
								}

							}
						}
					}
					break;
			}
		}

		void Check_Border()
		{
			for (int y = 0; y < cur_fg.size; y++)
			{
				if (cur_fg.grid[0, y] != 0 && cur_fg.posX < 1)
				{
					cur_fg.posX = 1;
					break;
				}
				if (cur_fg.grid[cur_fg.size - 1, y] != 0 && cur_fg.posX > Matrix.GetLength(0) - cur_fg.size - 1)
				{
					cur_fg.posX = Matrix.GetLength(0) - cur_fg.size - 1;
				}
			}
		}

		void Line_Check()
		{
			int full = 0;
			int fullcount = 0;
			for (int y = 0; y < Matrix.GetLength(1) - 1; y++)
			{
				for (int x = 1; x < Matrix.GetLength(0) - 1; x++)
				{
					if (Matrix[x, y] != 0)
					{
						full++;
					}
				}
				if (full == 10)
				{
					for (int l = (Matrix.GetLength(0) - 1) / 2; l >= 1; l--)
					{
						ImgLists[style].Draw(pictureBox1.CreateGraphics(), l * 16, (y - 3) * 16, 0);
						ImgLists[style].Draw(pictureBox1.CreateGraphics(), (Matrix.GetLength(0) - 1 - l) * 16, (y - 3) * 16, 0);
						System.Threading.Thread.Sleep(50);
					}
					for (int i = 1; i < Matrix.GetLength(0) - 1; i++)
					{
						Matrix[i, y] = 0;
					}
					for (int yy = y - 1; yy >= 0 ; yy--)
					{
						for (int xx = 1; xx < Matrix.GetLength(0) - 1; xx++)
						{
							Matrix[xx, yy + 1] = Matrix[xx, yy];
						}
					};
					fullcount++;
				}
				full = 0;
			}
			
			switch(fullcount)
			{
				case 1:
					score += 100;
					break;
				case 2:
					score += 200;
					break;
				case 3:
					score += 500;
					break;
				case 4:
					score += 1000;
					break;
			}
			fullcount = 0;
			//if (score % 1000 == 0 && score >= 1000)
			//	timer2.Interval -= 20;
		}

		void Bake()
		{
			for (int x = 0; x < cur_fg.size; x++)
			{
				for (int y = 0; y < cur_fg.size; y++)
				{
					if (cur_fg.grid[x, y] != 0)
					{
						Matrix[x + cur_fg.posX, y + cur_fg.posY] = cur_fg.grid[x, y];
					}
				}
			}
			Matrix_Update();
		}

		void Check_GameOver()
		{
			for (int i = 1; i < Matrix.GetLength(0) - 1; i++)
			{
				if (Matrix[i, 0] != 0)
				{
					for (int s = Matrix.GetLength(1) - 5; s >= 0; s--)
					{
						for (int t = 1; t < Matrix.GetLength(0) - 1; t++)
						{
							ImgLists[style].Draw(pictureBox1.CreateGraphics(), 16 * t, 16 * s, 1);
						}
						System.Threading.Thread.Sleep(100);
					}
					for (int s = Matrix.GetLength(1) - 5; s >= 0; s--)
					{
						for (int t = 1; t < Matrix.GetLength(0) - 1; t++)
						{
							ImgLists[style].Draw(pictureBox1.CreateGraphics(), 16 * t, 16 * s, 0);
						}
						System.Threading.Thread.Sleep(100);
					}
					for (int s = 0; s < Matrix.GetLength(1) - 1; s++)
					{
						for (int t = 1; t < Matrix.GetLength(0) - 1; t++)
						{
							Matrix[t, s] = 0;
						}
					}
					Update_ScoreFile();
					score = 0;
					cur_fg = new Figure(rand.Next(1, 8), rand.Next(4), 3, 0);
					nextfigure = rand.Next(1, 8);
					nxt_fg = new Figure(nextfigure, 0, 3, 0);
					Matrix_Update();
					min_Figure_Update();
					break;
				}
			}
		}

		void Update_ScoreFile()
		{
			File.AppendAllText("Tetris_Score.txt",score.ToString() + "\t" + DateTime.Now.ToString() + Environment.NewLine);
		}

		#endregion

		private void Form1_Load(object sender, EventArgs e)
		{
			ImgLists[0] = imageList1;
			ImgLists[1] = imageList2;
			ImgLists[2] = imageList3;

			bm1 = new Bitmap(Matrix.GetLength(0) * 16, Matrix.GetLength(1) * 16);
			gr1 = Graphics.FromImage(bm1);

			bm2 = new Bitmap(4 * 16, 4 * 16);
			gr2 = Graphics.FromImage(bm2);
			#region borders_create
			// нижня межа
			for (int i = 1; i < Matrix.GetLength(0) - 1; i++)
			{
				Matrix[i, Matrix.GetLength(1) - 1] = 8;
			}

			//права межа
			for (int i = 2; i < Matrix.GetLength(1); i++)
			{
				Matrix[Matrix.GetLength(0) - 1, i] = 9;
			}

			//ліва межа
			for (int i = 2; i < Matrix.GetLength(1); i++)
			{
				Matrix[0, i] = 10;
			}

			Matrix[Matrix.GetLength(0) - 1, Matrix.GetLength(1) - 1] = 11;
			Matrix[0, Matrix.GetLength(1) - 1] = 12;
			#endregion
			cur_fg = new Figure(rand.Next(1, 8), rand.Next(4), 3, 0);
			nextfigure = rand.Next(1, 8);
			nxt_fg = new Figure(nextfigure, 0, 3, 0);
			Matrix_Update();
			min_Figure_Update();

			//pictureBox1.Width = 16 * Matrix.GetLength(0);
			//pictureBox1.Height = 16 * Matrix.GetLength(1) - 16;
		}
		
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.R)
			{
				Matrix_Update();
				cur_fg.Rotate();
				Check_Border();
				Check_Side("left");
				Check_Side("right");
			}
			if (e.KeyCode == Keys.D)
			{
				Matrix_Update();
				Check_Side("right");
				cur_fg.Move("right");
			}
			if (e.KeyCode == Keys.A)
			{
				Matrix_Update();
				Check_Side("left");
				cur_fg.Move("left");
			}
			if (e.KeyCode == Keys.Space)
			{
				cur_fg.can_fall = true;
				while (cur_fg.can_fall == true)
				{
					Check_Collision();
					cur_fg.Move("down");
				}
			}
			if (e.KeyCode == Keys.S)
			{
				timer2.Enabled = false;
				timer3.Enabled = true;
			}
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.S)
			{
				timer2.Enabled = true;
				timer3.Enabled = false;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			Check_Collision();
			Line_Check();
			cur_fg.Move("down");
			Matrix_Update();
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			Check_Collision();
			Line_Check();
			cur_fg.Move("down");
			Matrix_Update();
		}

		#region styles
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			Styling();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			Styling();
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			Styling();
		}

		void Styling()
		{
			if (radioButton1.Checked)
			{
				style = 0;
			}
			if (radioButton2.Checked)
			{
				style = 1;
			}
			if (radioButton3.Checked)
			{
				style = 2;
			}
			min_Figure_Update();
		}
		#endregion

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Update_ScoreFile();
		}
	}
}
