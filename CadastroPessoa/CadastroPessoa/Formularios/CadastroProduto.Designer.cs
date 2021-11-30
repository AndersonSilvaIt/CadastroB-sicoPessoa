namespace CadastroPessoa.Formularios {
	partial class CadastroProduto {
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtnome_func = new System.Windows.Forms.TextBox();
			this.txtCod_func = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Descrição";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Codigo";
			// 
			// txtnome_func
			// 
			this.txtnome_func.Location = new System.Drawing.Point(88, 54);
			this.txtnome_func.Name = "txtnome_func";
			this.txtnome_func.Size = new System.Drawing.Size(248, 20);
			this.txtnome_func.TabIndex = 13;
			// 
			// txtCod_func
			// 
			this.txtCod_func.Location = new System.Drawing.Point(88, 28);
			this.txtCod_func.Name = "txtCod_func";
			this.txtCod_func.Size = new System.Drawing.Size(248, 20);
			this.txtCod_func.TabIndex = 12;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(132, 103);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 23);
			this.btnSalvar.TabIndex = 17;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// CadastroProduto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 145);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtnome_func);
			this.Controls.Add(this.txtCod_func);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CadastroProduto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CadastroProduto";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnome_func;
		private System.Windows.Forms.TextBox txtCod_func;
		private System.Windows.Forms.Button btnSalvar;
	}
}