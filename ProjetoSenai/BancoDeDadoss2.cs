using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
namespace ProjetoSenai
{
    internal class BancoDeDadoss2
    {
        public static SQLiteConnection conect;





       
        public static SQLiteConnection ConectBancoEmail()
        {
            conect = new SQLiteConnection("Data Source=" + Globais.CaminhoBanco1 + Globais.NomeBanco1);
            conect.Open();
            return conect;


        }


        public static DataTable ObterEmailEmpr()
        {
            DataTable dt = new DataTable();

            SQLiteDataAdapter da = null;
            try
            {
                using (var cmd = ConectBancoEmail().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Emaill SET Emailemp='" + Globais.nome1 + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBancoEmail());
                    da.Fill(dt);
                    ConectBancoEmail().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBancoEmail().Close();
                throw ex;
            }
        }
        public static DataTable ObterEmailEmprr()
        {
            DataTable dt = new DataTable();

            SQLiteDataAdapter da = null;
            try
            {
                using (var cmd = ConectBancoEmail().CreateCommand())
                {
                    cmd.CommandText = "SELECT Emailemp FROM Emaill";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBancoEmail());
                    da.Fill(dt);
                    ConectBancoEmail().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBancoEmail().Close();
                throw ex;
            }
        }
    }
}
