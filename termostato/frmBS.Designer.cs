namespace termostato
{
    partial class frmBS
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBS = new System.Windows.Forms.Button();
            this.numBS = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 116);
            this.label1.TabIndex = 1;
            this.label1.Text = "00°";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBS
            // 
            this.btnBS.Location = new System.Drawing.Point(12, 129);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(384, 51);
            this.btnBS.TabIndex = 2;
            this.btnBS.Text = "Ingresar Grados";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            this.btnBS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numBS_KeyPress);
            // 
            // numBS
            // 
            this.numBS.DecimalPlaces = 1;
            this.numBS.Location = new System.Drawing.Point(26, 89);
            this.numBS.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numBS.Name = "numBS";
            this.numBS.Size = new System.Drawing.Size(120, 20);
            this.numBS.TabIndex = 3;
            this.numBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBS.ValueChanged += new System.EventHandler(this.numBS_ValueChanged);
            this.numBS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numBS_KeyPress);
            // 
            // frmBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 202);
            this.Controls.Add(this.numBS);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 241);
            this.MinimumSize = new System.Drawing.Size(424, 241);
            this.Name = "frmBS";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Simon";
            this.Load += new System.EventHandler(this.frmBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.NumericUpDown numBS;
    }
}