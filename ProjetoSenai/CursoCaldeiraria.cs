using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;

namespace ProjetoSenai
{
    public partial class CursoCaldeiraria : Form
    {









        public CursoCaldeiraria()
        {
            
            InitializeComponent();
            lixo.DataSource = BancoDeDados.ObterTodosUsuarios();
            lixo.Columns[0].Width = 237;
            string queryQTDCD = String.Format(@"SELECT count(Nome_Aluno) as 'contAlunos' FROM
                                               ALUNOS");
            DataTable dt = new DataTable();
            dt = BancoDeDados.dql(queryQTDCD);
            int qtd = Int32.Parse(dt.Rows[0].Field<Int64>("contAlunos").ToString());
            lixo4.Text = qtd.ToString();



                ///////////////////DATA////////////////////////////////////////////////////////////////////////////



        }




        public string calcqtd()
        {

                string queryQTDCD = String.Format(@"SELECT count(Nome_Aluno) as 'contAlunos' FROM
                                               ALUNOS");
                DataTable dt = new DataTable();
                dt = BancoDeDados.dql(queryQTDCD);
                int qtd = Int32.Parse(dt.Rows[0].Field<Int64>("contAlunos").ToString());

               
            
            return calcqtd();
        }





        private void btn_addCD_Click(object sender, EventArgs e)
        {
            
                NovoCD novocd = new NovoCD();
                novocd.ShowDialog();
            
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            
                DataGridView dgve = (DataGridView)sender;
                int contlinhs = dgve.SelectedRows.Count;
                if (contlinhs > 0)
                {
                    DataTable dt = new DataTable();

                    string vid = dgve.SelectedRows[0].Cells[0].Value.ToString();
                    dt = BancoDeDados.ObterTodosUsuariosA(vid);
                    lixo1.Text = dt.Rows[0].Field<string>("Nome_Aluno").ToString();
                    lixo2.Text = dt.Rows[0].Field<string>("Data_Aluno").ToString();
                    lixo3.Text = dt.Rows[0].Field<string>("TelefoneCelular").ToString();


                
            }
        }

        private void tb_qtdCD_TextChanged(object sender, EventArgs e)
        {
   
        }
    }
}
