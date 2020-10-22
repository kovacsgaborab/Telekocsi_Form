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
            this.lbKimenet.Location = new System.Drawing.Point(127, 12);
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
            // FrmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
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

        }

        #endregion

        private System.Windows.Forms.Button Btbeolvasas;
        private System.Windows.Forms.ListBox lbKimenet;
        private System.Windows.Forms.Button BtnSecond;
        private System.Windows.Forms.Button BtnThird;
        private System.Windows.Forms.Button BtnFourth;
    }
}

