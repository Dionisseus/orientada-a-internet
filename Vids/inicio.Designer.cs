namespace Vids
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.getnickname = new System.Windows.Forms.TextBox();
            this.bn_entrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.closeapp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getnickname
            // 
            this.getnickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.getnickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getnickname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.getnickname.Location = new System.Drawing.Point(159, 356);
            this.getnickname.Name = "getnickname";
            this.getnickname.Size = new System.Drawing.Size(245, 37);
            this.getnickname.TabIndex = 0;
            this.getnickname.Text = "Nickname";
            this.getnickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getnickname.Click += new System.EventHandler(this.getnickname_Click_1);
            // 
            // bn_entrar
            // 
            this.bn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_entrar.Location = new System.Drawing.Point(432, 357);
            this.bn_entrar.Name = "bn_entrar";
            this.bn_entrar.Size = new System.Drawing.Size(108, 36);
            this.bn_entrar.TabIndex = 1;
            this.bn_entrar.Text = "Entrar";
            this.bn_entrar.UseVisualStyleBackColor = true;
            this.bn_entrar.Click += new System.EventHandler(this.bn_entrar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // closeapp
            // 
            this.closeapp.BackColor = System.Drawing.Color.Red;
            this.closeapp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeapp.BackgroundImage")));
            this.closeapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeapp.Location = new System.Drawing.Point(577, 0);
            this.closeapp.Name = "closeapp";
            this.closeapp.Size = new System.Drawing.Size(40, 40);
            this.closeapp.TabIndex = 2;
            this.closeapp.UseVisualStyleBackColor = false;
            this.closeapp.Click += new System.EventHandler(this.closeapp_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(617, 412);
            this.Controls.Add(this.closeapp);
            this.Controls.Add(this.bn_entrar);
            this.Controls.Add(this.getnickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox getnickname;
        private System.Windows.Forms.Button bn_entrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button closeapp;
    }
}

