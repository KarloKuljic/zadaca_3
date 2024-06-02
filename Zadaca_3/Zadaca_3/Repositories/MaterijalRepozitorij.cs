using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca_3.Model;
using DBLayer;
using System.Data.SqlClient;

namespace Zadaca_3.Repositories
{
    

    public class MaterijalRepozitorij
        {
        private static void DeleteObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string sql = $"DELETE FROM Materijali WHERE Id_materijala = {id};
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static Materijal GetMaterijal(int id)
            {
            Materijal materijal = null;
                string sql = $"SELECT * FROM Materijal WHERE Id = {id}";
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                if (reader.HasRows)
                {
                    reader.Read();
                materijal = CreateObject(reader);
                    reader.Close();
                }
                DB.CloseConnection();
                return materijal;+
            }
            public static List<Materijal> GetMaterijali()
            {
                List<Materijal> materijal = new List<Materijal>();
                string sql = "SELECT * FROM Materijal";
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                Materijal materijal = CreateObject(reader);
                materijal.Add(materijal);
                }
                reader.Close();
                DB.CloseConnection();

                return materijal;
            }
            private static Materijal CreateObject(SqlDataReader reader)
            {
                int Id_materijala = int.Parse(reader["Id_materijala"].ToString());
                string Ime_materijala = reader["Ime_materijala"].ToString();
                string Vrsta_materijala = reader["Vrsta_materijala"].ToString();

                var materijal = new Materijal
                {
                    Id_materijala = Id_materijala,
                    Ime_materijala = Ime_materijala,
                    Vrsta_materijala = Vrsta_materijala
                };
                return materijal;
            }

        }
    }


