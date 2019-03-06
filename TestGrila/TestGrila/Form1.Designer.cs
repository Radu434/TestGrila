namespace TestGrila
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
            this.gbRasp = new System.Windows.Forms.GroupBox();
            this.C = new System.Windows.Forms.RadioButton();
            this.A = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.btnInainte = new System.Windows.Forms.Button();
            this.btnVerificare = new System.Windows.Forms.Button();
            this.btnTestNou = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.cbLectie = new System.Windows.Forms.ComboBox();
            this.gbOptiuni = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.numConfirma = new System.Windows.Forms.NumericUpDown();
            this.lstIntrebare = new System.Windows.Forms.ListBox();
            this.lstRaspuns = new System.Windows.Forms.ListBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.lstC = new System.Windows.Forms.ListBox();
            this.lstCorect = new System.Windows.Forms.ListBox();
            this.gbRasp.SuspendLayout();
            this.gbOptiuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConfirma)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRasp
            // 
            this.gbRasp.Controls.Add(this.C);
            this.gbRasp.Controls.Add(this.A);
            this.gbRasp.Controls.Add(this.B);
            this.gbRasp.Location = new System.Drawing.Point(69, 118);
            this.gbRasp.Margin = new System.Windows.Forms.Padding(4);
            this.gbRasp.Name = "gbRasp";
            this.gbRasp.Padding = new System.Windows.Forms.Padding(4);
            this.gbRasp.Size = new System.Drawing.Size(367, 74);
            this.gbRasp.TabIndex = 4;
            this.gbRasp.TabStop = false;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(285, 23);
            this.C.Margin = new System.Windows.Forms.Padding(4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(38, 21);
            this.C.TabIndex = 6;
            this.C.TabStop = true;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(25, 23);
            this.A.Margin = new System.Windows.Forms.Padding(4);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(38, 21);
            this.A.TabIndex = 7;
            this.A.TabStop = true;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(164, 23);
            this.B.Margin = new System.Windows.Forms.Padding(4);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(38, 21);
            this.B.TabIndex = 5;
            this.B.TabStop = true;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // btnInainte
            // 
            this.btnInainte.Location = new System.Drawing.Point(255, 230);
            this.btnInainte.Margin = new System.Windows.Forms.Padding(4);
            this.btnInainte.Name = "btnInainte";
            this.btnInainte.Size = new System.Drawing.Size(180, 58);
            this.btnInainte.TabIndex = 5;
            this.btnInainte.Text = "Inainte";
            this.btnInainte.UseVisualStyleBackColor = true;
            this.btnInainte.Click += new System.EventHandler(this.btnInainte_Click);
            // 
            // btnVerificare
            // 
            this.btnVerificare.Location = new System.Drawing.Point(255, 295);
            this.btnVerificare.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(179, 58);
            this.btnVerificare.TabIndex = 6;
            this.btnVerificare.Text = "Verificare";
            this.btnVerificare.UseVisualStyleBackColor = true;
            // 
            // btnTestNou
            // 
            this.btnTestNou.Location = new System.Drawing.Point(68, 295);
            this.btnTestNou.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestNou.Name = "btnTestNou";
            this.btnTestNou.Size = new System.Drawing.Size(180, 58);
            this.btnTestNou.TabIndex = 8;
            this.btnTestNou.Text = "Test Nou";
            this.btnTestNou.UseVisualStyleBackColor = true;
            this.btnTestNou.Click += new System.EventHandler(this.btnTestNou_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(68, 230);
            this.btnInapoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(179, 58);
            this.btnInapoi.TabIndex = 9;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblIntrebare.Location = new System.Drawing.Point(69, 27);
            this.lblIntrebare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(367, 66);
            this.lblIntrebare.TabIndex = 10;
            this.lblIntrebare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntrebare.Click += new System.EventHandler(this.lblIntrebare_Click);
            // 
            // lblNr
            // 
            this.lblNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNr.Location = new System.Drawing.Point(12, 41);
            this.lblNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(49, 39);
            this.lblNr.TabIndex = 11;
            this.lblNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNr.Click += new System.EventHandler(this.lblNr_Click);
            // 
            // cbLectie
            // 
            this.cbLectie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbLectie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLectie.FormattingEnabled = true;
            this.cbLectie.Location = new System.Drawing.Point(483, 27);
            this.cbLectie.Margin = new System.Windows.Forms.Padding(4);
            this.cbLectie.Name = "cbLectie";
            this.cbLectie.Size = new System.Drawing.Size(265, 24);
            this.cbLectie.TabIndex = 12;
            // 
            // gbOptiuni
            // 
            this.gbOptiuni.Controls.Add(this.label2);
            this.gbOptiuni.Controls.Add(this.btnConfirma);
            this.gbOptiuni.Controls.Add(this.numConfirma);
            this.gbOptiuni.Location = new System.Drawing.Point(483, 118);
            this.gbOptiuni.Margin = new System.Windows.Forms.Padding(4);
            this.gbOptiuni.Name = "gbOptiuni";
            this.gbOptiuni.Padding = new System.Windows.Forms.Padding(4);
            this.gbOptiuni.Size = new System.Drawing.Size(267, 170);
            this.gbOptiuni.TabIndex = 13;
            this.gbOptiuni.TabStop = false;
            this.gbOptiuni.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cate intrebari sa contina testul?";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(183, 110);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(76, 27);
            this.btnConfirma.TabIndex = 1;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // numConfirma
            // 
            this.numConfirma.Location = new System.Drawing.Point(15, 112);
            this.numConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.numConfirma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numConfirma.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numConfirma.Name = "numConfirma";
            this.numConfirma.Size = new System.Drawing.Size(160, 22);
            this.numConfirma.TabIndex = 0;
            this.numConfirma.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lstIntrebare
            // 
            this.lstIntrebare.FormattingEnabled = true;
            this.lstIntrebare.ItemHeight = 16;
            this.lstIntrebare.Items.AddRange(new object[] {
            "asdf"});
            this.lstIntrebare.Location = new System.Drawing.Point(69, 513);
            this.lstIntrebare.Margin = new System.Windows.Forms.Padding(4);
            this.lstIntrebare.Name = "lstIntrebare";
            this.lstIntrebare.Size = new System.Drawing.Size(125, 196);
            this.lstIntrebare.TabIndex = 14;
            this.lstIntrebare.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstRaspuns
            // 
            this.lstRaspuns.FormattingEnabled = true;
            this.lstRaspuns.ItemHeight = 16;
            this.lstRaspuns.Location = new System.Drawing.Point(204, 513);
            this.lstRaspuns.Margin = new System.Windows.Forms.Padding(4);
            this.lstRaspuns.Name = "lstRaspuns";
            this.lstRaspuns.Size = new System.Drawing.Size(125, 196);
            this.lstRaspuns.TabIndex = 15;
            this.lstRaspuns.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 16;
            this.lstA.Items.AddRange(new object[] {
            "a"});
            this.lstA.Location = new System.Drawing.Point(339, 513);
            this.lstA.Margin = new System.Windows.Forms.Padding(4);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(125, 196);
            this.lstA.TabIndex = 16;
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 16;
            this.lstB.Items.AddRange(new object[] {
            "b"});
            this.lstB.Location = new System.Drawing.Point(473, 513);
            this.lstB.Margin = new System.Windows.Forms.Padding(4);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(125, 196);
            this.lstB.TabIndex = 17;
            // 
            // lstC
            // 
            this.lstC.FormattingEnabled = true;
            this.lstC.ItemHeight = 16;
            this.lstC.Items.AddRange(new object[] {
            "c"});
            this.lstC.Location = new System.Drawing.Point(608, 513);
            this.lstC.Margin = new System.Windows.Forms.Padding(4);
            this.lstC.Name = "lstC";
            this.lstC.Size = new System.Drawing.Size(125, 196);
            this.lstC.TabIndex = 18;
            // 
            // lstCorect
            // 
            this.lstCorect.FormattingEnabled = true;
            this.lstCorect.ItemHeight = 16;
            this.lstCorect.Location = new System.Drawing.Point(743, 513);
            this.lstCorect.Margin = new System.Windows.Forms.Padding(4);
            this.lstCorect.Name = "lstCorect";
            this.lstCorect.Size = new System.Drawing.Size(125, 196);
            this.lstCorect.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 725);
            this.Controls.Add(this.lstCorect);
            this.Controls.Add(this.lstC);
            this.Controls.Add(this.lstB);
            this.Controls.Add(this.lstA);
            this.Controls.Add(this.lstRaspuns);
            this.Controls.Add(this.lstIntrebare);
            this.Controls.Add(this.gbOptiuni);
            this.Controls.Add(this.cbLectie);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnTestNou);
            this.Controls.Add(this.btnVerificare);
            this.Controls.Add(this.btnInainte);
            this.Controls.Add(this.gbRasp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbRasp.ResumeLayout(false);
            this.gbRasp.PerformLayout();
            this.gbOptiuni.ResumeLayout(false);
            this.gbOptiuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConfirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbRasp;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.Button btnInainte;
        private System.Windows.Forms.Button btnVerificare;
        private System.Windows.Forms.Button btnTestNou;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.ComboBox cbLectie;
        private System.Windows.Forms.GroupBox gbOptiuni;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.NumericUpDown numConfirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstIntrebare;
        private System.Windows.Forms.ListBox lstRaspuns;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.ListBox lstC;
        private System.Windows.Forms.ListBox lstCorect;
    }
}

