using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
namespace ProjetoSenai
{
    internal class BancoDeDsadosCRS
    {
        public static SQLiteConnection connect;

        public static SQLiteConnection ConnectBanco()
        {
            connect = new SQLiteConnection("DataSource=" + Globais.CaminhoBanco2 + Globais.NomeBanco2);
            connect.Open();
            return connect;
        }
        public static void CursoSS()
        {
                     
                var cmd = ConnectBanco().CreateCommand();
                
                    cmd.CommandText = "INSERT INTO CRS (Cursos) VALUES(@Curso)";
  
            cmd.Parameters.AddWithValue("@Curso", Globais.Curso2);
            cmd.ExecuteNonQuery();
                
           
        }
        public static DataTable excluir()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM CRS";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectBanco());
                    da.Fill(dt);
                    ConnectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConnectBanco().Close();
                throw ex;
            }

        }
        public static DataTable Consultar()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConnectBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT Cursos as 'Cursos excedentes de 15' FROM CRS";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectBanco());
                    da.Fill(dt);
                    ConnectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConnectBanco().Close();
                throw ex;
            }


        }
    }
}
