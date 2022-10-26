using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Diagnostics;

namespace ProjetoSenai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string queryQTDCD = String.Format(@"SELECT count(tbl_name) as 'contAlunos' FROM
                                               sqlite_master WHERE type='table'");
            DataTable dt = new DataTable();
            dt = BancoDeDados.dql(queryQTDCD);
            Globais.cont = Int32.Parse(dt.Rows[0].Field<Int64>("contAlunos").ToString());

        }


        public void Atualizar()
        {

            dgv.DataSource = BancoDeDados.ObterTodosUsuarios();
            dgv.Columns[0].Width = 476;
            picture();
            calcqtd();
            tipCurso.Text = Globais.Curso;

        }
        public void calcqtd()
        {

            string queryQTDCD = String.Format(@"SELECT count(Nome_Aluno) as 'contAlunos' FROM
                                               '"+ Globais.Curso +"'");
            DataTable dt = new DataTable();
            dt = BancoDeDados.dql(queryQTDCD);
            int qtd = Int32.Parse(dt.Rows[0].Field<Int64>("contAlunos").ToString());
            tb_qtdCD.Text = qtd.ToString();
            if (qtd >= 15)
            {

            }

        }

        public void picture()
        {

            string queryQTDCD = String.Format(@"SELECT count(Nome_Aluno) as 'contAlunos' FROM
                                               '"+ Globais.Curso +"'");
            DataTable dt = new DataTable();
            dt = BancoDeDados.dql(queryQTDCD);
            int qtd = Int32.Parse(dt.Rows[0].Field<Int64>("contAlunos").ToString());
          
        }






        public void dgv_SelectionChanged(object sender, EventArgs e)
        {


            DataGridView dgve = (DataGridView)sender;

            int contlinhs = dgve.SelectedRows.Count;
            if (contlinhs > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgve.SelectedRows[0].Cells[0].Value.ToString();
                dt = BancoDeDados.ObterTodosUsuariosA(vid);
               
                tb_dataCD.Text = dt.Rows[0].Field<string>("Data_Aluno").ToString();
                tb_celularrCD.Text = dt.Rows[0].Field<string>("TelefoneCelular").ToString();
                tb_email.Text = dt.Rows[0].Field<string>("email").ToString();
                DataInsc.Text = dt.Rows[0].Field<string>("Data").ToString();
                tb_nomeCD.Text = dt.Rows[0].Field<string>("Nome_Aluno").ToString();
                //////////////////////////////
                ///

                
                tb_dataEdit.Text = dt.Rows[0].Field<string>("Data_aluno").ToString();
                tb_cellEdit.Text = dt.Rows[0].Field<string>("TelefoneCelular").ToString();
                tb_Editemail.Text = dt.Rows[0].Field<string>("email").ToString();
                tb_nomeEdit.Text = dt.Rows[0].Field<string>("Nome_Aluno").ToString();
            }
            else
            {
                tb_nomeCD.Text = "";
                tb_dataCD.Text = "";
                tb_celularrCD.Text = "";
                tb_email.Text = "";
                DataInsc.Text = "";
                //////////////////////////////
                ///

                tb_nomeEdit.Text = "";
                tb_dataEdit.Text = "";
                tb_cellEdit.Text = "";
                tb_Editemail.Text = "";
            }

        }

       

        private void btn_addCD_Click(object sender, EventArgs e)
        {
            if (tipCurso.Text == "Não selecionado")
            {
                MessageBox.Show("Selecione um curso primeiro!!");
            }
            else
            {
                NovoCD CD = new NovoCD();
                CD.ShowDialog();
                if (Globais.closed == true)
                {
                    Atualizar();
                    Globais.closed = false;
                }
            }
        }

        private void btn_editCD_Click(object sender, EventArgs e)
        {
            if (tipCurso.Text == "Não selecionado")
            {
                MessageBox.Show("Selecione um curso primeiro!!");
            }
            else
            {
                DialogResult res = MessageBox.Show("Confirma edição?", "Editar", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {

                    Globais.nome = tb_nomeCD.Text;
                    Globais.nomee = tb_nomeEdit.Text;
                    Globais.data = tb_dataEdit.Text;
                    Globais.Celular = tb_cellEdit.Text;
                    Globais.email = tb_Editemail.Text;
                    BancoDeDados.EditarAluno();
                    Atualizar();
                }

            }
        }

        private void btn_excluirCD_Click(object sender, EventArgs e)
        {
            if (tipCurso.Text == "Não selecionado")
            {
                MessageBox.Show("Selecione um curso primeiro!!");
            }
            else
            {
                DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    Globais.nome = tb_nomeCD.Text;
                    BancoDeDados.ExcluirAluno();
                    Atualizar();
                }
            }
        }

        private void pictureBox1_VisibleChanged(object sender, EventArgs e)
        {


        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////
        ///

        private void criarUmNovoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoCurso nv = new NovoCurso();
            nv.ShowDialog();
            if (Globais.closed == true)
            {
                Atualizar();
            }
            


        }

        private void outroCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DTCursos dts = new DTCursos();
            dts.ShowDialog();
            if (Globais.closed == true)
            {
                Atualizar();
                Globais.closed = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
          
            Atualizar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cursosExcedentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enviarEmailParaTodosOsAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipCurso.Text == "Não selecionado")
            {
                MessageBox.Show("Selecione um curso primeiro!!");
            }
            else
            {
                EMAIL email = new EMAIL();
               email.ShowDialog();
            }

        }

        private void inserirNovoEmailDaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  EmailEmpresa emp = new EmailEmpresa();
           // emp.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_pln_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {

                string queryQTDCD = String.Format(@"SELECT count(Nome_Aluno) as 'contAlunos' FROM'" +tipCurso.Text+"'");

                DataTable dt = new DataTable();
                dt = BancoDeDados.dql(queryQTDCD);
                Globais.cont = Int32.Parse(dt.Rows[0].Field<Int64>("contAlunos").ToString());

                string queryQTDCD2 = String.Format(@"SELECT * FROM'" + tipCurso.Text + "'");


                DataTable dt2 = new DataTable();
                dt2 = BancoDeDados.dql(queryQTDCD2);
                var worksheet = workbook.Worksheets.Add("Planilha");

                worksheet.Cell("A1").Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("A1").Style.Border.BottomBorderColor = XLColor.Black;
                worksheet.Cell("A1").Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("A1").Style.Border.LeftBorderColor = XLColor.Black;
                worksheet.Cell("A1").Style.Border.RightBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("A1").Style.Border.RightBorderColor = XLColor.Black;
                worksheet.Cell("A1").Style.Border.TopBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("A1").Style.Border.TopBorderColor = XLColor.Black;
                worksheet.Cell("A1").Style.Fill.BackgroundColor = XLColor.LightBlue;
               

                worksheet.Cell("B1").Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("B1").Style.Border.BottomBorderColor = XLColor.Black;
                worksheet.Cell("B1").Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("B1").Style.Border.LeftBorderColor = XLColor.Black;
                worksheet.Cell("B1").Style.Border.RightBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("B1").Style.Border.RightBorderColor = XLColor.Black;
                worksheet.Cell("B1").Style.Border.TopBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("B1").Style.Border.TopBorderColor = XLColor.Black;
                worksheet.Cell("B1").Style.Fill.BackgroundColor = XLColor.LightBlue;

                worksheet.Cell("C1").Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("C1").Style.Border.BottomBorderColor = XLColor.Black;
                worksheet.Cell("C1").Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("C1").Style.Border.LeftBorderColor = XLColor.Black;
                worksheet.Cell("C1").Style.Border.RightBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("C1").Style.Border.RightBorderColor = XLColor.Black;
                worksheet.Cell("C1").Style.Border.TopBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("C1").Style.Border.TopBorderColor = XLColor.Black;
                worksheet.Cell("C1").Style.Fill.BackgroundColor = XLColor.LightBlue;

                worksheet.Cell("D1").Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("D1").Style.Border.BottomBorderColor = XLColor.Black;
                worksheet.Cell("D1").Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("D1").Style.Border.LeftBorderColor = XLColor.Black;
                worksheet.Cell("D1").Style.Border.RightBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("D1").Style.Border.RightBorderColor = XLColor.Black;
                worksheet.Cell("D1").Style.Border.TopBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("D1").Style.Border.TopBorderColor = XLColor.Black;
                worksheet.Cell("D1").Style.Fill.BackgroundColor = XLColor.LightBlue;

                worksheet.Cell("E1").Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("E1").Style.Border.BottomBorderColor = XLColor.Black;
                worksheet.Cell("E1").Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("E1").Style.Border.LeftBorderColor = XLColor.Black;
                worksheet.Cell("E1").Style.Border.RightBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("E1").Style.Border.RightBorderColor = XLColor.Black;
                worksheet.Cell("E1").Style.Border.TopBorder = XLBorderStyleValues.Thick;
                worksheet.Cell("E1").Style.Border.TopBorderColor = XLColor.Black;
                worksheet.Cell("E1").Style.Fill.BackgroundColor = XLColor.LightBlue;



                for (int cont=0; cont < Globais.cont; cont++ )
                    {


                   
                    worksheet.Cell("A1").Value = "Nome Aluno"; worksheet.Cell("B1").Value = "Data De Nascimento"; worksheet.Cell("C1").Value = "Email"; worksheet.Cell("D1").Value = "Telefone/Celular"; worksheet.Cell("E1").Value = "Data de inscrição";
                    int cont2 = cont + 1;

                    //INCIO DAS BORDAS{

                    worksheet.Cell("A" +(cont2 + 1)).Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("A" + (cont2 + 1)).Style.Border.BottomBorderColor = XLColor.Black;
                    worksheet.Cell("A" + (cont2 + 1)).Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("A" + (cont2 + 1)).Style.Border.LeftBorderColor = XLColor.Black;
                    worksheet.Cell("A" + (cont2 + 1)).Style.Border.RightBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("A" + (cont2 + 1)).Style.Border.RightBorderColor = XLColor.Black;
                    worksheet.Cell("A" + (cont2 + 1)).Style.Border.TopBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("A" + (cont2 + 1)).Style.Border.TopBorderColor = XLColor.Black;

                    worksheet.Cell("B" + (cont2 + 1)).Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("B" + (cont2 + 1)).Style.Border.BottomBorderColor = XLColor.Black;
                    worksheet.Cell("B" + (cont2 + 1)).Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("B" + (cont2 + 1)).Style.Border.LeftBorderColor = XLColor.Black;
                    worksheet.Cell("B" + (cont2 + 1)).Style.Border.RightBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("B" + (cont2 + 1)).Style.Border.RightBorderColor = XLColor.Black;
                    worksheet.Cell("B" + (cont2 + 1)).Style.Border.TopBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("B" + (cont2 + 1)).Style.Border.TopBorderColor = XLColor.Black;

                    worksheet.Cell("C" + (cont2 + 1)).Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("C" + (cont2 + 1)).Style.Border.BottomBorderColor = XLColor.Black;
                    worksheet.Cell("C" + (cont2 + 1)).Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("C" + (cont2 + 1)).Style.Border.LeftBorderColor = XLColor.Black;
                    worksheet.Cell("C" + (cont2 + 1)).Style.Border.RightBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("C" + (cont2 + 1)).Style.Border.RightBorderColor = XLColor.Black;
                    worksheet.Cell("C" + (cont2 + 1)).Style.Border.TopBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("C" + (cont2 + 1)).Style.Border.TopBorderColor = XLColor.Black;

                    worksheet.Cell("D" + (cont2 + 1)).Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("D" + (cont2 + 1)).Style.Border.BottomBorderColor = XLColor.Black;
                    worksheet.Cell("D" + (cont2 + 1)).Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("D" + (cont2 + 1)).Style.Border.LeftBorderColor = XLColor.Black;
                    worksheet.Cell("D" + (cont2 + 1)).Style.Border.RightBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("D" + (cont2 + 1)).Style.Border.RightBorderColor = XLColor.Black;
                    worksheet.Cell("D" + (cont2 + 1)).Style.Border.TopBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("D" + (cont2 + 1)).Style.Border.TopBorderColor = XLColor.Black;

                    worksheet.Cell("E" + (cont2 + 1)).Style.Border.BottomBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("E" + (cont2 + 1)).Style.Border.BottomBorderColor = XLColor.Black;
                    worksheet.Cell("E" + (cont2 + 1)).Style.Border.LeftBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("E" + (cont2 + 1)).Style.Border.LeftBorderColor = XLColor.Black;
                    worksheet.Cell("E" + (cont2 + 1)).Style.Border.RightBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("E" + (cont2 + 1)).Style.Border.RightBorderColor = XLColor.Black;
                    worksheet.Cell("E" + (cont2 + 1)).Style.Border.TopBorder = XLBorderStyleValues.Thick;
                    worksheet.Cell("E" + (cont2 + 1)).Style.Border.TopBorderColor = XLColor.Black;




                    //FIM DAS BORDAS}
                    worksheet.Column("A").Width = 25;
                    worksheet.Column("B").Width = 25;
                    worksheet.Column("C").Width = 25;
                    worksheet.Column("D").Width = 25;
                    worksheet.Column("E").Width = 25;
                    worksheet.Cell("A" + (cont2 + 1)).Value = dt2.Rows[cont].Field<string>("Nome_Aluno").ToString();
                    worksheet.Cell("B" + (cont2 + 1)).Value = dt2.Rows[cont].Field<string>("Data_Aluno").ToString();
                    worksheet.Cell("C" + (cont2 + 1)).Value = dt2.Rows[cont].Field<string>("email").ToString();
                    worksheet.Cell("D" + (cont2 + 1)).Value = dt2.Rows[cont].Field<string>("TelefoneCelular").ToString();
                    worksheet.Cell("E" + (cont2 + 1)).Value = dt2.Rows[cont].Field<string>("Data").ToString();



                    workbook.SaveAs(Globais.CaminhoDaPlanilha+Globais.NomePlanilha);
                }
            }
                Process.Start(new ProcessStartInfo(Globais.CaminhoDaPlanilha+Globais.NomePlanilha) { UseShellExecute = true });
            
        }
    }
}



