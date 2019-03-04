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
            this.txtIntrebare = new System.Windows.Forms.Label();
            this.lblRasp3 = new System.Windows.Forms.Label();
            this.lblRasp2 = new System.Windows.Forms.Label();
            this.lblRasp1 = new System.Windows.Forms.Label();
            this.gbRasp = new System.Windows.Forms.GroupBox();
            this.rbRasp2 = new System.Windows.Forms.RadioButton();
            this.rbRasp3 = new System.Windows.Forms.RadioButton();
            this.rbRasp1 = new System.Windows.Forms.RadioButton();
            this.btnInainte = new System.Windows.Forms.Button();
            this.btnVerificare = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTestNou = new System.Windows.Forms.Button();
            this.gbRasp.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIntrebare
            // 
            this.txtIntrebare.AutoSize = true;
            this.txtIntrebare.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIntrebare.Location = new System.Drawing.Point(329, 121);
            this.txtIntrebare.Name = "txtIntrebare";
            this.txtIntrebare.Size = new System.Drawing.Size(86, 31);
            this.txtIntrebare.TabIndex = 0;
            this.txtIntrebare.Text = "label1";
            this.txtIntrebare.Click += new System.EventHandler(this.txtIntrebare_Click);
            // 
            // lblRasp3
            // 
            this.lblRasp3.AutoSize = true;
            this.lblRasp3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRasp3.Location = new System.Drawing.Point(335, 47);
            this.lblRasp3.Name = "lblRasp3";
            this.lblRasp3.Size = new System.Drawing.Size(35, 13);
            this.lblRasp3.TabIndex = 1;
            this.lblRasp3.Text = "label1";
            // 
            // lblRasp2
            // 
            this.lblRasp2.AutoSize = true;
            this.lblRasp2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRasp2.Location = new System.Drawing.Point(186, 47);
            this.lblRasp2.Name = "lblRasp2";
            this.lblRasp2.Size = new System.Drawing.Size(35, 13);
            this.lblRasp2.TabIndex = 2;
            this.lblRasp2.Text = "label1";
            // 
            // lblRasp1
            // 
            this.lblRasp1.AutoSize = true;
            this.lblRasp1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRasp1.Location = new System.Drawing.Point(32, 47);
            this.lblRasp1.Name = "lblRasp1";
            this.lblRasp1.Size = new System.Drawing.Size(35, 13);
            this.lblRasp1.TabIndex = 3;
            this.lblRasp1.Text = "label1";
            // 
            // gbRasp
            // 
            this.gbRasp.Controls.Add(this.rbRasp3);
            this.gbRasp.Controls.Add(this.lblRasp3);
            this.gbRasp.Controls.Add(this.lblRasp2);
            this.gbRasp.Controls.Add(this.lblRasp1);
            this.gbRasp.Controls.Add(this.rbRasp1);
            this.gbRasp.Controls.Add(this.rbRasp2);
            this.gbRasp.Location = new System.Drawing.Point(167, 283);
            this.gbRasp.Name = "gbRasp";
            this.gbRasp.Size = new System.Drawing.Size(419, 60);
            this.gbRasp.TabIndex = 4;
            this.gbRasp.TabStop = false;
            this.gbRasp.Text = "groupBox1";
            // 
            // rbRasp2
            // 
            this.rbRasp2.AutoSize = true;
            this.rbRasp2.Location = new System.Drawing.Point(160, 19);
            this.rbRasp2.Name = "rbRasp2";
            this.rbRasp2.Size = new System.Drawing.Size(32, 17);
            this.rbRasp2.TabIndex = 5;
            this.rbRasp2.TabStop = true;
            this.rbRasp2.Text = "B";
            this.rbRasp2.UseVisualStyleBackColor = true;
            // 
            // rbRasp3
            // 
            this.rbRasp3.AutoSize = true;
            this.rbRasp3.Location = new System.Drawing.Point(306, 19);
            this.rbRasp3.Name = "rbRasp3";
            this.rbRasp3.Size = new System.Drawing.Size(32, 17);
            this.rbRasp3.TabIndex = 6;
            this.rbRasp3.TabStop = true;
            this.rbRasp3.Text = "C";
            this.rbRasp3.UseVisualStyleBackColor = true;
            // 
            // rbRasp1
            // 
            this.rbRasp1.AutoSize = true;
            this.rbRasp1.Location = new System.Drawing.Point(6, 19);
            this.rbRasp1.Name = "rbRasp1";
            this.rbRasp1.Size = new System.Drawing.Size(32, 17);
            this.rbRasp1.TabIndex = 7;
            this.rbRasp1.TabStop = true;
            this.rbRasp1.Text = "A";
            this.rbRasp1.UseVisualStyleBackColor = true;
            // 
            // btnInainte
            // 
            this.btnInainte.Location = new System.Drawing.Point(390, 448);
            this.btnInainte.Name = "btnInainte";
            this.btnInainte.Size = new System.Drawing.Size(126, 47);
            this.btnInainte.TabIndex = 5;
            this.btnInainte.Text = "Inainte";
            this.btnInainte.UseVisualStyleBackColor = true;
            // 
            // btnVerificare
            // 
            this.btnVerificare.Location = new System.Drawing.Point(250, 448);
            this.btnVerificare.Name = "btnVerificare";
            this.btnVerificare.Size = new System.Drawing.Size(134, 47);
            this.btnVerificare.TabIndex = 6;
            this.btnVerificare.Text = "Verificare";
            this.btnVerificare.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(110, 448);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 47);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnTestNou
            // 
            this.btnTestNou.Location = new System.Drawing.Point(522, 448);
            this.btnTestNou.Name = "btnTestNou";
            this.btnTestNou.Size = new System.Drawing.Size(126, 47);
            this.btnTestNou.TabIndex = 8;
            this.btnTestNou.Text = "Test Nou";
            this.btnTestNou.UseVisualStyleBackColor = true;
            this.btnTestNou.Click += new System.EventHandler(this.btnTestNou_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 567);
            this.Controls.Add(this.btnTestNou);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVerificare);
            this.Controls.Add(this.btnInainte);
            this.Controls.Add(this.gbRasp);
            this.Controls.Add(this.txtIntrebare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbRasp.ResumeLayout(false);
            this.gbRasp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtIntrebare;
        private System.Windows.Forms.Label lblRasp3;
        private System.Windows.Forms.Label lblRasp2;
        private System.Windows.Forms.Label lblRasp1;
        private System.Windows.Forms.GroupBox gbRasp;
        private System.Windows.Forms.RadioButton rbRasp3;
        private System.Windows.Forms.RadioButton rbRasp1;
        private System.Windows.Forms.RadioButton rbRasp2;
        private System.Windows.Forms.Button btnInainte;
        private System.Windows.Forms.Button btnVerificare;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTestNou;
    }
}

