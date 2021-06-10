
namespace tabuada
{
    partial class frmSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSub));
            this.lblNumero4 = new System.Windows.Forms.Label();
            this.txtNumero4 = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnLimpar4 = new System.Windows.Forms.Button();
            this.txtTabuada4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumero4
            // 
            this.lblNumero4.AutoSize = true;
            this.lblNumero4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero4.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumero4.Location = new System.Drawing.Point(185, 66);
            this.lblNumero4.Name = "lblNumero4";
            this.lblNumero4.Size = new System.Drawing.Size(118, 32);
            this.lblNumero4.TabIndex = 0;
            this.lblNumero4.Text = "Número:";
            // 
            // txtNumero4
            // 
            this.txtNumero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero4.Location = new System.Drawing.Point(309, 66);
            this.txtNumero4.Multiline = true;
            this.txtNumero4.Name = "txtNumero4";
            this.txtNumero4.Size = new System.Drawing.Size(119, 32);
            this.txtNumero4.TabIndex = 1;
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(49, 113);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(104, 33);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "Calcular";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnLimpar4
            // 
            this.btnLimpar4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar4.Location = new System.Drawing.Point(51, 167);
            this.btnLimpar4.Name = "btnLimpar4";
            this.btnLimpar4.Size = new System.Drawing.Size(102, 33);
            this.btnLimpar4.TabIndex = 3;
            this.btnLimpar4.Text = "Limpar";
            this.btnLimpar4.UseVisualStyleBackColor = true;
            this.btnLimpar4.Click += new System.EventHandler(this.btnLimpar4_Click);
            // 
            // txtTabuada4
            // 
            this.txtTabuada4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTabuada4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTabuada4.ForeColor = System.Drawing.SystemColors.Control;
            this.txtTabuada4.Location = new System.Drawing.Point(177, 113);
            this.txtTabuada4.Multiline = true;
            this.txtTabuada4.Name = "txtTabuada4";
            this.txtTabuada4.Size = new System.Drawing.Size(299, 362);
            this.txtTabuada4.TabIndex = 4;
            // 
            // frmSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(538, 567);
            this.Controls.Add(this.txtTabuada4);
            this.Controls.Add(this.btnLimpar4);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtNumero4);
            this.Controls.Add(this.lblNumero4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero4;
        private System.Windows.Forms.TextBox txtNumero4;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnLimpar4;
        private System.Windows.Forms.TextBox txtTabuada4;
    }
}