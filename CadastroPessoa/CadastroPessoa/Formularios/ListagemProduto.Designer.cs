﻿namespace CadastroPessoa.Formularios {
	partial class ListagemProduto {
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(28, 59);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Adicionar";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(297, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Listagem Produtos";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(28, 88);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(657, 192);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(529, 317);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 23);
			this.btnEditar.TabIndex = 3;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(610, 317);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 23);
			this.btnExcluir.TabIndex = 4;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// ListagemProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 360);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdd);
			this.Name = "ListagemProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ListagemProduto";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
	}
}