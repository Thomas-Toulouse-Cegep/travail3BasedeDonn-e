using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WA_devoir3
{
    public partial class FrmAjouterExpertise : Form
    {
        public FrmAjouterExpertise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modalite = "";

            if (rb_Distance.Checked)
            {
                modalite = "distance";
            }
            if (rb_Mixte.Checked)
            {
                modalite = "mixte";
            }
            if (rb_Presence.Checked)
            {
                modalite = "présence";
            }

            ManagerExpertise managerExpertise = new ManagerExpertise();
            managerExpertise.AjouterExpertise(Convert.ToString(txt_Nom.Text), Convert.ToInt32(txt_NbHeure.Text), modalite);
            MessageBox.Show("Ajout réalisé avec succée !");
            ViderChamps();
        }

        private void ViderChamps()
        {
            txt_NbHeure.Clear();
            txt_Nom.Clear();
            rb_Presence.Checked = true;
        }

        private void FrmAjouterExpertise_Load(object sender, EventArgs e)
        {

        }
    }
}
