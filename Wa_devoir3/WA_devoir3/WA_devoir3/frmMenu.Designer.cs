
namespace WA_devoir3
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterUneExpertiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierOuDétruireUneExpertiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associerUneCatégorieAvecUneExpertiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreExpertiseDansUneCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorieEtExpertiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnMéchanicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterUneExpertiseToolStripMenuItem
            // 
            this.ajouterUneExpertiseToolStripMenuItem.Name = "ajouterUneExpertiseToolStripMenuItem";
            this.ajouterUneExpertiseToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.ajouterUneExpertiseToolStripMenuItem.Text = "Ajouter une expertise";
            this.ajouterUneExpertiseToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneExpertiseToolStripMenuItem_Click);
            // 
            // modifierOuDétruireUneExpertiseToolStripMenuItem
            // 
            this.modifierOuDétruireUneExpertiseToolStripMenuItem.Name = "modifierOuDétruireUneExpertiseToolStripMenuItem";
            this.modifierOuDétruireUneExpertiseToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.modifierOuDétruireUneExpertiseToolStripMenuItem.Text = "Modifier ou détruire une expertise";
            this.modifierOuDétruireUneExpertiseToolStripMenuItem.Click += new System.EventHandler(this.modifierOuDétruireUneExpertiseToolStripMenuItem_Click);
            // 
            // associerUneCatégorieAvecUneExpertiseToolStripMenuItem
            // 
            this.associerUneCatégorieAvecUneExpertiseToolStripMenuItem.Name = "associerUneCatégorieAvecUneExpertiseToolStripMenuItem";
            this.associerUneCatégorieAvecUneExpertiseToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.associerUneCatégorieAvecUneExpertiseToolStripMenuItem.Text = "Associer une catégorie avec une expertise";
            this.associerUneCatégorieAvecUneExpertiseToolStripMenuItem.Click += new System.EventHandler(this.associerUneCatégorieAvecUneExpertiseToolStripMenuItem_Click);
            // 
            // nombreExpertiseDansUneCatégorieToolStripMenuItem
            // 
            this.nombreExpertiseDansUneCatégorieToolStripMenuItem.Name = "nombreExpertiseDansUneCatégorieToolStripMenuItem";
            this.nombreExpertiseDansUneCatégorieToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.nombreExpertiseDansUneCatégorieToolStripMenuItem.Text = "Expertise pour un mécanicien";
            this.nombreExpertiseDansUneCatégorieToolStripMenuItem.Click += new System.EventHandler(this.nombreExpertiseDansUneCatégorieToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneExpertiseToolStripMenuItem,
            this.modifierOuDétruireUneExpertiseToolStripMenuItem,
            this.associerUneCatégorieAvecUneExpertiseToolStripMenuItem,
            this.nombreExpertiseDansUneCatégorieToolStripMenuItem,
            this.catégorieEtExpertiseToolStripMenuItem,
            this.ajouterUnMéchanicienToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // catégorieEtExpertiseToolStripMenuItem
            // 
            this.catégorieEtExpertiseToolStripMenuItem.Name = "catégorieEtExpertiseToolStripMenuItem";
            this.catégorieEtExpertiseToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.catégorieEtExpertiseToolStripMenuItem.Text = "Catégorie et expertise";
            this.catégorieEtExpertiseToolStripMenuItem.Click += new System.EventHandler(this.catégorieEtExpertiseToolStripMenuItem_Click);
            // 
            // ajouterUnMéchanicienToolStripMenuItem
            // 
            this.ajouterUnMéchanicienToolStripMenuItem.Name = "ajouterUnMéchanicienToolStripMenuItem";
            this.ajouterUnMéchanicienToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.ajouterUnMéchanicienToolStripMenuItem.Text = "Ajouter un méchanicien";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneExpertiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierOuDétruireUneExpertiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associerUneCatégorieAvecUneExpertiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreExpertiseDansUneCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorieEtExpertiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMéchanicienToolStripMenuItem;
    }
}

