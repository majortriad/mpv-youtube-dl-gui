namespace mpv_youtube_dl_gui
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
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.qualBest = new System.Windows.Forms.RadioButton();
			this.qualLow = new System.Windows.Forms.RadioButton();
			this.qualAudio = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(47, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(225, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "URL";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.qualAudio);
			this.groupBox1.Controls.Add(this.qualLow);
			this.groupBox1.Controls.Add(this.qualBest);
			this.groupBox1.Location = new System.Drawing.Point(15, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(257, 92);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Quality";
			// 
			// qualBest
			// 
			this.qualBest.AutoSize = true;
			this.qualBest.Checked = true;
			this.qualBest.Location = new System.Drawing.Point(6, 19);
			this.qualBest.Name = "qualBest";
			this.qualBest.Size = new System.Drawing.Size(46, 17);
			this.qualBest.TabIndex = 0;
			this.qualBest.TabStop = true;
			this.qualBest.Text = "Best";
			this.qualBest.UseVisualStyleBackColor = true;
			// 
			// qualLow
			// 
			this.qualLow.AutoSize = true;
			this.qualLow.Location = new System.Drawing.Point(6, 42);
			this.qualLow.Name = "qualLow";
			this.qualLow.Size = new System.Drawing.Size(45, 17);
			this.qualLow.TabIndex = 1;
			this.qualLow.TabStop = true;
			this.qualLow.Text = "Low";
			this.qualLow.UseVisualStyleBackColor = true;
			// 
			// qualAudio
			// 
			this.qualAudio.AutoSize = true;
			this.qualAudio.Location = new System.Drawing.Point(6, 65);
			this.qualAudio.Name = "qualAudio";
			this.qualAudio.Size = new System.Drawing.Size(74, 17);
			this.qualAudio.TabIndex = 2;
			this.qualAudio.TabStop = true;
			this.qualAudio.Text = "Audio only";
			this.qualAudio.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(197, 136);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 170);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton qualAudio;
		private System.Windows.Forms.RadioButton qualLow;
		private System.Windows.Forms.RadioButton qualBest;
		private System.Windows.Forms.Button button1;
	}
}

