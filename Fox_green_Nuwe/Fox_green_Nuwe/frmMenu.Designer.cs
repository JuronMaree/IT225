namespace Fox_green_Nuwe
{
    partial class frmMenu
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
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnNuweKliente = new System.Windows.Forms.Button();
            this.btnVerhuurings = new System.Windows.Forms.Button();
            this.btnVerkope = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(346, 313);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(150, 59);
            this.btnOptions.TabIndex = 9;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click_1);
            // 
            // btnNuweKliente
            // 
            this.btnNuweKliente.Location = new System.Drawing.Point(346, 256);
            this.btnNuweKliente.Name = "btnNuweKliente";
            this.btnNuweKliente.Size = new System.Drawing.Size(150, 51);
            this.btnNuweKliente.TabIndex = 8;
            this.btnNuweKliente.Text = "Kliente";
            this.btnNuweKliente.UseVisualStyleBackColor = true;
            this.btnNuweKliente.Click += new System.EventHandler(this.btnNuweKliente_Click_1);
            // 
            // btnVerhuurings
            // 
            this.btnVerhuurings.Location = new System.Drawing.Point(346, 193);
            this.btnVerhuurings.Name = "btnVerhuurings";
            this.btnVerhuurings.Size = new System.Drawing.Size(150, 57);
            this.btnVerhuurings.TabIndex = 7;
            this.btnVerhuurings.Text = "Verhuuring";
            this.btnVerhuurings.UseVisualStyleBackColor = true;
            // 
            // btnVerkope
            // 
            this.btnVerkope.Location = new System.Drawing.Point(346, 136);
            this.btnVerkope.Name = "btnVerkope";
            this.btnVerkope.Size = new System.Drawing.Size(150, 51);
            this.btnVerkope.TabIndex = 6;
            this.btnVerkope.Text = "VErkope";
            this.btnVerkope.UseVisualStyleBackColor = true;
            this.btnVerkope.Click += new System.EventHandler(this.btnVerkope_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(346, 79);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(150, 51);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnNuweKliente);
            this.Controls.Add(this.btnVerhuurings);
            this.Controls.Add(this.btnVerkope);
            this.Controls.Add(this.btnAdmin);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnNuweKliente;
        private System.Windows.Forms.Button btnVerhuurings;
        private System.Windows.Forms.Button btnVerkope;
        private System.Windows.Forms.Button btnAdmin;
    }
}