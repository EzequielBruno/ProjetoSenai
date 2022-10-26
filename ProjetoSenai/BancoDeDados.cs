using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace ProjetoSenai
{
    internal class BancoDeDados
    {
        public static SQLiteConnection conect;

        public static DataTable dql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                    da.Fill(dt);
                    ConectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }
        }

        public static void dml(string q, string msgok = null, string msgERRO = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {
                    cmd.CommandText = q;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());

                    cmd.ExecuteNonQuery();
                    ConectBanco().Close();
                    if (msgok != null)
                    {
                        MessageBox.Show(msgok);
                    }
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                ConectBanco().Close();
                throw ex;
            }


        }

        public static SQLiteConnection ConectBanco()
        {
            conect = new SQLiteConnection("Data Source=" + Globais.CaminhoBanco + Globais.NomeBanco);
            conect.Open();
            return conect;
        }
        public static DataTable ObterTodosUsuariosCD()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT Nome_Aluno FROM " + Globais.Curso + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                    da.Fill(dt);
                    ConectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }
        }
        public static void NovoAluno()
        {
            try
            {
                var cmd = ConectBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO'" + Globais.Curso + "'(Nome_Aluno, Data_Aluno, TelefoneCelular, email, Data) Values(@nome,@data,@celular,@email,@Dataa) ";
                cmd.Parameters.AddWithValue("@nome", Globais.nome);
                cmd.Parameters.AddWithValue("@data", Globais.data);
                cmd.Parameters.AddWithValue("@celular", Globais.Celular);
                cmd.Parameters.AddWithValue("@email", Globais.email);
                cmd.Parameters.AddWithValue("@Dataa", Globais.Data1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno salvo com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Este email ou nome já está cadastrado neste curso, por favor insira outro");

            }

        }
        public static DataTable ObterTodosUsuariosA(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM'" + Globais.Curso + "'WHERE Nome_Aluno ='" + id + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());

                    da.Fill(dt);
                    ConectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }

        }
        public static void EditarAluno()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {


                var cmd = ConectBanco().CreateCommand();
                cmd.CommandText = "UPDATE'" + Globais.Curso + "'SET Nome_Aluno='" + Globais.nomee + "', Data_Aluno='" + Globais.data + "', TelefoneCelular='" + Globais.Celular + "',email='" + Globais.email + "' WHERE Nome_Aluno='" + Globais.nome + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno editado com sucesso");
                ConectBanco().Close();
            }
            catch (Exception ex)
            {

                ConectBanco().Close();
                throw ex;
            }
        }

        public static void ExcluirAluno()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {


                var cmd = ConectBanco().CreateCommand();
                cmd.CommandText = "DELETE FROM'" + Globais.Curso + "'WHERE Nome_Aluno='" + Globais.nome + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno excluido com sucesso");
                ConectBanco().Close();
            }
            catch (Exception ex)
            {

                ConectBanco().Close();
                throw ex;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////CURSO ELETRICISTA DE MANUTENÇÂO//////////////////////////////

        public static DataTable ObterTodosUsuarios()
        {


            if (Globais.Curso == "")
            {

                MessageBox.Show("Não há cursos para mostrar");

            }
            else
            {
                DataTable dt = new DataTable();

                SQLiteDataAdapter da = null;

                try
                {
                    using (var cmd = ConectBanco().CreateCommand())
                    {
                        cmd.CommandText = "SELECT Nome_Aluno FROM'" + Globais.Curso + "'";
                        da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                        da.Fill(dt);
                        ConectBanco().Close();
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    ConectBanco().Close();
                    throw ex;
                }

            }
            return ObterTodosUsuarios();
        }
        public static void NovoAlunoA()
        {
            var cmd = ConectBanco().CreateCommand();
            cmd.CommandText = "INSERT INTO'" + Globais.Curso + "'(Nome_Aluno, Data_Aluno, TelefoneCelular, email, Data) Values(@nome,@data,@celular,@email,@Data) ";
            cmd.Parameters.AddWithValue("@nome", Globais.nome);
            cmd.Parameters.AddWithValue("@data", Globais.data);
            cmd.Parameters.AddWithValue("@celular", Globais.Celular);
            cmd.Parameters.AddWithValue("@email", Globais.email);
            cmd.Parameters.AddWithValue("@Data", Globais.Data1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Aluno salvo com sucesso");
        }
        public static DataTable ObterTodosUsuariosAA(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM'" + Globais.Curso + "'WHERE Nome_Aluno ='" + id + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());

                    da.Fill(dt);
                    ConectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }

        }
        public static void EditarAlunoA()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {


                var cmd = ConectBanco().CreateCommand();
                cmd.CommandText = "UPDATE '" + Globais.Curso + "'SET Nome_Aluno='" + Globais.nomee + "', Data_Aluno='" + Globais.data + "', TelefoneCelular='" + Globais.Celular + "',email='" + Globais.email + "' WHERE Nome_Aluno='" + Globais.nome + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno editado com sucesso");
                ConectBanco().Close();
            }
            catch (Exception ex)
            {

                ConectBanco().Close();
                throw ex;
            }
        }

        public static void ExcluirAlunoA()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {


                var cmd = ConectBanco().CreateCommand();
                cmd.CommandText = "DELETE FROM " + Globais.Curso + "' WHERE Nome_Aluno='" + Globais.nome + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno excluido com sucesso");
                ConectBanco().Close();
            }
            catch (Exception ex)
            {

                ConectBanco().Close();
                throw ex;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        ////
        ////////////////////////////////////////////////
        ///
        public static void NovoCurso()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var cmd = ConectBanco().CreateCommand();
                cmd.CommandText = "CREATE TABLE '" + Globais.Curso + "'(Nome_Aluno VARCHAR(30) UNIQUE, Data_Aluno VARCHAR(30), TelefoneCelular VARCHAR(30), email VARCHAR(30) PRIMARY KEY, Data VARCHAR(30) ) ";
                da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso ciado com sucesso");
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }
        }
        public static DataTable ObterTodasCursos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT CURSO FROM'" + Globais.Curso + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                    da.Fill(dt);
                    ConectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }
        }



        public static DataTable ObterTabela()
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {








                    cmd.CommandText = "SELECT tbl_name as 'Cursos' FROM sqlite_master WHERE type='table'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());

                    da.Fill(dt);
                    ConectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }

        }

        public static DataTable ObterTabelaA(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT tbl_name FROM sqlite_master WHERE type='table' AND tbl_name ='" + id + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());

                    da.Fill(dt);
                    ConectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }

        }

        public static void EditarCurso()
        {
            DTCursos de = new DTCursos();
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {


                var cmd = ConectBanco().CreateCommand();
                cmd.CommandText = "ALTER TABLE'" + Globais.Curso + "' RENAME TO'" + Globais.nome + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso editado com sucesso");
                ConectBanco().Close();
            }
            catch (Exception ex)
            {

                ConectBanco().Close();
                throw ex;
            }



        }


        public static void ExcluirCurso()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {


                var cmd = ConectBanco().CreateCommand();
                cmd.CommandText = "DROP TABLE '" + Globais.Curso + "'";
                da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso excluido com sucesso");
                ConectBanco().Close();
            }
            catch (Exception ex)
            {

                ConectBanco().Close();
                throw ex;
            }
        }

        public static DataTable ObterEmail()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConectBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT email FROM'" + Globais.Curso + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConectBanco());

                    da.Fill(dt);
                    ConectBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConectBanco().Close();
                throw ex;
            }
        }
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
                    cmd.CommandText = "UPDATE Emaill SET Emailemp='"+Globais.nome1+"'";
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

    

