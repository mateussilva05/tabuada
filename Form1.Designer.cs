
namespace tabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnTabuadaSoma = new System.Windows.Forms.Button();
            this.btnTabuadaDiv = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTabuada
            // 
            this.btnTabuada.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTabuada.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabuada.ForeColor = System.Drawing.Color.White;
            this.btnTabuada.Location = new System.Drawing.Point(152, 70);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(179, 61);
            this.btnTabuada.TabIndex = 0;
            this.btnTabuada.Text = "Tabuada de Multiplicação";
            this.btnTabuada.UseVisualStyleBackColor = false;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnTabuadaSoma
            // 
            this.btnTabuadaSoma.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTabuadaSoma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabuadaSoma.ForeColor = System.Drawing.Color.White;
            this.btnTabuadaSoma.Location = new System.Drawing.Point(152, 204);
            this.btnTabuadaSoma.Name = "btnTabuadaSoma";
            this.btnTabuadaSoma.Size = new System.Drawing.Size(179, 61);
            this.btnTabuadaSoma.TabIndex = 1;
            this.btnTabuadaSoma.Text = "Tabuada de\r\nAdição";
            this.btnTabuadaSoma.UseVisualStyleBackColor = false;
            this.btnTabuadaSoma.Click += new System.EventHandler(this.btnTabuadaSoma_Click);
            // 
            // btnTabuadaDiv
            // 
            this.btnTabuadaDiv.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTabuadaDiv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabuadaDiv.ForeColor = System.Drawing.Color.White;
            this.btnTabuadaDiv.Location = new System.Drawing.Point(152, 137);
            this.btnTabuadaDiv.Name = "btnTabuadaDiv";
            this.btnTabuadaDiv.Size = new System.Drawing.Size(179, 61);
            this.btnTabuadaDiv.TabIndex = 2;
            this.btnTabuadaDiv.Text = "Tabuada de\r\nDivisão";
            this.btnTabuadaDiv.UseVisualStyleBackColor = false;
            this.btnTabuadaDiv.Click += new System.EventHandler(this.btnTabuadaDiv_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Location = new System.Drawing.Point(152, 271);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(179, 61);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "Tabuada de\r\nSubtração";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(477, 406);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnTabuadaDiv);
            this.Controls.Add(this.btnTabuadaSoma);
            this.Controls.Add(this.btnTabuada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.Button btnTabuadaSoma;
        private System.Windows.Forms.Button btnTabuadaDiv;
        private System.Windows.Forms.Button btnSub;
    }
}

