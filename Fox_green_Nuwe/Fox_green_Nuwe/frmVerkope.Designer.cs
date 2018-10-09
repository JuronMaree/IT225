namespace Fox_green_Nuwe
{
    partial class frmVerkope
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eiendomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiedomAantalBadkamersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiedomAantalSlaapkamersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiendomPrysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiedomSwembadDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.eiedomGaragesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiedomAantalVloereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiedomOppervlakteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiedomTipePlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiedomAdisioneleInligtingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eiendomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foxgreenDatabaseDataSet = new Fox_green_Nuwe.FoxgreenDatabaseDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eiendomTableAdapter = new Fox_green_Nuwe.FoxgreenDatabaseDataSetTableAdapters.EiendomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eiendomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxgreenDatabaseDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 50);
            this.button2.TabIndex = 11;
            this.button2.Text = "Verander Current selected";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nuwe Huis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eiendomIDDataGridViewTextBoxColumn,
            this.areaIDDataGridViewTextBoxColumn,
            this.agentIDDataGridViewTextBoxColumn,
            this.klientIDDataGridViewTextBoxColumn,
            this.adresIDDataGridViewTextBoxColumn,
            this.eiedomAantalBadkamersDataGridViewTextBoxColumn,
            this.eiedomAantalSlaapkamersDataGridViewTextBoxColumn,
            this.eiendomPrysDataGridViewTextBoxColumn,
            this.eiedomSwembadDataGridViewCheckBoxColumn,
            this.eiedomGaragesDataGridViewTextBoxColumn,
            this.eiedomAantalVloereDataGridViewTextBoxColumn,
            this.eiedomOppervlakteDataGridViewTextBoxColumn,
            this.eiedomTipePlanDataGridViewTextBoxColumn,
            this.eiedomAdisioneleInligtingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eiendomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 290);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // eiendomIDDataGridViewTextBoxColumn
            // 
            this.eiendomIDDataGridViewTextBoxColumn.DataPropertyName = "EiendomID";
            this.eiendomIDDataGridViewTextBoxColumn.HeaderText = "EiendomID";
            this.eiendomIDDataGridViewTextBoxColumn.Name = "eiendomIDDataGridViewTextBoxColumn";
            // 
            // areaIDDataGridViewTextBoxColumn
            // 
            this.areaIDDataGridViewTextBoxColumn.DataPropertyName = "AreaID";
            this.areaIDDataGridViewTextBoxColumn.HeaderText = "AreaID";
            this.areaIDDataGridViewTextBoxColumn.Name = "areaIDDataGridViewTextBoxColumn";
            // 
            // agentIDDataGridViewTextBoxColumn
            // 
            this.agentIDDataGridViewTextBoxColumn.DataPropertyName = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.HeaderText = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.Name = "agentIDDataGridViewTextBoxColumn";
            // 
            // klientIDDataGridViewTextBoxColumn
            // 
            this.klientIDDataGridViewTextBoxColumn.DataPropertyName = "KlientID";
            this.klientIDDataGridViewTextBoxColumn.HeaderText = "KlientID";
            this.klientIDDataGridViewTextBoxColumn.Name = "klientIDDataGridViewTextBoxColumn";
            // 
            // adresIDDataGridViewTextBoxColumn
            // 
            this.adresIDDataGridViewTextBoxColumn.DataPropertyName = "AdresID";
            this.adresIDDataGridViewTextBoxColumn.HeaderText = "AdresID";
            this.adresIDDataGridViewTextBoxColumn.Name = "adresIDDataGridViewTextBoxColumn";
            // 
            // eiedomAantalBadkamersDataGridViewTextBoxColumn
            // 
            this.eiedomAantalBadkamersDataGridViewTextBoxColumn.DataPropertyName = "EiedomAantalBadkamers";
            this.eiedomAantalBadkamersDataGridViewTextBoxColumn.HeaderText = "EiedomAantalBadkamers";
            this.eiedomAantalBadkamersDataGridViewTextBoxColumn.Name = "eiedomAantalBadkamersDataGridViewTextBoxColumn";
            // 
            // eiedomAantalSlaapkamersDataGridViewTextBoxColumn
            // 
            this.eiedomAantalSlaapkamersDataGridViewTextBoxColumn.DataPropertyName = "EiedomAantalSlaapkamers";
            this.eiedomAantalSlaapkamersDataGridViewTextBoxColumn.HeaderText = "EiedomAantalSlaapkamers";
            this.eiedomAantalSlaapkamersDataGridViewTextBoxColumn.Name = "eiedomAantalSlaapkamersDataGridViewTextBoxColumn";
            // 
            // eiendomPrysDataGridViewTextBoxColumn
            // 
            this.eiendomPrysDataGridViewTextBoxColumn.DataPropertyName = "EiendomPrys";
            this.eiendomPrysDataGridViewTextBoxColumn.HeaderText = "EiendomPrys";
            this.eiendomPrysDataGridViewTextBoxColumn.Name = "eiendomPrysDataGridViewTextBoxColumn";
            // 
            // eiedomSwembadDataGridViewCheckBoxColumn
            // 
            this.eiedomSwembadDataGridViewCheckBoxColumn.DataPropertyName = "EiedomSwembad";
            this.eiedomSwembadDataGridViewCheckBoxColumn.HeaderText = "EiedomSwembad";
            this.eiedomSwembadDataGridViewCheckBoxColumn.Name = "eiedomSwembadDataGridViewCheckBoxColumn";
            // 
            // eiedomGaragesDataGridViewTextBoxColumn
            // 
            this.eiedomGaragesDataGridViewTextBoxColumn.DataPropertyName = "EiedomGarages";
            this.eiedomGaragesDataGridViewTextBoxColumn.HeaderText = "EiedomGarages";
            this.eiedomGaragesDataGridViewTextBoxColumn.Name = "eiedomGaragesDataGridViewTextBoxColumn";
            // 
            // eiedomAantalVloereDataGridViewTextBoxColumn
            // 
            this.eiedomAantalVloereDataGridViewTextBoxColumn.DataPropertyName = "EiedomAantalVloere";
            this.eiedomAantalVloereDataGridViewTextBoxColumn.HeaderText = "EiedomAantalVloere";
            this.eiedomAantalVloereDataGridViewTextBoxColumn.Name = "eiedomAantalVloereDataGridViewTextBoxColumn";
            // 
            // eiedomOppervlakteDataGridViewTextBoxColumn
            // 
            this.eiedomOppervlakteDataGridViewTextBoxColumn.DataPropertyName = "EiedomOppervlakte";
            this.eiedomOppervlakteDataGridViewTextBoxColumn.HeaderText = "EiedomOppervlakte";
            this.eiedomOppervlakteDataGridViewTextBoxColumn.Name = "eiedomOppervlakteDataGridViewTextBoxColumn";
            // 
            // eiedomTipePlanDataGridViewTextBoxColumn
            // 
            this.eiedomTipePlanDataGridViewTextBoxColumn.DataPropertyName = "EiedomTipePlan";
            this.eiedomTipePlanDataGridViewTextBoxColumn.HeaderText = "EiedomTipePlan";
            this.eiedomTipePlanDataGridViewTextBoxColumn.Name = "eiedomTipePlanDataGridViewTextBoxColumn";
            // 
            // eiedomAdisioneleInligtingDataGridViewTextBoxColumn
            // 
            this.eiedomAdisioneleInligtingDataGridViewTextBoxColumn.DataPropertyName = "EiedomAdisioneleInligting";
            this.eiedomAdisioneleInligtingDataGridViewTextBoxColumn.HeaderText = "EiedomAdisioneleInligting";
            this.eiedomAdisioneleInligtingDataGridViewTextBoxColumn.Name = "eiedomAdisioneleInligtingDataGridViewTextBoxColumn";
            // 
            // eiendomBindingSource
            // 
            this.eiendomBindingSource.DataMember = "Eiendom";
            this.eiendomBindingSource.DataSource = this.foxgreenDatabaseDataSet;
            // 
            // foxgreenDatabaseDataSet
            // 
            this.foxgreenDatabaseDataSet.DataSetName = "FoxgreenDatabaseDataSet";
            this.foxgreenDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.MenuToolStripMenuItem.Text = "Menu";
            this.MenuToolStripMenuItem.Click += new System.EventHandler(this.verhuringsToolStripMenuItem_Click);
            // 
            // eiendomTableAdapter
            // 
            this.eiendomTableAdapter.ClearBeforeFill = true;
            // 
            // frmVerkope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(775, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmVerkope";
            this.Text = "frmVerkope";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eiendomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxgreenDatabaseDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private FoxgreenDatabaseDataSet foxgreenDatabaseDataSet;
        private System.Windows.Forms.BindingSource eiendomBindingSource;
        private FoxgreenDatabaseDataSetTableAdapters.EiendomTableAdapter eiendomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiendomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiedomAantalBadkamersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiedomAantalSlaapkamersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiendomPrysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eiedomSwembadDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiedomGaragesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiedomAantalVloereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiedomOppervlakteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiedomTipePlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eiedomAdisioneleInligtingDataGridViewTextBoxColumn;
    }
}