
namespace M01A08D
{
    partial class btnMaximizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnMaximizar));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnmaxim = new System.Windows.Forms.PictureBox();
            this.btnmini = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.txtnumero = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.DarkMagenta;
            this.BarraTitulo.Controls.Add(this.btnmaxim);
            this.BarraTitulo.Controls.Add(this.btnmini);
            this.BarraTitulo.Controls.Add(this.btnFechar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(461, 24);
            this.BarraTitulo.TabIndex = 0;
            // 
            // btnmaxim
            // 
            this.btnmaxim.Image = ((System.Drawing.Image)(resources.GetObject("btnmaxim.Image")));
            this.btnmaxim.Location = new System.Drawing.Point(419, 5);
            this.btnmaxim.Name = "btnmaxim";
            this.btnmaxim.Size = new System.Drawing.Size(15, 15);
            this.btnmaxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaxim.TabIndex = 1;
            this.btnmaxim.TabStop = false;
            this.btnmaxim.Click += new System.EventHandler(this.btnmaxim_Click);
            // 
            // btnmini
            // 
            this.btnmini.Image = ((System.Drawing.Image)(resources.GetObject("btnmini.Image")));
            this.btnmini.Location = new System.Drawing.Point(389, -3);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(29, 29);
            this.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmini.TabIndex = 1;
            this.btnmini.TabStop = false;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(436, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtnumero
            // 
            this.txtnumero.AutoSize = true;
            this.txtnumero.ForeColor = System.Drawing.Color.White;
            this.txtnumero.Location = new System.Drawing.Point(27, 95);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(203, 25);
            this.txtnumero.TabIndex = 1;
            this.txtnumero.Text = "Digite um número:";
            this.txtnumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(236, 95);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(87, 31);
            this.textBox.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(236, 160);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 32);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(54, 241);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(126, 25);
            this.lblMsg.TabIndex = 4;
            this.lblMsg.Text = "Mensagem";
            this.lblMsg.Visible = false;
            // 
            // btnMaximizar
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(461, 311);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.BarraTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.Name = "btnMaximizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TALENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmaxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.PictureBox btnmini;
        private System.Windows.Forms.PictureBox btnmaxim;
        private System.Windows.Forms.Label txtnumero;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMsg;
    }
}

