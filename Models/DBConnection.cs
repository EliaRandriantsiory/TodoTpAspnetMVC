using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Todo.Models
{
    public class DBConnection
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TodoDbConnection"].ConnectionString);
        
        public static void CreationCompte(Utilisateur utilisateur)
        {
            var req = $"INSERT INTO utilisateur(nomutilisateur, motdepasse) VALUES ('{utilisateur.NomUtilisateur}','{utilisateur.MotDePasse}');";

            try
            {
                connectionString.Open();

                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();

                connectionString.Close();


            }catch (Exception e)
                {
                throw e;
                }


        }
    }
}