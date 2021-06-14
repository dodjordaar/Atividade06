
namespace Atividade06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.btSortear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(35, 52);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(99, 15);
            this.lblMinimo.TabIndex = 0;
            this.lblMinimo.Text = "Número mínimo:";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(35, 85);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(101, 15);
            this.lblMaximo.TabIndex = 1;
            this.lblMaximo.Text = "Número máximo:";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(140, 49);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(100, 23);
            this.txtMinimo.TabIndex = 2;
            this.txtMinimo.Text = "0";
            this.txtMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinimo.TextChanged += new System.EventHandler(this.txtMinimo_TextChanged);
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(140, 82);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 23);
            this.txtMaximo.TabIndex = 3;
            this.txtMaximo.Text = "10";
            this.txtMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSortear
            // 
            this.btSortear.Location = new System.Drawing.Point(140, 131);
            this.btSortear.Name = "btSortear";
            this.btSortear.Size = new System.Drawing.Size(100, 46);
            this.btSortear.TabIndex = 4;
            this.btSortear.Text = "SORTEAR";
            this.btSortear.UseVisualStyleBackColor = true;
            this.btSortear.Click += new System.EventHandler(this.btSortear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 198);
            this.Controls.Add(this.btSortear);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.lblMinimo);
            this.Name = "Form1";
            this.Text = "Sorterama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Button btSortear;
    }
}

