namespace CadastroPessoa.Formularios {
	partial class FormVenda {
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
			this.label12 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
			this.txtCodigoVenda = new System.Windows.Forms.TextBox();
			this.ddlCliente = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.gridItensVenda = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.ddlProduto = new System.Windows.Forms.ComboBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridItensVenda)).BeginInit();
			this.SuspendLayout();
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(185, 18);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 13);
			this.label12.TabIndex = 51;
			this.label12.Text = "Venda";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Código Funcionário";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 49;
			this.label1.Text = "Codigo Venda";
			// 
			// txtCodigoFuncionario
			// 
			this.txtCodigoFuncionario.Location = new System.Drawing.Point(119, 92);
			this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
			this.txtCodigoFuncionario.Size = new System.Drawing.Size(121, 20);
			this.txtCodigoFuncionario.TabIndex = 48;
			// 
			// txtCodigoVenda
			// 
			this.txtCodigoVenda.Location = new System.Drawing.Point(119, 66);
			this.txtCodigoVenda.Name = "txtCodigoVenda";
			this.txtCodigoVenda.Size = new System.Drawing.Size(121, 20);
			this.txtCodigoVenda.TabIndex = 47;
			// 
			// ddlCliente
			// 
			this.ddlCliente.FormattingEnabled = true;
			this.ddlCliente.Location = new System.Drawing.Point(119, 125);
			this.ddlCliente.Name = "ddlCliente";
			this.ddlCliente.Size = new System.Drawing.Size(121, 21);
			this.ddlCliente.TabIndex = 52;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 53;
			this.label3.Text = "Cliente";
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(119, 152);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(121, 20);
			this.txtQuantidade.TabIndex = 54;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(51, 155);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 55;
			this.label4.Text = "Quantidade";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(439, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 13);
			this.label5.TabIndex = 56;
			this.label5.Text = "Total Venda";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(555, 159);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(13, 13);
			this.lblTotal.TabIndex = 57;
			this.lblTotal.Text = "0";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(633, 219);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 59;
			this.btnAdd.Text = "Adicionar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// gridItensVenda
			// 
			this.gridItensVenda.AllowUserToAddRows = false;
			this.gridItensVenda.AllowUserToDeleteRows = false;
			this.gridItensVenda.AllowUserToResizeColumns = false;
			this.gridItensVenda.AllowUserToResizeRows = false;
			this.gridItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridItensVenda.Location = new System.Drawing.Point(42, 248);
			this.gridItensVenda.Name = "gridItensVenda";
			this.gridItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridItensVenda.ShowCellErrors = false;
			this.gridItensVenda.ShowCellToolTips = false;
			this.gridItensVenda.ShowEditingIcon = false;
			this.gridItensVenda.ShowRowErrors = false;
			this.gridItensVenda.Size = new System.Drawing.Size(666, 150);
			this.gridItensVenda.TabIndex = 58;
			this.gridItensVenda.VirtualMode = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(288, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 61;
			this.label6.Text = "Produto";
			// 
			// ddlProduto
			// 
			this.ddlProduto.FormattingEnabled = true;
			this.ddlProduto.Location = new System.Drawing.Point(343, 219);
			this.ddlProduto.Name = "ddlProduto";
			this.ddlProduto.Size = new System.Drawing.Size(121, 21);
			this.ddlProduto.TabIndex = 60;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(42, 421);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 62;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// FormVenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 456);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ddlProduto);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.gridItensVenda);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtQuantidade);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ddlCliente);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCodigoFuncionario);
			this.Controls.Add(this.txtCodigoVenda);
			this.Name = "FormVenda";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormVenda";
			((System.ComponentModel.ISupportInitialize)(this.gridItensVenda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCodigoFuncionario;
		private System.Windows.Forms.TextBox txtCodigoVenda;
		private System.Windows.Forms.ComboBox ddlCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtQuantidade;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView gridItensVenda;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox ddlProduto;
		private System.Windows.Forms.Button btnSalvar;
	}
}