namespace Telekocsi_Form
{
    partial class FrmFo
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
            this.Btbeolvasas = new System.Windows.Forms.Button();
            this.lbKimenet = new System.Windows.Forms.ListBox();
            this.BtnSecond = new System.Windows.Forms.Button();
            this.BtnThird = new System.Windows.Forms.Button();
            this.BtnFourth = new System.Windows.Forms.Button();
            this.BtnFifth = new System.Windows.Forms.Button();
            this.BtnSixth = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btbeolvasas
            // 
            this.Btbeolvasas.Location = new System.Drawing.Point(12, 12);
            this.Btbeolvasas.Name = "Btbeolvasas";
            this.Btbeolvasas.Size = new System.Drawing.Size(109, 36);
            this.Btbeolvasas.TabIndex = 0;
            this.Btbeolvasas.Text = "Beolvasás";
            this.Btbeolvasas.UseVisualStyleBackColor = true;
            this.Btbeolvasas.Click += new System.EventHandler(this.Btbeolvasas_Click);
            // 
            // lbKimenet
            // 
            this.lbKimenet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbKimenet.FormattingEnabled = true;
            this.lbKimenet.ItemHeight = 16;
            this.lbKimenet.Location = new System.Drawing.Point(127, 54);
            this.lbKimenet.Name = "lbKimenet";
            this.lbKimenet.Size = new System.Drawing.Size(451, 276);
            this.lbKimenet.TabIndex = 1;
            // 
            // BtnSecond
            // 
            this.BtnSecond.Enabled = false;
            this.BtnSecond.Location = new System.Drawing.Point(12, 54);
            this.BtnSecond.Name = "BtnSecond";
            this.BtnSecond.Size = new System.Drawing.Size(109, 36);
            this.BtnSecond.TabIndex = 2;
            this.BtnSecond.Text = "2. feladat";
            this.BtnSecond.UseVisualStyleBackColor = true;
            this.BtnSecond.Click += new System.EventHandler(this.BtnSecond_Click);
            // 
            // BtnThird
            // 
            this.BtnThird.Enabled = false;
            this.BtnThird.Location = new System.Drawing.Point(12, 96);
            this.BtnThird.Name = "BtnThird";
            this.BtnThird.Size = new System.Drawing.Size(109, 36);
            this.BtnThird.TabIndex = 3;
            this.BtnThird.Text = "3. feladat";
            this.BtnThird.UseVisualStyleBackColor = true;
            this.BtnThird.Click += new System.EventHandler(this.BtnThird_Click);
            // 
            // BtnFourth
            // 
            this.BtnFourth.Enabled = false;
            this.BtnFourth.Location = new System.Drawing.Point(12, 138);
            this.BtnFourth.Name = "BtnFourth";
            this.BtnFourth.Size = new System.Drawing.Size(109, 36);
            this.BtnFourth.TabIndex = 4;
            this.BtnFourth.Text = "4. feladat";
            this.BtnFourth.UseVisualStyleBackColor = true;
            this.BtnFourth.Click += new System.EventHandler(this.BtnFourth_Click);
            // 
            // BtnFifth
            // 
            this.BtnFifth.Enabled = false;
            this.BtnFifth.Location = new System.Drawing.Point(12, 180);
            this.BtnFifth.Name = "BtnFifth";
            this.BtnFifth.Size = new System.Drawing.Size(109, 36);
            this.BtnFifth.TabIndex = 5;
            this.BtnFifth.Text = "5. feladat";
            this.BtnFifth.UseVisualStyleBackColor = true;
            this.BtnFifth.Click += new System.EventHandler(this.BtnFifth_Click);
            // 
            // BtnSixth
            // 
            this.BtnSixth.Enabled = false;
            this.BtnSixth.Location = new System.Drawing.Point(12, 222);
            this.BtnSixth.Name = "BtnSixth";
            this.BtnSixth.Size = new System.Drawing.Size(109, 36);
            this.BtnSixth.TabIndex = 6;
            this.BtnSixth.Text = "6. feladat";
            this.BtnSixth.UseVisualStyleBackColor = true;
            this.BtnSixth.Click += new System.EventHandler(this.BtnSixth_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 293);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(109, 37);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Kilépés";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Feladatok kimenete";
            // 
            // FrmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnSixth);
            this.Controls.Add(this.BtnFifth);
            this.Controls.Add(this.BtnFourth);
            this.Controls.Add(this.BtnThird);
            this.Controls.Add(this.BtnSecond);
            this.Controls.Add(this.lbKimenet);
            this.Controls.Add(this.Btbeolvasas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telekocsi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btbeolvasas;
        private System.Windows.Forms.ListBox lbKimenet;
        private System.Windows.Forms.Button BtnSecond;
        private System.Windows.Forms.Button BtnThird;
        private System.Windows.Forms.Button BtnFourth;
        private System.Windows.Forms.Button BtnFifth;
        private System.Windows.Forms.Button BtnSixth;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
    }
}

