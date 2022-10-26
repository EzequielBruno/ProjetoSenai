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
    public partial class NovoCD : Form
    {
        public NovoCD()
        {
            InitializeComponent();
            Globais.closed = false;
        }

       




            private void btn_SalvarCD_Click(object sender, EventArgs e)
        {
            
            if (tb_nvd.Text == "" && tb_ndt.Text == "" && tb_celular.Text == "")
            {
                MessageBox.Show("Digite um nome ou data válida");
            }
            else
            {
               
                Globais.nome = tb_nvd.Text;
                Globais.data = tb_ndt.Text;
                Globais.Celular = tb_celular.Text;
                Globais.email = tb_email.Text;
                Globais.Data1 = Datainscr1.Text;
                BancoDeDados.NovoAluno();
                tb_nvd.Text = "";
                tb_ndt.Text = "";
                tb_celular.Text = "";
                tb_email.Text = "";
               
                Globais.closed = true;


            }
            
        }
    }
}
