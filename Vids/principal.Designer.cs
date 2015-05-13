namespace Vids
{
    partial class principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.listacontactos = new System.Windows.Forms.ListBox();
            this.mensaje = new System.Windows.Forms.RichTextBox();
            this.enviarmensaje = new System.Windows.Forms.Button();
            this.campomensaje = new System.Windows.Forms.RichTextBox();
            this.closegc = new System.Windows.Forms.Button();
            this.TD4W = new System.Windows.Forms.PictureBox();
            this.rb_estadoDisponible = new System.Windows.Forms.RadioButton();
            this.rb_estadoOcupado = new System.Windows.Forms.RadioButton();
            this.rb_estadoAusemte = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.etiqueta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_icons = new System.Windows.Forms.Panel();
            this.angel = new System.Windows.Forms.PictureBox();
            this.angry = new System.Windows.Forms.PictureBox();
            this.cool = new System.Windows.Forms.PictureBox();
            this.confuse = new System.Windows.Forms.PictureBox();
            this.devil = new System.Windows.Forms.PictureBox();
            this.cry = new System.Windows.Forms.PictureBox();
            this.smile = new System.Windows.Forms.PictureBox();
            this.shy = new System.Windows.Forms.PictureBox();
            this.sad = new System.Windows.Forms.PictureBox();
            this.grin = new System.Windows.Forms.PictureBox();
            this.sot = new System.Windows.Forms.PictureBox();
            this.dissa = new System.Windows.Forms.PictureBox();
            this.wink = new System.Windows.Forms.PictureBox();
            this.tonge = new System.Windows.Forms.PictureBox();
            this.teeh = new System.Windows.Forms.PictureBox();
            this.surprised = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TD4W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_icons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confuse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dissa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surprised)).BeginInit();
            this.SuspendLayout();
            // 
            // listacontactos
            // 
            this.listacontactos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listacontactos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listacontactos.FormattingEnabled = true;
            this.listacontactos.Location = new System.Drawing.Point(4, 57);
            this.listacontactos.Name = "listacontactos";
            this.listacontactos.Size = new System.Drawing.Size(166, 364);
            this.listacontactos.TabIndex = 10;
            this.listacontactos.UseTabStops = false;
            this.listacontactos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listacontactos_MouseDoubleClick);
            // 
            // mensaje
            // 
            this.mensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.Location = new System.Drawing.Point(176, 355);
            this.mensaje.MaxLength = 255;
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(462, 66);
            this.mensaje.TabIndex = 0;
            this.mensaje.Text = "";
            this.mensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mensaje_KeyDown);
            // 
            // enviarmensaje
            // 
            this.enviarmensaje.Location = new System.Drawing.Point(644, 355);
            this.enviarmensaje.Name = "enviarmensaje";
            this.enviarmensaje.Size = new System.Drawing.Size(59, 66);
            this.enviarmensaje.TabIndex = 1;
            this.enviarmensaje.Text = "Enviar";
            this.enviarmensaje.UseVisualStyleBackColor = true;
            this.enviarmensaje.Click += new System.EventHandler(this.enviarmensaje_Click);
            // 
            // campomensaje
            // 
            this.campomensaje.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.campomensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.campomensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.campomensaje.Location = new System.Drawing.Point(176, 7);
            this.campomensaje.Name = "campomensaje";
            this.campomensaje.ReadOnly = true;
            this.campomensaje.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.campomensaje.Size = new System.Drawing.Size(462, 342);
            this.campomensaje.TabIndex = 4;
            this.campomensaje.TabStop = false;
            this.campomensaje.Text = "";
            this.campomensaje.TextChanged += new System.EventHandler(this.campomensaje_TextChanged);
            // 
            // closegc
            // 
            this.closegc.BackColor = System.Drawing.SystemColors.Control;
            this.closegc.Location = new System.Drawing.Point(643, 7);
            this.closegc.Name = "closegc";
            this.closegc.Size = new System.Drawing.Size(60, 23);
            this.closegc.TabIndex = 2;
            this.closegc.Text = "Cerrar";
            this.closegc.UseVisualStyleBackColor = false;
            this.closegc.Click += new System.EventHandler(this.closegc_Click);
            // 
            // TD4W
            // 
            this.TD4W.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TD4W.Location = new System.Drawing.Point(644, 238);
            this.TD4W.Name = "TD4W";
            this.TD4W.Size = new System.Drawing.Size(60, 60);
            this.TD4W.TabIndex = 11;
            this.TD4W.TabStop = false;
            this.TD4W.Click += new System.EventHandler(this.TD4W_Click);
            // 
            // rb_estadoDisponible
            // 
            this.rb_estadoDisponible.AutoSize = true;
            this.rb_estadoDisponible.BackColor = System.Drawing.Color.Transparent;
            this.rb_estadoDisponible.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_estadoDisponible.Checked = true;
            this.rb_estadoDisponible.Location = new System.Drawing.Point(644, 130);
            this.rb_estadoDisponible.Name = "rb_estadoDisponible";
            this.rb_estadoDisponible.Size = new System.Drawing.Size(60, 30);
            this.rb_estadoDisponible.TabIndex = 12;
            this.rb_estadoDisponible.TabStop = true;
            this.rb_estadoDisponible.Text = "Disponible";
            this.rb_estadoDisponible.UseVisualStyleBackColor = false;
            // 
            // rb_estadoOcupado
            // 
            this.rb_estadoOcupado.AutoSize = true;
            this.rb_estadoOcupado.BackColor = System.Drawing.Color.Transparent;
            this.rb_estadoOcupado.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_estadoOcupado.Location = new System.Drawing.Point(646, 166);
            this.rb_estadoOcupado.Name = "rb_estadoOcupado";
            this.rb_estadoOcupado.Size = new System.Drawing.Size(55, 30);
            this.rb_estadoOcupado.TabIndex = 13;
            this.rb_estadoOcupado.Text = "Ocupado";
            this.rb_estadoOcupado.UseVisualStyleBackColor = false;
            // 
            // rb_estadoAusemte
            // 
            this.rb_estadoAusemte.AutoSize = true;
            this.rb_estadoAusemte.BackColor = System.Drawing.Color.Transparent;
            this.rb_estadoAusemte.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb_estadoAusemte.Location = new System.Drawing.Point(649, 202);
            this.rb_estadoAusemte.Name = "rb_estadoAusemte";
            this.rb_estadoAusemte.Size = new System.Drawing.Size(50, 30);
            this.rb_estadoAusemte.TabIndex = 14;
            this.rb_estadoAusemte.Text = "Ausente";
            this.rb_estadoAusemte.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // etiqueta
            // 
            this.etiqueta.AutoSize = true;
            this.etiqueta.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiqueta.Location = new System.Drawing.Point(12, 17);
            this.etiqueta.Name = "etiqueta";
            this.etiqueta.Size = new System.Drawing.Size(146, 29);
            this.etiqueta.TabIndex = 15;
            this.etiqueta.Text = "Nickname-Estado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 326);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 23);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // p_icons
            // 
            this.p_icons.Controls.Add(this.wink);
            this.p_icons.Controls.Add(this.tonge);
            this.p_icons.Controls.Add(this.teeh);
            this.p_icons.Controls.Add(this.surprised);
            this.p_icons.Controls.Add(this.smile);
            this.p_icons.Controls.Add(this.shy);
            this.p_icons.Controls.Add(this.sad);
            this.p_icons.Controls.Add(this.grin);
            this.p_icons.Controls.Add(this.sot);
            this.p_icons.Controls.Add(this.dissa);
            this.p_icons.Controls.Add(this.devil);
            this.p_icons.Controls.Add(this.cry);
            this.p_icons.Controls.Add(this.cool);
            this.p_icons.Controls.Add(this.confuse);
            this.p_icons.Controls.Add(this.angry);
            this.p_icons.Controls.Add(this.angel);
            this.p_icons.Location = new System.Drawing.Point(537, 259);
            this.p_icons.Name = "p_icons";
            this.p_icons.Size = new System.Drawing.Size(101, 90);
            this.p_icons.TabIndex = 17;
            this.p_icons.Visible = false;
            // 
            // angel
            // 
            this.angel.Image = ((System.Drawing.Image)(resources.GetObject("angel.Image")));
            this.angel.Location = new System.Drawing.Point(77, 67);
            this.angel.Name = "angel";
            this.angel.Size = new System.Drawing.Size(19, 18);
            this.angel.TabIndex = 0;
            this.angel.TabStop = false;
            this.angel.Click += new System.EventHandler(this.angel_Click);
            // 
            // angry
            // 
            this.angry.Image = ((System.Drawing.Image)(resources.GetObject("angry.Image")));
            this.angry.Location = new System.Drawing.Point(3, 67);
            this.angry.Name = "angry";
            this.angry.Size = new System.Drawing.Size(19, 18);
            this.angry.TabIndex = 1;
            this.angry.TabStop = false;
            this.angry.Click += new System.EventHandler(this.angry_Click);
            // 
            // cool
            // 
            this.cool.Image = ((System.Drawing.Image)(resources.GetObject("cool.Image")));
            this.cool.Location = new System.Drawing.Point(28, 3);
            this.cool.Name = "cool";
            this.cool.Size = new System.Drawing.Size(19, 18);
            this.cool.TabIndex = 3;
            this.cool.TabStop = false;
            this.cool.Click += new System.EventHandler(this.cool_Click);
            // 
            // confuse
            // 
            this.confuse.Image = ((System.Drawing.Image)(resources.GetObject("confuse.Image")));
            this.confuse.Location = new System.Drawing.Point(3, 3);
            this.confuse.Name = "confuse";
            this.confuse.Size = new System.Drawing.Size(19, 18);
            this.confuse.TabIndex = 2;
            this.confuse.TabStop = false;
            this.confuse.Click += new System.EventHandler(this.confuse_Click);
            // 
            // devil
            // 
            this.devil.Image = ((System.Drawing.Image)(resources.GetObject("devil.Image")));
            this.devil.Location = new System.Drawing.Point(77, 3);
            this.devil.Name = "devil";
            this.devil.Size = new System.Drawing.Size(19, 18);
            this.devil.TabIndex = 5;
            this.devil.TabStop = false;
            this.devil.Click += new System.EventHandler(this.devil_Click);
            // 
            // cry
            // 
            this.cry.Image = ((System.Drawing.Image)(resources.GetObject("cry.Image")));
            this.cry.Location = new System.Drawing.Point(53, 3);
            this.cry.Name = "cry";
            this.cry.Size = new System.Drawing.Size(19, 18);
            this.cry.TabIndex = 4;
            this.cry.TabStop = false;
            this.cry.Click += new System.EventHandler(this.cry_Click);
            // 
            // smile
            // 
            this.smile.Image = ((System.Drawing.Image)(resources.GetObject("smile.Image")));
            this.smile.Location = new System.Drawing.Point(77, 25);
            this.smile.Name = "smile";
            this.smile.Size = new System.Drawing.Size(19, 18);
            this.smile.TabIndex = 11;
            this.smile.TabStop = false;
            this.smile.Click += new System.EventHandler(this.smile_Click);
            // 
            // shy
            // 
            this.shy.Image = ((System.Drawing.Image)(resources.GetObject("shy.Image")));
            this.shy.Location = new System.Drawing.Point(53, 25);
            this.shy.Name = "shy";
            this.shy.Size = new System.Drawing.Size(19, 18);
            this.shy.TabIndex = 10;
            this.shy.TabStop = false;
            this.shy.Click += new System.EventHandler(this.shy_Click);
            // 
            // sad
            // 
            this.sad.Image = ((System.Drawing.Image)(resources.GetObject("sad.Image")));
            this.sad.Location = new System.Drawing.Point(28, 25);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(19, 18);
            this.sad.TabIndex = 9;
            this.sad.TabStop = false;
            this.sad.Click += new System.EventHandler(this.sad_Click);
            // 
            // grin
            // 
            this.grin.Image = ((System.Drawing.Image)(resources.GetObject("grin.Image")));
            this.grin.Location = new System.Drawing.Point(3, 25);
            this.grin.Name = "grin";
            this.grin.Size = new System.Drawing.Size(19, 18);
            this.grin.TabIndex = 8;
            this.grin.TabStop = false;
            this.grin.Click += new System.EventHandler(this.grin_Click);
            // 
            // sot
            // 
            this.sot.Image = ((System.Drawing.Image)(resources.GetObject("sot.Image")));
            this.sot.Location = new System.Drawing.Point(28, 67);
            this.sot.Name = "sot";
            this.sot.Size = new System.Drawing.Size(19, 18);
            this.sot.TabIndex = 7;
            this.sot.TabStop = false;
            this.sot.Click += new System.EventHandler(this.sot_Click);
            // 
            // dissa
            // 
            this.dissa.Image = ((System.Drawing.Image)(resources.GetObject("dissa.Image")));
            this.dissa.Location = new System.Drawing.Point(53, 67);
            this.dissa.Name = "dissa";
            this.dissa.Size = new System.Drawing.Size(19, 18);
            this.dissa.TabIndex = 6;
            this.dissa.TabStop = false;
            this.dissa.Click += new System.EventHandler(this.dissa_Click);
            // 
            // wink
            // 
            this.wink.Image = ((System.Drawing.Image)(resources.GetObject("wink.Image")));
            this.wink.Location = new System.Drawing.Point(77, 46);
            this.wink.Name = "wink";
            this.wink.Size = new System.Drawing.Size(19, 18);
            this.wink.TabIndex = 15;
            this.wink.TabStop = false;
            this.wink.Click += new System.EventHandler(this.wink_Click);
            // 
            // tonge
            // 
            this.tonge.Image = ((System.Drawing.Image)(resources.GetObject("tonge.Image")));
            this.tonge.Location = new System.Drawing.Point(53, 46);
            this.tonge.Name = "tonge";
            this.tonge.Size = new System.Drawing.Size(19, 18);
            this.tonge.TabIndex = 14;
            this.tonge.TabStop = false;
            this.tonge.Click += new System.EventHandler(this.tonge_Click);
            // 
            // teeh
            // 
            this.teeh.Image = ((System.Drawing.Image)(resources.GetObject("teeh.Image")));
            this.teeh.Location = new System.Drawing.Point(28, 46);
            this.teeh.Name = "teeh";
            this.teeh.Size = new System.Drawing.Size(19, 18);
            this.teeh.TabIndex = 13;
            this.teeh.TabStop = false;
            this.teeh.Click += new System.EventHandler(this.teeh_Click);
            // 
            // surprised
            // 
            this.surprised.Image = ((System.Drawing.Image)(resources.GetObject("surprised.Image")));
            this.surprised.Location = new System.Drawing.Point(3, 46);
            this.surprised.Name = "surprised";
            this.surprised.Size = new System.Drawing.Size(19, 18);
            this.surprised.TabIndex = 12;
            this.surprised.TabStop = false;
            this.surprised.Click += new System.EventHandler(this.surprised_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(713, 423);
            this.Controls.Add(this.p_icons);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.etiqueta);
            this.Controls.Add(this.rb_estadoAusemte);
            this.Controls.Add(this.rb_estadoOcupado);
            this.Controls.Add(this.rb_estadoDisponible);
            this.Controls.Add(this.TD4W);
            this.Controls.Add(this.closegc);
            this.Controls.Add(this.campomensaje);
            this.Controls.Add(this.enviarmensaje);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.listacontactos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.Click += new System.EventHandler(this.principal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.TD4W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_icons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.angel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confuse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dissa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surprised)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listacontactos;
        private System.Windows.Forms.RichTextBox mensaje;
        private System.Windows.Forms.Button enviarmensaje;
        private System.Windows.Forms.RichTextBox campomensaje;
        private System.Windows.Forms.Button closegc;
        private System.Windows.Forms.PictureBox TD4W;
        private System.Windows.Forms.RadioButton rb_estadoDisponible;
        private System.Windows.Forms.RadioButton rb_estadoOcupado;
        private System.Windows.Forms.RadioButton rb_estadoAusemte;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label etiqueta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel p_icons;
        private System.Windows.Forms.PictureBox wink;
        private System.Windows.Forms.PictureBox tonge;
        private System.Windows.Forms.PictureBox teeh;
        private System.Windows.Forms.PictureBox surprised;
        private System.Windows.Forms.PictureBox smile;
        private System.Windows.Forms.PictureBox shy;
        private System.Windows.Forms.PictureBox sad;
        private System.Windows.Forms.PictureBox grin;
        private System.Windows.Forms.PictureBox sot;
        private System.Windows.Forms.PictureBox dissa;
        private System.Windows.Forms.PictureBox devil;
        private System.Windows.Forms.PictureBox cry;
        private System.Windows.Forms.PictureBox cool;
        private System.Windows.Forms.PictureBox confuse;
        private System.Windows.Forms.PictureBox angry;
        private System.Windows.Forms.PictureBox angel;
    }
}