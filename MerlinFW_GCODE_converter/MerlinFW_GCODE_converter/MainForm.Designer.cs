/*
 * Created by SharpDevelop.
 * User: thoczek
 * Date: 2018-04-03
 * Time: 07:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MerlinFW_GCODE_converter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxG1Speed;
		private System.Windows.Forms.TextBox textBoxG0Speed;
		private System.Windows.Forms.CheckBox checkBoxEnagbleG1Speed;
		private System.Windows.Forms.CheckBox checkBoxEnableG0Speed;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxCommentsEnable;
		private System.Windows.Forms.CheckBox checkBoxFEnable;
		private System.Windows.Forms.CheckBox checkBoxSEnable;
		private System.Windows.Forms.CheckBox checkBoxOtherEnable;
		private System.Windows.Forms.CheckBox checkBoxMEnable;
		private System.Windows.Forms.CheckBox checkBoxTEnable;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkBoxTEnable = new System.Windows.Forms.CheckBox();
			this.checkBoxMEnable = new System.Windows.Forms.CheckBox();
			this.checkBoxSEnable = new System.Windows.Forms.CheckBox();
			this.checkBoxOtherEnable = new System.Windows.Forms.CheckBox();
			this.checkBoxFEnable = new System.Windows.Forms.CheckBox();
			this.checkBoxCommentsEnable = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxG1Speed = new System.Windows.Forms.TextBox();
			this.textBoxG0Speed = new System.Windows.Forms.TextBox();
			this.checkBoxEnagbleG1Speed = new System.Windows.Forms.CheckBox();
			this.checkBoxEnableG0Speed = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(742, 489);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.button2);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(734, 463);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Convert";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.TabPage1Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(92, 434);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Save";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(11, 434);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Open";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(652, 434);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Convert";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 6);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(721, 422);
			this.textBox1.TabIndex = 2;
			this.textBox1.WordWrap = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(734, 463);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkBoxTEnable);
			this.groupBox2.Controls.Add(this.checkBoxMEnable);
			this.groupBox2.Controls.Add(this.checkBoxSEnable);
			this.groupBox2.Controls.Add(this.checkBoxOtherEnable);
			this.groupBox2.Controls.Add(this.checkBoxFEnable);
			this.groupBox2.Controls.Add(this.checkBoxCommentsEnable);
			this.groupBox2.Location = new System.Drawing.Point(541, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(190, 205);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Other settings";
			// 
			// checkBoxTEnable
			// 
			this.checkBoxTEnable.Checked = true;
			this.checkBoxTEnable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxTEnable.Location = new System.Drawing.Point(6, 145);
			this.checkBoxTEnable.Name = "checkBoxTEnable";
			this.checkBoxTEnable.Size = new System.Drawing.Size(181, 24);
			this.checkBoxTEnable.TabIndex = 5;
			this.checkBoxTEnable.Text = "Enable Tool change commands";
			this.checkBoxTEnable.UseVisualStyleBackColor = true;
			this.checkBoxTEnable.CheckedChanged += new System.EventHandler(this.CheckBoxTEnableCheckedChanged);
			// 
			// checkBoxMEnable
			// 
			this.checkBoxMEnable.Checked = true;
			this.checkBoxMEnable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxMEnable.Location = new System.Drawing.Point(6, 115);
			this.checkBoxMEnable.Name = "checkBoxMEnable";
			this.checkBoxMEnable.Size = new System.Drawing.Size(126, 24);
			this.checkBoxMEnable.TabIndex = 4;
			this.checkBoxMEnable.Text = "Enable M commands";
			this.checkBoxMEnable.UseVisualStyleBackColor = true;
			// 
			// checkBoxSEnable
			// 
			this.checkBoxSEnable.Location = new System.Drawing.Point(6, 85);
			this.checkBoxSEnable.Name = "checkBoxSEnable";
			this.checkBoxSEnable.Size = new System.Drawing.Size(126, 24);
			this.checkBoxSEnable.TabIndex = 3;
			this.checkBoxSEnable.Text = "Enable S commands";
			this.checkBoxSEnable.UseVisualStyleBackColor = true;
			// 
			// checkBoxOtherEnable
			// 
			this.checkBoxOtherEnable.Checked = true;
			this.checkBoxOtherEnable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxOtherEnable.Location = new System.Drawing.Point(6, 177);
			this.checkBoxOtherEnable.Name = "checkBoxOtherEnable";
			this.checkBoxOtherEnable.Size = new System.Drawing.Size(152, 24);
			this.checkBoxOtherEnable.TabIndex = 2;
			this.checkBoxOtherEnable.Text = "Enable other commands";
			this.checkBoxOtherEnable.UseVisualStyleBackColor = true;
			// 
			// checkBoxFEnable
			// 
			this.checkBoxFEnable.Location = new System.Drawing.Point(6, 55);
			this.checkBoxFEnable.Name = "checkBoxFEnable";
			this.checkBoxFEnable.Size = new System.Drawing.Size(126, 24);
			this.checkBoxFEnable.TabIndex = 1;
			this.checkBoxFEnable.Text = "Enable F commands";
			this.checkBoxFEnable.UseVisualStyleBackColor = true;
			this.checkBoxFEnable.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// checkBoxCommentsEnable
			// 
			this.checkBoxCommentsEnable.Checked = true;
			this.checkBoxCommentsEnable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCommentsEnable.Location = new System.Drawing.Point(6, 25);
			this.checkBoxCommentsEnable.Name = "checkBoxCommentsEnable";
			this.checkBoxCommentsEnable.Size = new System.Drawing.Size(112, 24);
			this.checkBoxCommentsEnable.TabIndex = 0;
			this.checkBoxCommentsEnable.Text = "Enable comments";
			this.checkBoxCommentsEnable.UseVisualStyleBackColor = true;
			this.checkBoxCommentsEnable.CheckedChanged += new System.EventHandler(this.CheckBoxCommentsEnableCheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxG1Speed);
			this.groupBox1.Controls.Add(this.textBoxG0Speed);
			this.groupBox1.Controls.Add(this.checkBoxEnagbleG1Speed);
			this.groupBox1.Controls.Add(this.checkBoxEnableG0Speed);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(271, 84);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Speed";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(222, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "mm/min";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(222, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "mm/min";
			// 
			// textBoxG1Speed
			// 
			this.textBoxG1Speed.Location = new System.Drawing.Point(116, 51);
			this.textBoxG1Speed.Name = "textBoxG1Speed";
			this.textBoxG1Speed.Size = new System.Drawing.Size(100, 20);
			this.textBoxG1Speed.TabIndex = 9;
			this.textBoxG1Speed.Text = "230";
			// 
			// textBoxG0Speed
			// 
			this.textBoxG0Speed.Location = new System.Drawing.Point(116, 25);
			this.textBoxG0Speed.Name = "textBoxG0Speed";
			this.textBoxG0Speed.Size = new System.Drawing.Size(100, 20);
			this.textBoxG0Speed.TabIndex = 8;
			this.textBoxG0Speed.Text = "230";
			// 
			// checkBoxEnagbleG1Speed
			// 
			this.checkBoxEnagbleG1Speed.Checked = true;
			this.checkBoxEnagbleG1Speed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxEnagbleG1Speed.Location = new System.Drawing.Point(6, 51);
			this.checkBoxEnagbleG1Speed.Name = "checkBoxEnagbleG1Speed";
			this.checkBoxEnagbleG1Speed.Size = new System.Drawing.Size(104, 24);
			this.checkBoxEnagbleG1Speed.TabIndex = 7;
			this.checkBoxEnagbleG1Speed.Text = "Set G1 speed";
			this.checkBoxEnagbleG1Speed.UseVisualStyleBackColor = true;
			// 
			// checkBoxEnableG0Speed
			// 
			this.checkBoxEnableG0Speed.Checked = true;
			this.checkBoxEnableG0Speed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxEnableG0Speed.Location = new System.Drawing.Point(6, 21);
			this.checkBoxEnableG0Speed.Name = "checkBoxEnableG0Speed";
			this.checkBoxEnableG0Speed.Size = new System.Drawing.Size(104, 24);
			this.checkBoxEnableG0Speed.TabIndex = 6;
			this.checkBoxEnableG0Speed.Text = "Set G0 speed";
			this.checkBoxEnableG0Speed.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 515);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "MerlinFW_GCODE_converter";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
