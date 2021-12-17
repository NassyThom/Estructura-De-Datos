
namespace Stack_Without_Default_Class
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtValue = new System.Windows.Forms.TextBox();
			this.lblInsert = new System.Windows.Forms.Label();
			this.btnPush = new System.Windows.Forms.Button();
			this.lstBoxResult = new System.Windows.Forms.ListBox();
			this.btnPop = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(11, 49);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(150, 31);
			this.txtValue.TabIndex = 0;
			// 
			// lblInsert
			// 
			this.lblInsert.AutoSize = true;
			this.lblInsert.Location = new System.Drawing.Point(8, 21);
			this.lblInsert.Name = "lblInsert";
			this.lblInsert.Size = new System.Drawing.Size(163, 25);
			this.lblInsert.TabIndex = 1;
			this.lblInsert.Text = "Insert Value (string)";
			// 
			// btnPush
			// 
			this.btnPush.Location = new System.Drawing.Point(11, 99);
			this.btnPush.Name = "btnPush";
			this.btnPush.Size = new System.Drawing.Size(150, 34);
			this.btnPush.TabIndex = 2;
			this.btnPush.Text = "Push";
			this.btnPush.UseVisualStyleBackColor = true;
			this.btnPush.Click += new System.EventHandler(this.button1_Click);
			// 
			// lstBoxResult
			// 
			this.lstBoxResult.FormattingEnabled = true;
			this.lstBoxResult.ItemHeight = 25;
			this.lstBoxResult.Location = new System.Drawing.Point(189, 12);
			this.lstBoxResult.Name = "lstBoxResult";
			this.lstBoxResult.Size = new System.Drawing.Size(259, 229);
			this.lstBoxResult.TabIndex = 3;
			// 
			// btnPop
			// 
			this.btnPop.Location = new System.Drawing.Point(11, 151);
			this.btnPop.Name = "btnPop";
			this.btnPop.Size = new System.Drawing.Size(150, 34);
			this.btnPop.TabIndex = 4;
			this.btnPop.Text = "Pop";
			this.btnPop.UseVisualStyleBackColor = true;
			this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(92, 247);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(299, 159);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 434);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnPop);
			this.Controls.Add(this.lstBoxResult);
			this.Controls.Add(this.btnPush);
			this.Controls.Add(this.lblInsert);
			this.Controls.Add(this.txtValue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.Label lblInsert;
		private System.Windows.Forms.Button btnPush;
		private System.Windows.Forms.ListBox lstBoxResult;
		private System.Windows.Forms.Button btnPop;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

