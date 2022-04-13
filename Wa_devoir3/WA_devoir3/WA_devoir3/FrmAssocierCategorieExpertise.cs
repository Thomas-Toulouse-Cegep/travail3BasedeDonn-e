using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WA_devoir3
{
    public partial class FrmAssocierCategorieExpertise : Form
    {
        public FrmAssocierCategorieExpertise()
        {
            InitializeComponent();
        }

        private void FrmAssocierCategorieExpertise_Load(object sender, EventArgs e)
        {
            gb_Categorie.Visible = false;
        }

        private void btn_AfficherGB_Click(object sender, EventArgs e)
        {
            if (gb_Categorie.Visible)
            {
                gb_Categorie.Visible = false;
                gb_Categorie.Text = "+";
            }
            else
            {
                gb_Categorie.Visible = true;
                gb_Categorie.Text = "-";
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            txt_NomCategorie.Clear();
        }
    }
}
