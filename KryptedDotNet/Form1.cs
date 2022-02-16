using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KryptedDotNet.Controlz;

namespace KryptedDotNet
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002076 File Offset: 0x00000276
		public Form1()
		{
			this.WvDj85Xyx8Yvt0OC04LE();
		}

		// Token: 0x0600000D RID: 13
		[DllImport("DwmApi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

		// Token: 0x0600000E RID: 14 RVA: 0x000025DC File Offset: 0x000007DC
		private void SZb5pPGVDR5sh9yrX5Lb(object sender, EventArgs e)
		{
			new Guna2ShadowForm(this);
			new Guna2DragControl(this.panel1);
			new Guna2DragControl(this);
			new Guna2DragControl(this.label5);
			new Guna2DragControl(this.pictureBox2);
			this.guna2Panel2.Controls.Add(new Spammer());
			this.guna2Panel2.Controls.Add(new Detector());
			this.guna2Panel2.Controls.Find("Detector", false)[0].BringToFront();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002320 File Offset: 0x00000520
		private void mkY2MPRzP4E4xbzKeryr(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002320 File Offset: 0x00000520
		private void tZDOqzKtg5a7R0l8BIT9(object sender, EventArgs e)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002664 File Offset: 0x00000864
		private void yHF8NBvFanM67UhXhJcM(object sender, EventArgs e)
		{
			this.guna2Panel2.Controls.Find("Spammer", false)[0].BringToFront();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002690 File Offset: 0x00000890
		private void FXSju7M6q1I67ZsmU4Bo(object sender, EventArgs e)
		{
			this.guna2Panel2.Controls.Find("Detector", false)[0].BringToFront();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002320 File Offset: 0x00000520
		private void EETsTDAxiYrs6H3boVdf(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002320 File Offset: 0x00000520
		private void pYPIegyI1vDMHoHBD00q(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002320 File Offset: 0x00000520
		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002320 File Offset: 0x00000520
		private void Fs5nVekiz27YvmIaam8Y(object sender, EventArgs e)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002320 File Offset: 0x00000520
		private void g8MKxEVlo1MsMnlejAHv(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002320 File Offset: 0x00000520
		private void pictureBox6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002320 File Offset: 0x00000520
		private void Tyt7PeMHB4rafdrYHj1Y(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002320 File Offset: 0x00000520
		private void BR8YWKQWqPzYKrb7YtNE(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000026D4 File Offset: 0x000008D4
		private void WvDj85Xyx8Yvt0OC04LE()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.panel1 = new Guna2Panel();
			this.guna2ControlBox1 = new Guna2ControlBox();
			this.pictureBox2 = new PictureBox();
			this.label5 = new Label();
			this.guna2Panel1 = new Guna2Panel();
			this.pictureBox3 = new PictureBox();
			this.label2 = new Label();
			this.pictureBox6 = new PictureBox();
			this.pictureBox5 = new PictureBox();
			this.label6 = new Label();
			this.pictureBox1 = new PictureBox();
			this.label1 = new Label();
			this.guna2Panel2 = new Guna2Panel();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			this.guna2Panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox6).BeginInit();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
			this.panel1.BorderColor = Color.FromArgb(45, 49, 50);
			this.panel1.BorderRadius = 5;
			this.panel1.BorderThickness = 1;
			this.panel1.Controls.Add(this.guna2ControlBox1);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.CustomBorderColor = Color.FromArgb(27, 28, 32);
			this.panel1.FillColor = Color.FromArgb(26, 29, 32);
			this.panel1.Location = new Point(-6, -3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(753, 52);
			this.panel1.TabIndex = 13;
			this.panel1.Paint += this.pYPIegyI1vDMHoHBD00q;
			this.guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = Color.FromArgb(0, 0, 0, 0);
			this.guna2ControlBox1.IconColor = Color.White;
			this.guna2ControlBox1.Location = new Point(704, 4);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new Size(46, 50);
			this.guna2ControlBox1.TabIndex = 6;
			this.guna2ControlBox1.Click += this.guna2ControlBox1_Click;
			this.pictureBox2.BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage");
			this.pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
			this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(22, 10);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(30, 28);
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += this.Fs5nVekiz27YvmIaam8Y;
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.Transparent;
			this.label5.Font = new Font("Yu Gothic UI", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = SystemColors.ControlLightLight;
			this.label5.Location = new Point(54, 10);
			this.label5.Name = "label5";
			this.label5.Size = new Size(102, 19);
			this.label5.TabIndex = 5;
			this.label5.Text = "KryptedDotNet";
			this.label5.Click += this.tZDOqzKtg5a7R0l8BIT9;
			this.guna2Panel1.BackColor = Color.Transparent;
			this.guna2Panel1.BorderColor = Color.FromArgb(32, 36, 39);
			this.guna2Panel1.Controls.Add(this.pictureBox3);
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Controls.Add(this.pictureBox6);
			this.guna2Panel1.Controls.Add(this.pictureBox5);
			this.guna2Panel1.Controls.Add(this.label6);
			this.guna2Panel1.Controls.Add(this.pictureBox1);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.CustomBorderColor = Color.FromArgb(32, 36, 39);
			this.guna2Panel1.FillColor = Color.FromArgb(33, 36, 38);
			this.guna2Panel1.Location = new Point(0, 50);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new Size(103, 488);
			this.guna2Panel1.TabIndex = 14;
			this.guna2Panel1.Paint += this.g8MKxEVlo1MsMnlejAHv;
			this.pictureBox3.BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox3.BackgroundImage");
			this.pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(18, 178);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(68, 56);
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("Yu Gothic UI", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = SystemColors.ControlLightLight;
			this.label2.Location = new Point(20, 234);
			this.label2.Name = "label2";
			this.label2.Size = new Size(59, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "File Hub";
			this.pictureBox6.BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox6.BackgroundImage");
			this.pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
			this.pictureBox6.Image = (Image)componentResourceManager.GetObject("pictureBox6.Image");
			this.pictureBox6.Location = new Point(10, 9);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new Size(84, 77);
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += this.pictureBox6_Click;
			this.pictureBox5.BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox5.BackgroundImage");
			this.pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
			this.pictureBox5.Image = (Image)componentResourceManager.GetObject("pictureBox5.Image");
			this.pictureBox5.Location = new Point(16, 262);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new Size(68, 56);
			this.pictureBox5.TabIndex = 6;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += this.yHF8NBvFanM67UhXhJcM;
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.Transparent;
			this.label6.Font = new Font("Yu Gothic UI", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = SystemColors.ControlLightLight;
			this.label6.Location = new Point(24, 318);
			this.label6.Name = "label6";
			this.label6.Size = new Size(47, 19);
			this.label6.TabIndex = 5;
			this.label6.Text = "About";
			this.label6.Click += this.Tyt7PeMHB4rafdrYHj1Y;
			this.pictureBox1.BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage");
			this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
			this.pictureBox1.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new Point(22, 110);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size(58, 38);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += this.FXSju7M6q1I67ZsmU4Bo;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("Yu Gothic UI", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = SystemColors.ControlLightLight;
			this.label1.Location = new Point(20, 148);
			this.label1.Name = "label1";
			this.label1.Size = new Size(62, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Detector";
			this.label1.Click += this.BR8YWKQWqPzYKrb7YtNE;
			this.guna2Panel2.BackColor = Color.FromArgb(17, 19, 22);
			this.guna2Panel2.BorderColor = Color.FromArgb(17, 19, 22);
			this.guna2Panel2.CustomBorderColor = Color.FromArgb(17, 19, 22);
			this.guna2Panel2.FillColor = Color.FromArgb(17, 19, 22);
			this.guna2Panel2.Location = new Point(106, 50);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new Size(640, 478);
			this.guna2Panel2.TabIndex = 15;
			this.guna2Panel2.Paint += this.EETsTDAxiYrs6H3boVdf;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(17, 19, 22);
			base.ClientSize = new Size(745, 529);
			base.Controls.Add(this.guna2Panel2);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Name = "Form1";
			this.Text = "Form1";
			base.Load += this.SZb5pPGVDR5sh9yrX5Lb;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox2).EndInit();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox6).EndInit();
			((ISupportInitialize)this.pictureBox5).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000008 RID: 8
		private IContainer icontainer_0 = null;

		// Token: 0x04000009 RID: 9
		private Guna2Panel panel1;

		// Token: 0x0400000A RID: 10
		private Guna2Panel guna2Panel1;

		// Token: 0x0400000B RID: 11
		private Label label1;

		// Token: 0x0400000C RID: 12
		private PictureBox pictureBox1;

		// Token: 0x0400000D RID: 13
		private Label label5;

		// Token: 0x0400000E RID: 14
		private PictureBox pictureBox2;

		// Token: 0x0400000F RID: 15
		private PictureBox pictureBox5;

		// Token: 0x04000010 RID: 16
		private Label label6;

		// Token: 0x04000011 RID: 17
		private PictureBox pictureBox6;

		// Token: 0x04000012 RID: 18
		private Guna2Panel guna2Panel2;

		// Token: 0x04000013 RID: 19
		private Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000014 RID: 20
		private PictureBox pictureBox3;

		// Token: 0x04000015 RID: 21
		private Label label2;
	}
}
