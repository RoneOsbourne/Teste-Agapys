namespace TesteAgapys
{
    partial class Form1
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
            /*this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";*/

            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.txtArquivo.Location = new System.Drawing.Point(13, 52);
            this.txtArquivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(537, 27);
            this.txtArquivo.TabIndex = 0;

            this.txtCriterio.Location = new System.Drawing.Point(13, 109);
            this.txtCriterio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(574, 27);
            this.txtCriterio.TabIndex = 1;

            this.btnLocalizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.Location = new System.Drawing.Point(13, 146);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(236, 35);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar ";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.BtnLocalizar_Click);

            this.lbResultado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.ItemHeight = 17;
            this.lbResultado.Location = new System.Drawing.Point(13, 191);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(574, 327);
            this.lbResultado.TabIndex = 3;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informe o caminho e nome do arquivo";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informe o critério de busca";

            this.btnEncerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Location = new System.Drawing.Point(351, 146);
            this.btnEncerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(236, 35);
            this.btnEncerrar.TabIndex = 2;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.BtnEncerrar_Click);

            this.btnArquivo.Location = new System.Drawing.Point(549, 52);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(35, 27);
            this.btnArquivo.TabIndex = 6;
            this.btnArquivo.Text = "...";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.BtnArquivo_Click);

            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(12, 523);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(86, 17);
            this.lblResultados.TabIndex = 7;
            this.lblResultados.Text = "lblResultados";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 548);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.txtArquivo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localiza Linhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Label lblResultados;
    }
}

