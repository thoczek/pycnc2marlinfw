/*
 * Created by SharpDevelop.
 * User: thoczek
 * Date: 2018-04-03
 * Time: 07:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MerlinFW_GCODE_converter
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		String openFilename,convertedFile="";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			String trimmedLine;
			convertedFile="";
			foreach (string line in File.ReadLines(@openFilename))
			{
				if(String.IsNullOrWhiteSpace(line)){}
				else
				{
					//label1.Text=label1.Text+"\r\n"+line;
					if(line[0]==';' || line[0]=='(' )
					{
						if(checkBoxCommentsEnable.Checked)
						{
							convertedFile=convertedFile+"\r\n"+line;
						}
					}
					else if(line[0]=='F')
					{
						if(checkBoxFEnable.Checked)
						{
							convertedFile=convertedFile+"\r\n"+line;
						}
					}
					else if(line[0]=='S')
					{
						if(checkBoxSEnable.Checked)
						{
							convertedFile=convertedFile+"\r\n"+line;
						}
					}
					else if(line[0]=='T')
					{
						if(checkBoxTEnable.Checked)
						{
							convertedFile=convertedFile+"\r\n"+line;
						}
					}
					else if(line[0]=='M')
					{
						if(checkBoxMEnable.Checked)
						{
							convertedFile=convertedFile+"\r\n"+line;
						}
					}
					else if(line[0]=='G' && line[1]=='0')
					{
						if(checkBoxEnableG0Speed.Checked)
						{
						convertedFile=convertedFile+"\r\n"+line+" F"+textBoxG0Speed.Text;      	
						}
						else
						{
						convertedFile=convertedFile+"\r\n"+line;    
						}
					}
					else if(line[0]=='G' && line[1]=='1' )
					{
						if(checkBoxEnagbleG1Speed.Checked)
						{
					  		convertedFile=convertedFile+"\r\n"+line+" F"+textBoxG1Speed.Text;      	
						}
						else
						{
							convertedFile=convertedFile+"\r\n"+line; 
						}
					}
					else if(line[0]==' '&&(line[1]=='X'||line[1]=='Y'||line[1]=='Z'))
					{
						trimmedLine =line.Trim(' ');
						if(checkBoxEnagbleG1Speed.Checked)
						{
							convertedFile=convertedFile+"\r\nG1 "+trimmedLine+" F"+textBoxG1Speed.Text;
						}
						else
						{
							convertedFile=convertedFile+"\r\nG1 "+trimmedLine;
						}
					}
					else if(line[0]=='G')
					{
					  convertedFile=convertedFile+"\r\n"+line;      	
					}
					else if(checkBoxOtherEnable.Checked)
					{
						convertedFile=convertedFile+"\r\n"+line; 
					}
				}
			}
				//foreach (string line in file)
				textBox1.Text=convertedFile;
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			openFilename=openFileDialog1.FileName;
		}
		void Button3Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
		}
		void TabPage1Click(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void CheckBoxCommentsEnableCheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CheckBoxTEnableCheckedChanged(object sender, EventArgs e)
		{
	
		}
	}
}
