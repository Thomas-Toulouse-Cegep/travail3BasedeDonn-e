
namespace WA_devoir3
{
    partial class FrmAjouterExpertise
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Distance = new System.Windows.Forms.RadioButton();
            this.rb_Mixte = new System.Windows.Forms.RadioButton();
            this.rb_Presence = new System.Windows.Forms.RadioButton();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_NbHeure = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre d\'heure :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Distance);
            this.groupBox1.Controls.Add(this.rb_Mixte);
            this.groupBox1.Controls.Add(this.rb_Presence);
            this.groupBox1.Location = new System.Drawing.Point(11, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(241, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalité";
            // 
            // rb_Distance
            // 
            this.rb_Distance.AutoSize = true;
            this.rb_Distance.Location = new System.Drawing.Point(160, 37);
            this.rb_Distance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Distance.Name = "rb_Distance";
            this.rb_Distance.Size = new System.Drawing.Size(67, 17);
            this.rb_Distance.TabIndex = 2;
            this.rb_Distance.TabStop = true;
            this.rb_Distance.Text = "Distance";
            this.rb_Distance.UseVisualStyleBackColor = true;
            // 
            // rb_Mixte
            // 
            this.rb_Mixte.AutoSize = true;
            this.rb_Mixte.Location = new System.Drawing.Point(100, 37);
            this.rb_Mixte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Mixte.Name = "rb_Mixte";
            this.rb_Mixte.Size = new System.Drawing.Size(50, 17);
            this.rb_Mixte.TabIndex = 1;
            this.rb_Mixte.TabStop = true;
            this.rb_Mixte.Text = "Mixte";
            this.rb_Mixte.UseVisualStyleBackColor = true;
            // 
            // rb_Presence
            // 
            this.rb_Presence.AutoSize = true;
            this.rb_Presence.Location = new System.Drawing.Point(16, 37);
            this.rb_Presence.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_Presence.Name = "rb_Presence";
            this.rb_Presence.Size = new System.Drawing.Size(70, 17);
            this.rb_Presence.TabIndex = 0;
            this.rb_Presence.TabStop = true;
            this.rb_Presence.Text = "Présence";
            this.rb_Presence.UseVisualStyleBackColor = true;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(196, 199);
            this.btn_Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(56, 19);
            this.btn_Ajouter.TabIndex = 4;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(111, 7);
            this.txt_Nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(142, 20);
            this.txt_Nom.TabIndex = 5;
            // 
            // txt_NbHeure
            // 
            this.txt_NbHeure.Location = new System.Drawing.Point(111, 32);
            this.txt_NbHeure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NbHeure.Name = "txt_NbHeure";
            this.txt_NbHeure.Size = new System.Drawing.Size(142, 20);
            this.txt_NbHeure.TabIndex = 6;
            // 
            // FrmAjouterExpertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 235);
            this.Controls.Add(this.txt_NbHeure);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAjouterExpertise";
            this.Text = "Ajouter une expertise";
            this.Load += new System.EventHandler(this.FrmAjouterExpertise_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Distance;
        private System.Windows.Forms.RadioButton rb_Mixte;
        private System.Windows.Forms.RadioButton rb_Presence;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_NbHeure;
    }
}