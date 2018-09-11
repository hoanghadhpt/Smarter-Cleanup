using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SPi.BPR.ConversionServices.LN.Cleanup;
using SPi.BPR.ConversionServices.LN.RemoveEmphasis;
using SPi.BPR.ConversionServices.LN.Validation;
using System.IO;
using System.Text;
using SKGL;
using System.Text.RegularExpressions;

namespace Smarter_Cleanup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            base.Load += this.frmCleanup_Load;
            this.WorkId = 0;
            this.InitializeComponent();

        }

        string configfile = Directory.GetCurrentDirectory() + @"\E1897.xml";
        public int WorkId;



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void frmCleanup_Load(object sender, EventArgs e)
        {
            if (this.WorkId == 0)
            {
                this.Text = "Smarter Cleanup -- By Hoang Ha";
            }
            else if (this.WorkId == 1)
            {
                this.Text = "Remove Emphasis - UAT";
            }
            else if (this.WorkId == 2)
            {
                this.Text = "Validation - UAT";
            }
        }
        private void InitializeComponents()
        {
            this.txtOutput = new TextBox();
            this.Label7 = new Label();
            this.Label4 = new Label();
            this.txtLogCleanup = new TextBox();
            this.btnCleanup = new Button();
            this.Label5 = new Label();
            this.txtInputCleanup = new TextBox();
            this.txtConfigCleanup = new TextBox();
            this.Label6 = new Label();
            this.btnBrowseConfigXMLPath = new Button();
            this.Button1 = new Button();
            this.Button2 = new Button();
            this.Button3 = new Button();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.FolderBrowserDialog1 = new FolderBrowserDialog();
            this.SuspendLayout();
            Control txtOutput = this.txtOutput;
            Point location = new Point(8, 94);
            txtOutput.Location = location;
            this.txtOutput.Name = "txtOutput";
            Control txtOutput2 = this.txtOutput;
            Size size = new Size(411, 20);
            txtOutput2.Size = size;
            this.txtOutput.TabIndex = 4;
            this.Label7.AutoSize = true;
            Control label = this.Label7;
            location = new Point(4, 81);
            label.Location = location;
            this.Label7.Name = "Label7";
            Control label2 = this.Label7;
            size = new Size(79, 13);
            label2.Size = size;
            this.Label7.TabIndex = 24;
            this.Label7.Text = "Ouput file path:";
            this.Label4.AutoSize = true;
            Control label3 = this.Label4;
            location = new Point(7, 9);
            label3.Location = location;
            this.Label4.Name = "Label4";
            Control label4 = this.Label4;
            size = new Size(80, 13);
            label4.Size = size;
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Config file path:";
            Control txtLogCleanup = this.txtLogCleanup;
            location = new Point(8, 127);
            txtLogCleanup.Location = location;
            this.txtLogCleanup.Name = "txtLogCleanup";
            Control txtLogCleanup2 = this.txtLogCleanup;
            size = new Size(411, 20);
            txtLogCleanup2.Size = size;
            this.txtLogCleanup.TabIndex = 6;
            Control btnCleanup = this.btnCleanup;
            location = new Point(343, 157);
            btnCleanup.Location = location;
            this.btnCleanup.Name = "btnCleanup";
            Control btnCleanup2 = this.btnCleanup;
            size = new Size(75, 23);
            btnCleanup2.Size = size;
            this.btnCleanup.TabIndex = 8;
            this.btnCleanup.Text = "Start";
            this.btnCleanup.UseVisualStyleBackColor = true;
            this.Label5.AutoSize = true;
            Control label5 = this.Label5;
            location = new Point(4, 113);
            label5.Location = location;
            this.Label5.Name = "Label5";
            Control label6 = this.Label5;
            size = new Size(73, 13);
            label6.Size = size;
            this.Label5.TabIndex = 21;
            this.Label5.Text = "Error log path:";
            Control txtInputCleanup = this.txtInputCleanup;
            location = new Point(7, 61);
            txtInputCleanup.Location = location;
            this.txtInputCleanup.Name = "txtInputCleanup";
            Control txtInputCleanup2 = this.txtInputCleanup;
            size = new Size(411, 20);
            txtInputCleanup2.Size = size;
            this.txtInputCleanup.TabIndex = 2;
            Control txtConfigCleanup = this.txtConfigCleanup;
            location = new Point(8, 25);
            txtConfigCleanup.Location = location;
            this.txtConfigCleanup.Name = "txtConfigCleanup";
            Control txtConfigCleanup2 = this.txtConfigCleanup;
            size = new Size(411, 20);
            txtConfigCleanup2.Size = size;
            this.txtConfigCleanup.TabIndex = 0;
            this.Label6.AutoSize = true;
            Control label7 = this.Label6;
            location = new Point(5, 45);
            label7.Location = location;
            this.Label6.Name = "Label6";
            Control label8 = this.Label6;
            size = new Size(74, 13);
            label8.Size = size;
            this.Label6.TabIndex = 18;
            this.Label6.Text = "Input file path:";
            Control btnBrowseConfigXMLPath = this.btnBrowseConfigXMLPath;
            location = new Point(425, 25);
            btnBrowseConfigXMLPath.Location = location;
            this.btnBrowseConfigXMLPath.Name = "btnBrowseConfigXMLPath";
            Control btnBrowseConfigXMLPath2 = this.btnBrowseConfigXMLPath;
            size = new Size(31, 23);
            btnBrowseConfigXMLPath2.Size = size;
            this.btnBrowseConfigXMLPath.TabIndex = 1;
            this.btnBrowseConfigXMLPath.Text = "...";
            this.btnBrowseConfigXMLPath.UseVisualStyleBackColor = true;
            Control button = this.Button1;
            location = new Point(425, 59);
            button.Location = location;
            this.Button1.Name = "Button1";
            Control button2 = this.Button1;
            size = new Size(31, 23);
            button2.Size = size;
            this.Button1.TabIndex = 3;
            this.Button1.Text = "...";
            this.Button1.UseVisualStyleBackColor = true;
            Control button3 = this.Button2;
            location = new Point(425, 91);
            button3.Location = location;
            this.Button2.Name = "Button2";
            Control button4 = this.Button2;
            size = new Size(31, 23);
            button4.Size = size;
            this.Button2.TabIndex = 5;
            this.Button2.Text = "...";
            this.Button2.UseVisualStyleBackColor = true;
            Control button5 = this.Button3;
            location = new Point(425, 124);
            button5.Location = location;
            this.Button3.Name = "Button3";
            Control button6 = this.Button3;
            size = new Size(31, 23);
            button6.Size = size;
            this.Button3.TabIndex = 7;
            this.Button3.Text = "...";
            this.Button3.UseVisualStyleBackColor = true;
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            SizeF autoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleDimensions = autoScaleDimensions;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(466, 192);
            this.ClientSize = size;
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnBrowseConfigXMLPath);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtLogCleanup);
            this.Controls.Add(this.btnCleanup);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtInputCleanup);
            this.Controls.Add(this.txtConfigCleanup);
            this.Controls.Add(this.Label6);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCleanup";
            this.Text = "Cleanup - UAT";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual TextBox txtOutput
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtOutput;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtOutput = value;
            }
        }

        // Token: 0x17000039 RID: 57
        // (get) Token: 0x060000A0 RID: 160 RVA: 0x000B90F0 File Offset: 0x000B80F0
        // (set) Token: 0x060000A1 RID: 161 RVA: 0x000B9104 File Offset: 0x000B8104
        internal virtual Label Label7
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label7;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label7 = value;
            }
        }

        // Token: 0x1700003A RID: 58
        // (get) Token: 0x060000A2 RID: 162 RVA: 0x000B9110 File Offset: 0x000B8110
        // (set) Token: 0x060000A3 RID: 163 RVA: 0x000B9124 File Offset: 0x000B8124
        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label4;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label4 = value;
            }
        }

        // Token: 0x1700003B RID: 59
        // (get) Token: 0x060000A4 RID: 164 RVA: 0x000B9130 File Offset: 0x000B8130
        // (set) Token: 0x060000A5 RID: 165 RVA: 0x000B9144 File Offset: 0x000B8144
        internal virtual TextBox txtLogCleanup
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtLogCleanup;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtLogCleanup = value;
            }
        }

        // Token: 0x1700003C RID: 60
        // (get) Token: 0x060000A6 RID: 166 RVA: 0x000B9150 File Offset: 0x000B8150
        // (set) Token: 0x060000A7 RID: 167 RVA: 0x000B9164 File Offset: 0x000B8164
        internal virtual Button btnCleanup
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnCleanup;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnCleanup != null)
                {
                    this._btnCleanup.Click -= this.btnCleanup_Click;
                }
                this._btnCleanup = value;
                if (this._btnCleanup != null)
                {
                    this._btnCleanup.Click += this.btnCleanup_Click;
                }
            }
        }

        // Token: 0x1700003D RID: 61
        // (get) Token: 0x060000A8 RID: 168 RVA: 0x000B91B8 File Offset: 0x000B81B8
        // (set) Token: 0x060000A9 RID: 169 RVA: 0x000B91CC File Offset: 0x000B81CC
        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label5;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label5 = value;
            }
        }

        // Token: 0x1700003E RID: 62
        // (get) Token: 0x060000AA RID: 170 RVA: 0x000B91D8 File Offset: 0x000B81D8
        // (set) Token: 0x060000AB RID: 171 RVA: 0x000B91EC File Offset: 0x000B81EC
        internal virtual TextBox txtInputCleanup
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtInputCleanup;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtInputCleanup = value;
            }
        }

        // Token: 0x1700003F RID: 63
        // (get) Token: 0x060000AC RID: 172 RVA: 0x000B91F8 File Offset: 0x000B81F8
        // (set) Token: 0x060000AD RID: 173 RVA: 0x000B920C File Offset: 0x000B820C
        internal virtual TextBox txtConfigCleanup
        {
            [DebuggerNonUserCode]
            get
            {
                return this._txtConfigCleanup;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtConfigCleanup = value;
            }
        }

        // Token: 0x17000040 RID: 64
        // (get) Token: 0x060000AE RID: 174 RVA: 0x000B9218 File Offset: 0x000B8218
        // (set) Token: 0x060000AF RID: 175 RVA: 0x000B922C File Offset: 0x000B822C
        internal virtual Label Label6
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Label6;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._Label6 = value;
            }
        }

        // Token: 0x17000041 RID: 65
        // (get) Token: 0x060000B0 RID: 176 RVA: 0x000B9238 File Offset: 0x000B8238
        // (set) Token: 0x060000B1 RID: 177 RVA: 0x000B924C File Offset: 0x000B824C
        internal virtual Button btnBrowseConfigXMLPath
        {
            [DebuggerNonUserCode]
            get
            {
                return this._btnBrowseConfigXMLPath;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._btnBrowseConfigXMLPath != null)
                {
                    this._btnBrowseConfigXMLPath.Click -= this.btnBrowseConfigXMLPath_Click;
                }
                this._btnBrowseConfigXMLPath = value;
                if (this._btnBrowseConfigXMLPath != null)
                {
                    this._btnBrowseConfigXMLPath.Click += this.btnBrowseConfigXMLPath_Click;
                }
            }
        }

        // Token: 0x17000042 RID: 66
        // (get) Token: 0x060000B2 RID: 178 RVA: 0x000B92A0 File Offset: 0x000B82A0
        // (set) Token: 0x060000B3 RID: 179 RVA: 0x000B92B4 File Offset: 0x000B82B4
        internal virtual Button Button1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Button1 != null)
                {
                    this._Button1.Click -= this.Button1_Click;
                }
                this._Button1 = value;
                if (this._Button1 != null)
                {
                    this._Button1.Click += this.Button1_Click;
                }
            }
        }

        // Token: 0x17000043 RID: 67
        // (get) Token: 0x060000B4 RID: 180 RVA: 0x000B9308 File Offset: 0x000B8308
        // (set) Token: 0x060000B5 RID: 181 RVA: 0x000B931C File Offset: 0x000B831C
        internal virtual Button Button2
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button2;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Button2 != null)
                {
                    this._Button2.Click -= this.Button2_Click;
                }
                this._Button2 = value;
                if (this._Button2 != null)
                {
                    this._Button2.Click += this.Button2_Click;
                }
            }
        }

        // Token: 0x17000044 RID: 68
        // (get) Token: 0x060000B6 RID: 182 RVA: 0x000B9370 File Offset: 0x000B8370
        // (set) Token: 0x060000B7 RID: 183 RVA: 0x000B9384 File Offset: 0x000B8384
        internal virtual Button Button3
        {
            [DebuggerNonUserCode]
            get
            {
                return this._Button3;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (this._Button3 != null)
                {
                    this._Button3.Click -= this.Button3_Click;
                }
                this._Button3 = value;
                if (this._Button3 != null)
                {
                    this._Button3.Click += this.Button3_Click;
                }
            }
        }

        // Token: 0x17000045 RID: 69
        // (get) Token: 0x060000B8 RID: 184 RVA: 0x000B93D8 File Offset: 0x000B83D8
        // (set) Token: 0x060000B9 RID: 185 RVA: 0x000B93EC File Offset: 0x000B83EC
        internal virtual OpenFileDialog OpenFileDialog1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._OpenFileDialog1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._OpenFileDialog1 = value;
            }
        }

        // Token: 0x17000046 RID: 70
        // (get) Token: 0x060000BA RID: 186 RVA: 0x000B93F8 File Offset: 0x000B83F8
        // (set) Token: 0x060000BB RID: 187 RVA: 0x000B940C File Offset: 0x000B840C
        internal virtual FolderBrowserDialog FolderBrowserDialog1
        {
            [DebuggerNonUserCode]
            get
            {
                return this._FolderBrowserDialog1;
            }
            [DebuggerNonUserCode]
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._FolderBrowserDialog1 = value;
            }
        }

        // Token: 0x060000BC RID: 188 RVA: 0x000B9418 File Offset: 0x000B8418
        private void btnBrowseConfigXMLPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = this.OpenFileDialog1;
            openFileDialog.Multiselect = false;
            openFileDialog.FilterIndex = 1;
            openFileDialog.FileName = "";
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.txtConfigCleanup.Text = openFileDialog.FileName;
            }
        }

        // Token: 0x060000BD RID: 189 RVA: 0x000B9470 File Offset: 0x000B8470
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = this.OpenFileDialog1;
            openFileDialog.Multiselect = false;
            openFileDialog.FilterIndex = 1;
            openFileDialog.FileName = "";
            openFileDialog.Filter = "OUT Files (*.out)|*.out";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.txtInputCleanup.Text = openFileDialog.FileName;
            }
        }

        // Token: 0x060000BE RID: 190 RVA: 0x000B94C8 File Offset: 0x000B84C8
        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = this.OpenFileDialog1;
            openFileDialog.Multiselect = false;
            openFileDialog.FilterIndex = 1;
            openFileDialog.FileName = "";
            if (this.WorkId == 2)
            {
                openFileDialog.Filter = "LOG Files (*.log)|*.log";
            }
            else
            {
                openFileDialog.Filter = "OUT Files (*.out)|*.out";
            }
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.txtOutput.Text = openFileDialog.FileName;
            }
        }

        // Token: 0x060000BF RID: 191 RVA: 0x000B9534 File Offset: 0x000B8534
        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = this.OpenFileDialog1;
            openFileDialog.Multiselect = false;
            openFileDialog.FilterIndex = 1;
            openFileDialog.FileName = "";
            openFileDialog.Filter = "LOG Files (*.log)|*.log";
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                this.txtLogCleanup.Text = openFileDialog.FileName;
            }
        }

        // Token: 0x060000C0 RID: 192 RVA: 0x000B958C File Offset: 0x000B858C
        private void btnCleanup_Click(object sender, EventArgs e)
        {
            if (this.WorkId == 0)
            {
                clsCleanup clsCleanup = new clsCleanup();
                clsCleanup.Cleanup(this.txtInputCleanup.Text, this.txtOutput.Text, this.txtConfigCleanup.Text, this.txtLogCleanup.Text);
                //Interaction.MsgBox("Over", MsgBoxStyle.OkOnly, null);
            }
            else if (this.WorkId == 1)
            {
                clsRemoveEmphasis clsRemoveEmphasis = new clsRemoveEmphasis();
                clsRemoveEmphasis.RemoveEmphasis(this.txtInputCleanup.Text, this.txtOutput.Text, this.txtConfigCleanup.Text, this.txtLogCleanup.Text);
                //Interaction.MsgBox("Over", MsgBoxStyle.OkOnly, null);
            }
            else if (this.WorkId == 2)
            {
                clsValidation clsValidation = new clsValidation();
                clsValidation.Validate(this.txtInputCleanup.Text, this.txtOutput.Text, this.txtConfigCleanup.Text, this.txtLogCleanup.Text);
                //Interaction.MsgBox("Over", MsgBoxStyle.OkOnly, null);
            }
            else
            {
                Interaction.MsgBox("Can not perform this operation!!!!", MsgBoxStyle.OkOnly, null);
            }
        }

        // Token: 0x060000C1 RID: 193 RVA: 0x000B969C File Offset: 0x000B869C

        // Token: 0x04000066 RID: 102


        // Token: 0x04000067 RID: 103
        [AccessedThroughProperty("txtOutput")]
        private TextBox _txtOutput;

        // Token: 0x04000068 RID: 104
        [AccessedThroughProperty("Label7")]
        private Label _Label7;

        // Token: 0x04000069 RID: 105
        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        // Token: 0x0400006A RID: 106
        [AccessedThroughProperty("txtLogCleanup")]
        private TextBox _txtLogCleanup;

        // Token: 0x0400006B RID: 107
        [AccessedThroughProperty("btnCleanup")]
        private Button _btnCleanup;

        // Token: 0x0400006C RID: 108
        [AccessedThroughProperty("Label5")]
        private Label _Label5;

        // Token: 0x0400006D RID: 109
        [AccessedThroughProperty("txtInputCleanup")]
        private TextBox _txtInputCleanup;

        // Token: 0x0400006E RID: 110
        [AccessedThroughProperty("txtConfigCleanup")]
        private TextBox _txtConfigCleanup;

        // Token: 0x0400006F RID: 111
        [AccessedThroughProperty("Label6")]
        private Label _Label6;

        // Token: 0x04000070 RID: 112
        [AccessedThroughProperty("btnBrowseConfigXMLPath")]
        private Button _btnBrowseConfigXMLPath;

        // Token: 0x04000071 RID: 113
        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        // Token: 0x04000072 RID: 114
        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        // Token: 0x04000073 RID: 115
        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        // Token: 0x04000074 RID: 116
        [AccessedThroughProperty("OpenFileDialog1")]
        private OpenFileDialog _OpenFileDialog1;

        // Token: 0x04000075 RID: 117
        [AccessedThroughProperty("FolderBrowserDialog1")]
        private FolderBrowserDialog _FolderBrowserDialog1;

        private void Form1_Load_1(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            if (Environment.UserName.ToUpper().ToString() != "E1897")
            {
                Application.Exit();
            }

            string uName = Environment.UserName.ToUpper().ToString();
            string licFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SmarterCleanup";
            if (!Directory.Exists(licFolder))
            {
                Directory.CreateDirectory(licFolder);
            }
            //
            string LicFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SmarterCleanup\\" + uName + ".lic";
            SKGL.Validate valid = new SKGL.Validate();
            if (File.Exists(LicFile))
            {
                string tSerial = File.ReadAllText(LicFile).Trim();
                valid.secretPhase = uName + valid.MachineCode.ToString() + "SC";
                valid.Key = tSerial;
                if (valid.IsValid)
                {
                    panel1.Visible = false;
                }
                else
                {
                    panel1.Visible = true;
                    textBox2.Text = uName + valid.MachineCode.ToString() + "SC";
                }
            }
            else
            {
                panel1.Visible = true;
                textBox2.Text = uName + valid.MachineCode.ToString() + "SC";
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] outs = Directory.GetFiles(textBox1.Text, "*.out", SearchOption.AllDirectories);
            int a = 0;
            progressBar1.Maximum = outs.Length;
            foreach (string o in outs)
            {
                string o_name = Path.GetFileNameWithoutExtension(o);
                string o_output = Path.GetDirectoryName(o) + "\\" + o_name + ".visf";
                clsCleanup clsCleanup = new clsCleanup();
                clsCleanup.Cleanup(o, o_output, "E1897.xml", o_name + ".log");
                rep_a0(o_output);
                progressBar1.Value = ++a;
            }
            MessageBox.Show("Cleaned " + outs.Length + " file(s).");
        }

        private void rep_a0(string f)
        {
            string read = File.ReadAllText(f, Encoding.GetEncoding("iso-8859-1"));
            string mystring = new string((char)160, 1);
            read = read.Replace("$IIbid$N.", "$IIbid.$N");
            read = read.Replace("$IId$N.", "$IId.$N");
            read = read.Replace("$Iibid$N.", "$Iibid.$N");
            read = read.Replace(mystring.ToString(), " ");
            read = read.Replace("$N., $I", "., ");
            read = read.Replace("$N, $I", ", ");
            File.WriteAllText(f, read, Encoding.GetEncoding("iso-8859-1"));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                SKGL.Validate valid = new SKGL.Validate();
                valid.secretPhase = Environment.UserName.ToUpper() + valid.MachineCode.ToString() + "SC";
                valid.Key = textBox2.Text;
                if (valid.IsValid)
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SmarterCleanup");
                    string LicFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\SmarterCleanup\\" + Environment.UserName.ToUpper() + ".lic";
                    using (StreamWriter sw = File.CreateText(LicFile))
                    {
                        sw.WriteLine(textBox2.Text);
                    }
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Invalid Key", "       o_O", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Invalid Key", "^_^", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // Token: 0x04000076 RID: 118

    }
}

