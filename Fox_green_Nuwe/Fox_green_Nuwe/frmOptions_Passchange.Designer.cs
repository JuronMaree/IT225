namespace Fox_green_Nuwe
{
    partial class frmOptions_Passchange
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHerhaal = new System.Windows.Forms.TextBox();
            this.txtNuwe = new System.Windows.Forms.TextBox();
            this.txtOud = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Herhaal nuwe wagwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nuwe wagwoord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ou wagwoord";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "Verander wagwoord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHerhaal
            // 
            this.txtHerhaal.Location = new System.Drawing.Point(200, 142);
            this.txtHerhaal.Name = "txtHerhaal";
            this.txtHerhaal.Size = new System.Drawing.Size(140, 20);
            this.txtHerhaal.TabIndex = 16;
            // 
            // txtNuwe
            // 
            this.txtNuwe.Location = new System.Drawing.Point(201, 116);
            this.txtNuwe.Name = "txtNuwe";
            this.txtNuwe.Size = new System.Drawing.Size(140, 20);
            this.txtNuwe.TabIndex = 15;
            // 
            // txtOud
            // 
            this.txtOud.Location = new System.Drawing.Point(201, 64);
            this.txtOud.Name = "txtOud";
            this.txtOud.Size = new System.Drawing.Size(140, 20);
            this.txtOud.TabIndex = 14;
            // 
            // frmOptions_Passchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(425, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHerhaal);
            this.Controls.Add(this.txtNuwe);
            this.Controls.Add(this.txtOud);
            this.Name = "frmOptions_Passchange";
            this.Text = "frmOptions_Passchange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHerhaal;
        private System.Windows.Forms.TextBox txtNuwe;
        private System.Windows.Forms.TextBox txtOud;
    }
}