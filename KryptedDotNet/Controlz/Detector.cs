using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Guna.UI2.WinForms;

namespace KryptedDotNet.Controlz
{
	// Token: 0x02000009 RID: 9
	public class Detector : UserControl
	{
		// Token: 0x0600002B RID: 43 RVA: 0x000020C6 File Offset: 0x000002C6
		public Detector()
		{
			this.eiDeE4Xv19vArWnRXzMO();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000033CC File Offset: 0x000015CC
		public bool e7gPvONbtxGMQdsWHjCA()
		{
			bool result;
			try
			{
				try
				{
					goto IL_00;
					for (;;)
					{
						IL_00:
						goto IL_00;
					}
				}
				finally
				{
					IEnumerator<TypeDef> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000340C File Offset: 0x0000160C
		public void jmyiQzZexkBC2MJCxnXz()
		{
			try
			{
				for (;;)
				{
					IEnumerator<TypeDef> enumerator;
					try
					{
						for (;;)
						{
							IL_00:
							ModuleContext moduleContext = ModuleDef.CreateModuleContext();
							ModuleDefMD moduleDefMD = ModuleDefMD.Load(this.textBox1.Text, moduleContext);
							enumerator = moduleDefMD.Types.GetEnumerator();
							MethodDef methodDef;
							int num;
							if (methodDef.Body.Instructions[0].OpCode == OpCodes.Ldstr)
							{
								object operand = methodDef.Body.Instructions[num].Operand;
								if (operand.ToString().Contains("webhooks/"))
								{
									this.guna2TextBox1.Text = operand.ToString();
								}
								if (operand == null)
								{
								}
							}
							num++;
							if (num >= methodDef.Body.Instructions.Count)
							{
								methodDef.Body.OptimizeBranches();
								IEnumerator<MethodDef> enumerator2;
								if (!enumerator2.MoveNext())
								{
									break;
								}
							}
						}
					}
					finally
					{
						IEnumerator<MethodDef> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					if (!enumerator.MoveNext())
					{
						break;
					}
					goto IL_00;
				}
			}
			finally
			{
				IEnumerator<TypeDef> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000351C File Offset: 0x0000171C
		public bool qiFIIEO7G0aUcrKr8xzw()
		{
			bool result;
			try
			{
				try
				{
					goto IL_00;
					for (;;)
					{
						IL_00:
						goto IL_00;
					}
				}
				finally
				{
					IEnumerator<TypeDef> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000355C File Offset: 0x0000175C
		public void p9dIvEkE3pZTWDKBhp9L()
		{
			try
			{
				for (;;)
				{
					IEnumerator<TypeDef> enumerator;
					try
					{
						for (;;)
						{
							IL_00:
							ModuleContext moduleContext = ModuleDef.CreateModuleContext();
							ModuleDefMD moduleDefMD = ModuleDefMD.Load(this.textBox1.Text, moduleContext);
							enumerator = moduleDefMD.Types.GetEnumerator();
							MethodDef methodDef;
							int num;
							if (methodDef.Body.Instructions[0].OpCode == OpCodes.Ldstr)
							{
								object operand = methodDef.Body.Instructions[num].Operand;
								Console.WriteLine(operand);
								Regex regex = new Regex("\\b\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\b");
								if (regex.IsMatch(operand.ToString()))
								{
									MatchCollection matchCollection = regex.Matches(operand.ToString());
									this.guna2TextBox1.Text = matchCollection[0].ToString();
									this.guna2TextBox1.Text = operand.ToString();
								}
								if (operand == null)
								{
									break;
								}
							}
							num++;
							if (num >= methodDef.Body.Instructions.Count)
							{
								methodDef.Body.OptimizeBranches();
								IEnumerator<MethodDef> enumerator2;
								if (!enumerator2.MoveNext())
								{
									break;
								}
							}
						}
					}
					finally
					{
						IEnumerator<MethodDef> enumerator2;
						if (enumerator2 != null)
						{
							enumerator2.Dispose();
						}
					}
					if (!enumerator.MoveNext())
					{
						break;
					}
					goto IL_00;
				}
			}
			finally
			{
				IEnumerator<TypeDef> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000036C0 File Offset: 0x000018C0
		public void ks76KgZaCS4zo0JRExMD()
		{
			this.textBox4.Text = "";
			if (RATsDataBase.nSYRqD4kc9HtiIg7eROF(this.textBox1.Text))
			{
				this.p9dIvEkE3pZTWDKBhp9L();
				this.textBox2.Text = "DCRAT Detected";
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003708 File Offset: 0x00001908
		public void UKDRBQy9hJJjYnLwBGxO()
		{
			for (;;)
			{
				this.textBox4.Text = "";
				if (this.qiFIIEO7G0aUcrKr8xzw())
				{
					this.textBox2.Text = "Mercurial Grabber Detected";
					this.jmyiQzZexkBC2MJCxnXz();
				}
				this.e7gPvONbtxGMQdsWHjCA();
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003750 File Offset: 0x00001950
		private void fJBKVZ4vtswkd5qaoP5t(object sender, EventArgs e)
		{

		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003760 File Offset: 0x00001960
		private void iqttIkbAPNQyzxYLJtwc(object sender, EventArgs e)
		{
			
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003770 File Offset: 0x00001970
		private void lDfoMZGsxbIlbD6pPIBa(object sender, EventArgs e)
		{
			for (;;)
			{
				this.textBox2.Text.Contains("Mercurial");
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002320 File Offset: 0x00000520
		private void o3fgcykfHf1vTtIfKEgi(object sender, EventArgs e)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002330 File Offset: 0x00000530
		protected override void Dispose(bool disposing)
		{
			if (!disposing)
			{
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003794 File Offset: 0x00001994
		private void eiDeE4Xv19vArWnRXzMO()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Detector));
			this.textBox4 = new TextBox();
			this.pictureBox4 = new PictureBox();
			this.label2 = new Label();
			this.pictureBox3 = new PictureBox();
			this.label3 = new Label();
			this.guna2Button1 = new Guna2Button();
			this.label4 = new Label();
			this.guna2TextBox1 = new Guna2TextBox();
			this.textBox1 = new Guna2TextBox();
			this.textBox2 = new Guna2TextBox();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			base.SuspendLayout();
			this.textBox4.AutoCompleteMode = AutoCompleteMode.Append;
			this.textBox4.AutoCompleteSource = AutoCompleteSource.FileSystem;
			this.textBox4.BackColor = Color.FromArgb(33, 38, 38);
			this.textBox4.BorderStyle = BorderStyle.None;
			this.textBox4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.textBox4.ForeColor = Color.FromArgb(125, 137, 149);
			this.textBox4.Location = new Point(52, 20);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new Size(532, 143);
			this.textBox4.TabIndex = 22;
			this.textBox4.Text = "Output";
			this.pictureBox4.BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox4.BackgroundImage");
			this.pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBox4.Location = new Point(592, 336);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(26, 28);
			this.pictureBox4.TabIndex = 27;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += this.iqttIkbAPNQyzxYLJtwc;
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label2.ForeColor = SystemColors.ControlLightLight;
			this.label2.Location = new Point(54, 178);
			this.label2.Name = "label2";
			this.label2.Size = new Size(83, 17);
			this.label2.TabIndex = 18;
			this.label2.Text = "File Location";
			this.pictureBox3.BackgroundImage = (Image)componentResourceManager.GetObject("pictureBox3.BackgroundImage");
			this.pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
			this.pictureBox3.Location = new Point(590, 270);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(30, 28);
			this.pictureBox3.TabIndex = 20;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += this.lDfoMZGsxbIlbD6pPIBa;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.label3.ForeColor = SystemColors.ControlLightLight;
			this.label3.Location = new Point(53, 242);
			this.label3.Name = "label3";
			this.label3.Size = new Size(108, 17);
			this.label3.TabIndex = 19;
			this.label3.Text = "Detected Logger";
			this.guna2Button1.BorderRadius = 5;
			this.guna2Button1.DisabledState.BorderColor = Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = Color.FromArgb(32, 36, 39);
			this.guna2Button1.FocusedColor = Color.FromArgb(32, 36, 39);
			this.guna2Button1.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold);
			this.guna2Button1.ForeColor = Color.White;
			this.guna2Button1.Location = new Point(56, 392);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new Size(532, 58);
			this.guna2Button1.TabIndex = 26;
			this.guna2Button1.Text = "Search";
			this.guna2Button1.Click += this.fJBKVZ4vtswkd5qaoP5t;
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.Transparent;
			this.label4.Font = new Font("Segoe UI Semibold", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.ControlLightLight;
			this.label4.Location = new Point(54, 308);
			this.label4.Name = "label4";
			this.label4.Size = new Size(71, 17);
			this.label4.TabIndex = 21;
			this.label4.Text = "Webhook ";
			this.guna2TextBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
			this.guna2TextBox1.BorderColor = Color.FromArgb(33, 36, 38);
			this.guna2TextBox1.BorderRadius = 4;
			this.guna2TextBox1.Cursor = Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.guna2TextBox1.FillColor = Color.FromArgb(33, 38, 38);
			this.guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Font = new Font("Segoe UI", 9f);
			this.guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.guna2TextBox1.Location = new Point(57, 337);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderForeColor = Color.FromArgb(29, 28, 31);
			this.guna2TextBox1.PlaceholderText = "";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new Size(530, 31);
			this.guna2TextBox1.TabIndex = 25;
			this.guna2TextBox1.Click += this.o3fgcykfHf1vTtIfKEgi;
			this.textBox1.BackColor = Color.FromArgb(0, 0, 0, 0);
			this.textBox1.BorderColor = Color.FromArgb(33, 38, 38);
			this.textBox1.BorderRadius = 4;
			this.textBox1.Cursor = Cursors.IBeam;
			this.textBox1.DefaultText = "";
			this.textBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.textBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.textBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.textBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.textBox1.FillColor = Color.FromArgb(33, 38, 38);
			this.textBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.textBox1.Font = new Font("Segoe UI", 9f);
			this.textBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.textBox1.Location = new Point(56, 206);
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '\0';
			this.textBox1.PlaceholderForeColor = Color.FromArgb(125, 137, 149);
			this.textBox1.PlaceholderText = "";
			this.textBox1.SelectedText = "";
			this.textBox1.Size = new Size(530, 30);
			this.textBox1.TabIndex = 23;
			this.textBox2.BackColor = Color.FromArgb(0, 0, 0, 0);
			this.textBox2.BorderColor = Color.FromArgb(33, 36, 38);
			this.textBox2.BorderRadius = 4;
			this.textBox2.Cursor = Cursors.IBeam;
			this.textBox2.DefaultText = "";
			this.textBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.textBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.textBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.textBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.textBox2.FillColor = Color.FromArgb(33, 38, 38);
			this.textBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.textBox2.Font = new Font("Segoe UI", 9f);
			this.textBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.textBox2.Location = new Point(56, 270);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '\0';
			this.textBox2.PlaceholderForeColor = Color.FromArgb(29, 28, 31);
			this.textBox2.PlaceholderText = "";
			this.textBox2.SelectedText = "";
			this.textBox2.Size = new Size(530, 31);
			this.textBox2.TabIndex = 24;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(17, 19, 22);
			base.Controls.Add(this.textBox4);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.guna2TextBox1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.textBox2);
			base.Name = "Detector";
			base.Size = new Size(640, 478);
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001A RID: 26
		private IContainer icontainer_0 = null;

		// Token: 0x0400001B RID: 27
		public TextBox textBox4;

		// Token: 0x0400001C RID: 28
		private PictureBox pictureBox4;

		// Token: 0x0400001D RID: 29
		private Label label2;

		// Token: 0x0400001E RID: 30
		private PictureBox pictureBox3;

		// Token: 0x0400001F RID: 31
		private Label label3;

		// Token: 0x04000020 RID: 32
		private Guna2Button guna2Button1;

		// Token: 0x04000021 RID: 33
		private Label label4;

		// Token: 0x04000022 RID: 34
		private Guna2TextBox guna2TextBox1;

		// Token: 0x04000023 RID: 35
		private Guna2TextBox textBox1;

		// Token: 0x04000024 RID: 36
		private Guna2TextBox textBox2;
	}
}
