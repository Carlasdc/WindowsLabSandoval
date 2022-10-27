namespace WindowsLabSandoval
{
    partial class FrmLyVCaso5
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
            this.btnTemp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProv1 = new System.Windows.Forms.TextBox();
            this.txtProv2 = new System.Windows.Forms.TextBox();
            this.txtProv3 = new System.Windows.Forms.TextBox();
            this.txtProv4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(366, 265);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(132, 23);
            this.btnTemp.TabIndex = 0;
            this.btnTemp.Text = "Calcular Temperatura";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introducir provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introducir provincia 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Introducir provincia 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Introducir provincia 4";
            // 
            // txtProv1
            // 
            this.txtProv1.Location = new System.Drawing.Point(388, 84);
            this.txtProv1.Name = "txtProv1";
            this.txtProv1.Size = new System.Drawing.Size(100, 20);
            this.txtProv1.TabIndex = 8;
            // 
            // txtProv2
            // 
            this.txtProv2.Location = new System.Drawing.Point(388, 126);
            this.txtProv2.Name = "txtProv2";
            this.txtProv2.Size = new System.Drawing.Size(100, 20);
            this.txtProv2.TabIndex = 9;
            // 
            // txtProv3
            // 
            this.txtProv3.Location = new System.Drawing.Point(388, 176);
            this.txtProv3.Name = "txtProv3";
            this.txtProv3.Size = new System.Drawing.Size(100, 20);
            this.txtProv3.TabIndex = 10;
            // 
            // txtProv4
            // 
            this.txtProv4.Location = new System.Drawing.Point(388, 219);
            this.txtProv4.Name = "txtProv4";
            this.txtProv4.Size = new System.Drawing.Size(100, 20);
            this.txtProv4.TabIndex = 11;
            // 
            // FrmLyVCaso5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.txtProv4);
            this.Controls.Add(this.txtProv3);
            this.Controls.Add(this.txtProv2);
            this.Controls.Add(this.txtProv1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTemp);
            this.Name = "FrmLyVCaso5";
            this.Text = "FrmLyVCaso5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProv1;
        private System.Windows.Forms.TextBox txtProv2;
        private System.Windows.Forms.TextBox txtProv3;
        private System.Windows.Forms.TextBox txtProv4;
    }
}