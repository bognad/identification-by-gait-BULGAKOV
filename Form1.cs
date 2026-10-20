using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace MotionAnalysis
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.OpenFileDialog openFileDialog3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.TabPage tabPage10;
		private System.Windows.Forms.TabPage tabPage11;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label label60;
		private System.Windows.Forms.Label label61;
		private System.Windows.Forms.Label label62;
		private System.Windows.Forms.Label label63;
		private System.Windows.Forms.Label label64;
		private System.Windows.Forms.Label label65;
		private System.Windows.Forms.Label label66;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.Label label67;
		private System.Windows.Forms.Label label68;
		private System.Windows.Forms.Label label69;
		private System.Windows.Forms.Label label70;
		private System.Windows.Forms.Label label71;
		private System.Windows.Forms.Label label72;
		private System.Windows.Forms.Label label73;
		private System.Windows.Forms.Label label74;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.Label label75;
		private System.Windows.Forms.Label label76;
		private System.Windows.Forms.Label label77;
		private System.Windows.Forms.Label label78;
		private System.Windows.Forms.Label label79;
		private System.Windows.Forms.Label label80;
		private System.Windows.Forms.Label label81;
		private System.Windows.Forms.Label label82;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.Label label83;
		private System.Windows.Forms.Label label84;
		private System.Windows.Forms.Label label85;
		private System.Windows.Forms.Label label86;
		private System.Windows.Forms.Label label87;
		private System.Windows.Forms.Label label88;
		private System.Windows.Forms.Label label89;
		private System.Windows.Forms.Label label90;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.Label label91;
		private System.Windows.Forms.Label label92;
		private System.Windows.Forms.Label label93;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.Label label94;
		private System.Windows.Forms.Label label95;
		private System.Windows.Forms.Label label96;
		private System.Windows.Forms.Label label97;
		private System.Windows.Forms.Label label98;
		private System.Windows.Forms.Label label99;
		private System.Windows.Forms.Label label100;
		private System.Windows.Forms.Label label101;
		private System.Windows.Forms.Label label102;
		private System.Windows.Forms.Label label103;
		private System.Windows.Forms.GroupBox groupBox17;
		private System.Windows.Forms.Label label104;
		private System.Windows.Forms.Label label105;
		private System.Windows.Forms.Label label106;
		private System.Windows.Forms.Label label107;
		private System.Windows.Forms.Label label108;
		private System.Windows.Forms.Label label109;
		private System.Windows.Forms.Label label110;
		private System.Windows.Forms.Label label111;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.Label label112;
		private System.Windows.Forms.Label label113;
		private System.Windows.Forms.Label label114;
		private System.Windows.Forms.Label label115;
		private System.Windows.Forms.Label label116;
		private System.Windows.Forms.Label label117;
		private System.Windows.Forms.Label label118;
		private System.Windows.Forms.Label label119;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox19;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label120;
		private System.Windows.Forms.Label label121;
		private System.Windows.Forms.Label label122;
		private System.Windows.Forms.Label label123;
		private System.Windows.Forms.Label label124;
		private System.Windows.Forms.Label label125;
		private System.Windows.Forms.GroupBox groupBox20;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label126;
		private System.Windows.Forms.Label label127;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Label label128;
		private System.Windows.Forms.Label label129;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.OpenFileDialog openFileDialog4;
		private System.Windows.Forms.SaveFileDialog saveFileDialog2;
		private System.Windows.Forms.TabPage tabPage12;
		private System.Windows.Forms.GroupBox groupBox21;
		private System.Windows.Forms.GroupBox groupBox22;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.GroupBox groupBox23;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.GroupBox groupBox24;
		private System.Windows.Forms.CheckBox checkBox8;
		private System.Windows.Forms.CheckBox checkBox9;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label130;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label131;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox20 = new System.Windows.Forms.GroupBox();
			this.button23 = new System.Windows.Forms.Button();
			this.label129 = new System.Windows.Forms.Label();
			this.label128 = new System.Windows.Forms.Label();
			this.button22 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label127 = new System.Windows.Forms.Label();
			this.label126 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button19 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.label125 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.button2 = new System.Windows.Forms.Button();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button16 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label9 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.button25 = new System.Windows.Forms.Button();
			this.label103 = new System.Windows.Forms.Label();
			this.label102 = new System.Windows.Forms.Label();
			this.label100 = new System.Windows.Forms.Label();
			this.label99 = new System.Windows.Forms.Label();
			this.label98 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.label101 = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.button17 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label26 = new System.Windows.Forms.Label();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.label25 = new System.Windows.Forms.Label();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.label17 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.label22 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label23 = new System.Windows.Forms.Label();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.label24 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.groupBox19 = new System.Windows.Forms.GroupBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.label94 = new System.Windows.Forms.Label();
			this.label95 = new System.Windows.Forms.Label();
			this.label96 = new System.Windows.Forms.Label();
			this.label97 = new System.Windows.Forms.Label();
			this.groupBox15 = new System.Windows.Forms.GroupBox();
			this.label123 = new System.Windows.Forms.Label();
			this.label124 = new System.Windows.Forms.Label();
			this.label121 = new System.Windows.Forms.Label();
			this.label122 = new System.Windows.Forms.Label();
			this.label120 = new System.Windows.Forms.Label();
			this.label93 = new System.Windows.Forms.Label();
			this.label91 = new System.Windows.Forms.Label();
			this.label92 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.label83 = new System.Windows.Forms.Label();
			this.label84 = new System.Windows.Forms.Label();
			this.label85 = new System.Windows.Forms.Label();
			this.label86 = new System.Windows.Forms.Label();
			this.label87 = new System.Windows.Forms.Label();
			this.label88 = new System.Windows.Forms.Label();
			this.label89 = new System.Windows.Forms.Label();
			this.label90 = new System.Windows.Forms.Label();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.label75 = new System.Windows.Forms.Label();
			this.label76 = new System.Windows.Forms.Label();
			this.label77 = new System.Windows.Forms.Label();
			this.label78 = new System.Windows.Forms.Label();
			this.label79 = new System.Windows.Forms.Label();
			this.label80 = new System.Windows.Forms.Label();
			this.label81 = new System.Windows.Forms.Label();
			this.label82 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.label45 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.label67 = new System.Windows.Forms.Label();
			this.label68 = new System.Windows.Forms.Label();
			this.label69 = new System.Windows.Forms.Label();
			this.label70 = new System.Windows.Forms.Label();
			this.label71 = new System.Windows.Forms.Label();
			this.label72 = new System.Windows.Forms.Label();
			this.label73 = new System.Windows.Forms.Label();
			this.label74 = new System.Windows.Forms.Label();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.label55 = new System.Windows.Forms.Label();
			this.label56 = new System.Windows.Forms.Label();
			this.label57 = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.label59 = new System.Windows.Forms.Label();
			this.label60 = new System.Windows.Forms.Label();
			this.label61 = new System.Windows.Forms.Label();
			this.label62 = new System.Windows.Forms.Label();
			this.label63 = new System.Windows.Forms.Label();
			this.label64 = new System.Windows.Forms.Label();
			this.label65 = new System.Windows.Forms.Label();
			this.label66 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.label112 = new System.Windows.Forms.Label();
			this.label113 = new System.Windows.Forms.Label();
			this.label114 = new System.Windows.Forms.Label();
			this.label115 = new System.Windows.Forms.Label();
			this.label116 = new System.Windows.Forms.Label();
			this.label117 = new System.Windows.Forms.Label();
			this.label118 = new System.Windows.Forms.Label();
			this.label119 = new System.Windows.Forms.Label();
			this.groupBox17 = new System.Windows.Forms.GroupBox();
			this.label104 = new System.Windows.Forms.Label();
			this.label105 = new System.Windows.Forms.Label();
			this.label106 = new System.Windows.Forms.Label();
			this.label107 = new System.Windows.Forms.Label();
			this.label108 = new System.Windows.Forms.Label();
			this.label109 = new System.Windows.Forms.Label();
			this.label110 = new System.Windows.Forms.Label();
			this.label111 = new System.Windows.Forms.Label();
			this.tabPage12 = new System.Windows.Forms.TabPage();
			this.label131 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label130 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button24 = new System.Windows.Forms.Button();
			this.groupBox21 = new System.Windows.Forms.GroupBox();
			this.groupBox23 = new System.Windows.Forms.GroupBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.groupBox22 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.groupBox24 = new System.Windows.Forms.GroupBox();
			this.checkBox8 = new System.Windows.Forms.CheckBox();
			this.checkBox9 = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.groupBox20.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
			this.panel5.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			this.tabPage11.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.groupBox19.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.tabPage12.SuspendLayout();
			this.groupBox21.SuspendLayout();
			this.groupBox23.SuspendLayout();
			this.groupBox22.SuspendLayout();
			this.groupBox24.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Изображения(*.gif;*.jpg;*.jpeg;*.bmp;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.png|Все фа" +
				"йлы|*.*";
			this.openFileDialog1.Multiselect = true;
			this.openFileDialog1.ShowReadOnly = true;
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.Filter = "Изображения(*.gif;*.jpg;*.jpeg;*.bmp;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.png|Все фа" +
				"йлы|*.*";
			// 
			// openFileDialog3
			// 
			this.openFileDialog3.Filter = "Файлы данных *.dat|*.dat";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox20);
			this.panel1.Controls.Add(this.label125);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1015, 700);
			this.panel1.TabIndex = 7;
			this.panel1.Visible = false;
			// 
			// groupBox20
			// 
			this.groupBox20.Controls.Add(this.button23);
			this.groupBox20.Controls.Add(this.label129);
			this.groupBox20.Controls.Add(this.label128);
			this.groupBox20.Controls.Add(this.button22);
			this.groupBox20.Controls.Add(this.button21);
			this.groupBox20.Controls.Add(this.button20);
			this.groupBox20.Controls.Add(this.textBox2);
			this.groupBox20.Controls.Add(this.label127);
			this.groupBox20.Controls.Add(this.label126);
			this.groupBox20.Controls.Add(this.listBox2);
			this.groupBox20.Controls.Add(this.button19);
			this.groupBox20.Controls.Add(this.button18);
			this.groupBox20.Location = new System.Drawing.Point(424, 40);
			this.groupBox20.Name = "groupBox20";
			this.groupBox20.Size = new System.Drawing.Size(584, 584);
			this.groupBox20.TabIndex = 14;
			this.groupBox20.TabStop = false;
			// 
			// button23
			// 
			this.button23.Location = new System.Drawing.Point(16, 16);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(304, 40);
			this.button23.TabIndex = 11;
			this.button23.Text = "Создать новую базу данных";
			this.button23.Click += new System.EventHandler(this.button23_Click);
			// 
			// label129
			// 
			this.label129.Location = new System.Drawing.Point(376, 32);
			this.label129.Name = "label129";
			this.label129.Size = new System.Drawing.Size(200, 16);
			this.label129.TabIndex = 10;
			this.label129.Text = "Unnamed.mab";
			// 
			// label128
			// 
			this.label128.Location = new System.Drawing.Point(344, 32);
			this.label128.Name = "label128";
			this.label128.Size = new System.Drawing.Size(40, 16);
			this.label128.TabIndex = 9;
			this.label128.Text = "База:";
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.button22.Location = new System.Drawing.Point(200, 240);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(64, 40);
			this.button22.TabIndex = 8;
			this.button22.Text = "Удалить файл";
			this.button22.Click += new System.EventHandler(this.button22_Click);
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.LightGreen;
			this.button21.Location = new System.Drawing.Point(200, 144);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(64, 40);
			this.button21.TabIndex = 7;
			this.button21.Text = "Добавить файл";
			this.button21.Click += new System.EventHandler(this.button21_Click);
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(272, 480);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(304, 32);
			this.button20.TabIndex = 6;
			this.button20.Text = "Сохранить измененое описание походки";
			this.button20.Click += new System.EventHandler(this.button20_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(272, 128);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(304, 344);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "";
			// 
			// label127
			// 
			this.label127.Location = new System.Drawing.Point(272, 112);
			this.label127.Name = "label127";
			this.label127.Size = new System.Drawing.Size(208, 16);
			this.label127.TabIndex = 4;
			this.label127.Text = "Описание походки:";
			// 
			// label126
			// 
			this.label126.Location = new System.Drawing.Point(16, 112);
			this.label126.Name = "label126";
			this.label126.Size = new System.Drawing.Size(104, 16);
			this.label126.TabIndex = 3;
			this.label126.Text = "Файлы походок:";
			// 
			// listBox2
			// 
			this.listBox2.Location = new System.Drawing.Point(16, 128);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(176, 381);
			this.listBox2.TabIndex = 2;
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// button19
			// 
			this.button19.Location = new System.Drawing.Point(8, 520);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(304, 40);
			this.button19.TabIndex = 1;
			this.button19.Text = "Сохранить базу данных";
			this.button19.Click += new System.EventHandler(this.button19_Click);
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(16, 64);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(304, 40);
			this.button18.TabIndex = 0;
			this.button18.Text = "Открыть базу данных";
			this.button18.Click += new System.EventHandler(this.button18_Click);
			// 
			// label125
			// 
			this.label125.Location = new System.Drawing.Point(568, 16);
			this.label125.Name = "label125";
			this.label125.Size = new System.Drawing.Size(176, 24);
			this.label125.TabIndex = 13;
			this.label125.Text = "База данных походок:";
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(80, 640);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(240, 40);
			this.button5.TabIndex = 12;
			this.button5.Text = "Перейти к следующему этапу >>";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(16, 528);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(376, 96);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(24, 16);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 32);
			this.button3.TabIndex = 6;
			this.button3.Text = "Выбрать файл";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(248, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Файл созданый данной программой, содержащий координаты отмеченных точек.";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Location = new System.Drawing.Point(16, 72);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 424);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.numericUpDown1);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.numericUpDown2);
			this.groupBox3.Location = new System.Drawing.Point(8, 208);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(352, 208);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Мерный куб";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(64, 168);
			this.numericUpDown1.Maximum = new System.Decimal(new int[] {
																		   100000,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
			this.numericUpDown1.TabIndex = 12;
			this.numericUpDown1.Value = new System.Decimal(new int[] {
																		 400,
																		 0,
																		 0,
																		 0});
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(144, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 16);
			this.label7.TabIndex = 11;
			this.label7.Text = "Высота";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 172);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Длина";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(232, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Размеры мерного куба (в миллиметрах):";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(32, 88);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(208, 32);
			this.button4.TabIndex = 6;
			this.button4.Text = "Выбрать файл  с мерным кубом";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(336, 56);
			this.label4.TabIndex = 1;
			this.label4.Text = "Мерный куб - изображение содержащее объект с известными реальными горизонтальными" +
				" и вертикальными размерами, предназначенный для масштабирования отмечаемых на ка" +
				"драх координат.";
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(192, 168);
			this.numericUpDown2.Maximum = new System.Decimal(new int[] {
																		   100000,
																		   0,
																		   0,
																		   0});
			this.numericUpDown2.Minimum = new System.Decimal(new int[] {
																		   1,
																		   0,
																		   0,
																		   0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(56, 20);
			this.numericUpDown2.TabIndex = 12;
			this.numericUpDown2.Value = new System.Decimal(new int[] {
																		 400,
																		 0,
																		 0,
																		 0});
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(40, 160);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 32);
			this.button2.TabIndex = 5;
			this.button2.Text = "Выбрать файлы";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(16, 136);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(264, 16);
			this.radioButton4.TabIndex = 4;
			this.radioButton4.Text = "Выбрать файлы из каталога вручную";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "Выбрать папку";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(152, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "(маска вида: Общее_имя * , где * - произвольные символы)";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(40, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "Кадр *";
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new System.Drawing.Point(16, 24);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(264, 16);
			this.radioButton3.TabIndex = 0;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Выбрать файлы из каталога по маске";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(16, 504);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(184, 16);
			this.radioButton2.TabIndex = 9;
			this.radioButton2.Text = "Файл с данными";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(16, 48);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(184, 16);
			this.radioButton1.TabIndex = 8;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Папка с файлами";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "Источник входных данных:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.button7);
			this.panel2.Controls.Add(this.button6);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(450, 450);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1015, 700);
			this.panel2.TabIndex = 8;
			this.panel2.Visible = false;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label11.Location = new System.Drawing.Point(808, 208);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(168, 72);
			this.label11.TabIndex = 5;
			this.label11.Text = "Порядок расстановки точек на мерном кубе";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(808, 288);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(168, 160);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(384, 640);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(152, 40);
			this.button7.TabIndex = 3;
			this.button7.Text = "Далее >>";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(208, 640);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(152, 40);
			this.button6.TabIndex = 2;
			this.button6.Text = "Сбросить точки";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(16, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(768, 32);
			this.label8.TabIndex = 1;
			this.label8.Text = "Нажмите на ЛЕВУЮ НИЖНЮЮ точку куба";
			this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(8, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(768, 576);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button16);
			this.panel3.Controls.Add(this.button13);
			this.panel3.Controls.Add(this.button12);
			this.panel3.Controls.Add(this.button11);
			this.panel3.Controls.Add(this.button10);
			this.panel3.Controls.Add(this.button9);
			this.panel3.Controls.Add(this.button8);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.listBox1);
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Location = new System.Drawing.Point(500, 500);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1015, 700);
			this.panel3.TabIndex = 9;
			this.panel3.Visible = false;
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(480, 664);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(112, 24);
			this.button16.TabIndex = 11;
			this.button16.Text = "Пропустить точку";
			this.button16.Click += new System.EventHandler(this.button16_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(8, 624);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(120, 64);
			this.button13.TabIndex = 10;
			this.button13.Text = "Сбросить ВСЕ точки со всех кадров";
			this.button13.Click += new System.EventHandler(this.button13_Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(656, 624);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(120, 64);
			this.button12.TabIndex = 9;
			this.button12.Text = "Перейти к обработке данных";
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(336, 664);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(112, 24);
			this.button11.TabIndex = 8;
			this.button11.Text = "Сбросить точки";
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(192, 664);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(112, 24);
			this.button10.TabIndex = 7;
			this.button10.Text = "Отменить точку";
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(480, 624);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(112, 24);
			this.button9.TabIndex = 6;
			this.button9.Text = "Следующий кадр";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(192, 624);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(112, 24);
			this.button8.TabIndex = 5;
			this.button8.Text = "Предыдущий кадр";
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label10.ForeColor = System.Drawing.Color.Blue;
			this.label10.Location = new System.Drawing.Point(8, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(768, 24);
			this.label10.TabIndex = 4;
			this.label10.Text = "Точка 1: Плечевой сустав левой руки";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(792, 8);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(201, 373);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(320, 624);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(144, 16);
			this.label9.TabIndex = 2;
			this.label9.Text = "Кадр: 1 из ";
			this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(784, 432);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(224, 238);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(8, 40);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(768, 576);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
			this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.button25);
			this.panel4.Controls.Add(this.label103);
			this.panel4.Controls.Add(this.label102);
			this.panel4.Controls.Add(this.label100);
			this.panel4.Controls.Add(this.label99);
			this.panel4.Controls.Add(this.label98);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.numericUpDown3);
			this.panel4.Controls.Add(this.button15);
			this.panel4.Controls.Add(this.button14);
			this.panel4.Controls.Add(this.label101);
			this.panel4.Location = new System.Drawing.Point(550, 550);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1015, 700);
			this.panel4.TabIndex = 10;
			this.panel4.Visible = false;
			// 
			// button25
			// 
			this.button25.Location = new System.Drawing.Point(760, 648);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(240, 40);
			this.button25.TabIndex = 11;
			this.button25.Text = "Вернутся к выбору источников данных";
			this.button25.Click += new System.EventHandler(this.button25_Click);
			// 
			// label103
			// 
			this.label103.Location = new System.Drawing.Point(224, 232);
			this.label103.Name = "label103";
			this.label103.Size = new System.Drawing.Size(72, 16);
			this.label103.TabIndex = 10;
			this.label103.Text = "0";
			// 
			// label102
			// 
			this.label102.Location = new System.Drawing.Point(48, 224);
			this.label102.Name = "label102";
			this.label102.Size = new System.Drawing.Size(168, 24);
			this.label102.TabIndex = 9;
			this.label102.Text = "Минимальное количество кадров для обработки:";
			this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label100
			// 
			this.label100.Location = new System.Drawing.Point(224, 160);
			this.label100.Name = "label100";
			this.label100.Size = new System.Drawing.Size(72, 16);
			this.label100.TabIndex = 8;
			this.label100.Text = "0";
			// 
			// label99
			// 
			this.label99.Location = new System.Drawing.Point(104, 192);
			this.label99.Name = "label99";
			this.label99.Size = new System.Drawing.Size(112, 24);
			this.label99.TabIndex = 5;
			this.label99.Text = "Заполнено кадров:";
			this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label98
			// 
			this.label98.Location = new System.Drawing.Point(136, 160);
			this.label98.Name = "label98";
			this.label98.Size = new System.Drawing.Size(80, 24);
			this.label98.TabIndex = 4;
			this.label98.Text = "Всего кадров:";
			this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(72, 120);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(192, 24);
			this.label16.TabIndex = 3;
			this.label16.Text = "Количество используемых кадров:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numericUpDown3
			// 
			this.numericUpDown3.Location = new System.Drawing.Point(272, 120);
			this.numericUpDown3.Minimum = new System.Decimal(new int[] {
																		   3,
																		   0,
																		   0,
																		   0});
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(40, 20);
			this.numericUpDown3.TabIndex = 2;
			this.numericUpDown3.Value = new System.Decimal(new int[] {
																		 3,
																		 0,
																		 0,
																		 0});
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(56, 272);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(272, 64);
			this.button15.TabIndex = 1;
			this.button15.Text = "Перейти к выводу результатов";
			this.button15.Click += new System.EventHandler(this.button15_Click);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(56, 32);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(272, 48);
			this.button14.TabIndex = 0;
			this.button14.Text = "Сохранить данные в файл";
			this.button14.Click += new System.EventHandler(this.button14_Click);
			// 
			// label101
			// 
			this.label101.Location = new System.Drawing.Point(224, 192);
			this.label101.Name = "label101";
			this.label101.Size = new System.Drawing.Size(72, 16);
			this.label101.TabIndex = 8;
			this.label101.Text = "0";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Файлы данных *.dat|*.dat";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label12);
			this.panel5.Controls.Add(this.button17);
			this.panel5.Controls.Add(this.tabControl1);
			this.panel5.Controls.Add(this.label13);
			this.panel5.Controls.Add(this.label14);
			this.panel5.Controls.Add(this.label15);
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1015, 700);
			this.panel5.TabIndex = 11;
			this.panel5.Visible = false;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.label12.ForeColor = System.Drawing.Color.Blue;
			this.label12.Location = new System.Drawing.Point(440, 675);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(83, 16);
			this.label12.TabIndex = 2;
			this.label12.Text = "____________";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(832, 672);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(176, 24);
			this.button17.TabIndex = 1;
			this.button17.Text = "Вернутся к обработке данных";
			this.button17.Click += new System.EventHandler(this.button17_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage12);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1016, 670);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label26);
			this.tabPage1.Controls.Add(this.pictureBox20);
			this.tabPage1.Controls.Add(this.label25);
			this.tabPage1.Controls.Add(this.pictureBox19);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1008, 644);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Углы";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(8, 328);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(272, 16);
			this.label26.TabIndex = 15;
			this.label26.Text = "Угол сгибания коленного сустава";
			// 
			// pictureBox20
			// 
			this.pictureBox20.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox20.Location = new System.Drawing.Point(8, 352);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(984, 277);
			this.pictureBox20.TabIndex = 14;
			this.pictureBox20.TabStop = false;
			this.pictureBox20.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox20_Paint);
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(8, 8);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(272, 16);
			this.label25.TabIndex = 13;
			this.label25.Text = "Угол сгибания локтевого сустава";
			// 
			// pictureBox19
			// 
			this.pictureBox19.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox19.Location = new System.Drawing.Point(8, 32);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(984, 277);
			this.pictureBox19.TabIndex = 3;
			this.pictureBox19.TabStop = false;
			this.pictureBox19.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox19_Paint);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tabControl2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1008, 644);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Перемещения";
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage5);
			this.tabControl2.Controls.Add(this.tabPage6);
			this.tabControl2.Controls.Add(this.tabPage7);
			this.tabControl2.Controls.Add(this.tabPage8);
			this.tabControl2.Controls.Add(this.tabPage9);
			this.tabControl2.Controls.Add(this.tabPage10);
			this.tabControl2.Controls.Add(this.tabPage11);
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(1008, 640);
			this.tabControl2.TabIndex = 0;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.label17);
			this.tabPage5.Controls.Add(this.pictureBox5);
			this.tabPage5.Controls.Add(this.pictureBox6);
			this.tabPage5.Controls.Add(this.pictureBox7);
			this.tabPage5.Controls.Add(this.label18);
			this.tabPage5.Controls.Add(this.label19);
			this.tabPage5.Controls.Add(this.pictureBox8);
			this.tabPage5.Controls.Add(this.label20);
			this.tabPage5.Controls.Add(this.label21);
			this.tabPage5.Controls.Add(this.pictureBox9);
			this.tabPage5.Controls.Add(this.pictureBox10);
			this.tabPage5.Controls.Add(this.label22);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(1000, 614);
			this.tabPage5.TabIndex = 0;
			this.tabPage5.Text = "Все графики";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(8, 6);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(184, 16);
			this.label17.TabIndex = 11;
			this.label17.Text = "Плечо";
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox5.Location = new System.Drawing.Point(8, 24);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(432, 181);
			this.pictureBox5.TabIndex = 6;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox5_Paint);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox6.Location = new System.Drawing.Point(8, 224);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(432, 181);
			this.pictureBox6.TabIndex = 7;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox6_Paint);
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox7.Location = new System.Drawing.Point(8, 424);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(432, 181);
			this.pictureBox7.TabIndex = 5;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox7_Paint);
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 208);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(184, 16);
			this.label18.TabIndex = 10;
			this.label18.Text = "Локоть";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(8, 408);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(184, 16);
			this.label19.TabIndex = 13;
			this.label19.Text = "Кисть";
			// 
			// pictureBox8
			// 
			this.pictureBox8.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox8.Location = new System.Drawing.Point(472, 224);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(432, 181);
			this.pictureBox8.TabIndex = 4;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox8_Paint);
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(472, 6);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(184, 16);
			this.label20.TabIndex = 12;
			this.label20.Text = "Колено";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(472, 408);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(200, 16);
			this.label21.TabIndex = 8;
			this.label21.Text = "Движение центра тяжести по оси Y";
			// 
			// pictureBox9
			// 
			this.pictureBox9.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox9.Location = new System.Drawing.Point(472, 424);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(432, 181);
			this.pictureBox9.TabIndex = 3;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox9_Paint);
			// 
			// pictureBox10
			// 
			this.pictureBox10.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox10.Location = new System.Drawing.Point(472, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(432, 181);
			this.pictureBox10.TabIndex = 2;
			this.pictureBox10.TabStop = false;
			this.pictureBox10.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox10_Paint);
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(472, 208);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(184, 16);
			this.label22.TabIndex = 9;
			this.label22.Text = "Стопа";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.pictureBox11);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(1000, 614);
			this.tabPage6.TabIndex = 1;
			this.tabPage6.Text = "Плечо";
			// 
			// pictureBox11
			// 
			this.pictureBox11.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox11.Location = new System.Drawing.Point(8, 8);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(984, 600);
			this.pictureBox11.TabIndex = 0;
			this.pictureBox11.TabStop = false;
			this.pictureBox11.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox11_Paint);
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.pictureBox12);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new System.Drawing.Size(1000, 614);
			this.tabPage7.TabIndex = 2;
			this.tabPage7.Text = "Локоть";
			// 
			// pictureBox12
			// 
			this.pictureBox12.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox12.Location = new System.Drawing.Point(8, 8);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(984, 600);
			this.pictureBox12.TabIndex = 1;
			this.pictureBox12.TabStop = false;
			this.pictureBox12.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox12_Paint);
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.pictureBox13);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Size = new System.Drawing.Size(1000, 614);
			this.tabPage8.TabIndex = 3;
			this.tabPage8.Text = "Кисть";
			// 
			// pictureBox13
			// 
			this.pictureBox13.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox13.Location = new System.Drawing.Point(8, 8);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(984, 600);
			this.pictureBox13.TabIndex = 1;
			this.pictureBox13.TabStop = false;
			this.pictureBox13.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox13_Paint);
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.pictureBox14);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Size = new System.Drawing.Size(1000, 614);
			this.tabPage9.TabIndex = 4;
			this.tabPage9.Text = "Колено";
			// 
			// pictureBox14
			// 
			this.pictureBox14.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox14.Location = new System.Drawing.Point(8, 8);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(984, 600);
			this.pictureBox14.TabIndex = 1;
			this.pictureBox14.TabStop = false;
			this.pictureBox14.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox14_Paint);
			// 
			// tabPage10
			// 
			this.tabPage10.Controls.Add(this.pictureBox15);
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(1000, 614);
			this.tabPage10.TabIndex = 5;
			this.tabPage10.Text = "Стопа";
			// 
			// pictureBox15
			// 
			this.pictureBox15.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox15.Location = new System.Drawing.Point(8, 7);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(984, 600);
			this.pictureBox15.TabIndex = 1;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox15_Paint);
			// 
			// tabPage11
			// 
			this.tabPage11.Controls.Add(this.pictureBox16);
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Size = new System.Drawing.Size(1000, 614);
			this.tabPage11.TabIndex = 6;
			this.tabPage11.Text = "Движение центра тяжести по оси Y";
			// 
			// pictureBox16
			// 
			this.pictureBox16.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox16.Location = new System.Drawing.Point(8, 8);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(984, 600);
			this.pictureBox16.TabIndex = 1;
			this.pictureBox16.TabStop = false;
			this.pictureBox16.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox16_Paint);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label23);
			this.tabPage3.Controls.Add(this.pictureBox17);
			this.tabPage3.Controls.Add(this.pictureBox18);
			this.tabPage3.Controls.Add(this.label24);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1008, 644);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Динамика ходьбы";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(8, 4);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(272, 16);
			this.label23.TabIndex = 12;
			this.label23.Text = "Динамика движения центра тяжести по оси X";
			// 
			// pictureBox17
			// 
			this.pictureBox17.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox17.Location = new System.Drawing.Point(8, 22);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(984, 277);
			this.pictureBox17.TabIndex = 2;
			this.pictureBox17.TabStop = false;
			this.pictureBox17.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox17_Paint);
			// 
			// pictureBox18
			// 
			this.pictureBox18.BackColor = System.Drawing.Color.AliceBlue;
			this.pictureBox18.Location = new System.Drawing.Point(8, 344);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(984, 277);
			this.pictureBox18.TabIndex = 2;
			this.pictureBox18.TabStop = false;
			this.pictureBox18.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox18_Paint);
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(8, 328);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(304, 16);
			this.label24.TabIndex = 12;
			this.label24.Text = "График мгновенных скоростей центра тяжести по оси X";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.groupBox16);
			this.tabPage4.Controls.Add(this.groupBox15);
			this.tabPage4.Controls.Add(this.groupBox4);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1008, 644);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Статистические данные";
			// 
			// groupBox16
			// 
			this.groupBox16.Controls.Add(this.groupBox19);
			this.groupBox16.Controls.Add(this.label94);
			this.groupBox16.Controls.Add(this.label95);
			this.groupBox16.Controls.Add(this.label96);
			this.groupBox16.Controls.Add(this.label97);
			this.groupBox16.Location = new System.Drawing.Point(0, 360);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new System.Drawing.Size(480, 136);
			this.groupBox16.TabIndex = 2;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "Временные параметры";
			// 
			// groupBox19
			// 
			this.groupBox19.Controls.Add(this.label35);
			this.groupBox19.Controls.Add(this.label36);
			this.groupBox19.Controls.Add(this.label37);
			this.groupBox19.Controls.Add(this.label38);
			this.groupBox19.Controls.Add(this.label39);
			this.groupBox19.Controls.Add(this.label40);
			this.groupBox19.Controls.Add(this.label41);
			this.groupBox19.Controls.Add(this.label42);
			this.groupBox19.Location = new System.Drawing.Point(8, 64);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Size = new System.Drawing.Size(464, 64);
			this.groupBox19.TabIndex = 8;
			this.groupBox19.TabStop = false;
			this.groupBox19.Text = "Скорость движения центра тяжести по оси X";
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(256, 16);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(88, 16);
			this.label35.TabIndex = 5;
			this.label35.Text = "1,0000 м/c";
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(200, 16);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(56, 16);
			this.label36.TabIndex = 4;
			this.label36.Text = "Среднее:";
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(72, 16);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(88, 16);
			this.label37.TabIndex = 3;
			this.label37.Text = "1,0000 м/c";
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(8, 16);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(64, 16);
			this.label38.TabIndex = 2;
			this.label38.Text = "Минимум:";
			// 
			// label39
			// 
			this.label39.Location = new System.Drawing.Point(72, 40);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(80, 16);
			this.label39.TabIndex = 3;
			this.label39.Text = "1,0000 м/c";
			// 
			// label40
			// 
			this.label40.Location = new System.Drawing.Point(8, 40);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(64, 16);
			this.label40.TabIndex = 2;
			this.label40.Text = "Максимум:";
			// 
			// label41
			// 
			this.label41.Location = new System.Drawing.Point(256, 40);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(88, 16);
			this.label41.TabIndex = 3;
			this.label41.Text = "1,0000 м/c";
			// 
			// label42
			// 
			this.label42.Location = new System.Drawing.Point(192, 40);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(72, 16);
			this.label42.TabIndex = 2;
			this.label42.Text = "Дисперсия:";
			// 
			// label94
			// 
			this.label94.Location = new System.Drawing.Point(264, 24);
			this.label94.Name = "label94";
			this.label94.Size = new System.Drawing.Size(48, 16);
			this.label94.TabIndex = 7;
			this.label94.Text = "100 м/с";
			// 
			// label95
			// 
			this.label95.Location = new System.Drawing.Point(16, 24);
			this.label95.Name = "label95";
			this.label95.Size = new System.Drawing.Size(256, 16);
			this.label95.TabIndex = 6;
			this.label95.Text = "Средняя скорость ходьбы (расстояния/время):";
			// 
			// label96
			// 
			this.label96.Location = new System.Drawing.Point(312, 24);
			this.label96.Name = "label96";
			this.label96.Size = new System.Drawing.Size(16, 16);
			this.label96.TabIndex = 6;
			this.label96.Text = "=";
			// 
			// label97
			// 
			this.label97.Location = new System.Drawing.Point(328, 24);
			this.label97.Name = "label97";
			this.label97.Size = new System.Drawing.Size(72, 16);
			this.label97.TabIndex = 7;
			this.label97.Text = "100 км/ч";
			// 
			// groupBox15
			// 
			this.groupBox15.Controls.Add(this.label123);
			this.groupBox15.Controls.Add(this.label124);
			this.groupBox15.Controls.Add(this.label121);
			this.groupBox15.Controls.Add(this.label122);
			this.groupBox15.Controls.Add(this.label120);
			this.groupBox15.Controls.Add(this.label93);
			this.groupBox15.Controls.Add(this.label91);
			this.groupBox15.Controls.Add(this.label92);
			this.groupBox15.Location = new System.Drawing.Point(0, 264);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(480, 96);
			this.groupBox15.TabIndex = 1;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "Пространственные параметры";
			// 
			// label123
			// 
			this.label123.Location = new System.Drawing.Point(392, 24);
			this.label123.Name = "label123";
			this.label123.Size = new System.Drawing.Size(40, 16);
			this.label123.TabIndex = 11;
			this.label123.Text = "100 см";
			// 
			// label124
			// 
			this.label124.Location = new System.Drawing.Point(256, 24);
			this.label124.Name = "label124";
			this.label124.Size = new System.Drawing.Size(144, 16);
			this.label124.TabIndex = 10;
			this.label124.Text = "Длина шага правой ноги:";
			// 
			// label121
			// 
			this.label121.Location = new System.Drawing.Point(392, 56);
			this.label121.Name = "label121";
			this.label121.Size = new System.Drawing.Size(72, 16);
			this.label121.TabIndex = 9;
			this.label121.Text = "100 см";
			// 
			// label122
			// 
			this.label122.Location = new System.Drawing.Point(256, 56);
			this.label122.Name = "label122";
			this.label122.Size = new System.Drawing.Size(120, 16);
			this.label122.TabIndex = 8;
			this.label122.Text = "Клиренс правой ноги:";
			// 
			// label120
			// 
			this.label120.Location = new System.Drawing.Point(144, 56);
			this.label120.Name = "label120";
			this.label120.Size = new System.Drawing.Size(88, 16);
			this.label120.TabIndex = 7;
			this.label120.Text = "100 см";
			// 
			// label93
			// 
			this.label93.Location = new System.Drawing.Point(16, 56);
			this.label93.Name = "label93";
			this.label93.Size = new System.Drawing.Size(120, 16);
			this.label93.TabIndex = 6;
			this.label93.Text = "Клиренс левой ноги:";
			// 
			// label91
			// 
			this.label91.Location = new System.Drawing.Point(144, 24);
			this.label91.Name = "label91";
			this.label91.Size = new System.Drawing.Size(40, 16);
			this.label91.TabIndex = 5;
			this.label91.Text = "100 см";
			// 
			// label92
			// 
			this.label92.Location = new System.Drawing.Point(16, 24);
			this.label92.Name = "label92";
			this.label92.Size = new System.Drawing.Size(136, 16);
			this.label92.TabIndex = 4;
			this.label92.Text = "Длина шага левой ноги:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.groupBox8);
			this.groupBox4.Controls.Add(this.groupBox7);
			this.groupBox4.Location = new System.Drawing.Point(0, 0);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1008, 256);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Кинематические параметры";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.groupBox14);
			this.groupBox8.Controls.Add(this.groupBox13);
			this.groupBox8.Controls.Add(this.groupBox9);
			this.groupBox8.Controls.Add(this.groupBox12);
			this.groupBox8.Controls.Add(this.groupBox10);
			this.groupBox8.Controls.Add(this.groupBox11);
			this.groupBox8.Location = new System.Drawing.Point(8, 88);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(984, 160);
			this.groupBox8.TabIndex = 3;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Амплитуда перемещений";
			// 
			// groupBox14
			// 
			this.groupBox14.Controls.Add(this.label83);
			this.groupBox14.Controls.Add(this.label84);
			this.groupBox14.Controls.Add(this.label85);
			this.groupBox14.Controls.Add(this.label86);
			this.groupBox14.Controls.Add(this.label87);
			this.groupBox14.Controls.Add(this.label88);
			this.groupBox14.Controls.Add(this.label89);
			this.groupBox14.Controls.Add(this.label90);
			this.groupBox14.Location = new System.Drawing.Point(496, 104);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(480, 40);
			this.groupBox14.TabIndex = 2;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Движение центра тяжести по оси Y";
			// 
			// label83
			// 
			this.label83.Location = new System.Drawing.Point(168, 16);
			this.label83.Name = "label83";
			this.label83.Size = new System.Drawing.Size(40, 16);
			this.label83.TabIndex = 5;
			this.label83.Text = "100 см";
			// 
			// label84
			// 
			this.label84.Location = new System.Drawing.Point(112, 16);
			this.label84.Name = "label84";
			this.label84.Size = new System.Drawing.Size(56, 16);
			this.label84.TabIndex = 4;
			this.label84.Text = "Среднее:";
			// 
			// label85
			// 
			this.label85.Location = new System.Drawing.Point(64, 16);
			this.label85.Name = "label85";
			this.label85.Size = new System.Drawing.Size(40, 16);
			this.label85.TabIndex = 3;
			this.label85.Text = "100 см";
			// 
			// label86
			// 
			this.label86.Location = new System.Drawing.Point(8, 16);
			this.label86.Name = "label86";
			this.label86.Size = new System.Drawing.Size(64, 16);
			this.label86.TabIndex = 2;
			this.label86.Text = "Минимум:";
			// 
			// label87
			// 
			this.label87.Location = new System.Drawing.Point(280, 16);
			this.label87.Name = "label87";
			this.label87.Size = new System.Drawing.Size(40, 16);
			this.label87.TabIndex = 3;
			this.label87.Text = "100 см";
			// 
			// label88
			// 
			this.label88.Location = new System.Drawing.Point(216, 16);
			this.label88.Name = "label88";
			this.label88.Size = new System.Drawing.Size(64, 16);
			this.label88.TabIndex = 2;
			this.label88.Text = "Максимум:";
			// 
			// label89
			// 
			this.label89.Location = new System.Drawing.Point(392, 16);
			this.label89.Name = "label89";
			this.label89.Size = new System.Drawing.Size(64, 16);
			this.label89.TabIndex = 3;
			this.label89.Text = "100 см";
			// 
			// label90
			// 
			this.label90.Location = new System.Drawing.Point(328, 16);
			this.label90.Name = "label90";
			this.label90.Size = new System.Drawing.Size(72, 16);
			this.label90.TabIndex = 2;
			this.label90.Text = "Дисперсия:";
			// 
			// groupBox13
			// 
			this.groupBox13.Controls.Add(this.label75);
			this.groupBox13.Controls.Add(this.label76);
			this.groupBox13.Controls.Add(this.label77);
			this.groupBox13.Controls.Add(this.label78);
			this.groupBox13.Controls.Add(this.label79);
			this.groupBox13.Controls.Add(this.label80);
			this.groupBox13.Controls.Add(this.label81);
			this.groupBox13.Controls.Add(this.label82);
			this.groupBox13.Location = new System.Drawing.Point(8, 104);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(472, 40);
			this.groupBox13.TabIndex = 2;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Точка \"Стопа\"";
			// 
			// label75
			// 
			this.label75.Location = new System.Drawing.Point(168, 16);
			this.label75.Name = "label75";
			this.label75.Size = new System.Drawing.Size(40, 16);
			this.label75.TabIndex = 5;
			this.label75.Text = "100 см";
			// 
			// label76
			// 
			this.label76.Location = new System.Drawing.Point(112, 16);
			this.label76.Name = "label76";
			this.label76.Size = new System.Drawing.Size(56, 16);
			this.label76.TabIndex = 4;
			this.label76.Text = "Среднее:";
			// 
			// label77
			// 
			this.label77.Location = new System.Drawing.Point(64, 16);
			this.label77.Name = "label77";
			this.label77.Size = new System.Drawing.Size(40, 16);
			this.label77.TabIndex = 3;
			this.label77.Text = "100 см";
			// 
			// label78
			// 
			this.label78.Location = new System.Drawing.Point(8, 16);
			this.label78.Name = "label78";
			this.label78.Size = new System.Drawing.Size(64, 16);
			this.label78.TabIndex = 2;
			this.label78.Text = "Минимум:";
			// 
			// label79
			// 
			this.label79.Location = new System.Drawing.Point(280, 16);
			this.label79.Name = "label79";
			this.label79.Size = new System.Drawing.Size(40, 16);
			this.label79.TabIndex = 3;
			this.label79.Text = "100 см";
			// 
			// label80
			// 
			this.label80.Location = new System.Drawing.Point(216, 16);
			this.label80.Name = "label80";
			this.label80.Size = new System.Drawing.Size(64, 16);
			this.label80.TabIndex = 2;
			this.label80.Text = "Максимум:";
			// 
			// label81
			// 
			this.label81.Location = new System.Drawing.Point(392, 16);
			this.label81.Name = "label81";
			this.label81.Size = new System.Drawing.Size(64, 16);
			this.label81.TabIndex = 3;
			this.label81.Text = "100 см";
			// 
			// label82
			// 
			this.label82.Location = new System.Drawing.Point(328, 16);
			this.label82.Name = "label82";
			this.label82.Size = new System.Drawing.Size(72, 16);
			this.label82.TabIndex = 2;
			this.label82.Text = "Дисперсия:";
			// 
			// groupBox9
			// 
			this.groupBox9.Controls.Add(this.label45);
			this.groupBox9.Controls.Add(this.label46);
			this.groupBox9.Controls.Add(this.label43);
			this.groupBox9.Controls.Add(this.label44);
			this.groupBox9.Controls.Add(this.label47);
			this.groupBox9.Controls.Add(this.label48);
			this.groupBox9.Controls.Add(this.label49);
			this.groupBox9.Controls.Add(this.label50);
			this.groupBox9.Location = new System.Drawing.Point(8, 24);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(472, 40);
			this.groupBox9.TabIndex = 2;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Точка \"плечо\"";
			// 
			// label45
			// 
			this.label45.Location = new System.Drawing.Point(168, 16);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(40, 16);
			this.label45.TabIndex = 5;
			this.label45.Text = "100 см";
			// 
			// label46
			// 
			this.label46.Location = new System.Drawing.Point(112, 16);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(56, 16);
			this.label46.TabIndex = 4;
			this.label46.Text = "Среднее:";
			// 
			// label43
			// 
			this.label43.Location = new System.Drawing.Point(64, 16);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(40, 16);
			this.label43.TabIndex = 3;
			this.label43.Text = "100 см";
			// 
			// label44
			// 
			this.label44.Location = new System.Drawing.Point(8, 16);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(64, 16);
			this.label44.TabIndex = 2;
			this.label44.Text = "Минимум:";
			// 
			// label47
			// 
			this.label47.Location = new System.Drawing.Point(280, 16);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(40, 16);
			this.label47.TabIndex = 3;
			this.label47.Text = "100 см";
			// 
			// label48
			// 
			this.label48.Location = new System.Drawing.Point(216, 16);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(64, 16);
			this.label48.TabIndex = 2;
			this.label48.Text = "Максимум:";
			// 
			// label49
			// 
			this.label49.Location = new System.Drawing.Point(392, 16);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(64, 16);
			this.label49.TabIndex = 3;
			this.label49.Text = "100 см";
			// 
			// label50
			// 
			this.label50.Location = new System.Drawing.Point(328, 16);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(72, 16);
			this.label50.TabIndex = 2;
			this.label50.Text = "Дисперсия:";
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.label67);
			this.groupBox12.Controls.Add(this.label68);
			this.groupBox12.Controls.Add(this.label69);
			this.groupBox12.Controls.Add(this.label70);
			this.groupBox12.Controls.Add(this.label71);
			this.groupBox12.Controls.Add(this.label72);
			this.groupBox12.Controls.Add(this.label73);
			this.groupBox12.Controls.Add(this.label74);
			this.groupBox12.Location = new System.Drawing.Point(496, 64);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(480, 40);
			this.groupBox12.TabIndex = 2;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Точка \"Колено\"";
			// 
			// label67
			// 
			this.label67.Location = new System.Drawing.Point(168, 16);
			this.label67.Name = "label67";
			this.label67.Size = new System.Drawing.Size(40, 16);
			this.label67.TabIndex = 5;
			this.label67.Text = "100 см";
			// 
			// label68
			// 
			this.label68.Location = new System.Drawing.Point(112, 16);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(56, 16);
			this.label68.TabIndex = 4;
			this.label68.Text = "Среднее:";
			// 
			// label69
			// 
			this.label69.Location = new System.Drawing.Point(64, 16);
			this.label69.Name = "label69";
			this.label69.Size = new System.Drawing.Size(40, 16);
			this.label69.TabIndex = 3;
			this.label69.Text = "100 см";
			// 
			// label70
			// 
			this.label70.Location = new System.Drawing.Point(8, 16);
			this.label70.Name = "label70";
			this.label70.Size = new System.Drawing.Size(64, 16);
			this.label70.TabIndex = 2;
			this.label70.Text = "Минимум:";
			// 
			// label71
			// 
			this.label71.Location = new System.Drawing.Point(280, 16);
			this.label71.Name = "label71";
			this.label71.Size = new System.Drawing.Size(40, 16);
			this.label71.TabIndex = 3;
			this.label71.Text = "100 см";
			// 
			// label72
			// 
			this.label72.Location = new System.Drawing.Point(216, 16);
			this.label72.Name = "label72";
			this.label72.Size = new System.Drawing.Size(64, 16);
			this.label72.TabIndex = 2;
			this.label72.Text = "Максимум:";
			// 
			// label73
			// 
			this.label73.Location = new System.Drawing.Point(392, 16);
			this.label73.Name = "label73";
			this.label73.Size = new System.Drawing.Size(64, 16);
			this.label73.TabIndex = 3;
			this.label73.Text = "100 см";
			// 
			// label74
			// 
			this.label74.Location = new System.Drawing.Point(328, 16);
			this.label74.Name = "label74";
			this.label74.Size = new System.Drawing.Size(72, 16);
			this.label74.TabIndex = 2;
			this.label74.Text = "Дисперсия:";
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.label51);
			this.groupBox10.Controls.Add(this.label52);
			this.groupBox10.Controls.Add(this.label53);
			this.groupBox10.Controls.Add(this.label54);
			this.groupBox10.Controls.Add(this.label55);
			this.groupBox10.Controls.Add(this.label56);
			this.groupBox10.Controls.Add(this.label57);
			this.groupBox10.Controls.Add(this.label58);
			this.groupBox10.Location = new System.Drawing.Point(496, 24);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(480, 40);
			this.groupBox10.TabIndex = 2;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Точка \"Локоть\"";
			// 
			// label51
			// 
			this.label51.Location = new System.Drawing.Point(168, 16);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(40, 16);
			this.label51.TabIndex = 5;
			this.label51.Text = "100 см";
			// 
			// label52
			// 
			this.label52.Location = new System.Drawing.Point(112, 16);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(56, 16);
			this.label52.TabIndex = 4;
			this.label52.Text = "Среднее:";
			// 
			// label53
			// 
			this.label53.Location = new System.Drawing.Point(64, 16);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(40, 16);
			this.label53.TabIndex = 3;
			this.label53.Text = "100 см";
			// 
			// label54
			// 
			this.label54.Location = new System.Drawing.Point(8, 16);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(64, 16);
			this.label54.TabIndex = 2;
			this.label54.Text = "Минимум:";
			// 
			// label55
			// 
			this.label55.Location = new System.Drawing.Point(280, 16);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(40, 16);
			this.label55.TabIndex = 3;
			this.label55.Text = "100 см";
			// 
			// label56
			// 
			this.label56.Location = new System.Drawing.Point(216, 16);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(64, 16);
			this.label56.TabIndex = 2;
			this.label56.Text = "Максимум:";
			// 
			// label57
			// 
			this.label57.Location = new System.Drawing.Point(392, 16);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(64, 16);
			this.label57.TabIndex = 3;
			this.label57.Text = "100 см";
			// 
			// label58
			// 
			this.label58.Location = new System.Drawing.Point(328, 16);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(72, 16);
			this.label58.TabIndex = 2;
			this.label58.Text = "Дисперсия:";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.label59);
			this.groupBox11.Controls.Add(this.label60);
			this.groupBox11.Controls.Add(this.label61);
			this.groupBox11.Controls.Add(this.label62);
			this.groupBox11.Controls.Add(this.label63);
			this.groupBox11.Controls.Add(this.label64);
			this.groupBox11.Controls.Add(this.label65);
			this.groupBox11.Controls.Add(this.label66);
			this.groupBox11.Location = new System.Drawing.Point(8, 64);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(472, 40);
			this.groupBox11.TabIndex = 2;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Точка \"Кисть\"";
			// 
			// label59
			// 
			this.label59.Location = new System.Drawing.Point(168, 16);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(40, 16);
			this.label59.TabIndex = 5;
			this.label59.Text = "100 см";
			// 
			// label60
			// 
			this.label60.Location = new System.Drawing.Point(112, 16);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(56, 16);
			this.label60.TabIndex = 4;
			this.label60.Text = "Среднее:";
			// 
			// label61
			// 
			this.label61.Location = new System.Drawing.Point(64, 16);
			this.label61.Name = "label61";
			this.label61.Size = new System.Drawing.Size(40, 16);
			this.label61.TabIndex = 3;
			this.label61.Text = "100 см";
			// 
			// label62
			// 
			this.label62.Location = new System.Drawing.Point(8, 16);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(64, 16);
			this.label62.TabIndex = 2;
			this.label62.Text = "Минимум:";
			// 
			// label63
			// 
			this.label63.Location = new System.Drawing.Point(280, 16);
			this.label63.Name = "label63";
			this.label63.Size = new System.Drawing.Size(40, 16);
			this.label63.TabIndex = 3;
			this.label63.Text = "100 см";
			// 
			// label64
			// 
			this.label64.Location = new System.Drawing.Point(216, 16);
			this.label64.Name = "label64";
			this.label64.Size = new System.Drawing.Size(64, 16);
			this.label64.TabIndex = 2;
			this.label64.Text = "Максимум:";
			// 
			// label65
			// 
			this.label65.Location = new System.Drawing.Point(392, 16);
			this.label65.Name = "label65";
			this.label65.Size = new System.Drawing.Size(64, 16);
			this.label65.TabIndex = 3;
			this.label65.Text = "100 см";
			// 
			// label66
			// 
			this.label66.Location = new System.Drawing.Point(328, 16);
			this.label66.Name = "label66";
			this.label66.Size = new System.Drawing.Size(72, 16);
			this.label66.TabIndex = 2;
			this.label66.Text = "Дисперсия:";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.groupBox18);
			this.groupBox7.Controls.Add(this.groupBox17);
			this.groupBox7.Location = new System.Drawing.Point(8, 16);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(984, 64);
			this.groupBox7.TabIndex = 0;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Амплитуда углов (в градусах)";
			// 
			// groupBox18
			// 
			this.groupBox18.Controls.Add(this.label112);
			this.groupBox18.Controls.Add(this.label113);
			this.groupBox18.Controls.Add(this.label114);
			this.groupBox18.Controls.Add(this.label115);
			this.groupBox18.Controls.Add(this.label116);
			this.groupBox18.Controls.Add(this.label117);
			this.groupBox18.Controls.Add(this.label118);
			this.groupBox18.Controls.Add(this.label119);
			this.groupBox18.Location = new System.Drawing.Point(520, 16);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(456, 40);
			this.groupBox18.TabIndex = 5;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Коленный сустав";
			// 
			// label112
			// 
			this.label112.Location = new System.Drawing.Point(168, 16);
			this.label112.Name = "label112";
			this.label112.Size = new System.Drawing.Size(40, 16);
			this.label112.TabIndex = 5;
			this.label112.Text = "100";
			// 
			// label113
			// 
			this.label113.Location = new System.Drawing.Point(112, 16);
			this.label113.Name = "label113";
			this.label113.Size = new System.Drawing.Size(56, 16);
			this.label113.TabIndex = 4;
			this.label113.Text = "Среднее:";
			// 
			// label114
			// 
			this.label114.Location = new System.Drawing.Point(64, 16);
			this.label114.Name = "label114";
			this.label114.Size = new System.Drawing.Size(40, 16);
			this.label114.TabIndex = 3;
			this.label114.Text = "100";
			// 
			// label115
			// 
			this.label115.Location = new System.Drawing.Point(8, 16);
			this.label115.Name = "label115";
			this.label115.Size = new System.Drawing.Size(64, 16);
			this.label115.TabIndex = 2;
			this.label115.Text = "Минимум:";
			// 
			// label116
			// 
			this.label116.Location = new System.Drawing.Point(280, 16);
			this.label116.Name = "label116";
			this.label116.Size = new System.Drawing.Size(40, 16);
			this.label116.TabIndex = 3;
			this.label116.Text = "100";
			// 
			// label117
			// 
			this.label117.Location = new System.Drawing.Point(216, 16);
			this.label117.Name = "label117";
			this.label117.Size = new System.Drawing.Size(64, 16);
			this.label117.TabIndex = 2;
			this.label117.Text = "Максимум:";
			// 
			// label118
			// 
			this.label118.Location = new System.Drawing.Point(392, 16);
			this.label118.Name = "label118";
			this.label118.Size = new System.Drawing.Size(56, 16);
			this.label118.TabIndex = 3;
			this.label118.Text = "100";
			// 
			// label119
			// 
			this.label119.Location = new System.Drawing.Point(328, 16);
			this.label119.Name = "label119";
			this.label119.Size = new System.Drawing.Size(72, 16);
			this.label119.TabIndex = 2;
			this.label119.Text = "Дисперсия:";
			// 
			// groupBox17
			// 
			this.groupBox17.Controls.Add(this.label104);
			this.groupBox17.Controls.Add(this.label105);
			this.groupBox17.Controls.Add(this.label106);
			this.groupBox17.Controls.Add(this.label107);
			this.groupBox17.Controls.Add(this.label108);
			this.groupBox17.Controls.Add(this.label109);
			this.groupBox17.Controls.Add(this.label110);
			this.groupBox17.Controls.Add(this.label111);
			this.groupBox17.Location = new System.Drawing.Point(8, 16);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Size = new System.Drawing.Size(456, 40);
			this.groupBox17.TabIndex = 4;
			this.groupBox17.TabStop = false;
			this.groupBox17.Text = "Локтевой сустав";
			// 
			// label104
			// 
			this.label104.Location = new System.Drawing.Point(168, 16);
			this.label104.Name = "label104";
			this.label104.Size = new System.Drawing.Size(40, 16);
			this.label104.TabIndex = 5;
			this.label104.Text = "100";
			// 
			// label105
			// 
			this.label105.Location = new System.Drawing.Point(112, 16);
			this.label105.Name = "label105";
			this.label105.Size = new System.Drawing.Size(56, 16);
			this.label105.TabIndex = 4;
			this.label105.Text = "Среднее:";
			// 
			// label106
			// 
			this.label106.Location = new System.Drawing.Point(64, 16);
			this.label106.Name = "label106";
			this.label106.Size = new System.Drawing.Size(40, 16);
			this.label106.TabIndex = 3;
			this.label106.Text = "100";
			// 
			// label107
			// 
			this.label107.Location = new System.Drawing.Point(8, 16);
			this.label107.Name = "label107";
			this.label107.Size = new System.Drawing.Size(64, 16);
			this.label107.TabIndex = 2;
			this.label107.Text = "Минимум:";
			// 
			// label108
			// 
			this.label108.Location = new System.Drawing.Point(280, 16);
			this.label108.Name = "label108";
			this.label108.Size = new System.Drawing.Size(40, 16);
			this.label108.TabIndex = 3;
			this.label108.Text = "100";
			// 
			// label109
			// 
			this.label109.Location = new System.Drawing.Point(216, 16);
			this.label109.Name = "label109";
			this.label109.Size = new System.Drawing.Size(64, 16);
			this.label109.TabIndex = 2;
			this.label109.Text = "Максимум:";
			// 
			// label110
			// 
			this.label110.Location = new System.Drawing.Point(392, 16);
			this.label110.Name = "label110";
			this.label110.Size = new System.Drawing.Size(56, 16);
			this.label110.TabIndex = 3;
			this.label110.Text = "100";
			// 
			// label111
			// 
			this.label111.Location = new System.Drawing.Point(328, 16);
			this.label111.Name = "label111";
			this.label111.Size = new System.Drawing.Size(72, 16);
			this.label111.TabIndex = 2;
			this.label111.Text = "Дисперсия:";
			// 
			// tabPage12
			// 
			this.tabPage12.Controls.Add(this.label131);
			this.tabPage12.Controls.Add(this.textBox4);
			this.tabPage12.Controls.Add(this.label130);
			this.tabPage12.Controls.Add(this.textBox3);
			this.tabPage12.Controls.Add(this.button24);
			this.tabPage12.Controls.Add(this.groupBox21);
			this.tabPage12.Location = new System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Size = new System.Drawing.Size(1008, 644);
			this.tabPage12.TabIndex = 4;
			this.tabPage12.Text = "Анализ походки";
			// 
			// label131
			// 
			this.label131.Location = new System.Drawing.Point(712, 152);
			this.label131.Name = "label131";
			this.label131.Size = new System.Drawing.Size(248, 50);
			this.label131.TabIndex = 5;
			this.label131.Text = "Alfa - константа от 0 до 1,\r\nR - корреляция.\r\nЕсли Alfa<R - сходство не достаточн" +
				"ое,\r\nЕсли Alfa>R - сходство достаточное.\r\n";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(616, 166);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(80, 20);
			this.textBox4.TabIndex = 4;
			this.textBox4.Text = "0,8";
			// 
			// label130
			// 
			this.label130.Location = new System.Drawing.Point(576, 168);
			this.label130.Name = "label130";
			this.label130.Size = new System.Drawing.Size(40, 16);
			this.label130.TabIndex = 3;
			this.label130.Text = "Alfa = ";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(8, 208);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox3.Size = new System.Drawing.Size(984, 416);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// button24
			// 
			this.button24.Location = new System.Drawing.Point(168, 152);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(288, 48);
			this.button24.TabIndex = 1;
			this.button24.Text = "Проанализировать";
			this.button24.Click += new System.EventHandler(this.button24_Click);
			// 
			// groupBox21
			// 
			this.groupBox21.Controls.Add(this.groupBox23);
			this.groupBox21.Controls.Add(this.groupBox22);
			this.groupBox21.Controls.Add(this.groupBox24);
			this.groupBox21.Location = new System.Drawing.Point(8, 8);
			this.groupBox21.Name = "groupBox21";
			this.groupBox21.Size = new System.Drawing.Size(992, 136);
			this.groupBox21.TabIndex = 0;
			this.groupBox21.TabStop = false;
			this.groupBox21.Text = "Данные для анализа";
			// 
			// groupBox23
			// 
			this.groupBox23.Controls.Add(this.checkBox3);
			this.groupBox23.Controls.Add(this.checkBox4);
			this.groupBox23.Controls.Add(this.checkBox5);
			this.groupBox23.Controls.Add(this.checkBox6);
			this.groupBox23.Controls.Add(this.checkBox7);
			this.groupBox23.Location = new System.Drawing.Point(232, 16);
			this.groupBox23.Name = "groupBox23";
			this.groupBox23.Size = new System.Drawing.Size(496, 112);
			this.groupBox23.TabIndex = 1;
			this.groupBox23.TabStop = false;
			this.groupBox23.Text = "Перемещения точек";
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(16, 32);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(144, 24);
			this.checkBox3.TabIndex = 0;
			this.checkBox3.Text = "Плечо";
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(16, 72);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(144, 24);
			this.checkBox4.TabIndex = 0;
			this.checkBox4.Text = "Локоть";
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(176, 72);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(144, 24);
			this.checkBox5.TabIndex = 0;
			this.checkBox5.Text = "Колено";
			// 
			// checkBox6
			// 
			this.checkBox6.Location = new System.Drawing.Point(176, 32);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(144, 24);
			this.checkBox6.TabIndex = 0;
			this.checkBox6.Text = "Кисть";
			// 
			// checkBox7
			// 
			this.checkBox7.Location = new System.Drawing.Point(336, 48);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(144, 24);
			this.checkBox7.TabIndex = 0;
			this.checkBox7.Text = "Стопа";
			// 
			// groupBox22
			// 
			this.groupBox22.Controls.Add(this.checkBox2);
			this.groupBox22.Controls.Add(this.checkBox1);
			this.groupBox22.Location = new System.Drawing.Point(16, 16);
			this.groupBox22.Name = "groupBox22";
			this.groupBox22.Size = new System.Drawing.Size(176, 112);
			this.groupBox22.TabIndex = 0;
			this.groupBox22.TabStop = false;
			this.groupBox22.Text = "Углы";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(24, 72);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(120, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Коленный сустав";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(24, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(112, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Локтевой сустав";
			// 
			// groupBox24
			// 
			this.groupBox24.Controls.Add(this.checkBox8);
			this.groupBox24.Controls.Add(this.checkBox9);
			this.groupBox24.Location = new System.Drawing.Point(760, 16);
			this.groupBox24.Name = "groupBox24";
			this.groupBox24.Size = new System.Drawing.Size(176, 112);
			this.groupBox24.TabIndex = 0;
			this.groupBox24.TabStop = false;
			this.groupBox24.Text = "Сторона тела";
			// 
			// checkBox8
			// 
			this.checkBox8.Location = new System.Drawing.Point(24, 72);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(120, 24);
			this.checkBox8.TabIndex = 1;
			this.checkBox8.Text = "Правая";
			// 
			// checkBox9
			// 
			this.checkBox9.Checked = true;
			this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox9.Location = new System.Drawing.Point(24, 32);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(112, 24);
			this.checkBox9.TabIndex = 0;
			this.checkBox9.Text = "Левая";
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(728, 680);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(96, 16);
			this.label13.TabIndex = 2;
			this.label13.Text = "Правая сторона";
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(520, 680);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(88, 16);
			this.label14.TabIndex = 2;
			this.label14.Text = "Левая сторона";
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.Color.Red;
			this.label15.Location = new System.Drawing.Point(656, 675);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 16);
			this.label15.TabIndex = 2;
			this.label15.Text = "____________";
			this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label29);
			this.groupBox5.Controls.Add(this.label30);
			this.groupBox5.Controls.Add(this.label28);
			this.groupBox5.Controls.Add(this.label27);
			this.groupBox5.Location = new System.Drawing.Point(8, 16);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(400, 48);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Амплитуда углов";
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(296, 24);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(64, 16);
			this.label29.TabIndex = 3;
			this.label29.Text = "100 град.";
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(200, 24);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(96, 16);
			this.label30.TabIndex = 2;
			this.label30.Text = "Локтевой сустав:";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(112, 24);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 16);
			this.label28.TabIndex = 1;
			this.label28.Text = "100 град.";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(8, 24);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(104, 16);
			this.label27.TabIndex = 0;
			this.label27.Text = "Коленный сустав:";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label31);
			this.groupBox6.Controls.Add(this.label32);
			this.groupBox6.Controls.Add(this.label33);
			this.groupBox6.Controls.Add(this.label34);
			this.groupBox6.Location = new System.Drawing.Point(416, 16);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(416, 48);
			this.groupBox6.TabIndex = 1;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Амплитуда перемещений";
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(344, 24);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(48, 16);
			this.label31.TabIndex = 3;
			this.label31.Text = "100 см";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(216, 24);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(128, 16);
			this.label32.TabIndex = 2;
			this.label32.Text = "Голенстопный сустав:";
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(136, 24);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(48, 16);
			this.label33.TabIndex = 1;
			this.label33.Text = "100 см";
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(8, 24);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(128, 16);
			this.label34.TabIndex = 0;
			this.label34.Text = "Лучезапястный сустав:";
			// 
			// openFileDialog4
			// 
			this.openFileDialog4.Filter = "Базы данных *.mab|*.mab";
			// 
			// saveFileDialog2
			// 
			this.saveFileDialog2.FileName = "Unnamed.mab";
			this.saveFileDialog2.Filter = "Базы данных *.mab|*.mab";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1016, 701);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Анализ движения человека";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox20.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
			this.panel5.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage9.ResumeLayout(false);
			this.tabPage10.ResumeLayout(false);
			this.tabPage11.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.groupBox19.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox17.ResumeLayout(false);
			this.tabPage12.ResumeLayout(false);
			this.groupBox21.ResumeLayout(false);
			this.groupBox23.ResumeLayout(false);
			this.groupBox22.ResumeLayout(false);
			this.groupBox24.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		String[] PictNames;                         // Массив с названиями файлов исходных изображений
		String CubeFilename = "";                   // Файл с тестовым кубом
		PointF CubeSize = new PointF(0, 0);         // Размеры тестового куба (в миллиметрах)
		PointF[] CubePoints = new PointF[3];        // Отмеченные точки на тестовом кубе (в миллиметрах)
		int CubeStep;                               // Номер точки отмечаемой в данный момент на тестовом кубе
		PointF MetersPerPoint = new PointF(0, 0);   // Коэффициент "метров на точку"
		int CadrNum;                                // Номер текущего кадра
		int[] CadrStep;                             // Номер точки отмечаемой в данный момент на кадре
		PointF[,] CadrPoints;                       // Точки отмеченные на кадрах [номер кадра, номер точки]
		float[,] Oscilations;                       // Колебания точек в метрах относительно оси проходящей через центр тяжести
		
		string DatabaseName = "Unnamed.mab";        // имя базы данных по умолчанию
		ArrayList FileBase = new ArrayList();       // массив имен файлов
		ArrayList DescrBase = new ArrayList();      // массив описаний файлов
		ArrayList ScaleBase = new ArrayList();      // массив MetersPerPoint
		ArrayList CadrNumBase = new ArrayList();    // массив CadrNum
		ArrayList CadrPointsBase = new ArrayList(); // массив CadrPoints

		ArrayList CorrelationBase = new ArrayList();    // массив CadrNum
		// в 4-ом столбце массива показана динамика движения центра тяжести
		Point HelpPoint;

		private void Form1_Load(object sender, System.EventArgs e)
			// Событие при загрузке формы
		{
			// Инициализация объектов формы
			this.Text = "Анализ движения человека: Выбор источника входных данных";
			label129.Text = Path.GetFileName(DatabaseName);

			groupBox1.Enabled = true;
			groupBox2.Enabled = false;

			textBox1.Enabled = true;
			button1.Enabled = true;
			label2.Enabled = true;
			button2.Enabled = false;

			button5.Enabled = false;

			panel1.Visible = true;

			panel1.Location = new System.Drawing.Point(0,0); panel1.Size = new System.Drawing.Size(1015,700);
			panel2.Location = new System.Drawing.Point(0,0); panel2.Size = new System.Drawing.Size(1015,700);

			HelpPoint.X = -1;
		}

		public bool CheckPicture(string Filename)
			// Функция для проверки формата файла Filename
			// Если расширение соответствует картинке то возвращает True
		{
			bool check = false;
			string Ext = System.IO.Path.GetExtension(Filename);
			Ext = Ext.ToLower();
			if (Ext == ".gif") check = true;
			if (Ext == ".jpg") check = true;
			if (Ext == ".jpeg") check = true;
			if (Ext == ".bmp") check = true;
			if (Ext == ".png") check = true;
			return check;
		}

		float RoundTo2(float num)
			// Функция округления переменной float до 2-х знаков после запятой
		{
			num = num * 100;
			num = (float)Math.Floor(num);
			num = num / 100;
			return num;
		}

		float RoundTo4(float num)
			// Функция округления переменной float до 4-х знаков после запятой
		{
			num = num * 10000;
			num = (float)Math.Floor(num);
			num = num / 10000;
			return num;
		}

		public float PixToMetersX(float Pix)
			// Функция конвертирования размера в пикселях в реальный размер в метрах (по горизонтали)
		{
			return (Pix * MetersPerPoint.X);
		}

		float Angle_point (PointF a, PointF b, PointF c)
			// Функция для расчета угла между тремя точками
			// Возвращает угол в градусах
		{
			double x1 = a.X - b.X, x2 = c.X - b.X;
			double y1 = a.Y - b.Y, y2 = c.Y - b.Y;
			double d1 = Math.Sqrt (x1 * x1 + y1 * y1);
			double d2 = Math.Sqrt (x2 * x2 + y2 * y2);
			double angle = Math.Acos ((x1 * x2 + y1 * y2) / (d1 * d2));
			angle = angle * 180 / Math.PI;
			return (float)angle;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
			// Радио-кнопка "Папка с файлами"
		{
			groupBox1.Enabled = true;
			groupBox2.Enabled = false;
			button5.Enabled = false;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
			// Радио-кнопка "Файл с данными"
		{
			groupBox1.Enabled = false;
			groupBox2.Enabled = true;
			button5.Enabled = false;
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
			// Радио-кнопка "Выбрать файлы из каталога по маске"
		{
			textBox1.Enabled = true;
			button1.Enabled = true;
			label2.Enabled = true;
			button2.Enabled = false;
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			textBox1.Enabled = false;
			button1.Enabled = false;
			label2.Enabled = false;
			button2.Enabled = true;
		}

		private void button2_Click(object sender, System.EventArgs e)
			// Кнопка для выбора файлов с исходными изображениями
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
			PictNames = openFileDialog1.FileNames;
			// Проверка файлов
			bool chk = true;
			for (int i = 0; i < PictNames.Length; i++)
			{
				if (CheckPicture(PictNames[i]) == false) chk = false;
			}
			if (chk == false) { MessageBox.Show("Некоторые файлы которые Вы выбрали не являются изображениями!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); PictNames = null; button5.Enabled = false; return; }
			//Доступ к кнопке перехода к расстановке точек
			if (PictNames != null && CubeFilename != "") button5.Enabled = true;
		}

		private void button1_Click(object sender, System.EventArgs e)
			// Кнопка для выбора файлов из папки по маске
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel) return;
			// Выбор файлов соответствующих маске
			PictNames = Directory.GetFiles(folderBrowserDialog1.SelectedPath, textBox1.Text);
			System.Array.Sort(PictNames);
			// Проверка файлов
			bool chk = true;
			for (int i = 0; i < PictNames.Length; i++)
			{
				if (CheckPicture(PictNames[i]) == false) chk = false;
			}
			if (chk == false) { MessageBox.Show("Выберите папку с файлами в которой содержатся изображения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); PictNames = null; button5.Enabled = false; return; }
			//Доступ к кнопке перехода к расстановке точек
			if (PictNames != null && CubeFilename != "") button5.Enabled = true;
		}

		private void button4_Click(object sender, System.EventArgs e)
			// Кнопка для выбора файла с тестовым кубом
		{
			if (openFileDialog2.ShowDialog() == DialogResult.Cancel) return;
			CubeFilename = openFileDialog2.FileName;
			if (CheckPicture(CubeFilename) == false) { MessageBox.Show("Выберите файл с картинкой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); CubeFilename = ""; button5.Enabled = false; return; }
			pictureBox1.Image = Image.FromFile(CubeFilename);
			//Доступ к кнопке перехода к расстановке точек
			if (PictNames != null && CubeFilename != "") button5.Enabled = true;
		}


		private void button3_Click(object sender, System.EventArgs e)
			// Загрузки данных из файла
		{
			if (LoadFromFile() == false) { return; }
			button5.Enabled = true;
		}

		public bool LoadFromFile()
		// Загрузка данных из файла
		{
			int NumCadrs;
			if (openFileDialog3.ShowDialog() == DialogResult.Cancel) { return false; }
			if (File.Exists(openFileDialog3.FileName) == false) { MessageBox.Show("Файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); button5.Enabled = false; return false; }

				
			TextReader streamReader = new StreamReader(openFileDialog3.FileName);
			for (int i = 0; i < 20; i++) streamReader.ReadLine();
			// Считывание данных из файла
			// Коэффициент "метров на точку"
			MetersPerPoint.X = Convert.ToSingle(streamReader.ReadLine());
			MetersPerPoint.Y = Convert.ToSingle(streamReader.ReadLine());
                
			// Количество кадров
			NumCadrs = Convert.ToInt32(streamReader.ReadLine());
			CadrPoints = new PointF[NumCadrs, 17];
						          
			// Заполняем массив значениями "точка отсутствует"
			for (int j = 0; j < 17; j++)
			{
				for (int i = 0; i < NumCadrs; i++) { CadrPoints[i,j].X = -255; CadrPoints[i,j].Y = -255; };
			};

			// Точки отмеченные на кадрах [номер кадра, номер точки]
			for (int Cadr = 0; Cadr < (NumCadrs); Cadr++)
			{
				for (int i = 0; i < 17; i++)
				{
					CadrPoints[Cadr, i].X = Convert.ToSingle(streamReader.ReadLine());
					CadrPoints[Cadr, i].Y = Convert.ToSingle(streamReader.ReadLine());
				}
			}
			return true;
		}

		private void button5_Click(object sender, System.EventArgs e)
			// Кнопка перехода к измерению мерного куба
		{
			if (radioButton1.Checked == true) 
			{
				if (PictNames.Length < 1) { MessageBox.Show("Вы не выбрали не одного файла удовлетворяющего условиям программы (поддерживаются изображения в форматах JPEG, GIF, BMP, PNG)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); PictNames = null; button5.Enabled = false; return; }

				this.Text = "Анализ движения человека: Измерение мерного куба";
				CubeSize.X = (float)numericUpDown1.Value;
				CubeSize.Y = (float)numericUpDown2.Value;

				CubeStep = 0;
				label8.Text = "Нажмите на ЛЕВУЮ ВЕРХНЮЮ точку куба";

				panel1.Visible = false;
				panel2.Visible = true;
			}
			else
			{
				panel1.Visible = false;
				this.Text = "Анализ движения человека: Обработка данных и их сохранение";
				panel4.Location = new Point(0,0);
				panel4.Visible = true;
				numericUpDown3.Maximum = CadrPoints.Length / 17;
			
				// Подсчет количества заполненных кадров
				int LastCadr = 0;
				for (int Cadr = 0; Cadr < (CadrPoints.Length / 17); Cadr++)
				{
					for (int i = 0; i < 17; i++)
					{
						if (CadrPoints[Cadr, i].X != -255) LastCadr = Cadr;
					}
				}
				LastCadr++;

				if (LastCadr > 2) numericUpDown3.Value = LastCadr;
				label100.Text = (CadrPoints.Length / 17).ToString();
				label101.Text = LastCadr.ToString();;
				label103.Text = numericUpDown3.Minimum.ToString();;
			};
		}

		private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
			// Отмечание точек на кубе
		{
			if (CubeStep == 3) return;
			CubePoints[CubeStep].X = e.X;
			CubePoints[CubeStep].Y = e.Y;
			CubeStep++;
			pictureBox1.Refresh();
			if (CubeStep == 1) { label8.Text = "Нажмите на ЛЕВУЮ НИЖНЮЮ точку куба"; }
			if (CubeStep == 2) { label8.Text = "Нажмите на ПРАВУЮ НИЖНЮЮ точку куба"; }
			if (CubeStep == 3) 
			{             
				// Расстояние между двумя точками
				float HSize = (float)Math.Sqrt(Math.Pow((CubePoints[2].X - CubePoints[1].X),2.0) + Math.Pow((CubePoints[2].Y - CubePoints[1].Y),2.0));
				float VSize = (float)Math.Sqrt(Math.Pow((CubePoints[0].X - CubePoints[1].X), 2.0) + Math.Pow((CubePoints[0].Y - CubePoints[1].Y), 2.0));
				// Расчет количества точек на метр
				MetersPerPoint.X = (CubeSize.X / 1000) / HSize;
				MetersPerPoint.Y = (CubeSize.Y / 1000) / VSize;
                
				label8.Text = "Проверьте правильность ввода и нажмите на кнопку 'Далее'"; 
			}
		}

		private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
			// Отрисовка точек на кубе
		{
			if (CubePoints.Length == 0) return;
            
			float x,y;
			for (int i = 0; i < CubeStep; i++)
			{
				x = CubePoints[i].X;
				y = CubePoints[i].Y;
				e.Graphics.FillEllipse(Brushes.Red, x - 5, y - 5, 10, 10);
			}
			if (CubeStep >= 2) { e.Graphics.DrawLine(Pens.Red, CubePoints[0].X, CubePoints[0].Y, CubePoints[1].X, CubePoints[1].Y); }
			if (CubeStep == 3) { e.Graphics.DrawLine(Pens.Red, CubePoints[1].X, CubePoints[1].Y, CubePoints[2].X, CubePoints[2].Y); }
		}

		private void button6_Click(object sender, System.EventArgs e)
			// Кнопка "Сбросить точки с куба"
		{
			CubeStep = 0;
			label8.Text = "Нажмите на ЛЕВУЮ НИЖНЮЮ точку куба";
			pictureBox1.Refresh();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
			// Диалог закрытия программы
		{
			if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
			// Переход к расстановке точек
		{
			if (CubeStep < 3) {MessageBox.Show("Отметьте все точки на кубе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;}

			CadrPoints = new PointF[PictNames.Length,17];

			// Заполняем массив значениями "точка отсутствует"
			for (int j = 0; j < 17; j++)
			{
				for (int i = 0; i < CadrPoints.Length/17; i++) { CadrPoints[i,j].X = -255; CadrPoints[i,j].Y = -255; };
			};

			this.Text = "Анализ движения человека: Расстановка точек на кадрах";
			panel2.Visible = false;
			panel3.Visible = true; panel3.Location = new Point(0,0);
			pictureBox2.Image = Image.FromFile(PictNames[0]);
			CadrNum = 0;
			CadrStep = new int[PictNames.Length];
			for (int i = 0; i < PictNames.Length; i++) CadrStep[CadrNum] = 0;
			label9.Text = "Кадр: 1 из " + PictNames.Length;
			for (int i = 0; i < PictNames.Length; i++) { listBox1.Items.Add(Path.GetFileNameWithoutExtension(PictNames[i])); }
			listBox1.SetSelected(0, true);

			HelpPoint = new Point(103, 64); // Перенос точки на картинке-подсказке
			pictureBox3.Refresh();
		}

		private void pictureBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
			// Расстановка точек на кадрах
		{
			if (CadrStep[CadrNum] < 17)
			{
				CadrPoints[CadrNum, CadrStep[CadrNum]].X = e.X; // Сохранение точки в массиве
				CadrPoints[CadrNum, CadrStep[CadrNum]].Y = e.Y;
				ChangeHelp(CadrStep[CadrNum] + 2);
			}

			if (CadrStep[CadrNum] == 17)
			{
				if (CadrNum == (PictNames.Length - 1))
				{
					/*if (MessageBox.Show("Вы действительно хотите закончить ввод точек?", "Анализ движения человека", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						//groupBox3.Visible = false; ShowPanel(4);
						return;
					}*/
				}

				if (CadrNum != (PictNames.Length - 1))
				{
					CadrNum++;
					pictureBox2.Image = Image.FromFile(PictNames[CadrNum]);
					ChangeHelp(CadrStep[CadrNum] + 1);
					label9.Text = "Кадр: " + (CadrNum + 1) + " из " + PictNames.Length;
					listBox1.SetSelected(CadrNum, true);
					pictureBox2.Refresh();
					return;
				}
				else
				{
					CadrStep[CadrNum]--;
				}
			}

			CadrStep[CadrNum]++;
			pictureBox2.Refresh();
		}	
	
		void ChangeHelp(int Step)
			// Служебная функция изменяющая сообщение-подсказку и переносящая точку на каринке-подсказке
		{
			if (Step == 1)
			{
				HelpPoint = new Point(100, 74); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 1: Плечевой сустав левой руки"; // Смена сообщения с названием следующей точки
			}
			if (Step == 2)
			{
				HelpPoint = new Point(89, 122); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 2: Локтевой сустав левой руки"; // Смена сообщения с названием следующей точки
			}
			if (Step == 3)
			{
				HelpPoint = new Point(36, 172); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 3: Лучезапястный сустав левой руки"; // Смена сообщения с названием следующей точки
			}
			if (Step == 4)
			{
				HelpPoint = new Point(111, 172); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 4: Общий центр масс человека"; // Смена сообщения с названием следующей точки
			}
			if (Step == 5)
			{
				HelpPoint = new Point(113, 187); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 5: Тазобедренный сустав левой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 6)
			{
				HelpPoint = new Point(136, 262); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 6: Коленный сустав левой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 7)
			{
				HelpPoint = new Point(180, 338); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 7: Голеностопный сустав левой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 8)
			{
				HelpPoint = new Point(193, 342); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 8: Пятка левой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 9)
			{
				HelpPoint = new Point(149, 361); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 9: Носок левой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 10)
			{
				HelpPoint = new Point(100, 74); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 10: Плечевой сустав правой руки"; // Смена сообщения с названием следующей точки
			}
			if (Step == 11)
			{
				HelpPoint = new Point(89, 122); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 11: Локтевой сустав правой руки"; // Смена сообщения с названием следующей точки
			}
			if (Step == 12)
			{
				HelpPoint = new Point(36, 172); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 12: Лучезапястный сустав правой руки"; // Смена сообщения с названием следующей точки
			}
			if (Step == 13)
			{
				HelpPoint = new Point(106, 187); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 13: Тазобедренный сустав правой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 14)
			{
				HelpPoint = new Point(70, 265); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 14: Коленный сустав правой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 15)
			{
				HelpPoint = new Point(44, 336); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 15: Голеностопный сустав правой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 16)
			{
				HelpPoint = new Point(48, 349); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 16: Пятка правой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 17)
			{
				HelpPoint = new Point(9, 338); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Точка 17: Носок правой ноги"; // Смена сообщения с названием следующей точки
			}
			if (Step == 18)
			{
				HelpPoint = new Point(9, 338); // Перенос точки на картинке-подсказке
				pictureBox3.Refresh();
				label10.Text = "Кликните на изображении для перехода к следующему кадру"; // Смена сообщения с названием следующей точки
			}
		}

		private void pictureBox3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
			// Отрисовка точек на картинке-подсказке
		{
			if (HelpPoint.X == -1) return;
            
			float x,y;
			x = HelpPoint.X;
			y = HelpPoint.Y;
			e.Graphics.FillEllipse(Brushes.Red, x - 5, y - 5, 10, 10);	
		}

		private void button8_Click(object sender, System.EventArgs e)
			// Кнопка возврата к предыдущему кадру
		{
			if (CadrNum > 0) 
			{ 
				CadrNum--;

				pictureBox2.Image = Image.FromFile(PictNames[CadrNum]);
				ChangeHelp(CadrStep[CadrNum] + 1);
				label9.Text = "Кадр: " + (CadrNum + 1) + " из " + PictNames.Length;
				listBox1.SetSelected(CadrNum, true);
				pictureBox2.Refresh();
			}
		}

		private void button9_Click(object sender, System.EventArgs e)
			// Кнопка перехода к следующему кадру
		{
			if (CadrNum < (PictNames.Length - 1))
			{
				CadrNum++;

				pictureBox2.Image = Image.FromFile(PictNames[CadrNum]);
				ChangeHelp(CadrStep[CadrNum] + 1);
				label9.Text = "Кадр: " + (CadrNum + 1) + " из " + PictNames.Length;
				listBox1.SetSelected(CadrNum, true);
				pictureBox2.Refresh();
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			CadrNum = listBox1.SelectedIndex;

			pictureBox2.Image = Image.FromFile(PictNames[CadrNum]);
			ChangeHelp(CadrStep[CadrNum] + 1);
			label9.Text = "Кадр: " + (CadrNum + 1) + " из " + PictNames.Length;
			pictureBox2.Refresh();
		}

		private void button11_Click(object sender, System.EventArgs e)
			// Кнопка для сброса отмеченных точек
		{
			CadrStep[CadrNum] = 0;
			ChangeHelp(CadrStep[CadrNum] + 1);
			pictureBox2.Refresh();

			for (int i = 0; i < 17; i++)
			{
				CadrPoints[CadrNum, i].X = -255;
				CadrPoints[CadrNum, i].Y = -255;
			}
		}

		private void button10_Click(object sender, System.EventArgs e)
			// Кнопка для отмены точки
		{
			if (CadrStep[CadrNum] == 0) return;

			CadrStep[CadrNum]--;
			ChangeHelp(CadrStep[CadrNum] + 1);
			pictureBox2.Refresh();

			CadrPoints[CadrNum, CadrStep[CadrNum]].X = -255;
			CadrPoints[CadrNum, CadrStep[CadrNum]].Y = -255;
		}

		private void button16_Click(object sender, System.EventArgs e)
			// Кнопка для пропуска точки
		{
			if (CadrStep[CadrNum] == 17) 
			{
				if (CadrNum < (PictNames.Length - 1))
				{
					CadrNum++;

					pictureBox2.Image = Image.FromFile(PictNames[CadrNum]);
					ChangeHelp(CadrStep[CadrNum] + 1);
					label9.Text = "Кадр: " + (CadrNum + 1) + " из " + PictNames.Length;
					listBox1.SetSelected(CadrNum, true);
					pictureBox2.Refresh();
				}
			}
			else
			{
				CadrStep[CadrNum]++;
				ChangeHelp(CadrStep[CadrNum] + 1);
				pictureBox2.Refresh();
			}
		}

		private void button13_Click(object sender, System.EventArgs e)
			// Кнопка для сброса ВСЕХ отмеченных точек
		{
			if (DialogResult.Cancel == MessageBox.Show("Вы действительно хотите удалить все точки со всех кадров? Данное действие не может быть отменено.", "Внимание", MessageBoxButtons.OKCancel)) return;
			ChangeHelp(1);
			for (int Erase = 0; Erase < PictNames.Length; Erase++)
			{
				CadrStep[Erase] = 0;
				for (int i = 0; i < 17; i++)
				{
					CadrPoints[Erase, i].X = -255;
					CadrPoints[Erase, i].Y = -255;
				}
			}
			pictureBox2.Refresh();
		}
		
		private void pictureBox2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
			// Отрисовка точек на кадре
		{
			if (CadrPoints.Length == 0) return;

			float x, y;
			for (int i = 0; i < CadrStep[CadrNum]; i++)
			{
				x = CadrPoints[CadrNum, i].X;
				y = CadrPoints[CadrNum, i].Y;
				if (i < 9)
				{
					e.Graphics.FillEllipse(Brushes.Red, x - 5, y - 5, 10, 10);
				}
				else
				{
					e.Graphics.FillEllipse(Brushes.Yellow, x - 5, y - 5, 10, 10);
				};
			}
			if (!((CadrPoints[CadrNum, 0].X == -255 && CadrPoints[CadrNum, 0].X == -255) || (CadrPoints[CadrNum, 1].X == -255 && CadrPoints[CadrNum, 1].X == -255)))
			{
				if (CadrStep[CadrNum] >= 2) { e.Graphics.DrawLine(Pens.Red, CadrPoints[CadrNum, 0].X, CadrPoints[CadrNum, 0].Y, CadrPoints[CadrNum, 1].X, CadrPoints[CadrNum, 1].Y); }
			}
			if (!((CadrPoints[CadrNum, 1].X == -255 && CadrPoints[CadrNum, 1].X == -255) || (CadrPoints[CadrNum, 2].X == -255 && CadrPoints[CadrNum, 2].X == -255)))
			{
				if (CadrStep[CadrNum] >= 3) { e.Graphics.DrawLine(Pens.Red, CadrPoints[CadrNum, 1].X, CadrPoints[CadrNum, 1].Y, CadrPoints[CadrNum, 2].X, CadrPoints[CadrNum, 2].Y); }
			}
			if (!((CadrPoints[CadrNum, 4].X == -255 && CadrPoints[CadrNum, 4].X == -255) || (CadrPoints[CadrNum, 5].X == -255 && CadrPoints[CadrNum, 5].X == -255)))
			{
				if (CadrStep[CadrNum] >= 6) { e.Graphics.DrawLine(Pens.Red, CadrPoints[CadrNum, 4].X, CadrPoints[CadrNum, 4].Y, CadrPoints[CadrNum, 5].X, CadrPoints[CadrNum, 5].Y); }
			}            
			if (!((CadrPoints[CadrNum, 5].X == -255 && CadrPoints[CadrNum, 5].X == -255) || (CadrPoints[CadrNum, 6].X == -255 && CadrPoints[CadrNum, 6].X == -255)))
			{
				if (CadrStep[CadrNum] >= 7) { e.Graphics.DrawLine(Pens.Red, CadrPoints[CadrNum, 5].X, CadrPoints[CadrNum, 5].Y, CadrPoints[CadrNum, 6].X, CadrPoints[CadrNum, 6].Y); }
			}            
			if (!((CadrPoints[CadrNum, 7].X == -255 && CadrPoints[CadrNum, 7].X == -255) || (CadrPoints[CadrNum, 8].X == -255 && CadrPoints[CadrNum, 8].X == -255)))
			{
				if (CadrStep[CadrNum] >= 9) { e.Graphics.DrawLine(Pens.Red, CadrPoints[CadrNum, 7].X, CadrPoints[CadrNum, 7].Y, CadrPoints[CadrNum, 8].X, CadrPoints[CadrNum, 8].Y); }
			}

			if (!((CadrPoints[CadrNum, 9].X == -255 && CadrPoints[CadrNum, 9].X == -255) || (CadrPoints[CadrNum, 10].X == -255 && CadrPoints[CadrNum, 10].X == -255)))
			{
				if (CadrStep[CadrNum] >= 11) { e.Graphics.DrawLine(Pens.Yellow, CadrPoints[CadrNum, 9].X, CadrPoints[CadrNum, 9].Y, CadrPoints[CadrNum, 10].X, CadrPoints[CadrNum, 10].Y); }
			}
			if (!((CadrPoints[CadrNum, 10].X == -255 && CadrPoints[CadrNum, 10].X == -255) || (CadrPoints[CadrNum, 11].X == -255 && CadrPoints[CadrNum, 11].X == -255)))
			{
				if (CadrStep[CadrNum] >= 12) { e.Graphics.DrawLine(Pens.Yellow, CadrPoints[CadrNum, 10].X, CadrPoints[CadrNum, 10].Y, CadrPoints[CadrNum, 11].X, CadrPoints[CadrNum, 11].Y); }
			}
			if (!((CadrPoints[CadrNum, 12].X == -255 && CadrPoints[CadrNum, 12].X == -255) || (CadrPoints[CadrNum, 13].X == -255 && CadrPoints[CadrNum, 13].X == -255)))
			{
				if (CadrStep[CadrNum] >= 14) { e.Graphics.DrawLine(Pens.Yellow, CadrPoints[CadrNum, 12].X, CadrPoints[CadrNum, 12].Y, CadrPoints[CadrNum, 13].X, CadrPoints[CadrNum, 13].Y); }
			}
			if (!((CadrPoints[CadrNum, 13].X == -255 && CadrPoints[CadrNum, 13].X == -255) || (CadrPoints[CadrNum, 14].X == -255 && CadrPoints[CadrNum, 14].X == -255)))
			{
				if (CadrStep[CadrNum] >= 15) { e.Graphics.DrawLine(Pens.Yellow, CadrPoints[CadrNum, 13].X, CadrPoints[CadrNum, 13].Y, CadrPoints[CadrNum, 14].X, CadrPoints[CadrNum, 14].Y); }
			}
			if (!((CadrPoints[CadrNum, 15].X == -255 && CadrPoints[CadrNum, 15].X == -255) || (CadrPoints[CadrNum, 16].X == -255 && CadrPoints[CadrNum, 16].X == -255)))
			{
				if (CadrStep[CadrNum] >= 17) { e.Graphics.DrawLine(Pens.Yellow, CadrPoints[CadrNum, 15].X, CadrPoints[CadrNum, 15].Y, CadrPoints[CadrNum, 16].X, CadrPoints[CadrNum, 16].Y); }
			}
		}

		private void button12_Click(object sender, System.EventArgs e)
			// Кнопка перехода к этапу сохранения и обработки данных
		{
			if (DialogResult.Cancel == MessageBox.Show("Вы действительно хотите закончить ввод точек? Данное действие не может быть отменено.", "Внимание", MessageBoxButtons.OKCancel)) return;
			panel3.Visible = false;
			this.Text = "Анализ движения человека: Обработка данных и их сохранение";
			panel4.Location = new Point(0,0);
			panel4.Visible = true;
			numericUpDown3.Maximum = CadrPoints.Length / 17;
			
			// Подсчет количества заполненных кадров
			int LastCadr = 0;
			for (int Cadr = 0; Cadr < (CadrPoints.Length / 17); Cadr++)
			{
				for (int i = 0; i < 17; i++)
				{
					if (CadrPoints[Cadr, i].X != -255) LastCadr = Cadr;
				}
			}
			LastCadr++;

			if (LastCadr > 2) numericUpDown3.Value = LastCadr;
			label100.Text = (CadrPoints.Length / 17).ToString();
			label101.Text = LastCadr.ToString();;
			label103.Text = numericUpDown3.Minimum.ToString();;
		}

		private void button14_Click(object sender, System.EventArgs e)
			// Кнопка сохранения данных в файл
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) { return; }
			if (File.Exists(saveFileDialog1.FileName)) { File.Delete(saveFileDialog1.FileName); }
			
			TextWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
			
			// Запись данных в файл
			// Заголовок файла
			streamWriter.WriteLine("// Синтаксис файла координат:");
			streamWriter.WriteLine("// 1-ая строка: Масштабный коэффициент 'метров на точку' по оси X");
			streamWriter.WriteLine("// 2-ая строка: Масштабный коэффициент 'метров на точку' по оси Y");
			streamWriter.WriteLine("// 3-ая строка: Количество кадров");
			streamWriter.WriteLine("// 4-ая и 5-ая строки - X и Y координаты точки плечевого сустава");
			streamWriter.WriteLine("// 6-ая и 7-ая строки - X и Y координаты точки локтевого сустава");
			streamWriter.WriteLine("// 8-ая и 9-ая строки - X и Y координаты точки кистевого сустава");
			streamWriter.WriteLine("// 10-ая и 11-ая строки - X и Y координаты точки центра тяжести");
			streamWriter.WriteLine("// 12-ая и 13-ая строки - X и Y координаты точки коленного сустава");
			streamWriter.WriteLine("// 14-ая и 15-ая строки - X и Y координаты точки голеностопного сустава");
			streamWriter.WriteLine("// 16-ая и 17-ая строки - X и Y координаты точки левой пятки");
			streamWriter.WriteLine("// 18-ая и 19-ая строки - X и Y координаты точки левого носка");
			streamWriter.WriteLine("// 20-ая и 21-ая строки - X и Y координаты точки правого плечевого сустава ");
			streamWriter.WriteLine("// 22-ая и 23-ая строки - X и Y координаты точки правого локтевого сустава");
			streamWriter.WriteLine("// 24-ая и 25-ая строки - X и Y координаты точки правого кистевого сустава");
			streamWriter.WriteLine("// 26-ая и 27-ая строки - X и Y координаты точки правого коленного сустава");
			streamWriter.WriteLine("// 28-ая и 29-ая строки - X и Y координаты точки правого голеностопного сустава");
			streamWriter.WriteLine("// 30-ая и 31-ая строки - X и Y координаты точки правой пятки");
			streamWriter.WriteLine("// 32-ая и 33-ая строки - X и Y координаты точки правого носка");
			streamWriter.WriteLine("// далее строки 4 - 15 повторяются для каждого кадра");

			// Коэффициент "метров на точку"
			streamWriter.WriteLine(MetersPerPoint.X);
			streamWriter.WriteLine(MetersPerPoint.Y);

			// Количество кадров
			streamWriter.WriteLine(CadrPoints.Length / 17);

			// Точки отмеченные на кадрах [номер кадра, номер точки]
			for (int Cadr = 0; Cadr < (CadrPoints.Length / 17); Cadr++)
			{
				for (int i = 0; i < 17; i++)
				{
					streamWriter.WriteLine(CadrPoints[Cadr, i].X);
					streamWriter.WriteLine(CadrPoints[Cadr, i].Y);
				}
			}
			
			streamWriter.Close();
		}

		private void button15_Click(object sender, System.EventArgs e)
			// Кнопка перехода к результатам
		{
			panel4.Visible = false;
			this.Text = "Анализ движения человека: Результаты обработки данных";
			panel5.Location = new Point(0,0);
			panel5.Visible = true;

			////////////////////------------------------------------------------////////////////////
			////////////////////------------------ ГРАФИКИ ---------------------////////////////////
			////////////////////------------------------------------------------////////////////////
			
			Oscilations = new float[(int)numericUpDown3.Value, 23];
			
			// Расчет колебаний точек и динамики движения центра тяжести            
			for (int j = 0; j < 17; j++)
			{
				for (int i = 0; i < numericUpDown3.Value; i++)
				{
					if (j != 3)
					{
						if (CadrPoints[i, j].X != -255)
						{
							Oscilations[i, j] = -1 * PixToMetersX(CadrPoints[i, j].X - CadrPoints[i, 3].X);
						}
						else Oscilations[i, j] = -255;
					}
					else
					{
						//Динамика движения по оси X
						Oscilations[i, 3] = PixToMetersX(CadrPoints[0, 3].X - CadrPoints[i, 3].X);
					}
					//Динамика движения по оси Y
					Oscilations[i, 17] = PixToMetersX(CadrPoints[i, 3].Y) - PixToMetersX(CadrPoints[0, 3].Y);
				}
			}
			
			// График мгновенных скоростей
			for (int i = 0; i < numericUpDown3.Value - 2; i++)
			{ 
				Oscilations[i+1, 18] = (Oscilations[i+2, 3] - Oscilations[i, 3]) / (2.0f/25.0f);
			}
			Oscilations[0, 18] = -255;
			Oscilations[(int)numericUpDown3.Value - 1, 18] = -255;

			// Расчет углов
			for (int i = 0; i < numericUpDown3.Value; i++)
			{
				Oscilations[i, 19] = -255;
				Oscilations[i, 20] = -255;
				Oscilations[i, 21] = -255;
				Oscilations[i, 22] = -255;
			}

			for (int i = 0; i < numericUpDown3.Value; i++)
			{
				//Левая рука
				if (!(CadrPoints[i, 0].X == -255 || CadrPoints[i, 1].X == -255 || CadrPoints[i, 2].X == -255))
				{
					Oscilations[i, 19] = Angle_point(CadrPoints[i, 0],CadrPoints[i, 1],CadrPoints[i, 2]);
				}
				
				//Левая нога
				if (!(CadrPoints[i, 4].X == -255 || CadrPoints[i, 5].X == -255 || CadrPoints[i, 6].X == -255))
				{
					Oscilations[i, 20] = Angle_point(CadrPoints[i, 4],CadrPoints[i, 5],CadrPoints[i, 6]);
				}

				//Правая рука
				if (!(CadrPoints[i, 9].X == -255 || CadrPoints[i, 10].X == -255 || CadrPoints[i, 11].X == -255))
				{
					Oscilations[i, 21] = Angle_point(CadrPoints[i, 9],CadrPoints[i, 10],CadrPoints[i, 11]);
				}

				//Правая нога
				if (!(CadrPoints[i, 12].X == -255 || CadrPoints[i, 13].X == -255 || CadrPoints[i, 14].X == -255))
				{
					Oscilations[i, 22] = Angle_point(CadrPoints[i, 12],CadrPoints[i, 13],CadrPoints[i, 14]);
				}
			}

			////////////////////------------------------------------------------////////////////////
			////////////////////----------- СТАТИСТИЧЕСКИЕ ДАННЫЕ --------------////////////////////
			////////////////////------------------------------------------------////////////////////
			
			// Результаты
			float[] Min = new float[23];         // Минимумы
			float[] Max = new float[23];         // Максимумы
			float[] Middle = new float[23];      // Средние значения
			float[] Disp = new float[23];        // Дисперсии
			float Speed;                         // Средняя скорость движения

			int NumCadrs = (int)numericUpDown3.Value;
			int NumFull = 0; // Количество заполненных кадров
	
			for (int j = 0; j < 7; j++)
			{
				Min[j] = 999999f;
				Max[j] = -999999f;
				Middle[j] = 0;
				Disp[j] = 0;

                
				if (!(j == 3 || j == 4))
				{
					// Расчет минимумов, максимумов и средних значений
					NumFull = 0;
					for (int i = 0; i < NumCadrs; i++)
					{
						if (Oscilations[i, j] != -255)
						{
							if (Oscilations[i, j] < Min[j]) Min[j] = Oscilations[i, j];
							if (Oscilations[i, j] > Max[j]) Max[j] = Oscilations[i, j];
							Middle[j] = Middle[j] + Oscilations[i, j];
							NumFull++;
						}
					}
					Middle[j] = Middle[j] / NumFull;

					// Расчет дисперсии
					NumFull = 0;
					for (int i = 0; i < NumCadrs; i++)
					{
						if (Oscilations[i, j] != -255)
						{
							Disp[j] = Disp[j] + (float)Math.Pow(Oscilations[i, j] - Middle[j], 2.0);
							NumFull++;
						}
					}
					Disp[j] = Disp[j] / (NumFull - 1);

					// Перевод в сантиметры
					Min[j] = Min[j] * 100;
					Max[j] = Max[j] * 100;
					Middle[j] = Middle[j] * 100;
					Disp[j] = Disp[j] * 100;

					// Округление
					Min[j] = (int)Min[j];
					Max[j] = (int)Max[j];
					Middle[j] = (int)Middle[j];
					Disp[j] = RoundTo2(Disp[j]);
				}
			}
			
			for (int j = 17; j <= 22; j++)
			{
				Min[j] = 999999f;
				Max[j] = -999999f;
				Middle[j] = 0;
				Disp[j] = 0;

				// Расчет минимумов, максимумов и средних значений
				NumFull = 0;
				for (int i = 0; i < NumCadrs; i++)
				{
					if (Oscilations[i, j] != -255)
					{
						if (Oscilations[i, j] < Min[j]) Min[j] = Oscilations[i, j];
						if (Oscilations[i, j] > Max[j]) Max[j] = Oscilations[i, j];
						Middle[j] = Middle[j] + Oscilations[i, j];
						NumFull++;
					}
				}
				Middle[j] = Middle[j] / NumFull;

				// Расчет дисперсии
				NumFull = 0;
				for (int i = 0; i < NumCadrs-1; i++)
				{
					if (Oscilations[i, j] != -255)
					{
						Disp[j] = Disp[j] + (float)Math.Pow(Oscilations[i, j] - Middle[j], 2.0);
						NumFull++;
					}
				}
				Disp[j] = Disp[j] / (NumFull - 1);
					
				if (j == 17) 
				{
					// Перевод в сантиметры
					Min[j] = Min[j] * 100;
					Max[j] = Max[j] * 100;
					Middle[j] = Middle[j] * 100;
					Disp[j] = Disp[j] * 100;
				}

				if (j!=18)
				{
					// Округление до двух знаков после запятой
					Min[j] = (int)Min[j];
					Max[j] = (int)Max[j];
					Middle[j] = (int)Middle[j];
					Disp[j] = (int)Disp[j];
				}
				else
				{
					// Округление до двух знаков после запятой
					Min[j] = RoundTo4(Min[j]);
					Max[j] = RoundTo4(Max[j]);
					Middle[j] = RoundTo4(Middle[j]);
					Disp[j] = RoundTo4(Disp[j]);
				}
			}
			

			// Заполнение элементов формы результатами
			label43.Text = Min[0].ToString() + " см";
			label45.Text = Middle[0].ToString() + " см";
			label47.Text = Max[0].ToString() + " см";
			label49.Text = Disp[0].ToString() + " см";

			label53.Text = Min[1].ToString() + " см";
			label51.Text = Middle[1].ToString() + " см";
			label55.Text = Max[1].ToString() + " см";
			label57.Text = Disp[1].ToString() + " см";

			label61.Text = Min[2].ToString() + " см";
			label59.Text = Middle[2].ToString() + " см";
			label63.Text = Max[2].ToString() + " см";
			label65.Text = Disp[2].ToString() + " см";

			label69.Text = Min[5].ToString() + " см";
			label67.Text = Middle[5].ToString() + " см";
			label71.Text = Max[5].ToString() + " см";
			label73.Text = Disp[5].ToString() + " см";

			label77.Text = Min[6].ToString() + " см";
			label75.Text = Middle[6].ToString() + " см";
			label79.Text = Max[6].ToString() + " см";
			label81.Text = Disp[6].ToString() + " см";

			label85.Text = Min[17].ToString() + " см";
			label83.Text = Middle[17].ToString() + " см";
			label87.Text = Max[17].ToString() + " см";
			label89.Text = Disp[17].ToString() + " см";

			label106.Text = Min[19].ToString();
			label104.Text = Middle[19].ToString();
			label108.Text = Max[19].ToString();
			label110.Text = Disp[19].ToString();

			label114.Text = Min[20].ToString();
			label112.Text = Middle[20].ToString();
			label116.Text = Max[20].ToString();
			label118.Text = Disp[20].ToString();

			label37.Text = Min[18].ToString() + " м/с";
			label35.Text = Middle[18].ToString() + " м/с";
			label39.Text = Max[18].ToString() + " м/с";
			label41.Text = Disp[18].ToString() + " м/с";

			float StepLenL = 0, StepLenR = 0;
			float MinSL = 9999, MaxSL = -9999, MinSR = 9999, MaxSR = -9999; 
			
			// Определение длины шага левой ноги
			for (int i = 0; i < NumCadrs/2; i++)
			{
				if ( Oscilations[i, 7] != -255)
				{
					if (MinSL > Oscilations[i, 7]) { MinSL = Oscilations[i, 7]; }
					if (MaxSL < Oscilations[i, 7]) { MaxSL = Oscilations[i, 7]; }
				}
			}
			StepLenL = MaxSL - MinSL;
			StepLenL *= 100;
			label91.Text = ((int)StepLenL).ToString() + " см";

			// Определение длины шага правой ноги
			for (int i = 0; i < NumCadrs/2; i++)
			{
				if ( Oscilations[i, 15] != -255)
				{
					if (MinSR > Oscilations[i, 15]) { MinSR = Oscilations[i, 15]; }
					if (MaxSR < Oscilations[i, 15]) { MaxSR = Oscilations[i, 15]; }
				}
			}
			StepLenR = MaxSR - MinSR;
			StepLenR *= 100;
			label123.Text = ((int)StepLenR).ToString() + " см";

			// Скорость ходьбы
			Speed = (Oscilations[NumCadrs - 1, 3] - Oscilations[0, 3]) / ((float)NumCadrs / 25.0f);
			label94.Text = RoundTo2(Speed).ToString() + " м/с";
			label97.Text = RoundTo2(Speed * 3.6f).ToString() + " км/ч";

			float FloorLevelL = 0;
			float FloorLevelR = 0;
			// -------- Клиренс -------- //
			// Уровень пола (определяется по наименьшей высоте пяток)
			for (int i = 0; i < NumCadrs; i++)
			{
				if (CadrPoints[i, 7].X != -255)
				{
					if (CadrPoints[i, 7].Y > FloorLevelL) FloorLevelL = CadrPoints[i, 7].Y;
				}
				if (CadrPoints[i, 15].X != -255)
				{
					if (CadrPoints[i, 15].Y > FloorLevelR) FloorLevelR = CadrPoints[i, 15].Y;
				}
			}
			
			float ClearanceL = FloorLevelL; // Клиренс левой ноги
			float ClearanceR = FloorLevelR; // Клиренс правой ноги
			// Поиск параллельного положения стопы
			float MinClearance = 3; // Минимальный клиренс
			float Dopusk = 0;              
			float MaxDopusk = 5; // Максимальное отклонение стопы от горизонтального положения
			
			// Клиренс левой ноги
			do
			{
				for (int i = 0; i < NumCadrs; i++)
				{
					if (!(CadrPoints[i, 8].Y == -255 && CadrPoints[i, 7].Y == -255))
					{
						if (CadrPoints[i, 8].Y == CadrPoints[i, 7].Y + Dopusk || CadrPoints[i, 8].Y == CadrPoints[i, 7].Y - Dopusk)
						{
							if (CadrPoints[i, 8].Y < ClearanceL) ClearanceL = CadrPoints[i, 8].Y; 
						}
					}
				}
				Dopusk++;
			} while ( ClearanceL < (FloorLevelL - MinClearance) && Dopusk > MaxDopusk);
			ClearanceL = FloorLevelL - ClearanceL;
			ClearanceL = PixToMetersX(ClearanceL);

			label120.Text = RoundTo2(ClearanceL * 100).ToString() + " см";

			// Клиренс правой ноги
			MinClearance = 3; // Минимальный клиренс
			Dopusk = 0;              
			MaxDopusk = 5; // Максимальное отклонение стопы от горизонтального положения
			do
			{
				for (int i = 0; i < NumCadrs; i++)
				{
					if (!(CadrPoints[i, 8].Y == -255 && CadrPoints[i, 7].Y == -255))
					{
						if (CadrPoints[i, 8].Y == CadrPoints[i, 7].Y + Dopusk || CadrPoints[i, 8].Y == CadrPoints[i, 7].Y - Dopusk)
						{
							if (CadrPoints[i, 8].Y < ClearanceR) ClearanceR = CadrPoints[i, 8].Y; 
						}
					}
				}
				Dopusk++;
			} while ( ClearanceR < (FloorLevelR - MinClearance) && Dopusk > MaxDopusk);
			ClearanceR = FloorLevelR - ClearanceR;
			ClearanceR = PixToMetersX(ClearanceR);

			label121.Text = RoundTo2(ClearanceR * 100).ToString() + " см";
			// ------------------------- //
		}
		
		private void button17_Click(object sender, System.EventArgs e)
		// Кнопка перехода обратно к обработке данных
		{
			panel5.Visible = false;
			this.Text = "Анализ движения человека: Обработка данных и их сохранение";
			panel4.Location = new Point(0,0);
			panel4.Visible = true;
		}
		public void DrawGraphOsc(PaintEventArgs e, int GraphNum, int SizeX, int SizeY)
		// Функция для рисования графиков из массива Oscilations
		// e - Аргумент события Paint
		// SizeX, SizeY - размеры области для вывода графика
		// GraphNum - номер рисуемого графика
		{
			if (Oscilations.Length == 0) return;

			int MaxWay = (int)Math.Ceiling(Oscilations[(int)numericUpDown3.Value - 1, 3]);
			Font drawFont = new Font("Arial", 8);
			float ZoomX, ZoomY;
			bool ExistDot = true; // Флаг для пропускания несуществующих точек
			string Metrika = " м";
			float MinAngle = 999999;
			float MaxAngle = 0;
			ZoomX = SizeX / (float)numericUpDown3.Value;
			ZoomY = SizeY / (float)(60 * 2);

			//Отрисовка координатной сетки
			for (int i = 0; i <= SizeY; i = i + (SizeY / 12))
			{
				e.Graphics.DrawLine(Pens.Gray, 0, i, SizeX, i);
			}
			//e.Graphics.DrawLine(Pens.Black, 0, SizeY / 2, SizeX, SizeY / 2);
			for (int i = 0; i <= SizeX; i = i + (SizeX / 6))
			{
				e.Graphics.DrawLine(Pens.Gray, i, 0, i, SizeY);
			}
			//Градуировка шкалы
			e.Graphics.DrawString((int)(numericUpDown3.Value/6) + "", drawFont, Brushes.Black, SizeX / 6, SizeY / 2);
			e.Graphics.DrawString((int)(numericUpDown3.Value/3) + "", drawFont, Brushes.Black, SizeX / 3, SizeY / 2);
			e.Graphics.DrawString((int)(numericUpDown3.Value/2) + "", drawFont, Brushes.Black, SizeX / 2, SizeY / 2);
			e.Graphics.DrawString((int)(2*numericUpDown3.Value/3) + "", drawFont, Brushes.Black, 2 * SizeX / 3, SizeY / 2);
			e.Graphics.DrawString((int)(5*numericUpDown3.Value/6) + "", drawFont, Brushes.Black, 5 * SizeX / 6, SizeY / 2);
			e.Graphics.DrawString("кадры", drawFont, Brushes.Black, SizeX - 35, SizeY / 2);
            
			//Отрисовка графика
			PointF[] dots = new PointF[(int)numericUpDown3.Value];
			PointF Pt1 = new PointF(0,0); PointF Pt2 = new PointF(0,0);
			if (!(GraphNum == 3 || GraphNum > 17))
			{
				// Левая сторона
				for (int i = 0; i < numericUpDown3.Value; i++)
				{
					ExistDot = true;
					if (Oscilations[i, GraphNum] == -255) ExistDot = false;
					
					Pt1.X = i * ZoomX;
					Pt1.Y = SizeY - ((Oscilations[i, GraphNum] * 100) + 60) * ZoomY;
					if (i < ((int)numericUpDown3.Value - 1))
					{
						if (Oscilations[(i+1), GraphNum] == -255) ExistDot = false;
						Pt2.X = (i+1) * ZoomX;
						Pt2.Y = SizeY - ((Oscilations[(i+1), GraphNum] * 100) + 60) * ZoomY;
					}
					if (ExistDot == true) e.Graphics.DrawLine(Pens.Blue,Pt1,Pt2);
				}

				// Правая сторона
				int RightGraphNum;
				if (GraphNum < 3)
				{
					RightGraphNum = GraphNum + 9;
				} else RightGraphNum = GraphNum + 8;
				
				if (GraphNum < 17)
				{
					for (int i = 0; i < numericUpDown3.Value; i++)
					{
						ExistDot = true;
						if (Oscilations[i, RightGraphNum] == -255) ExistDot = false;
					
						Pt1.X = i * ZoomX;
						Pt1.Y = SizeY - ((Oscilations[i, RightGraphNum] * 100) + 60) * ZoomY;
						if (i < ((int)numericUpDown3.Value - 1))
						{
							if (Oscilations[(i+1), RightGraphNum] == -255) ExistDot = false;
							Pt2.X = (i+1) * ZoomX;
							Pt2.Y = SizeY - ((Oscilations[(i+1), RightGraphNum] * 100) + 60) * ZoomY;
						}
						if (ExistDot == true) e.Graphics.DrawLine(Pens.Red,Pt1,Pt2);	
					}
				}

				//Градуировка шкалы
				e.Graphics.DrawString("-40 см", drawFont, Brushes.Black, 0, 5 * SizeY / 6);
				e.Graphics.DrawString("-20 см", drawFont, Brushes.Black, 0, 2 * SizeY / 3);
				e.Graphics.DrawString("0", drawFont, Brushes.Black, 0, SizeY / 2);
				e.Graphics.DrawString("20 см", drawFont, Brushes.Black, 0, SizeY / 3);
				e.Graphics.DrawString("40 см", drawFont, Brushes.Black, 0, SizeY / 6);
			}
			else
			{
				if ( GraphNum == 3 ) Metrika = " м";
				if ( GraphNum == 18 ) Metrika = " м/c";
				if ( GraphNum > 18 ) Metrika = " град.";

				if ( GraphNum <= 18 )
				{
					for (int i = 0; i < numericUpDown3.Value; i++)
					{
						ExistDot = true;
						if (Oscilations[i, GraphNum] == -255) ExistDot = false;
					
						Pt1.X = i * ZoomX;
						Pt1.Y = SizeY - (Oscilations[i, GraphNum] * 100) * (SizeY / 400f);
						if (i < ((int)numericUpDown3.Value - 1))
						{
							if (Oscilations[(i+1), GraphNum] == -255) ExistDot = false;
							Pt2.X = (i+1) * ZoomX;
							Pt2.Y = SizeY - (Oscilations[i+1, GraphNum] * 100) * (SizeY / 400f);
						}
						if (ExistDot == true) e.Graphics.DrawLine(Pens.Blue,Pt1,Pt2);
					}
				
					//Градуировка шкалы
					e.Graphics.DrawString("0" + Metrika, drawFont, Brushes.Red, 0, SizeY-14);
					e.Graphics.DrawString(MaxWay / 4f + Metrika, drawFont, Brushes.Black, 0, 6 * SizeY / 8);
					e.Graphics.DrawString(MaxWay / 2f + Metrika, drawFont, Brushes.Black, 0, SizeY / 2);
					e.Graphics.DrawString(3f * MaxWay / 4f + Metrika, drawFont, Brushes.Black, 0, SizeY / 4);
					e.Graphics.DrawString(MaxWay + Metrika, drawFont, Brushes.Red, 0, 0);
				}
				else
				{
					// Поиск максимальных и минимальных значений углов
					for (int i = 0; i < numericUpDown3.Value; i++)
					{
						for (int j = 19; j <= 22; j++)
						{

							if ( Oscilations[i, j] != -255 )
							{
								if (MinAngle > Oscilations[i, j]) MinAngle = Oscilations[i, j];
								if (MaxAngle < Oscilations[i, j]) MaxAngle = Oscilations[i, j];
							}
						}
					}
					
					// Подбор границ графика
					MinAngle = (float) ((int)(MinAngle / 10) * 10);
					MaxAngle = (float) ((int)(MaxAngle / 10) * 10 + 10);
					
					// Отрисовка графика
					// Левая сторона
					for (int i = 0; i < numericUpDown3.Value; i++)
					{
						ExistDot = true;
						if (Oscilations[i, GraphNum] == -255) ExistDot = false;
					
						Pt1.X = i * ZoomX;
						Pt1.Y = SizeY - ((Oscilations[i, GraphNum] - MinAngle) * (400.0f / (MaxAngle - MinAngle))) * (SizeY / 400f);
						if (i < ((int)numericUpDown3.Value - 1))
						{
							if (Oscilations[(i+1), GraphNum] == -255) ExistDot = false;
							Pt2.X = (i+1) * ZoomX;
							Pt2.Y = SizeY - ((Oscilations[i+1, GraphNum] - MinAngle) * (400.0f / (MaxAngle - MinAngle))) * (SizeY / 400f);
						}
						if (ExistDot == true) e.Graphics.DrawLine(Pens.Blue,Pt1,Pt2);
					}

					// Правая сторона
					for (int i = 0; i < numericUpDown3.Value; i++)
					{
						ExistDot = true;
						if (Oscilations[i, GraphNum+2] == -255) ExistDot = false;
					
						Pt1.X = i * ZoomX;
						Pt1.Y = SizeY - ((Oscilations[i, GraphNum+2] - MinAngle) * (400.0f / (MaxAngle - MinAngle))) * (SizeY / 400f);
						if (i < ((int)numericUpDown3.Value - 1))
						{
							if (Oscilations[(i+1), GraphNum+2] == -255) ExistDot = false;
							Pt2.X = (i+1) * ZoomX;
							Pt2.Y = SizeY - ((Oscilations[i+1, GraphNum+2] - MinAngle) * (400.0f / (MaxAngle - MinAngle))) * (SizeY / 400f);
						}
						if (ExistDot == true) e.Graphics.DrawLine(Pens.Red,Pt1,Pt2);
					}

					//Градуировка шкалы
					e.Graphics.DrawString(MinAngle + Metrika, drawFont, Brushes.Red, 0, SizeY-14);
					e.Graphics.DrawString((MinAngle + (MaxAngle - MinAngle)/4) + Metrika, drawFont, Brushes.Black, 0, 6 * SizeY / 8);
					e.Graphics.DrawString((MaxAngle - (MaxAngle - MinAngle)/2) + Metrika, drawFont, Brushes.Black, 0, SizeY / 2);
					e.Graphics.DrawString((MaxAngle - (MaxAngle - MinAngle)/4) + Metrika, drawFont, Brushes.Black, 0, SizeY / 4);
					e.Graphics.DrawString(MaxAngle + Metrika, drawFont, Brushes.Red, 0, 0);
				}
			}
		}

		private void pictureBox5_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 0, pictureBox5.Width, pictureBox5.Height);
		}

		private void pictureBox6_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 1, pictureBox6.Width, pictureBox6.Height);
		}

		private void pictureBox7_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 2, pictureBox7.Width, pictureBox7.Height);
		}

		private void pictureBox10_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 5, pictureBox10.Width, pictureBox10.Height);
		}

		private void pictureBox8_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 6, pictureBox8.Width, pictureBox8.Height);
		}

		private void pictureBox9_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 17, pictureBox9.Width, pictureBox9.Height);
		}

		private void pictureBox11_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 0, pictureBox11.Width, pictureBox11.Height);
		}

		private void pictureBox12_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 1, pictureBox12.Width, pictureBox12.Height);
		}

		private void pictureBox13_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 2, pictureBox13.Width, pictureBox13.Height);
		}

		private void pictureBox14_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 5, pictureBox14.Width, pictureBox14.Height);
		}

		private void pictureBox15_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 6, pictureBox15.Width, pictureBox15.Height);
		}

		private void pictureBox16_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 17, pictureBox16.Width, pictureBox16.Height);
		}

		private void pictureBox17_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 3, pictureBox17.Width, pictureBox17.Height);
		}

		private void pictureBox18_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 18, pictureBox18.Width, pictureBox18.Height);
		}

		private void pictureBox19_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 19, pictureBox19.Width, pictureBox19.Height);
		}

		private void pictureBox20_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			DrawGraphOsc(e, 20, pictureBox20.Width, pictureBox20.Height);
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button21_Click(object sender, System.EventArgs e)
		// Кнопка добавления файла в базу данных
		{
			string FileAdd = "";
			textBox2.Text = "";
			// загрузка данных из файла
			if (LoadFromFile() == false) {return;}

			FileAdd = openFileDialog3.FileName;
			listBox2.Items.Add(Path.GetFileName(FileAdd));
			// добавляем данные в базу данных
			FileBase.Add(FileAdd);
			DescrBase.Add(textBox2.Text);
			ScaleBase.Add(MetersPerPoint);
			CadrNumBase.Add(CadrPoints.Length / 17);
			CadrPointsBase.Add(CadrPoints);

			if (listBox2.Items.Count > 0) {listBox2.SetSelected(listBox2.Items.Count - 1,true);}
		}

		private void button20_Click(object sender, System.EventArgs e)
		// кнопка добавления описания файла
		{
			if (listBox2.SelectedIndex < 0) {return;}
			DescrBase[listBox2.SelectedIndex] = textBox2.Text;
		}

		private void listBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (listBox2.SelectedIndex < 0) {return;}
			textBox2.Text = DescrBase[listBox2.SelectedIndex].ToString();
		}

		private void button22_Click(object sender, System.EventArgs e)
		// Кнопка удаления файла из базы данных
		{
			if (listBox2.SelectedIndex < 0) {return;}
			textBox2.Text = "";

			// удаляем данные из базы данных
			FileBase.RemoveAt(listBox2.SelectedIndex);
			DescrBase.RemoveAt(listBox2.SelectedIndex);
			ScaleBase.RemoveAt(listBox2.SelectedIndex);
			CadrNumBase.RemoveAt(listBox2.SelectedIndex);
			CadrPointsBase.RemoveAt(listBox2.SelectedIndex);

			listBox2.Items.RemoveAt(listBox2.SelectedIndex);
		}

		private void button23_Click(object sender, System.EventArgs e)
		// Кнопка создания новой базы данных
		{
			if (MessageBox.Show("Вы действительно хотите создать новую базу данных?","Анализ движения человека",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel) { return; }
			DatabaseName = "Unnamed.mab";        // имя базы данных
			label129.Text = Path.GetFileName(DatabaseName);
			textBox2.Text = "";

			listBox2.Items.Clear();

			// удаляем данные из базы данных
			FileBase.Clear();
			DescrBase.Clear();
			ScaleBase.Clear();
			CadrNumBase.Clear();
			CadrPointsBase.Clear();
		}

		private void button19_Click(object sender, System.EventArgs e)
		// Кнопка для сохранения базы данных
		{
			if (saveFileDialog2.ShowDialog() == DialogResult.Cancel) { return; }
			if (File.Exists(saveFileDialog2.FileName)) { File.Delete(saveFileDialog2.FileName); }
			DatabaseName = saveFileDialog2.FileName;        // имя базы данных
			label129.Text = Path.GetFileName(DatabaseName);
			
			// создание нового файла для записи
			BinaryWriter bw = new BinaryWriter(File.Open(DatabaseName, FileMode.Create));
			
			// Запись данных в файл
			// Количество файлов в базе
			bw.Write(FileBase.Count);
			
			for (int j = 0; j < FileBase.Count; j++)
			{
				// имя файла
				bw.Write(FileBase[j].ToString());

				// описание файла
				bw.Write(DescrBase[j].ToString());
				
				// Коэффициент "метров на точку"
				
				bw.Write(((PointF)ScaleBase[j]).X);
				bw.Write(((PointF)ScaleBase[j]).Y);

				// Количество кадров
				bw.Write((int)CadrNumBase[j]);

				// Точки отмеченные на кадрах [номер кадра, номер точки]
				for (int Cadr = 0; Cadr < ((int)CadrNumBase[j]); Cadr++)
				{
					for (int i = 0; i < 17; i++)
					{
						bw.Write(((PointF[,])CadrPointsBase[j])[Cadr, i].X);
						bw.Write(((PointF[,])CadrPointsBase[j])[Cadr, i].Y);
					}
				}
			}
			bw.Close();
		}

		private void button18_Click(object sender, System.EventArgs e)
		// кнопка для открытия файла
		{
			int jCount = 0; // количество файлов в базе
			PointF MPP = new PointF(0,0); 
			int CadrsNum = 0;
			PointF[,] TempCadrPoints;

			if (openFileDialog4.ShowDialog() == DialogResult.Cancel) { return; }
			if (File.Exists(openFileDialog4.FileName) == false) { MessageBox.Show("Файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); button5.Enabled = false; return; }
			DatabaseName = openFileDialog4.FileName;        // имя базы данных
			label129.Text = Path.GetFileName(DatabaseName);
			saveFileDialog2.FileName = DatabaseName;
			textBox2.Text = "";

			listBox2.Items.Clear();

			// удаляем данные из базы данных
			FileBase.Clear();
			DescrBase.Clear();
			ScaleBase.Clear();
			CadrNumBase.Clear();
			CadrPointsBase.Clear();

			// создание нового файла для записи
			BinaryReader br = new BinaryReader(File.Open(DatabaseName, FileMode.Open));
			
			// Запись данных в файл
			// Количество файлов в базе
			jCount = br.ReadInt32();
			
			for (int j = 0; j < jCount; j++)
			{
				// имя файла
				FileBase.Add(br.ReadString());

				// описание файла
				DescrBase.Add(br.ReadString());
				
				// Коэффициент "метров на точку"
				MPP.X = br.ReadSingle();
				MPP.Y = br.ReadSingle();
				ScaleBase.Add(MPP);

				// Количество кадров
				CadrsNum = br.ReadInt32();
				CadrNumBase.Add(CadrsNum);

				TempCadrPoints = new PointF[CadrsNum,17];

				// Точки отмеченные на кадрах [номер кадра, номер точки]
				for (int Cadr = 0; Cadr < CadrsNum; Cadr++)
				{
					for (int i = 0; i < 17; i++)
					{
						TempCadrPoints[Cadr, i].X = br.ReadSingle();
						TempCadrPoints[Cadr, i].Y = br.ReadSingle();
					}
				}
				CadrPointsBase.Add(TempCadrPoints);

				listBox2.Items.Add(Path.GetFileName(FileBase[j].ToString()));
			}
			br.Close();
		}

		private void button24_Click(object sender, System.EventArgs e)
		// кнопка для анализа походки
		{
			if (FileBase.Count < 1) {return;}

			int[] RateNum;
			float[] Rating;
			float[,] Angles;
			int iMax = 0;

			// создаем переменные для хранения результатов
			if (CorrelationBase.Count > 0) CorrelationBase.Clear();
			RateNum = new int[FileBase.Count];
			Rating = new float[FileBase.Count];
			for(int i=0;i<FileBase.Count;i++) RateNum[i]=0;
			for(int i=0;i<FileBase.Count;i++) Rating[i]=0.0f;

			for (int Motion = 0; Motion < FileBase.Count; Motion++) // Номер походки
			{
				Angles = new float[(int)CadrNumBase[Motion],4];

				iMax = (int)numericUpDown3.Value;
				if ((CadrPoints.Length / 23) < iMax) iMax = CadrPoints.Length / 23;
				if ((((PointF[,])CadrPointsBase[Motion]).Length / 4) < iMax) iMax = ((PointF[,])CadrPointsBase[Motion]).Length / 4;

				// Расчет углов
				for (int i = 0; i < iMax; i++)
				{
					Angles[i, 0] = -255;
					Angles[i, 1] = -255;
					Angles[i, 2] = -255;
					Angles[i, 3] = -255;
				}
				for (int i = 0; i < iMax; i++)
				{
					//Левая рука
					if (!(((PointF[,])CadrPointsBase[Motion])[i, 0].X == -255 || ((PointF[,])CadrPointsBase[Motion])[i, 1].X == -255 || ((PointF[,])CadrPointsBase[Motion])[i, 2].X == -255))
					{
						Angles[i, 0] = Angle_point(((PointF[,])CadrPointsBase[Motion])[i, 0],((PointF[,])CadrPointsBase[Motion])[i, 1],((PointF[,])CadrPointsBase[Motion])[i, 2]);
					}
				
					//Левая нога
					if (!(((PointF[,])CadrPointsBase[Motion])[i, 4].X == -255 || ((PointF[,])CadrPointsBase[Motion])[i, 5].X == -255 || ((PointF[,])CadrPointsBase[Motion])[i, 6].X == -255))
					{
						Angles[i, 1] = Angle_point(((PointF[,])CadrPointsBase[Motion])[i, 4],((PointF[,])CadrPointsBase[Motion])[i, 5],((PointF[,])CadrPointsBase[Motion])[i, 6]);
					}

					//Правая рука
					if (!(((PointF[,])CadrPointsBase[Motion])[i, 9].X == -255 || ((PointF[,])CadrPointsBase[Motion])[i, 10].X == -255 || ((PointF[,])CadrPointsBase[Motion])[i, 11].X == -255))
					{
						Angles[i, 2] = Angle_point(((PointF[,])CadrPointsBase[Motion])[i, 9],((PointF[,])CadrPointsBase[Motion])[i, 10],((PointF[,])CadrPointsBase[Motion])[i, 11]);
					}

					//Правая нога
					if (!(((PointF[,])CadrPointsBase[Motion])[i, 12].X == -255 || ((PointF[,])CadrPointsBase[Motion])[i, 13].X == -255 || ((PointF[,])CadrPointsBase[Motion])[i, 14].X == -255))
					{
						Angles[i, 3] = Angle_point(((PointF[,])CadrPointsBase[Motion])[i, 12],((PointF[,])CadrPointsBase[Motion])[i, 13],((PointF[,])CadrPointsBase[Motion])[i, 14]);
					}
				}

				for (int ang = 0; ang < 4; ang++) // номер угла
				{
					if (checkBox1.Checked == false && (ang == 0 || ang == 2)) continue;
					if (checkBox2.Checked == false && (ang == 1 || ang == 3)) continue;
					if (checkBox9.Checked == false && (ang == 0 || ang == 1)) continue;
					if (checkBox8.Checked == false && (ang == 2 || ang == 3)) continue;
					Rating[Motion] += CorrelationAngles(Oscilations, Angles, ang + 19, ang, iMax);	
					RateNum[Motion]++;
				}

				for (int Dot = 0; Dot < 17; Dot++) // Номер точки
				{
					// Пропускаем ненужные точки
					if (Dot == 3) continue;
					if (Dot == 4) continue;
					if (Dot == 7) continue;
					if (Dot == 8) continue;
					if (Dot == 12) continue;
					if (Dot == 15) continue;
					if (Dot == 16) continue;
					if (checkBox3.Checked == false && (Dot == 0 || Dot == 9)) continue;
					if (checkBox4.Checked == false && (Dot == 1 || Dot == 10)) continue;
					if (checkBox6.Checked == false && (Dot == 2 || Dot == 11)) continue;
					if (checkBox5.Checked == false && (Dot == 5 || Dot == 13)) continue;
					if (checkBox7.Checked == false && (Dot == 6 || Dot == 14)) continue;
					if (checkBox9.Checked == false && (Dot == 0 || Dot == 1 || Dot == 2 || Dot == 5 || Dot == 6)) continue;
					if (checkBox8.Checked == false && (Dot == 9 || Dot == 10 || Dot == 11 || Dot == 13 || Dot == 14)) continue;

					Rating[Motion] += CorrelationPoints(CadrPoints, ((PointF[,])CadrPointsBase[Motion]), Dot, Dot, (int)numericUpDown3.Value, (PointF)ScaleBase[Motion]);	
					RateNum[Motion]++;
				}
				if (RateNum[Motion] > 0) Rating[Motion] /= RateNum[Motion];
				CorrelationBase.Add(Rating[Motion]);
				
			}
			textBox3.Text ="";
			float Max = 0;
			int MaxIndex = 0;
			for(int i = 0; i < FileBase.Count; i++)
			{
				if ((float)CorrelationBase[i] >= Max) { Max = (float)CorrelationBase[i]; MaxIndex = i; }
			}
			if (Max >= Convert.ToSingle(textBox4.Text)) // Коэффициент альфа
			{
				textBox3.Text = textBox3.Text + "Походка распознана, она соответствует походке из файла " + Path.GetFileName(FileBase[MaxIndex].ToString()) + ". Описание походки: " + DescrBase[MaxIndex] + ", Степень сходства: " + CorrelationBase[MaxIndex] + System.Environment.NewLine + System.Environment.NewLine;
			}
			else
			{
				textBox3.Text = textBox3.Text + "Походка не распознана, возможно нужно выбрать меньший коэффициент ?." + System.Environment.NewLine + System.Environment.NewLine;
			};

			for(int i = 0; i < FileBase.Count; i++)
			{
				textBox3.Text = textBox3.Text + "Файл походки: " + Path.GetFileName(FileBase[i].ToString()) + ", Описание: " + DescrBase[i] + ", Степень сходства: " + CorrelationBase[i] + System.Environment.NewLine;
			}
		}

		private void button25_Click(object sender, System.EventArgs e)
		// кнопка возврата к выбору источника данных
		{
			panel4.Visible = false;
			this.Text = "Анализ движения человека: Выбор источника входных данных";
			panel1.Location = new Point(0,0);
			panel1.Visible = true;
		}

		public float CorrelationAngles (float[,] x, float[,] y, int xNum, int yNum, int iMax)
		// функция для получение корреляции двух массивов
		{
			float xSum = 0, ySum = 0, temp1 = 0, temp2 = 0, temp3 = 0;
			float SumNum = 0;
			float Corel = 0;
			
			if ((x.Length / 23) < iMax) iMax = x.Length / 23;
			if ((y.Length / 4) < iMax) iMax = y.Length / 4;
			// подсчитываем средние x и y
			SumNum = 0;
			for (int i = 0; i<iMax;i++)
			{
				if (!(x[i,xNum] == -255 || y[i,yNum] == -255))
				{
					xSum += x[i,xNum];
					ySum += y[i,yNum];
					SumNum++;
				}
			}
			xSum = xSum / SumNum;
			ySum = ySum / SumNum;

			for (int i = 0; i<iMax;i++)
			{
				if (!(x[i,xNum] == -255 || y[i,yNum] == -255))
				{
					temp1 += (x[i,xNum] - xSum) * (y[i,yNum] - ySum);
					temp2 += (float)Math.Pow((double)(x[i,xNum] - xSum),2.0);
					temp3 += (float)Math.Pow((double)(y[i,yNum] - ySum),2.0);
				}
			}
			
			temp2 = (float)Math.Sqrt((double)temp2);
			temp3 = (float)Math.Sqrt((double)temp3);
			
			Corel = temp1 / (temp2 * temp3);

			if (SumNum < 1) Corel = 1;
			return Math.Abs(Corel);
		}

		public float CorrelationPoints (PointF[,] _x, PointF[,] _y, int xNum, int yNum, int iMax, PointF YMetersPerPoint)
			// функция для получение корреляции двух массивов
		{
			PointF[,] x = new PointF[(_x.Length/17),17];
			PointF[,] y = new PointF[(_y.Length/17),17];
			for (int i = 0; i < (_x.Length/17); i++)
			{
				x[i, xNum].Y = (_x[i, xNum].X - _x[i, 3].X) * YMetersPerPoint.X;
			}
			for (int i = 0; i < (_y.Length/17); i++)
			{
				y[i, yNum].Y = (_y[i, yNum].X - _y[i, 3].X) * YMetersPerPoint.X;
			}

			float xSum = 0, ySum = 0, temp1 = 0, temp2 = 0, temp3 = 0;
			float SumNum = 0;
			float Corel = 0;
			
			if ((x.Length / 17) < iMax) iMax = x.Length / 17;
			if ((y.Length / 17) < iMax) iMax = y.Length / 17;
			// подсчитываем средние x и y
			SumNum = 0;
			for (int i = 0; i<iMax;i++)
			{
				if (!(x[i,xNum].Y == -255 || y[i,yNum].Y == -255))
				{
					xSum += x[i,xNum].Y;
					ySum += y[i,yNum].Y;
					SumNum++;
				}
			}
			xSum = xSum / SumNum;
			ySum = ySum / SumNum;

			for (int i = 0; i<iMax;i++)
			{
				if (!(x[i,xNum].Y == -255 || y[i,yNum].Y == -255))
				{
					temp1 += (x[i,xNum].Y - xSum) * (y[i,yNum].Y - ySum);
					temp2 += (float)Math.Pow((double)(x[i,xNum].Y - xSum),2.0);
					temp3 += (float)Math.Pow((double)(y[i,yNum].Y - ySum),2.0);
				}
			}
			
			temp2 = (float)Math.Sqrt((double)temp2);
			temp3 = (float)Math.Sqrt((double)temp3);
			
			Corel = temp1 / (temp2 * temp3);

			if (SumNum < 1) Corel = 1;
			return Math.Abs(Corel);
		}
	}
}
