namespace ProjetoSenai
{
    partial class EMAIL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMAIL));
            this.TB_MENSAGEM = new System.Windows.Forms.TextBox();
            this.TB_TITULO = new System.Windows.Forms.TextBox();
            this.BTN_ENVIAR = new System.Windows.Forms.Button();
            this.cb_curso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_email = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbox = new System.Windows.Forms.CheckBox();
            this.pgbr = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_MENSAGEM
            // 
            this.TB_MENSAGEM.Location = new System.Drawing.Point(12, 216);
            this.TB_MENSAGEM.Multiline = true;
            this.TB_MENSAGEM.Name = "TB_MENSAGEM";
            this.TB_MENSAGEM.Size = new System.Drawing.Size(512, 209);
            this.TB_MENSAGEM.TabIndex = 0;
            // 
            // TB_TITULO
            // 
            this.TB_TITULO.Location = new System.Drawing.Point(12, 190);
            this.TB_TITULO.Name = "TB_TITULO";
            this.TB_TITULO.Size = new System.Drawing.Size(100, 20);
            this.TB_TITULO.TabIndex = 1;
            // 
            // BTN_ENVIAR
            // 
            this.BTN_ENVIAR.Location = new System.Drawing.Point(544, 402);
            this.BTN_ENVIAR.Name = "BTN_ENVIAR";
            this.BTN_ENVIAR.Size = new System.Drawing.Size(75, 23);
            this.BTN_ENVIAR.TabIndex = 2;
            this.BTN_ENVIAR.Text = "Enviar";
            this.BTN_ENVIAR.UseVisualStyleBackColor = true;
            this.BTN_ENVIAR.Click += new System.EventHandler(this.BTN_ENVIAR_Click);
            // 
            // cb_curso
            // 
            this.cb_curso.FormattingEnabled = true;
            this.cb_curso.Location = new System.Drawing.Point(12, 54);
            this.cb_curso.Name = "cb_curso";
            this.cb_curso.Size = new System.Drawing.Size(121, 21);
            this.cb_curso.TabIndex = 3;
            this.cb_curso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Curso";
            // 
            // cb_email
            // 
            this.cb_email.FormattingEnabled = true;
            this.cb_email.Location = new System.Drawing.Point(12, 113);
            this.cb_email.Name = "cb_email";
            this.cb_email.Size = new System.Drawing.Size(285, 21);
            this.cb_email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecione ou digite o email";
            // 
            // chbox
            // 
            this.chbox.AutoSize = true;
            this.chbox.Location = new System.Drawing.Point(303, 117);
            this.chbox.Name = "chbox";
            this.chbox.Size = new System.Drawing.Size(56, 17);
            this.chbox.TabIndex = 7;
            this.chbox.Text = "Todos";
            this.chbox.UseVisualStyleBackColor = true;
            this.chbox.CheckedChanged += new System.EventHandler(this.chbox_CheckedChanged);
            // 
            // pgbr
            // 
            this.pgbr.Location = new System.Drawing.Point(15, 511);
            this.pgbr.Name = "pgbr";
            this.pgbr.Size = new System.Drawing.Size(773, 23);
            this.pgbr.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Progresso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjetoSenai.Properties.Resources.download;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(602, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // EMAIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pgbr);
            this.Controls.Add(this.chbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_curso);
            this.Controls.Add(this.BTN_ENVIAR);
            this.Controls.Add(this.TB_TITULO);
            this.Controls.Add(this.TB_MENSAGEM);
            this.Name = "EMAIL";
            this.Text = "EMAIL";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_MENSAGEM;
        private System.Windows.Forms.TextBox TB_TITULO;
        private System.Windows.Forms.Button BTN_ENVIAR;
        private System.Windows.Forms.ComboBox cb_curso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbox;
        private System.Windows.Forms.ProgressBar pgbr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}