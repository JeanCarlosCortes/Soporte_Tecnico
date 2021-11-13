
namespace JeanCarlosCortes
{
    partial class Detalles
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Historialbutton = new System.Windows.Forms.Button();
            this.Menubutton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(903, 330);
            this.dataGridView.TabIndex = 0;
            // 
            // Historialbutton
            // 
            this.Historialbutton.Location = new System.Drawing.Point(77, 385);
            this.Historialbutton.Name = "Historialbutton";
            this.Historialbutton.Size = new System.Drawing.Size(137, 48);
            this.Historialbutton.TabIndex = 1;
            this.Historialbutton.Text = "Historial";
            this.Historialbutton.UseVisualStyleBackColor = true;
            this.Historialbutton.Click += new System.EventHandler(this.Historialbutton_Click);
            // 
            // Menubutton
            // 
            this.Menubutton.Location = new System.Drawing.Point(286, 385);
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(137, 48);
            this.Menubutton.TabIndex = 2;
            this.Menubutton.Text = "Menu";
            this.Menubutton.UseVisualStyleBackColor = true;
            this.Menubutton.Click += new System.EventHandler(this.Menubutton_Click);
            // 
            // Salirbutton
            // 
            this.Salirbutton.Location = new System.Drawing.Point(480, 385);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(137, 48);
            this.Salirbutton.TabIndex = 3;
            this.Salirbutton.Text = "Salir";
            this.Salirbutton.UseVisualStyleBackColor = true;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 558);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.Menubutton);
            this.Controls.Add(this.Historialbutton);
            this.Controls.Add(this.dataGridView);
            this.Name = "Detalles";
            this.Text = "Detalles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Historialbutton;
        private System.Windows.Forms.Button Menubutton;
        private System.Windows.Forms.Button Salirbutton;
    }
}