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
            this.gbRasp.Location = new System.Drawing.Point(52, 96);
            this.gbRasp.Name = "gbRasp";
            this.gbRasp.Size = new System.Drawing.Size(275, 60);
            this.gbRasp.TabIndex = 4;
            this.gbRasp.TabStop = false;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(214, 19);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(32, 17);
            this.C.TabIndex = 6;
            this.C.TabStop = true;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(19, 19);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(32, 17);
            this.A.TabIndex = 7;
            this.A.TabStop = true;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(123, 19);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(32, 17);
            this.B.TabIndex = 5;
            this.B.TabStop = true;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // btnInainte
            // 
            this.btnInainte.Location = new System.Drawing.Point(191, 187);
            this.btnInainte.Name = "btnInainte";
            this.btnInainte.Size = new System.Drawing.Size(135, 47);
            this.btnInainte.TabIndex = 5;
            this.btnInainte.Text = "Inainte";
            this.btnInainte.UseVisualStyleBackColor = true;
            this.btnInainte.Click += new System.EventHandler(this.btnInainte_Click);
            // 
            // btnVerificare
            // 
            this.btnVerificare.Location = new System.Drawing.Point(191, 240);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(134, 47);
            this.btnVerificare.TabIndex = 6;
            this.btnVerificare.Text = "Verificare";
            this.btnVerificare.UseVisualStyleBackColor = true;
            // 
            // btnTestNou
            // 
            this.btnTestNou.Location = new System.Drawing.Point(51, 240);
            this.btnTestNou.Name = "btnTestNou";
            this.btnTestNou.Size = new System.Drawing.Size(135, 47);
            this.btnTestNou.TabIndex = 8;
            this.btnTestNou.Text = "Test Nou";
            this.btnTestNou.UseVisualStyleBackColor = true;
            this.btnTestNou.Click += new System.EventHandler(this.btnTestNou_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(51, 187);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(134, 47);
            this.btnInapoi.TabIndex = 9;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblIntrebare.Location = new System.Drawing.Point(52, 22);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(275, 54);
            this.lblIntrebare.TabIndex = 10;
            this.lblIntrebare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntrebare.Click += new System.EventHandler(this.lblIntrebare_Click);
            // 
            // lblNr
            // 
            this.lblNr.BackColor = System.Drawing.Color.Transparent;
            this.lblNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNr.Location = new System.Drawing.Point(9, 33);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(37, 32);
            this.lblNr.TabIndex = 11;
            this.lblNr.Text = "1";
            this.lblNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNr.Click += new System.EventHandler(this.lblNr_Click);
            // 
            // cbLectie
            // 
            this.cbLectie.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbLectie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbLectie.FormattingEnabled = true;
            this.cbLectie.Location = new System.Drawing.Point(362, 22);
            this.cbLectie.Name = "cbLectie";
            this.cbLectie.Size = new System.Drawing.Size(200, 21);
            this.cbLectie.TabIndex = 12;
            // 
            // gbOptiuni
            // 
            this.gbOptiuni.Controls.Add(this.label2);
            this.gbOptiuni.Controls.Add(this.btnConfirma);
            this.gbOptiuni.Controls.Add(this.numConfirma);
            this.gbOptiuni.Location = new System.Drawing.Point(362, 96);
            this.gbOptiuni.Name = "gbOptiuni";
            this.gbOptiuni.Size = new System.Drawing.Size(200, 138);
            this.gbOptiuni.TabIndex = 13;
            this.gbOptiuni.TabStop = false;
            this.gbOptiuni.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cate intrebari sa contina testul?";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(137, 89);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(57, 22);
            this.btnConfirma.TabIndex = 1;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // numConfirma
            // 
            this.numConfirma.Location = new System.Drawing.Point(11, 91);
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
            this.numConfirma.Size = new System.Drawing.Size(120, 20);
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
            this.lstIntrebare.Items.AddRange(new object[] {
            "asdf",
            "as",
            "as",
            "a",
            "sa",
            "s"});
            this.lstIntrebare.Location = new System.Drawing.Point(52, 417);
            this.lstIntrebare.Name = "lstIntrebare";
            this.lstIntrebare.Size = new System.Drawing.Size(95, 160);
            this.lstIntrebare.TabIndex = 14;
            this.lstIntrebare.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstRaspuns
            // 
            this.lstRaspuns.FormattingEnabled = true;
            this.lstRaspuns.Location = new System.Drawing.Point(153, 417);
            this.lstRaspuns.Name = "lstRaspuns";
            this.lstRaspuns.Size = new System.Drawing.Size(95, 160);
            this.lstRaspuns.TabIndex = 15;
            this.lstRaspuns.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f"});
            this.lstA.Location = new System.Drawing.Point(254, 417);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(95, 160);
            this.lstA.TabIndex = 16;
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.Items.AddRange(new object[] {
            "b",
            "c",
            "d",
            "e",
            "f",
            "g"});
            this.lstB.Location = new System.Drawing.Point(355, 417);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(95, 160);
            this.lstB.TabIndex = 17;
            // 
            // lstC
            // 
            this.lstC.FormattingEnabled = true;
            this.lstC.Items.AddRange(new object[] {
            "c",
            "d",
            "e",
            "f",
            "g",
            "h"});
            this.lstC.Location = new System.Drawing.Point(456, 417);
            this.lstC.Name = "lstC";
            this.lstC.Size = new System.Drawing.Size(95, 160);
            this.lstC.TabIndex = 18;
            // 
            // lstCorect
            // 
            this.lstCorect.FormattingEnabled = true;
            this.lstCorect.Location = new System.Drawing.Point(557, 417);
            this.lstCorect.Name = "lstCorect";
            this.lstCorect.Size = new System.Drawing.Size(95, 160);
            this.lstCorect.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 589);
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

