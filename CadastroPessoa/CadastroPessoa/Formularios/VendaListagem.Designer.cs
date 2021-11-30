namespace CadastroPessoa.Formularios {
	partial class VendaListagem {
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
			this.gridVenda = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridVenda)).BeginInit();
			this.SuspendLayout();
			// 
			// gridVenda
			// 
			this.gridVenda.AllowUserToAddRows = false;
			this.gridVenda.AllowUserToDeleteRows = false;
			this.gridVenda.AllowUserToResizeColumns = false;
			this.gridVenda.AllowUserToResizeRows = false;
			this.gridVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridVenda.Location = new System.Drawing.Point(12, 99);
			this.gridVenda.Name = "gridVenda";
			this.gridVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridVenda.ShowCellErrors = false;
			this.gridVenda.ShowCellToolTips = false;
			this.gridVenda.ShowEditingIcon = false;
			this.gridVenda.ShowRowErrors = false;
			this.gridVenda.Size = new System.Drawing.Size(666, 150);
			this.gridVenda.TabIndex = 10;
			this.gridVenda.VirtualMode = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(294, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Listagem Vendas";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(25, 53);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 6;
			this.btnAdd.Text = "Adicionar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// VendaListagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 347);
			this.Controls.Add(this.gridVenda);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdd);
			this.Name = "VendaListagem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VendaListagem";
			((System.ComponentModel.ISupportInitialize)(this.gridVenda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridVenda;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
	}
}