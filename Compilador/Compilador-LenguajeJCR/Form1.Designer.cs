﻿namespace Compilador_LenguajeJCR
{
    partial class frmLJCR
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxCodigoFuente = new System.Windows.Forms.RichTextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.rtxTokens = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxCodigoFuente
            // 
            this.rtxCodigoFuente.Location = new System.Drawing.Point(12, 15);
            this.rtxCodigoFuente.Name = "rtxCodigoFuente";
            this.rtxCodigoFuente.Size = new System.Drawing.Size(609, 131);
            this.rtxCodigoFuente.TabIndex = 0;
            this.rtxCodigoFuente.Text = "";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(686, 13);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizar.TabIndex = 1;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(22, 160);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(89, 23);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "TOKENS";
            // 
            // rtxTokens
            // 
            this.rtxTokens.Location = new System.Drawing.Point(12, 186);
            this.rtxTokens.Name = "rtxTokens";
            this.rtxTokens.Size = new System.Drawing.Size(609, 138);
            this.rtxTokens.TabIndex = 3;
            this.rtxTokens.Text = "";
            // 
            // frmLJCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtxTokens);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.rtxCodigoFuente);
            this.Name = "frmLJCR";
            this.Text = "LENGUAJE JCR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxCodigoFuente;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.RichTextBox rtxTokens;
    }
}

