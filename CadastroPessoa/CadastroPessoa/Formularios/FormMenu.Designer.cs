namespace CadastroPessoa.Formularios {
	partial class FormMenu {
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
			this.btnFunc = new System.Windows.Forms.Button();
			this.btnProduto = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnFunc
			// 
			this.btnFunc.Location = new System.Drawing.Point(34, 47);
			this.btnFunc.Name = "btnFunc";
			this.btnFunc.Size = new System.Drawing.Size(75, 75);
			this.btnFunc.TabIndex = 0;
			this.btnFunc.Text = "Funcionário";
			this.btnFunc.UseVisualStyleBackColor = true;
			this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
			// 
			// btnProduto
			// 
			this.btnProduto.Location = new System.Drawing.Point(144, 47);
			this.btnProduto.Name = "btnProduto";
			this.btnProduto.Size = new System.Drawing.Size(75, 75);
			this.btnProduto.TabIndex = 1;
			this.btnProduto.Text = "Produto";
			this.btnProduto.UseVisualStyleBackColor = true;
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(34, 128);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(75, 75);
			this.btnCliente.TabIndex = 2;
			this.btnCliente.Text = "Cliente";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 241);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.btnProduto);
			this.Controls.Add(this.btnFunc);
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMenu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnFunc;
		private System.Windows.Forms.Button btnProduto;
		private System.Windows.Forms.Button btnCliente;
	}
}