namespace TriviaRectangularGame
{
    partial class FrmProblemas
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
            this.components = new System.ComponentModel.Container();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblReloj = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrecuencia.Location = new System.Drawing.Point(12, 31);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(1222, 143);
            this.lblFrecuencia.TabIndex = 0;
            this.lblFrecuencia.Text = "Prueba de Frecuencias - Considerando α= 5%, n= 4\n0.03991   0.17546   0.24122   0." +
    "03788   0.48228";
            this.lblFrecuencia.Click += new System.EventHandler(this.lblFrecuencia_Click);
            // 
            // btnSi
            // 
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.Location = new System.Drawing.Point(333, 249);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(724, 60);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "SI";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(333, 334);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(724, 60);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(31, 490);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(0, 28);
            this.lblReloj.TabIndex = 4;
            this.lblReloj.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FrmProblemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 561);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.lblFrecuencia);
            this.Name = "FrmProblemas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TriviaRectangularGame";
            this.Load += new System.EventHandler(this.FrmProblemas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}