namespace WindowsLabSandoval
{
    partial class FrmEj4
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
            this.txtFigura = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblFigura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFigura
            // 
            this.txtFigura.Location = new System.Drawing.Point(208, 76);
            this.txtFigura.Name = "txtFigura";
            this.txtFigura.Size = new System.Drawing.Size(100, 20);
            this.txtFigura.TabIndex = 0;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(197, 124);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(120, 23);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "Calcular area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Location = new System.Drawing.Point(38, 79);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(124, 13);
            this.lblFigura.TabIndex = 2;
            this.lblFigura.Text = "Ingrese un tipo de figura ";
            // 
            // FrmEj4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtFigura);
            this.Name = "FrmEj4";
            this.Text = "FrmEj4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFigura;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblFigura;
    }
}