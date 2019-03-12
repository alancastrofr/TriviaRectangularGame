namespace TriviaRectangularGame
{
    partial class FrmDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDados));
            this.btnLanzarDados = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLanzarDados
            // 
            this.btnLanzarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanzarDados.ForeColor = System.Drawing.Color.Black;
            this.btnLanzarDados.Location = new System.Drawing.Point(513, 244);
            this.btnLanzarDados.Name = "btnLanzarDados";
            this.btnLanzarDados.Size = new System.Drawing.Size(235, 65);
            this.btnLanzarDados.TabIndex = 0;
            this.btnLanzarDados.UseVisualStyleBackColor = true;
            this.btnLanzarDados.Click += new System.EventHandler(this.btnLanzarDados_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(425, 27);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(0, 108);
            this.lblNombreUsuario.TabIndex = 1;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(513, 244);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(235, 65);
            this.btnContinuar.TabIndex = 4;
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(679, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puntos :";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.White;
            this.lblPuntos.Location = new System.Drawing.Point(851, 27);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(66, 24);
            this.lblPuntos.TabIndex = 8;
            this.lblPuntos.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(225, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Jugador:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(813, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 287);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 287);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1246, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.btnLanzarDados);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TriviaRectangularGame";
            this.Load += new System.EventHandler(this.FrmDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLanzarDados;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label label2;
    }
}