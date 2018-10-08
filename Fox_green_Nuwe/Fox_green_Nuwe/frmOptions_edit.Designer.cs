namespace Fox_green_Nuwe
{
    partial class frmOptions_edit
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
            this.txtTelefoon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.Label();
            this.txtEpos = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresNaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTelefoon
            // 
            this.txtTelefoon.Location = new System.Drawing.Point(325, 244);
            this.txtTelefoon.Name = "txtTelefoon";
            this.txtTelefoon.Size = new System.Drawing.Size(279, 20);
            this.txtTelefoon.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 144;
            this.label7.Text = "Telefoon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 141;
            this.label3.Text = "E-pos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 140;
            this.label2.Text = "Adress : StraatNommer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 139;
            this.label1.Text = "Van";
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(197, 89);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(35, 13);
            this.sd.TabIndex = 138;
            this.sd.Text = "Naam";
            // 
            // txtEpos
            // 
            this.txtEpos.Location = new System.Drawing.Point(325, 192);
            this.txtEpos.Name = "txtEpos";
            this.txtEpos.Size = new System.Drawing.Size(279, 20);
            this.txtEpos.TabIndex = 136;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(325, 138);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(279, 20);
            this.txtAdress.TabIndex = 135;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(325, 112);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(279, 20);
            this.txtSurname.TabIndex = 134;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(325, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(279, 20);
            this.txtName.TabIndex = 133;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 132;
            this.button2.Text = "Change Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 131;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 147;
            this.label4.Text = "Adress : Straat Naam";
            // 
            // txtAdresNaam
            // 
            this.txtAdresNaam.Location = new System.Drawing.Point(325, 164);
            this.txtAdresNaam.Name = "txtAdresNaam";
            this.txtAdresNaam.Size = new System.Drawing.Size(279, 20);
            this.txtAdresNaam.TabIndex = 146;
            // 
            // frmOptions_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresNaam);
            this.Controls.Add(this.txtTelefoon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.txtEpos);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmOptions_edit";
            this.Text = "frmOptions_edit";
            this.Load += new System.EventHandler(this.frmOptions_edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTelefoon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.TextBox txtEpos;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresNaam;
    }
}