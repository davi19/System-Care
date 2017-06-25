namespace SystemCare
{
    partial class Consultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridConsultas = new MetroFramework.Controls.MetroGrid();
            this.FecharConsulta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Consultar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridConsultas
            // 
            this.GridConsultas.AllowUserToAddRows = false;
            this.GridConsultas.AllowUserToDeleteRows = false;
            this.GridConsultas.AllowUserToResizeRows = false;
            this.GridConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FecharConsulta,
            this.Consultar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridConsultas.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridConsultas.EnableHeadersVisualStyles = false;
            this.GridConsultas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridConsultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridConsultas.Location = new System.Drawing.Point(23, 87);
            this.GridConsultas.Name = "GridConsultas";
            this.GridConsultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridConsultas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridConsultas.Size = new System.Drawing.Size(754, 190);
            this.GridConsultas.Style = MetroFramework.MetroColorStyle.Green;
            this.GridConsultas.TabIndex = 0;
            this.GridConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsultas_CellContentClick);
            // 
            // FecharConsulta
            // 
            this.FecharConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FecharConsulta.HeaderText = "Encerrar Consulta";
            this.FecharConsulta.Name = "FecharConsulta";
            this.FecharConsulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FecharConsulta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FecharConsulta.Text = "Encerrar Consulta";
            this.FecharConsulta.UseColumnTextForButtonValue = true;
            this.FecharConsulta.Width = 111;
            // 
            // Consultar
            // 
            this.Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar.HeaderText = "Consultas";
            this.Consultar.Name = "Consultar";
            this.Consultar.Text = "Consultar";
            this.Consultar.UseColumnTextForButtonValue = true;
            this.Consultar.Width = 62;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.GridConsultas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Consultas";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GridConsultas;
        private System.Windows.Forms.DataGridViewButtonColumn FecharConsulta;
        private System.Windows.Forms.DataGridViewButtonColumn Consultar;
    }
}