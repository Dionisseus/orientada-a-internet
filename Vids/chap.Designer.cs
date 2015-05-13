namespace Vids
{
    partial class chap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chap));
            this.messagebox = new System.Windows.Forms.RichTextBox();
            this.enviarchat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.videoLlamadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversacion = new System.Windows.Forms.RichTextBox();
            this.videorec = new System.Windows.Forms.PictureBox();
            this.videosen = new System.Windows.Forms.PictureBox();
            this.hang = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videorec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hang)).BeginInit();
            this.SuspendLayout();
            // 
            // messagebox
            // 
            this.messagebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messagebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagebox.Location = new System.Drawing.Point(4, 304);
            this.messagebox.MaxLength = 256;
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(498, 77);
            this.messagebox.TabIndex = 0;
            this.messagebox.Text = "";
            // 
            // enviarchat
            // 
            this.enviarchat.Location = new System.Drawing.Point(508, 304);
            this.enviarchat.Name = "enviarchat";
            this.enviarchat.Size = new System.Drawing.Size(75, 77);
            this.enviarchat.TabIndex = 1;
            this.enviarchat.Text = "Enviar";
            this.enviarchat.UseVisualStyleBackColor = true;
            this.enviarchat.Click += new System.EventHandler(this.enviarchat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoLlamadaToolStripMenuItem,
            this.iniciarJuegoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // videoLlamadaToolStripMenuItem
            // 
            this.videoLlamadaToolStripMenuItem.Name = "videoLlamadaToolStripMenuItem";
            this.videoLlamadaToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.videoLlamadaToolStripMenuItem.Text = "Iniciar Videollamada";
            this.videoLlamadaToolStripMenuItem.Click += new System.EventHandler(this.videoLlamadaToolStripMenuItem_Click);
            // 
            // iniciarJuegoToolStripMenuItem
            // 
            this.iniciarJuegoToolStripMenuItem.Name = "iniciarJuegoToolStripMenuItem";
            this.iniciarJuegoToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.iniciarJuegoToolStripMenuItem.Text = "Iniciar Juego";
            // 
            // conversacion
            // 
            this.conversacion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.conversacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conversacion.Location = new System.Drawing.Point(4, 27);
            this.conversacion.Name = "conversacion";
            this.conversacion.Size = new System.Drawing.Size(498, 271);
            this.conversacion.TabIndex = 3;
            this.conversacion.Text = "";
            this.conversacion.TextChanged += new System.EventHandler(this.conversacion_TextChanged);
            // 
            // videorec
            // 
            this.videorec.Location = new System.Drawing.Point(508, 27);
            this.videorec.Name = "videorec";
            this.videorec.Size = new System.Drawing.Size(215, 215);
            this.videorec.TabIndex = 4;
            this.videorec.TabStop = false;
            this.videorec.Visible = false;
            // 
            // videosen
            // 
            this.videosen.Location = new System.Drawing.Point(590, 248);
            this.videosen.Name = "videosen";
            this.videosen.Size = new System.Drawing.Size(132, 132);
            this.videosen.TabIndex = 5;
            this.videosen.TabStop = false;
            this.videosen.Visible = false;
            // 
            // hang
            // 
            this.hang.Image = ((System.Drawing.Image)(resources.GetObject("hang.Image")));
            this.hang.Location = new System.Drawing.Point(509, 248);
            this.hang.Name = "hang";
            this.hang.Size = new System.Drawing.Size(74, 50);
            this.hang.TabIndex = 6;
            this.hang.TabStop = false;
            this.hang.Visible = false;
            this.hang.Click += new System.EventHandler(this.hang_Click);
            // 
            // chap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.hang);
            this.Controls.Add(this.videosen);
            this.Controls.Add(this.videorec);
            this.Controls.Add(this.conversacion);
            this.Controls.Add(this.enviarchat);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "chap";
            this.Text = "chap";
            this.Load += new System.EventHandler(this.chap_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videorec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox messagebox;
        private System.Windows.Forms.Button enviarchat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem videoLlamadaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox conversacion;
        private System.Windows.Forms.PictureBox videorec;
        private System.Windows.Forms.PictureBox videosen;
        private System.Windows.Forms.PictureBox hang;
        private System.Windows.Forms.ToolStripMenuItem iniciarJuegoToolStripMenuItem;
    }
}