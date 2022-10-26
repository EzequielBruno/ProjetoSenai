namespace ProjetoSenai
{
    partial class DTCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DTCursos));
            this.DDgv = new System.Windows.Forms.DataGridView();
            this.btn_ConfDTCursos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_CursoExEdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_editCD = new System.Windows.Forms.Button();
            this.btn_excluirCD = new System.Windows.Forms.Button();
            this.tb_exlock = new System.Windows.Forms.TextBox();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DDgv
            // 
            this.DDgv.AllowUserToAddRows = false;
            this.DDgv.AllowUserToDeleteRows = false;
            this.DDgv.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DDgv.Location = new System.Drawing.Point(12, 12);
            this.DDgv.MultiSelect = false;
            this.DDgv.Name = "DDgv";
            this.DDgv.ReadOnly = true;
            this.DDgv.RowHeadersVisible = false;
            this.DDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DDgv.Size = new System.Drawing.Size(497, 261);
            this.DDgv.TabIndex = 1;
            this.DDgv.SelectionChanged += new System.EventHandler(this.DDgv_SelectionChanged);
            // 
            // btn_ConfDTCursos
            // 
            this.btn_ConfDTCursos.BackColor = System.Drawing.Color.White;
            this.btn_ConfDTCursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ConfDTCursos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ConfDTCursos.Location = new System.Drawing.Point(402, 279);
            this.btn_ConfDTCursos.Name = "btn_ConfDTCursos";
            this.btn_ConfDTCursos.Size = new System.Drawing.Size(107, 21);
            this.btn_ConfDTCursos.TabIndex = 2;
            this.btn_ConfDTCursos.Text = "Confirmar";
            this.btn_ConfDTCursos.UseVisualStyleBackColor = false;
            this.btn_ConfDTCursos.Click += new System.EventHandler(this.btn_ConfDTCursos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(9, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Nome do Candidato(a)";
            // 
            // tb_CursoExEdi
            // 
            this.tb_CursoExEdi.BackColor = System.Drawing.Color.LavenderBlush;
            this.tb_CursoExEdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CursoExEdi.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_CursoExEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CursoExEdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_CursoExEdi.Location = new System.Drawing.Point(12, 319);
            this.tb_CursoExEdi.Name = "tb_CursoExEdi";
            this.tb_CursoExEdi.Size = new System.Drawing.Size(196, 20);
            this.tb_CursoExEdi.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(78, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Editar";
            // 
            // btn_editCD
            // 
            this.btn_editCD.BackColor = System.Drawing.Color.White;
            this.btn_editCD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editCD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_editCD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_editCD.Location = new System.Drawing.Point(224, 319);
            this.btn_editCD.Name = "btn_editCD";
            this.btn_editCD.Size = new System.Drawing.Size(75, 23);
            this.btn_editCD.TabIndex = 43;
            this.btn_editCD.Text = "Editar";
            this.btn_editCD.UseVisualStyleBackColor = false;
            this.btn_editCD.Click += new System.EventHandler(this.btn_editCD_Click);
            // 
            // btn_excluirCD
            // 
            this.btn_excluirCD.BackColor = System.Drawing.Color.White;
            this.btn_excluirCD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excluirCD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excluirCD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excluirCD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluirCD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_excluirCD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_excluirCD.Location = new System.Drawing.Point(12, 359);
            this.btn_excluirCD.Name = "btn_excluirCD";
            this.btn_excluirCD.Size = new System.Drawing.Size(75, 23);
            this.btn_excluirCD.TabIndex = 44;
            this.btn_excluirCD.Text = "Excluir";
            this.btn_excluirCD.UseVisualStyleBackColor = false;
            this.btn_excluirCD.Click += new System.EventHandler(this.btn_excluirCD_Click);
            // 
            // tb_exlock
            // 
            this.tb_exlock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_exlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_exlock.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_exlock.Enabled = false;
            this.tb_exlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_exlock.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_exlock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_exlock.Location = new System.Drawing.Point(12, 292);
            this.tb_exlock.Name = "tb_exlock";
            this.tb_exlock.ReadOnly = true;
            this.tb_exlock.Size = new System.Drawing.Size(196, 20);
            this.tb_exlock.TabIndex = 45;
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.AllowUserToDeleteRows = false;
            this.DGV2.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV2.Enabled = false;
            this.DGV2.Location = new System.Drawing.Point(515, 12);
            this.DGV2.MultiSelect = false;
            this.DGV2.Name = "DGV2";
            this.DGV2.ReadOnly = true;
            this.DGV2.RowHeadersVisible = false;
            this.DGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV2.Size = new System.Drawing.Size(285, 261);
            this.DGV2.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::ProjetoSenai.Properties.Resources.download;
            this.pictureBox1.Image = global::ProjetoSenai.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(635, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // DTCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(812, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV2);
            this.Controls.Add(this.tb_exlock);
            this.Controls.Add(this.btn_excluirCD);
            this.Controls.Add(this.btn_editCD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_CursoExEdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ConfDTCursos);
            this.Controls.Add(this.DDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DTCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.DDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DDgv;
        private System.Windows.Forms.Button btn_ConfDTCursos;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tb_CursoExEdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_editCD;
        private System.Windows.Forms.Button btn_excluirCD;
        public System.Windows.Forms.TextBox tb_exlock;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}