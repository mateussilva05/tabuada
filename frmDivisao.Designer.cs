
namespace tabuada
{
    partial class frmDivisao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivisao));
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnLimpar3 = new System.Windows.Forms.Button();
            this.lblNumero3 = new System.Windows.Forms.Label();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.txtTabuada3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDivisao
            // 
            this.btnDivisao.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(49, 113);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(104, 33);
            this.btnDivisao.TabIndex = 0;
            this.btnDivisao.Text = "Calcular";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnLimpar3
            // 
            this.btnLimpar3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar3.Location = new System.Drawing.Point(51, 167);
            this.btnLimpar3.Name = "btnLimpar3";
            this.btnLimpar3.Size = new System.Drawing.Size(102, 33);
            this.btnLimpar3.TabIndex = 1;
            this.btnLimpar3.Text = "Limpar";
            this.btnLimpar3.UseVisualStyleBackColor = true;
            this.btnLimpar3.Click += new System.EventHandler(this.btnLimpar3_Click);
            // 
            // lblNumero3
            // 
            this.lblNumero3.AutoSize = true;
            this.lblNumero3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero3.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumero3.Location = new System.Drawing.Point(185, 66);
            this.lblNumero3.Name = "lblNumero3";
            this.lblNumero3.Size = new System.Drawing.Size(118, 32);
            this.lblNumero3.TabIndex = 2;
            this.lblNumero3.Text = "Número:";
            // 
            // txtNumero3
            // 
            this.txtNumero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero3.Location = new System.Drawing.Point(309, 66);
            this.txtNumero3.Multiline = true;
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(119, 32);
            this.txtNumero3.TabIndex = 3;
            // 
            // txtTabuada3
            // 
            this.txtTabuada3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTabuada3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabuada3.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTabuada3.Location = new System.Drawing.Point(177, 113);
            this.txtTabuada3.Multiline = true;
            this.txtTabuada3.Name = "txtTabuada3";
            this.txtTabuada3.Size = new System.Drawing.Size(299, 362);
            this.txtTabuada3.TabIndex = 4;
            // 
            // frmDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(538, 567);
            this.Controls.Add(this.txtTabuada3);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.lblNumero3);
            this.Controls.Add(this.btnLimpar3);
            this.Controls.Add(this.btnDivisao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDivisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnLimpar3;
        private System.Windows.Forms.Label lblNumero3;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.TextBox txtTabuada3;
    }
}