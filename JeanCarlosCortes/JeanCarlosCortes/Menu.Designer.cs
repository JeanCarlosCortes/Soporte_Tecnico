
namespace JeanCarlosCortes
{
    partial class Menu
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
            this.Tiposbutton = new System.Windows.Forms.Button();
            this.Estadosbutton = new System.Windows.Forms.Button();
            this.Detallesbutton = new System.Windows.Forms.Button();
            this.Ticketbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tiposbutton
            // 
            this.Tiposbutton.Location = new System.Drawing.Point(94, 124);
            this.Tiposbutton.Name = "Tiposbutton";
            this.Tiposbutton.Size = new System.Drawing.Size(111, 42);
            this.Tiposbutton.TabIndex = 0;
            this.Tiposbutton.Text = "Tipos";
            this.Tiposbutton.UseVisualStyleBackColor = true;
            this.Tiposbutton.Click += new System.EventHandler(this.Tiposbutton_Click);
            // 
            // Estadosbutton
            // 
            this.Estadosbutton.Location = new System.Drawing.Point(273, 124);
            this.Estadosbutton.Name = "Estadosbutton";
            this.Estadosbutton.Size = new System.Drawing.Size(111, 42);
            this.Estadosbutton.TabIndex = 1;
            this.Estadosbutton.Text = "Estados";
            this.Estadosbutton.UseVisualStyleBackColor = true;
            this.Estadosbutton.Click += new System.EventHandler(this.Estadosbutton_Click);
            // 
            // Detallesbutton
            // 
            this.Detallesbutton.Location = new System.Drawing.Point(273, 187);
            this.Detallesbutton.Name = "Detallesbutton";
            this.Detallesbutton.Size = new System.Drawing.Size(111, 42);
            this.Detallesbutton.TabIndex = 3;
            this.Detallesbutton.Text = "Detalles";
            this.Detallesbutton.UseVisualStyleBackColor = true;
            this.Detallesbutton.Click += new System.EventHandler(this.Detallesbutton_Click);
            // 
            // Ticketbutton
            // 
            this.Ticketbutton.Location = new System.Drawing.Point(94, 187);
            this.Ticketbutton.Name = "Ticketbutton";
            this.Ticketbutton.Size = new System.Drawing.Size(111, 42);
            this.Ticketbutton.TabIndex = 2;
            this.Ticketbutton.Text = "Tickets";
            this.Ticketbutton.UseVisualStyleBackColor = true;
            this.Ticketbutton.Click += new System.EventHandler(this.Ticketbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Detallesbutton);
            this.Controls.Add(this.Ticketbutton);
            this.Controls.Add(this.Estadosbutton);
            this.Controls.Add(this.Tiposbutton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tiposbutton;
        private System.Windows.Forms.Button Estadosbutton;
        private System.Windows.Forms.Button Detallesbutton;
        private System.Windows.Forms.Button Ticketbutton;
        private System.Windows.Forms.Label label1;
    }
}