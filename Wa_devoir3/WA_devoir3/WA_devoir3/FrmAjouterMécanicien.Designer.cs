
namespace WA_devoir3
{
    partial class FrmAjouterMécanicien
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
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrénom = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAssuranceSociale = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrénom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAsssuranceSociale = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(13, 23);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(53, 18);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom : ";
            // 
            // lbPrénom
            // 
            this.lbPrénom.AutoSize = true;
            this.lbPrénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrénom.Location = new System.Drawing.Point(13, 59);
            this.lbPrénom.Name = "lbPrénom";
            this.lbPrénom.Size = new System.Drawing.Size(76, 20);
            this.lbPrénom.TabIndex = 1;
            this.lbPrénom.Text = "Prénom : ";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(13, 96);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 20);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email :";
            // 
            // lbAssuranceSociale
            // 
            this.lbAssuranceSociale.AutoSize = true;
            this.lbAssuranceSociale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssuranceSociale.Location = new System.Drawing.Point(13, 146);
            this.lbAssuranceSociale.Name = "lbAssuranceSociale";
            this.lbAssuranceSociale.Size = new System.Drawing.Size(146, 20);
            this.lbAssuranceSociale.TabIndex = 3;
            this.lbAssuranceSociale.Text = "Assurance sociale :";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNom.Location = new System.Drawing.Point(165, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(286, 26);
            this.txtNom.TabIndex = 4;
            // 
            // txtPrénom
            // 
            this.txtPrénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrénom.Location = new System.Drawing.Point(165, 56);
            this.txtPrénom.Name = "txtPrénom";
            this.txtPrénom.Size = new System.Drawing.Size(286, 26);
            this.txtPrénom.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(165, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(286, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtAsssuranceSociale
            // 
            this.txtAsssuranceSociale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsssuranceSociale.Location = new System.Drawing.Point(165, 143);
            this.txtAsssuranceSociale.Name = "txtAsssuranceSociale";
            this.txtAsssuranceSociale.Size = new System.Drawing.Size(286, 26);
            this.txtAsssuranceSociale.TabIndex = 7;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(363, 191);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(88, 35);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FrmAjouterMécanicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 242);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtAsssuranceSociale);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrénom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lbAssuranceSociale);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPrénom);
            this.Controls.Add(this.lbNom);
            this.Name = "FrmAjouterMécanicien";
            this.Text = "Ajouter Mécanicien";
            this.Load += new System.EventHandler(this.FrmAjouterMécanicien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbPrénom;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbAssuranceSociale;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrénom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAsssuranceSociale;
        private System.Windows.Forms.Button btnAjouter;
    }
}