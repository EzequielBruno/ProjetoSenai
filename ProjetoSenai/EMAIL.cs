using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace ProjetoSenai
{
    public partial class EMAIL : Form
    {
        public EMAIL()
        {
            InitializeComponent();


            string queryQTDCD = String.Format(@"SELECT count(tbl_name) as 'contAlunos' FROM
                                               sqlite_master WHERE type='table'");
            DataTable dt = new DataTable();
            dt = BancoDeDados.dql(queryQTDCD);
            Globais.cont = Int32.Parse(dt.Rows[0].Field<Int64>("contAlunos").ToString());
            DataTable dt2 = new DataTable();
            dt2 = BancoDeDados.ObterTabela();
            cb_curso.Text = dt2.Rows[0].Field<string>("Cursos").ToString();
            for (int cont = 0; cont < Globais.cont; cont++)
            {
                string Nomess = dt2.Rows[cont].Field<string>("Cursos").ToString();
                cb_curso.Items.Add(Nomess);
            }



            string queryQTDCD3 = String.Format(@"SELECT count(email) as 'em' FROM'" + Globais.Curso + "'");

            DataTable dt6 = new DataTable();
            dt6 = BancoDeDados.dql(queryQTDCD3);
            Globais.cont2 = Int32.Parse(dt6.Rows[0].Field<Int64>("em").ToString());



            Globais.Curso = cb_curso.Text;
            string queryQTDCD1 = String.Format(@"SELECT email as 'em' FROM'" + Globais.Curso + "'");

            DataTable dt4 = new DataTable();
            dt4 = BancoDeDados.dql(queryQTDCD1);





            for (int cont = 0; cont < Globais.cont2; cont++)
            {
                string Nomess = dt4.Rows[cont].Field<string>("em").ToString();
                cb_email.Items.Add(Nomess);
            }
            cb_email.Text = dt4.Rows[0].Field<string>("em").ToString();



        }



       



        private async void BTN_ENVIAR_Click(object sender, EventArgs e)
        {
            pgbr.Value = 0;
            pgbr.Value = 50;
            bool con = true;
            await Task.Delay(TimeSpan.FromMilliseconds(200));
            if (chbox.Checked == false)
            {
                
                MailMessage mailMessage = new MailMessage("EmailDaEmpresaAqui", cb_email.Text);
                try
                {
                    
                    mailMessage.Subject = TB_TITULO.Text;//titulo email
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = TB_MENSAGEM.Text;
                    mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                    mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                    var smtpClient = new SmtpClient("smtp.elasticemail.com", 2525);
                    smtpClient.UseDefaultCredentials = false;
                   
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential("EmailDaEmpresaAqui", "ChaveDisponibilizadaPelaAPIAqui");
                    smtpClient.Send(mailMessage);
                    pgbr.Value = 100;
                    await Task.Delay(TimeSpan.FromMilliseconds(200));
                    MessageBox.Show("Email enviado com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "FALHA");
                }
                
            }
            else
            {
               

                Globais.Curso = cb_curso.Text;
                string queryQTDCD = String.Format(@"SELECT count(email) as 'em' FROM'" + Globais.Curso + "'");

                DataTable dt = new DataTable();
                dt = BancoDeDados.dql(queryQTDCD);
                Globais.cont2 = Int32.Parse(dt.Rows[0].Field<Int64>("em").ToString());

                string queryQTDCD1 = String.Format(@"SELECT email as 'em' FROM'" + Globais.Curso + "'");

                DataTable dt1 = new DataTable();
                dt1 = BancoDeDados.dql(queryQTDCD1);
                double val = 0;
                double pr = 0;
                double pr2 = 0;
                for (int cont = 0; cont < Globais.cont2; cont++)
                {
                    
                        pr = 100 / Globais.cont2;
                        val = pr+pr;
                        TB_TITULO.Text = val.ToString();
                        pgbr.Value = Convert.ToInt32(val);
                    
                    await Task.Delay(TimeSpan.FromMilliseconds(200));
                    try
                    {
                    
                        MailMessage mailMessage = new MailMessage("EmailDaEmpresaAqui", dt1.Rows[0].Field<string>("em").ToString());
                        mailMessage.Subject = TB_TITULO.Text;
                        mailMessage.IsBodyHtml = true;
                        mailMessage.Body = TB_MENSAGEM.Text;
                        mailMessage.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                        mailMessage.BodyEncoding = Encoding.GetEncoding("UTF-8");

                        var smtpClient = new SmtpClient("smtp.elasticemail.com", 2525);
                        smtpClient.UseDefaultCredentials = false;

                        smtpClient.EnableSsl = true;
                        smtpClient.Credentials = new NetworkCredential("EmailDaEmpresaAqui", "ChaveDisponibilizadaPelaAPIAqui");
                        smtpClient.Send(mailMessage);
                        con = true;

                       

                    }
                 
                    catch (Exception ex)
                    {
                        con = false;
                        MessageBox.Show(ex.Message, "FALHA");
                    }
                }
                if (con == true)
                {
                    MessageBox.Show("Emails enviado com Sucesso");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_email.Items.Clear();


            Globais.Curso = cb_curso.Text;


            string queryQTDCD = String.Format(@"SELECT count(email) as 'em' FROM'" + Globais.Curso + "'");

            DataTable dt = new DataTable();
            dt = BancoDeDados.dql(queryQTDCD);
            Globais.cont2 = Int32.Parse(dt.Rows[0].Field<Int64>("em").ToString());



            string queryQTDCD1 = String.Format(@"SELECT email as 'em' FROM'" + Globais.Curso + "'");

            DataTable dt4 = new DataTable();
            dt4 = BancoDeDados.dql(queryQTDCD1);







            for (int cont = 0; cont < Globais.cont2; cont++)
            {
                string Nomess = dt4.Rows[cont].Field<string>("em").ToString();
                cb_email.Items.Add(Nomess);
            }
            cb_email.Text = dt4.Rows[0].Field<string>("em").ToString();
        
    
            

        }

        private void chbox_CheckedChanged(object sender, EventArgs e)
        {
            if(chbox.Checked == true)
            {
                cb_email.Enabled = false;
            }
            else
            {
                cb_email.Enabled = true;
            }
        }
    }
    





}
