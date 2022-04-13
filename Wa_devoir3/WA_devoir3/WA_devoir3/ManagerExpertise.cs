using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Data;

namespace WA_devoir3
{
    class ManagerExpertise : Manager
    {
        public void AjouterExpertise(string nom, int nombreHeure, string modalite)
        {
            using (SqlConnection Cnn = getConection())
            {
                string sql = "AjouterExpertise";
                SqlCommand cmd = new SqlCommand(sql, Cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@expertise", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@nb_heure", SqlDbType.Int);
                cmd.Parameters.Add("@modalite", SqlDbType.NVarChar, 50);

                cmd.Parameters["@expertise"].Value = nom;
                cmd.Parameters["@nb_heure"].Value = nombreHeure;
                cmd.Parameters["@modalite"].Value = modalite;

                Cnn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
