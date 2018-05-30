namespace HonestTomatoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CountTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NoStarChk = new System.Windows.Forms.CheckBox();
            this.HalfStarChk = new System.Windows.Forms.CheckBox();
            this.NoStarTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HalfStarTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StarTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.URLParseTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GObtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DebugOut = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CountTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NoStarTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.HalfStarTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.StarTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.URLParseTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 170);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // CountTxt
            // 
            this.CountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountTxt.Location = new System.Drawing.Point(105, 52);
            this.CountTxt.Name = "CountTxt";
            this.CountTxt.Size = new System.Drawing.Size(665, 22);
            this.CountTxt.TabIndex = 50;
            this.CountTxt.Text = "row review_table_row";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "CountText:";
            // 
            // NoStarChk
            // 
            this.NoStarChk.AutoSize = true;
            this.NoStarChk.Location = new System.Drawing.Point(229, 49);
            this.NoStarChk.Name = "NoStarChk";
            this.NoStarChk.Size = new System.Drawing.Size(271, 21);
            this.NoStarChk.TabIndex = 20;
            this.NoStarChk.Text = "Include \"No Interest\" as 0 Star Ratings";
            this.NoStarChk.UseVisualStyleBackColor = true;
            // 
            // HalfStarChk
            // 
            this.HalfStarChk.AutoSize = true;
            this.HalfStarChk.Checked = true;
            this.HalfStarChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HalfStarChk.Location = new System.Drawing.Point(42, 49);
            this.HalfStarChk.Name = "HalfStarChk";
            this.HalfStarChk.Size = new System.Drawing.Size(181, 21);
            this.HalfStarChk.TabIndex = 10;
            this.HalfStarChk.Text = "Include 1/2 Star Ratings";
            this.HalfStarChk.UseVisualStyleBackColor = true;
            // 
            // NoStarTxt
            // 
            this.NoStarTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoStarTxt.Location = new System.Drawing.Point(105, 136);
            this.NoStarTxt.Name = "NoStarTxt";
            this.NoStarTxt.Size = new System.Drawing.Size(665, 22);
            this.NoStarTxt.TabIndex = 80;
            this.NoStarTxt.Text = "ni.png";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "0 Star Text:";
            // 
            // HalfStarTxt
            // 
            this.HalfStarTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HalfStarTxt.Location = new System.Drawing.Point(105, 108);
            this.HalfStarTxt.Name = "HalfStarTxt";
            this.HalfStarTxt.Size = new System.Drawing.Size(665, 22);
            this.HalfStarTxt.TabIndex = 70;
            this.HalfStarTxt.Text = "&frac12;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "1/2 Star Text:";
            // 
            // StarTxt
            // 
            this.StarTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StarTxt.Location = new System.Drawing.Point(105, 80);
            this.StarTxt.Name = "StarTxt";
            this.StarTxt.Size = new System.Drawing.Size(665, 22);
            this.StarTxt.TabIndex = 60;
            this.StarTxt.Text = "glyphicon-star\"></span>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Star Text:";
            // 
            // URLParseTxt
            // 
            this.URLParseTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLParseTxt.Location = new System.Drawing.Point(105, 24);
            this.URLParseTxt.Name = "URLParseTxt";
            this.URLParseTxt.Size = new System.Drawing.Size(665, 22);
            this.URLParseTxt.TabIndex = 40;
            this.URLParseTxt.Text = "https://www.rottentomatoes.com/m/[ID]/reviews/?page=[PAGE]&type=user&sort=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL Parse:";
            // 
            // IDTxt
            // 
            this.IDTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDTxt.Location = new System.Drawing.Point(42, 21);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(647, 22);
            this.IDTxt.TabIndex = 0;
            this.IDTxt.Text = "star_wars_the_last_jedi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID:";
            // 
            // GObtn
            // 
            this.GObtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GObtn.Location = new System.Drawing.Point(695, 21);
            this.GObtn.Name = "GObtn";
            this.GObtn.Size = new System.Drawing.Size(75, 49);
            this.GObtn.TabIndex = 30;
            this.GObtn.Text = "GO";
            this.GObtn.UseVisualStyleBackColor = true;
            this.GObtn.Click += new System.EventHandler(this.GObtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DebugOut);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 227);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.IDTxt);
            this.groupBox3.Controls.Add(this.NoStarChk);
            this.groupBox3.Controls.Add(this.GObtn);
            this.groupBox3.Controls.Add(this.HalfStarChk);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 79);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // DebugOut
            // 
            this.DebugOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DebugOut.Location = new System.Drawing.Point(9, 21);
            this.DebugOut.Multiline = true;
            this.DebugOut.Name = "DebugOut";
            this.DebugOut.ReadOnly = true;
            this.DebugOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DebugOut.Size = new System.Drawing.Size(761, 200);
            this.DebugOut.TabIndex = 35;
            this.DebugOut.Text = resources.GetString("DebugOut.Text");
            this.DebugOut.WordWrap = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Honest Tomatoes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox NoStarChk;
        private System.Windows.Forms.CheckBox HalfStarChk;
        private System.Windows.Forms.TextBox NoStarTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HalfStarTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StarTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox URLParseTxt;
        private System.Windows.Forms.TextBox CountTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GObtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox DebugOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

