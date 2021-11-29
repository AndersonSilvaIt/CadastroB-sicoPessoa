namespace CadastroPessoa.Formularios {
	partial class ClienteListagem {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gridCliente = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(188, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Lista Cliente";
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(603, 247);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 8;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(522, 247);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 62);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Adicionar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// gridCliente
			// 
			this.gridCliente.AllowUserToAddRows = false;
			this.gridCliente.AllowUserToDeleteRows = false;
			this.gridCliente.AllowUserToResizeColumns = false;
			this.gridCliente.AllowUserToResizeRows = false;
			this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCliente.Location = new System.Drawing.Point(12, 91);
			this.gridCliente.Name = "gridCliente";
			this.gridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridCliente.ShowCellErrors = false;
			this.gridCliente.ShowCellToolTips = false;
			this.gridCliente.ShowEditingIcon = false;
			this.gridCliente.ShowRowErrors = false;
			this.gridCliente.Size = new System.Drawing.Size(666, 150);
			this.gridCliente.TabIndex = 5;
			this.gridCliente.VirtualMode = true;
			// 
			// ClienteListagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 282);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.gridCliente);
			this.Name = "ClienteListagem";
			this.Text = "ClienteListagem";
			((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView gridCliente;
	}
}