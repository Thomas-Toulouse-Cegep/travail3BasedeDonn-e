
namespace WA_devoir3
{
    partial class frmCategorieEtExpertises
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
            this.lbCategorie = new System.Windows.Forms.Label();
            this.DgvCategorie = new System.Windows.Forms.DataGridView();
            this.DgvExpertise = new System.Windows.Forms.DataGridView();
            this.lbExpertise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpertise)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCategorie
            // 
            this.lbCategorie.AutoSize = true;
            this.lbCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategorie.Location = new System.Drawing.Point(12, 19);
            this.lbCategorie.Name = "lbCategorie";
            this.lbCategorie.Size = new System.Drawing.Size(67, 16);
            this.lbCategorie.TabIndex = 0;
            this.lbCategorie.Text = "Catégorie";
            // 
            // DgvCategorie
            // 
            this.DgvCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorie.Location = new System.Drawing.Point(12, 38);
            this.DgvCategorie.Name = "DgvCategorie";
            this.DgvCategorie.Size = new System.Drawing.Size(533, 150);
            this.DgvCategorie.TabIndex = 1;
            // 
            // DgvExpertise
            // 
            this.DgvExpertise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpertise.Location = new System.Drawing.Point(12, 266);
            this.DgvExpertise.Name = "DgvExpertise";
            this.DgvExpertise.Size = new System.Drawing.Size(533, 155);
            this.DgvExpertise.TabIndex = 3;
            this.DgvExpertise.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lbExpertise
            // 
            this.lbExpertise.AutoSize = true;
            this.lbExpertise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpertise.Location = new System.Drawing.Point(12, 247);
            this.lbExpertise.Name = "lbExpertise";
            this.lbExpertise.Size = new System.Drawing.Size(64, 16);
            this.lbExpertise.TabIndex = 2;
            this.lbExpertise.Text = "Expertise";
            // 
            // frmCategorieEtExpertises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 428);
            this.Controls.Add(this.DgvExpertise);
            this.Controls.Add(this.lbExpertise);
            this.Controls.Add(this.DgvCategorie);
            this.Controls.Add(this.lbCategorie);
            this.Name = "frmCategorieEtExpertises";
            this.Text = "Categorie et expertises";
            this.Load += new System.EventHandler(this.frmCategorieEtExpertises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpertise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCategorie;
        private System.Windows.Forms.DataGridView DgvCategorie;
        private System.Windows.Forms.DataGridView DgvExpertise;
        private System.Windows.Forms.Label lbExpertise;
    }
}