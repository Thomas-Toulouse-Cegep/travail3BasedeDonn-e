
namespace WA_devoir3
{
    partial class FrmExpertisePourUnMechanicien
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
            this.DgvMécanicien = new System.Windows.Forms.DataGridView();
            this.lbMécanicien = new System.Windows.Forms.Label();
            this.CmbRechercheExpertise = new System.Windows.Forms.ComboBox();
            this.GrboxRechercheExpertise = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMécanicien)).BeginInit();
            this.GrboxRechercheExpertise.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvMécanicien
            // 
            this.DgvMécanicien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMécanicien.Location = new System.Drawing.Point(12, 143);
            this.DgvMécanicien.Name = "DgvMécanicien";
            this.DgvMécanicien.Size = new System.Drawing.Size(533, 150);
            this.DgvMécanicien.TabIndex = 3;
            // 
            // lbMécanicien
            // 
            this.lbMécanicien.AutoSize = true;
            this.lbMécanicien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMécanicien.Location = new System.Drawing.Point(9, 124);
            this.lbMécanicien.Name = "lbMécanicien";
            this.lbMécanicien.Size = new System.Drawing.Size(77, 16);
            this.lbMécanicien.TabIndex = 2;
            this.lbMécanicien.Text = "Mécanicien";
            // 
            // CmbRechercheExpertise
            // 
            this.CmbRechercheExpertise.FormattingEnabled = true;
            this.CmbRechercheExpertise.Location = new System.Drawing.Point(6, 35);
            this.CmbRechercheExpertise.Name = "CmbRechercheExpertise";
            this.CmbRechercheExpertise.Size = new System.Drawing.Size(336, 21);
            this.CmbRechercheExpertise.TabIndex = 5;
            // 
            // GrboxRechercheExpertise
            // 
            this.GrboxRechercheExpertise.Controls.Add(this.CmbRechercheExpertise);
            this.GrboxRechercheExpertise.Location = new System.Drawing.Point(12, 12);
            this.GrboxRechercheExpertise.Name = "GrboxRechercheExpertise";
            this.GrboxRechercheExpertise.Size = new System.Drawing.Size(348, 78);
            this.GrboxRechercheExpertise.TabIndex = 6;
            this.GrboxRechercheExpertise.TabStop = false;
            this.GrboxRechercheExpertise.Text = "Recherche d\'un expertise";
            // 
            // FrmExpertisePourUnMechanicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 317);
            this.Controls.Add(this.GrboxRechercheExpertise);
            this.Controls.Add(this.DgvMécanicien);
            this.Controls.Add(this.lbMécanicien);
            this.Name = "FrmExpertisePourUnMechanicien";
            this.Text = "Expertise Pour Un Mechanicien";
            this.Load += new System.EventHandler(this.FrmExpertisePourUnMechanicien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMécanicien)).EndInit();
            this.GrboxRechercheExpertise.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvMécanicien;
        private System.Windows.Forms.Label lbMécanicien;
        private System.Windows.Forms.ComboBox CmbRechercheExpertise;
        private System.Windows.Forms.GroupBox GrboxRechercheExpertise;
    }
}