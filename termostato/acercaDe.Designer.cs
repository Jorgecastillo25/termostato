namespace termostato
{
    partial class acercaDe
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
            this.lblApp = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblOS = new System.Windows.Forms.Label();
            this.lblDBMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblApp
            // 
            this.lblApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.Location = new System.Drawing.Point(12, 9);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(553, 88);
            this.lblApp.TabIndex = 0;
            this.lblApp.Text = "Termostato";
            this.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.Crimson;
            this.lblAutor.Location = new System.Drawing.Point(-2, 97);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(540, 74);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor: José Antonio Tamez Garza\r\n Jorge Francisco Guerrero Castillo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFecha.Location = new System.Drawing.Point(-2, 171);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(236, 37);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha y hora: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.ForeColor = System.Drawing.Color.Green;
            this.lblOS.Location = new System.Drawing.Point(-2, 208);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(309, 37);
            this.lblOS.TabIndex = 3;
            this.lblOS.Text = "Sistema operativo: ";
            // 
            // lblDBMS
            // 
            this.lblDBMS.AutoSize = true;
            this.lblDBMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBMS.ForeColor = System.Drawing.Color.Maroon;
            this.lblDBMS.Location = new System.Drawing.Point(-2, 245);
            this.lblDBMS.Name = "lblDBMS";
            this.lblDBMS.Size = new System.Drawing.Size(300, 37);
            this.lblDBMS.TabIndex = 4;
            this.lblDBMS.Text = "DBMS: MySQL 5.7";
            // 
            // acercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 291);
            this.Controls.Add(this.lblDBMS);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "acercaDe";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.acercaDe_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.Label lblDBMS;
    }
}