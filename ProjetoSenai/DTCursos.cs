using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSenai
{
    public partial class DTCursos : Form
    {
        public DTCursos()
        {
            InitializeComponent();
            int cont2 = 33;

            DDgv.DataSource = BancoDeDados.ObterTabela();
            DDgv.Columns[0].Width = 476;
            Globais.closed = false;
            int cont;
            string queryQTDTB = String.Format(@"SELECT count(tbl_name) as 'contAlunos' FROM
                                               sqlite_master WHERE type='table'");
            DataTable da = new DataTable();
            da = BancoDeDados.dql(queryQTDTB);
            Globais.cont = Int32.Parse(da.Rows[0].Field<Int64>("contAlunos").ToString());
            BancoDeDsadosCRS.excluir();
            for (cont = 0; cont < Globais.cont;)
            {
                
                string queryQTDNM = String.Format(@"SELECT tbl_name as 'contAlunos' FROM
                                               sqlite_master WHERE type='table'");
                da = BancoDeDados.dql(queryQTDNM);

                Globais.Curso1 = da.Rows[cont].Field<string>("contAlunos").ToString();

                string queryQTDALUNOS = String.Format(@"SELECT count(Nome_aluno) as 'contAlunos' FROM
                                               '" + Globais.Curso1 + "'");
                da = BancoDeDados.dql(queryQTDALUNOS);
                Globais.aviso = Int32.Parse(da.Rows[0].Field<Int64>("contAlunos").ToString());
                DataTable df = new DataTable();
                
                if (Globais.aviso >= 15)
                {
                    
                    Globais.Curso2 = Globais.Curso1;
                    BancoDeDsadosCRS.CursoSS();

                   

                   

                }
                else
                {

                }
               
                cont++;

            }
            DGV2.DataSource = BancoDeDsadosCRS.Consultar();
            DGV2.Columns[0].Width = 260;











        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ConfDTCursos_Click(object sender, EventArgs e)
        {
            int contlinhs = DDgv.SelectedRows.Count;
            if (contlinhs <= 0)
            {
                MessageBox.Show("Nenhum curso para selecionar");
            }
            else
            {


                Globais.closed = true;
                this.Close();
            }
        }

        private void DDgv_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgve = (DataGridView)sender;

            int contlinhs = dgve.SelectedRows.Count;
            if (contlinhs > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgve.SelectedRows[0].Cells[0].Value.ToString();
                dt = BancoDeDados.ObterTabelaA(vid);
               Globais.Curso = dt.Rows[0].Field<string>("tbl_name").ToString();
                tb_CursoExEdi.Text = dt.Rows[0].Field<string>("tbl_name").ToString();
                tb_exlock.Text = dt.Rows[0].Field<string>("tbl_name").ToString();
            }
        }

        private void btn_editCD_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma edição?", "Editar", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {

                Globais.nome = tb_CursoExEdi.Text;

                BancoDeDados.EditarCurso();

                DDgv.DataSource = BancoDeDados.ObterTabela();
                DDgv.Columns[0].Width = 476;
            }
        }

        private void btn_excluirCD_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Globais.nome = tb_exlock.Text;
                BancoDeDados.ExcluirCurso();
                DDgv.DataSource = BancoDeDados.ObterTabela();
                DDgv.Columns[0].Width = 476;
            }
        }

      
    }

}
