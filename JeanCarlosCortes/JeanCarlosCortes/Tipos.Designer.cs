
namespace JeanCarlosCortes
{
    partial class Tipos
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
            this.RPantallabutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RModulobutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MPreventivobutton = new System.Windows.Forms.Button();
            this.CBateriabutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RPantallabutton
            // 
            this.RPantallabutton.Location = new System.Drawing.Point(61, 38);
            this.RPantallabutton.Name = "RPantallabutton";
            this.RPantallabutton.Size = new System.Drawing.Size(125, 47);
            this.RPantallabutton.TabIndex = 0;
            this.RPantallabutton.Text = "Reparación de pantalla";
            this.RPantallabutton.UseVisualStyleBackColor = true;
            this.RPantallabutton.Click += new System.EventHandler(this.RPantallabutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RModulobutton);
            this.groupBox1.Controls.Add(this.RPantallabutton);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reparación de celulares";
            // 
            // RModulobutton
            // 
            this.RModulobutton.Location = new System.Drawing.Point(268, 38);
            this.RModulobutton.Name = "RModulobutton";
            this.RModulobutton.Size = new System.Drawing.Size(125, 47);
            this.RModulobutton.TabIndex = 1;
            this.RModulobutton.Text = "Reparación del módulo de carga";
            this.RModulobutton.UseVisualStyleBackColor = true;
            this.RModulobutton.Click += new System.EventHandler(this.RModulobutton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MPreventivobutton);
            this.groupBox2.Controls.Add(this.CBateriabutton);
            this.groupBox2.Location = new System.Drawing.Point(11, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reparación de computadoras";
            // 
            // MPreventivobutton
            // 
            this.MPreventivobutton.Location = new System.Drawing.Point(310, 42);
            this.MPreventivobutton.Name = "MPreventivobutton";
            this.MPreventivobutton.Size = new System.Drawing.Size(125, 47);
            this.MPreventivobutton.TabIndex = 2;
            this.MPreventivobutton.Text = "Mantenimiento preventivo";
            this.MPreventivobutton.UseVisualStyleBackColor = true;
            this.MPreventivobutton.Click += new System.EventHandler(this.MPreventivobutton_Click);
            // 
            // CBateriabutton
            // 
            this.CBateriabutton.Location = new System.Drawing.Point(61, 42);
            this.CBateriabutton.Name = "CBateriabutton";
            this.CBateriabutton.Size = new System.Drawing.Size(125, 47);
            this.CBateriabutton.TabIndex = 0;
            this.CBateriabutton.Text = "Cambio de bateria";
            this.CBateriabutton.UseVisualStyleBackColor = true;
            this.CBateriabutton.Click += new System.EventHandler(this.CBateriabutton_Click);
            // 
            // Tipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Tipos";
            this.Text = "Tipos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RPantallabutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RModulobutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MPreventivobutton;
        private System.Windows.Forms.Button CBateriabutton;
    }
}