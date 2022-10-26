namespace ProjetoSenai
{
    partial class CursoCaldeiraria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lixo1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lixo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lixo = new System.Windows.Forms.DataGridView();
            this.lixo7 = new System.Windows.Forms.Button();
            this.lixo6 = new System.Windows.Forms.Button();
            this.lixo5 = new System.Windows.Forms.Button();
            this.lixo3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lixo4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lixo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Candidato(a)";
            // 
            // lixo1
            // 
            this.lixo1.Cursor = System.Windows.Forms.Cursors.No;
            this.lixo1.Enabled = false;
            this.lixo1.HideSelection = false;
            this.lixo1.Location = new System.Drawing.Point(34, 58);
            this.lixo1.Name = "lixo1";
            this.lixo1.Size = new System.Drawing.Size(196, 20);
            this.lixo1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // lixo2
            // 
            this.lixo2.Cursor = System.Windows.Forms.Cursors.No;
            this.lixo2.Enabled = false;
            this.lixo2.HideSelection = false;
            this.lixo2.Location = new System.Drawing.Point(34, 112);
            this.lixo2.Name = "lixo2";
            this.lixo2.Size = new System.Drawing.Size(100, 20);
            this.lixo2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Nacismento";
            // 
            // lixo
            // 
            this.lixo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lixo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lixo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lixo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lixo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lixo.EnableHeadersVisualStyles = false;
            this.lixo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lixo.Location = new System.Drawing.Point(282, 12);
            this.lixo.MultiSelect = false;
            this.lixo.Name = "lixo";
            this.lixo.RowHeadersVisible = false;
            this.lixo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lixo.Size = new System.Drawing.Size(240, 307);
            this.lixo.TabIndex = 7;
            this.lixo.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // lixo7
            // 
            this.lixo7.Location = new System.Drawing.Point(34, 185);
            this.lixo7.Name = "lixo7";
            this.lixo7.Size = new System.Drawing.Size(75, 23);
            this.lixo7.TabIndex = 8;
            this.lixo7.Text = "Editar";
            this.lixo7.UseVisualStyleBackColor = true;
            // 
            // lixo6
            // 
            this.lixo6.Location = new System.Drawing.Point(115, 185);
            this.lixo6.Name = "lixo6";
            this.lixo6.Size = new System.Drawing.Size(75, 23);
            this.lixo6.TabIndex = 9;
            this.lixo6.Text = "Excluir";
            this.lixo6.UseVisualStyleBackColor = true;
            // 
            // lixo5
            // 
            this.lixo5.Location = new System.Drawing.Point(34, 296);
            this.lixo5.Name = "lixo5";
            this.lixo5.Size = new System.Drawing.Size(100, 23);
            this.lixo5.TabIndex = 10;
            this.lixo5.Text = "Adicionar novo";
            this.lixo5.UseVisualStyleBackColor = true;
            this.lixo5.Click += new System.EventHandler(this.btn_addCD_Click);
            // 
            // lixo3
            // 
            this.lixo3.Cursor = System.Windows.Forms.Cursors.No;
            this.lixo3.Enabled = false;
            this.lixo3.HideSelection = false;
            this.lixo3.Location = new System.Drawing.Point(140, 112);
            this.lixo3.Name = "lixo3";
            this.lixo3.Size = new System.Drawing.Size(136, 20);
            this.lixo3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone/Celular";
            // 
            // lixo4
            // 
            this.lixo4.Cursor = System.Windows.Forms.Cursors.No;
            this.lixo4.Enabled = false;
            this.lixo4.HideSelection = false;
            this.lixo4.Location = new System.Drawing.Point(34, 159);
            this.lixo4.Name = "lixo4";
            this.lixo4.ReadOnly = true;
            this.lixo4.Size = new System.Drawing.Size(47, 20);
            this.lixo4.TabIndex = 13;
            this.lixo4.TabStop = false;
            this.lixo4.TextChanged += new System.EventHandler(this.tb_qtdCD_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantidade de interessados";
            // 
            // CursoCaldeiraria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 331);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lixo4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lixo3);
            this.Controls.Add(this.lixo5);
            this.Controls.Add(this.lixo6);
            this.Controls.Add(this.lixo7);
            this.Controls.Add(this.lixo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lixo2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lixo1);
            this.Controls.Add(this.label1);
            this.Name = "CursoCaldeiraria";
            this.Text = "CursoCaldeiraria";
            ((System.ComponentModel.ISupportInitialize)(this.lixo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lixo7;
        private System.Windows.Forms.Button lixo6;
        private System.Windows.Forms.Button lixo5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox lixo4;
        public System.Windows.Forms.TextBox lixo1;
        public System.Windows.Forms.DataGridView lixo;
        public System.Windows.Forms.TextBox lixo2;
        public System.Windows.Forms.TextBox lixo3;
    }
}