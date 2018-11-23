namespace TriviaRectangularGame
{
    partial class FrmPreguntas
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnRespuesta1 = new System.Windows.Forms.Button();
            this.btnRespuesta3 = new System.Windows.Forms.Button();
            this.btnRespuesta4 = new System.Windows.Forms.Button();
            this.btnRespuesta2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.Font = new System.Drawing.Font("Game Over", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(22, 21);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(1193, 110);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Definió simulación como el proceso de diseñar y desarrollar un modelo computariza" +
    "do de un sistema o proceso";
            // 
            // btnRespuesta1
            // 
            this.btnRespuesta1.Font = new System.Drawing.Font("Game Over", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta1.Location = new System.Drawing.Point(366, 164);
            this.btnRespuesta1.Name = "btnRespuesta1";
            this.btnRespuesta1.Size = new System.Drawing.Size(213, 60);
            this.btnRespuesta1.TabIndex = 1;
            this.btnRespuesta1.Text = "H. Maisel  ";
            this.btnRespuesta1.UseVisualStyleBackColor = true;
            this.btnRespuesta1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRespuesta3
            // 
            this.btnRespuesta3.Font = new System.Drawing.Font("Game Over", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta3.Location = new System.Drawing.Point(366, 252);
            this.btnRespuesta3.Name = "btnRespuesta3";
            this.btnRespuesta3.Size = new System.Drawing.Size(213, 60);
            this.btnRespuesta3.TabIndex = 2;
            this.btnRespuesta3.Text = "Robert E. Shannon";
            this.btnRespuesta3.UseVisualStyleBackColor = true;
            this.btnRespuesta3.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRespuesta4
            // 
            this.btnRespuesta4.Font = new System.Drawing.Font("Game Over", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta4.Location = new System.Drawing.Point(715, 252);
            this.btnRespuesta4.Name = "btnRespuesta4";
            this.btnRespuesta4.Size = new System.Drawing.Size(213, 60);
            this.btnRespuesta4.TabIndex = 3;
            this.btnRespuesta4.Text = "Ninguno";
            this.btnRespuesta4.UseVisualStyleBackColor = true;
            this.btnRespuesta4.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRespuesta2
            // 
            this.btnRespuesta2.Font = new System.Drawing.Font("Game Over", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespuesta2.Location = new System.Drawing.Point(715, 164);
            this.btnRespuesta2.Name = "btnRespuesta2";
            this.btnRespuesta2.Size = new System.Drawing.Size(213, 60);
            this.btnRespuesta2.TabIndex = 4;
            this.btnRespuesta2.Text = "Thomas Naylor";
            this.btnRespuesta2.UseVisualStyleBackColor = true;
            this.btnRespuesta2.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 561);
            this.Controls.Add(this.btnRespuesta2);
            this.Controls.Add(this.btnRespuesta4);
            this.Controls.Add(this.btnRespuesta3);
            this.Controls.Add(this.btnRespuesta1);
            this.Controls.Add(this.lblPregunta);
            this.Name = "FrmPreguntas";
            this.Text = "FrmPreguntas";
            this.Load += new System.EventHandler(this.FrmPreguntas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnRespuesta1;
        private System.Windows.Forms.Button btnRespuesta3;
        private System.Windows.Forms.Button btnRespuesta4;
        private System.Windows.Forms.Button btnRespuesta2;
        private System.Windows.Forms.Timer timer1;
    }
}