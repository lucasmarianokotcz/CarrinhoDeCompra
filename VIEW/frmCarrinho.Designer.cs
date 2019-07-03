namespace CarrinhoDeCompra
{
    partial class frmCarrinho
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionarAoCarrinho = new System.Windows.Forms.Button();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.btnFecharPedido = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalCarrinho = new System.Windows.Forms.Label();
            this.btnLimparCarrinho = new System.Windows.Forms.Button();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.panelDadosProduto = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.panelDadosProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica Neue", 15.75F);
            this.label1.Location = new System.Drawing.Point(422, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carrinho de compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(78, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(54, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor unitário";
            // 
            // btnAdicionarAoCarrinho
            // 
            this.btnAdicionarAoCarrinho.Location = new System.Drawing.Point(67, 167);
            this.btnAdicionarAoCarrinho.Name = "btnAdicionarAoCarrinho";
            this.btnAdicionarAoCarrinho.Size = new System.Drawing.Size(155, 23);
            this.btnAdicionarAoCarrinho.TabIndex = 7;
            this.btnAdicionarAoCarrinho.Text = "Adicionar ao carrinho";
            this.btnAdicionarAoCarrinho.UseVisualStyleBackColor = true;
            this.btnAdicionarAoCarrinho.Click += new System.EventHandler(this.btnAdicionarAoCarrinho_Click);
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Location = new System.Drawing.Point(57, 247);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.RowTemplate.Height = 23;
            this.dgvCarrinho.Size = new System.Drawing.Size(971, 269);
            this.dgvCarrinho.TabIndex = 8;
            this.dgvCarrinho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellClick);
            this.dgvCarrinho.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarrinho_CellEndEdit);
            // 
            // btnFecharPedido
            // 
            this.btnFecharPedido.Location = new System.Drawing.Point(922, 522);
            this.btnFecharPedido.Name = "btnFecharPedido";
            this.btnFecharPedido.Size = new System.Drawing.Size(106, 32);
            this.btnFecharPedido.TabIndex = 9;
            this.btnFecharPedido.Text = "Fechar pedido";
            this.btnFecharPedido.UseVisualStyleBackColor = true;
            this.btnFecharPedido.Click += new System.EventHandler(this.btnFecharPedido_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor total: R$";
            // 
            // lblTotalCarrinho
            // 
            this.lblTotalCarrinho.AutoSize = true;
            this.lblTotalCarrinho.Location = new System.Drawing.Point(128, 532);
            this.lblTotalCarrinho.Name = "lblTotalCarrinho";
            this.lblTotalCarrinho.Size = new System.Drawing.Size(28, 14);
            this.lblTotalCarrinho.TabIndex = 11;
            this.lblTotalCarrinho.Text = "0,00";
            // 
            // btnLimparCarrinho
            // 
            this.btnLimparCarrinho.Location = new System.Drawing.Point(922, 86);
            this.btnLimparCarrinho.Name = "btnLimparCarrinho";
            this.btnLimparCarrinho.Size = new System.Drawing.Size(106, 32);
            this.btnLimparCarrinho.TabIndex = 13;
            this.btnLimparCarrinho.Text = "Limpar carrinho";
            this.btnLimparCarrinho.UseVisualStyleBackColor = true;
            this.btnLimparCarrinho.Click += new System.EventHandler(this.btnLimparCarrinho_Click);
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(3, 30);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(100, 21);
            this.txtValorUnitario.TabIndex = 5;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(3, 3);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 21);
            this.txtProduto.TabIndex = 3;
            // 
            // panelDadosProduto
            // 
            this.panelDadosProduto.Controls.Add(this.txtProduto);
            this.panelDadosProduto.Controls.Add(this.txtValorUnitario);
            this.panelDadosProduto.Location = new System.Drawing.Point(128, 97);
            this.panelDadosProduto.Name = "panelDadosProduto";
            this.panelDadosProduto.Size = new System.Drawing.Size(129, 57);
            this.panelDadosProduto.TabIndex = 12;
            // 
            // frmCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 583);
            this.Controls.Add(this.btnLimparCarrinho);
            this.Controls.Add(this.lblTotalCarrinho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFecharPedido);
            this.Controls.Add(this.dgvCarrinho);
            this.Controls.Add(this.btnAdicionarAoCarrinho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelDadosProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.panelDadosProduto.ResumeLayout(false);
            this.panelDadosProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarAoCarrinho;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button btnFecharPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalCarrinho;
        private System.Windows.Forms.Button btnLimparCarrinho;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Panel panelDadosProduto;
    }
}

