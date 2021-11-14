
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Tiposbutton = new System.Windows.Forms.Button();
            this.Ticketbutton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tiposbutton
            // 
            this.Tiposbutton.Location = new System.Drawing.Point(20, 21);
            this.Tiposbutton.Name = "Tiposbutton";
            this.Tiposbutton.Size = new System.Drawing.Size(111, 42);
            this.Tiposbutton.TabIndex = 0;
            this.Tiposbutton.Text = "Tipos";
            this.Tiposbutton.UseVisualStyleBackColor = true;
            this.Tiposbutton.Click += new System.EventHandler(this.Tiposbutton_Click);
            // 
            // Ticketbutton
            // 
            this.Ticketbutton.Location = new System.Drawing.Point(168, 21);
            this.Ticketbutton.Name = "Ticketbutton";
            this.Ticketbutton.Size = new System.Drawing.Size(111, 42);
            this.Ticketbutton.TabIndex = 2;
            this.Ticketbutton.Text = "Tickets";
            this.Ticketbutton.UseVisualStyleBackColor = true;
            this.Ticketbutton.Click += new System.EventHandler(this.Ticketbutton_Click);
            // 
            // Salirbutton
            // 
            this.Salirbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Salirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salirbutton.Location = new System.Drawing.Point(405, 265);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(111, 42);
            this.Salirbutton.TabIndex = 5;
            this.Salirbutton.Text = "Salir";
            this.Salirbutton.UseVisualStyleBackColor = false;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ticketbutton);
            this.groupBox1.Controls.Add(this.Tiposbutton);
            this.groupBox1.Location = new System.Drawing.Point(51, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tiposbutton;
        private System.Windows.Forms.Button Ticketbutton;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}