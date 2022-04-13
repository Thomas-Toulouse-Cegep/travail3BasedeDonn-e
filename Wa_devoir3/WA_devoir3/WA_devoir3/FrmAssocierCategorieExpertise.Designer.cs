
namespace WA_devoir3
{
    partial class FrmAssocierCategorieExpertise
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_Associer = new System.Windows.Forms.Button();
            this.btn_AfficherGB = new System.Windows.Forms.Button();
            this.gb_Categorie = new System.Windows.Forms.GroupBox();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.btn_CreerAssocier = new System.Windows.Forms.Button();
            this.txt_NomCategorie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_Expertise = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gb_Categorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Expertise)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btn_Associer
            // 
            this.btn_Associer.Location = new System.Drawing.Point(185, 62);
            this.btn_Associer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Associer.Name = "btn_Associer";
            this.btn_Associer.Size = new System.Drawing.Size(56, 19);
            this.btn_Associer.TabIndex = 4;
            this.btn_Associer.Text = "Associer";
            this.btn_Associer.UseVisualStyleBackColor = true;
            // 
            // btn_AfficherGB
            // 
            this.btn_AfficherGB.Location = new System.Drawing.Point(275, 91);
            this.btn_AfficherGB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AfficherGB.Name = "btn_AfficherGB";
            this.btn_AfficherGB.Size = new System.Drawing.Size(22, 21);
            this.btn_AfficherGB.TabIndex = 5;
            this.btn_AfficherGB.Text = "+";
            this.btn_AfficherGB.UseVisualStyleBackColor = true;
            this.btn_AfficherGB.Click += new System.EventHandler(this.btn_AfficherGB_Click);
            // 
            // gb_Categorie
            // 
            this.gb_Categorie.Controls.Add(this.btn_Annuler);
            this.gb_Categorie.Controls.Add(this.btn_CreerAssocier);
            this.gb_Categorie.Controls.Add(this.txt_NomCategorie);
            this.gb_Categorie.Controls.Add(this.label3);
            this.gb_Categorie.Location = new System.Drawing.Point(301, 59);
            this.gb_Categorie.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Categorie.Name = "gb_Categorie";
            this.gb_Categorie.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Categorie.Size = new System.Drawing.Size(270, 124);
            this.gb_Categorie.TabIndex = 6;
            this.gb_Categorie.TabStop = false;
            this.gb_Categorie.Text = "Ajout d\'une catégorie";
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(0, 84);
            this.btn_Annuler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(56, 19);
            this.btn_Annuler.TabIndex = 3;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // btn_CreerAssocier
            // 
            this.btn_CreerAssocier.Location = new System.Drawing.Point(83, 84);
            this.btn_CreerAssocier.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CreerAssocier.Name = "btn_CreerAssocier";
            this.btn_CreerAssocier.Size = new System.Drawing.Size(172, 19);
            this.btn_CreerAssocier.TabIndex = 2;
            this.btn_CreerAssocier.Text = "Ajouter mécanicien à l\'expertise";
            this.btn_CreerAssocier.UseVisualStyleBackColor = true;
            // 
            // txt_NomCategorie
            // 
            this.txt_NomCategorie.Location = new System.Drawing.Point(17, 41);
            this.txt_NomCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NomCategorie.Name = "txt_NomCategorie";
            this.txt_NomCategorie.Size = new System.Drawing.Size(238, 20);
            this.txt_NomCategorie.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expertise dans la catégorie :\r\n";
            // 
            // DGV_Expertise
            // 
            this.DGV_Expertise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Expertise.Location = new System.Drawing.Point(12, 202);
            this.DGV_Expertise.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Expertise.Name = "DGV_Expertise";
            this.DGV_Expertise.RowHeadersWidth = 51;
            this.DGV_Expertise.RowTemplate.Height = 24;
            this.DGV_Expertise.Size = new System.Drawing.Size(236, 122);
            this.DGV_Expertise.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_Associer);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 86);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherhe d\'un mécanicien";
            // 
            // FrmAssocierCategorieExpertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_Expertise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gb_Categorie);
            this.Controls.Add(this.btn_AfficherGB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAssocierCategorieExpertise";
            this.Text = "Associer une catégorie avec une expertise";
            this.Load += new System.EventHandler(this.FrmAssocierCategorieExpertise_Load);
            this.gb_Categorie.ResumeLayout(false);
            this.gb_Categorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Expertise)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Associer;
        private System.Windows.Forms.Button btn_AfficherGB;
        private System.Windows.Forms.GroupBox gb_Categorie;
        private System.Windows.Forms.TextBox txt_NomCategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Button btn_CreerAssocier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_Expertise;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}