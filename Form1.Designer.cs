namespace GrillaFromBindingList
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.alturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.nacimientoDataGridViewTextBoxColumn,
            this.alturaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.datosBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(776, 426);
			this.dataGridView1.TabIndex = 0;
			// 
			// datosBindingSource
			// 
			this.datosBindingSource.DataSource = typeof(GrillaFromBindingList.Models.Datos);
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
			this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
			this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			// 
			// edadDataGridViewTextBoxColumn
			// 
			this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
			this.edadDataGridViewTextBoxColumn.HeaderText = "edad";
			this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
			// 
			// nacimientoDataGridViewTextBoxColumn
			// 
			this.nacimientoDataGridViewTextBoxColumn.DataPropertyName = "nacimiento";
			this.nacimientoDataGridViewTextBoxColumn.HeaderText = "nacimiento";
			this.nacimientoDataGridViewTextBoxColumn.Name = "nacimientoDataGridViewTextBoxColumn";
			// 
			// alturaDataGridViewTextBoxColumn
			// 
			this.alturaDataGridViewTextBoxColumn.DataPropertyName = "altura";
			this.alturaDataGridViewTextBoxColumn.HeaderText = "altura";
			this.alturaDataGridViewTextBoxColumn.Name = "alturaDataGridViewTextBoxColumn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 447);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn alturaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource datosBindingSource;
	}
}

