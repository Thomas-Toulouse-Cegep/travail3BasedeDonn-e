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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void ajouterUneExpertiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjouterExpertise maForm = new FrmAjouterExpertise();
            maForm.ShowDialog();
        }

        private void modifierOuDétruireUneExpertiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifierDetruireExpertise maForm = new FrmModifierDetruireExpertise();
            maForm.ShowDialog();
        }

        private void associerUneCatégorieAvecUneExpertiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAssocierCategorieExpertise maForm = new FrmAssocierCategorieExpertise();
            maForm.ShowDialog();
        }

        private void nombreExpertiseDansUneCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpertisePourUnMechanicien maForm = new FrmExpertisePourUnMechanicien();
            maForm.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void catégorieEtExpertiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorieEtExpertises maForm = new frmCategorieEtExpertises();
            maForm.ShowDialog();
        }
    }
}
