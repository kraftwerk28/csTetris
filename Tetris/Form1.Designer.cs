namespace Tetris
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.imageList3 = new System.Windows.Forms.ImageList(this.components);
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(192, 336);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Enabled = true;
			this.timer2.Interval = 500;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(198, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Score:";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(198, 109);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(64, 64);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(193, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 29);
			this.label2.TabIndex = 3;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "black.png");
			this.imageList1.Images.SetKeyName(1, "red.png");
			this.imageList1.Images.SetKeyName(2, "orange.png");
			this.imageList1.Images.SetKeyName(3, "yellow.png");
			this.imageList1.Images.SetKeyName(4, "green.png");
			this.imageList1.Images.SetKeyName(5, "cyan.png");
			this.imageList1.Images.SetKeyName(6, "blue.png");
			this.imageList1.Images.SetKeyName(7, "violet.png");
			this.imageList1.Images.SetKeyName(8, "down_border.png");
			this.imageList1.Images.SetKeyName(9, "right_border.png");
			this.imageList1.Images.SetKeyName(10, "left_border.png");
			this.imageList1.Images.SetKeyName(11, "down_right_border.png");
			this.imageList1.Images.SetKeyName(12, "down_left_border.png");
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "black.png");
			this.imageList2.Images.SetKeyName(1, "red.png");
			this.imageList2.Images.SetKeyName(2, "orange.png");
			this.imageList2.Images.SetKeyName(3, "yellow.png");
			this.imageList2.Images.SetKeyName(4, "green.png");
			this.imageList2.Images.SetKeyName(5, "cyan.png");
			this.imageList2.Images.SetKeyName(6, "blue.png");
			this.imageList2.Images.SetKeyName(7, "violet.png");
			this.imageList2.Images.SetKeyName(8, "down_border.png");
			this.imageList2.Images.SetKeyName(9, "right_border.png");
			this.imageList2.Images.SetKeyName(10, "left_border.png");
			this.imageList2.Images.SetKeyName(11, "down_right_border.png");
			this.imageList2.Images.SetKeyName(12, "down_left_border.png");
			// 
			// imageList3
			// 
			this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
			this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList3.Images.SetKeyName(0, "black.png");
			this.imageList3.Images.SetKeyName(1, "red.png");
			this.imageList3.Images.SetKeyName(2, "orange.png");
			this.imageList3.Images.SetKeyName(3, "yellow.png");
			this.imageList3.Images.SetKeyName(4, "green.png");
			this.imageList3.Images.SetKeyName(5, "cyan.png");
			this.imageList3.Images.SetKeyName(6, "blue.png");
			this.imageList3.Images.SetKeyName(7, "violet.png");
			this.imageList3.Images.SetKeyName(8, "down_border.png");
			this.imageList3.Images.SetKeyName(9, "right_border.png");
			this.imageList3.Images.SetKeyName(10, "left_border.png");
			this.imageList3.Images.SetKeyName(11, "down_right_border.png");
			this.imageList3.Images.SetKeyName(12, "down_left_border.png");
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.ForeColor = System.Drawing.Color.White;
			this.radioButton1.Location = new System.Drawing.Point(198, 262);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(42, 17);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Flat";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.ForeColor = System.Drawing.Color.White;
			this.radioButton2.Location = new System.Drawing.Point(198, 285);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(74, 17);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "OldSchool";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.ForeColor = System.Drawing.Color.White;
			this.radioButton3.Location = new System.Drawing.Point(198, 308);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(58, 17);
			this.radioButton3.TabIndex = 6;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Classic";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// timer3
			// 
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(284, 337);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tetris";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ImageList imageList3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.Timer timer3;
	}
}

