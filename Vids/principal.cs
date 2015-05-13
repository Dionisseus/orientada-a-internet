using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Net.NetworkInformation;
using System.IO;
using System.Windows.Input;
using System.Collections;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Media;
using Informacion;
using System.Resources;

namespace Vids
{
    delegate void SetTextCallback(string text);

    delegate void SetZumbido(bool q);

    public partial class principal : Form
    {
        private string nickname;
        private string estado="Disponible";
        public static Socket master;
        private Hashtable emoticons;
        
        byte[] data = new byte[1024];
        Thread e;

        IPAddress miIP = datos.obtenerip();
        SoundPlayer player;

        public principal(string nick)
        {
            InitializeComponent();
            player = new SoundPlayer("TD4W.wav");

            nickname = nick;
           
            IPAddress[] localIP = Dns.GetHostAddresses("2nd");
            
            master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


            try
            {
                master.Connect(localIP, 1806);
            }
            catch
            {
                MessageBox.Show("Error al Conectar con el servidor, Vuelva a Intentar");
                Application.Restart();
            }
            try
            {
                e = new Thread(new ThreadStart(this.datos_entrando));
                this.e.Start();

            }
            catch
            {
                MessageBox.Show("Error al Iniciar Subproceso'Escuchar' Vuelva a Intentar");
                Application.Restart();
            }
            etiqueta.Text=nickname+"-"+estado;
        }

        #region eventos

        private void listacontactos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listacontactos.ValueMember != "")
            {
                IPAddress ipp = IPAddress.Parse(listacontactos.ValueMember);
                chap ms = new chap(ipp, nickname);
                ms.Show();
            }
        }

        private void closegc_Click(object sender, EventArgs e)
        {

            datos d = new datos(tipo.delete, miIP);
            master.Send(d.toBytes());
           Application.Exit();
        }

        private void principal_Click(object sender, EventArgs e)
        {
        }

        private void campomensaje_TextChanged(object sender, EventArgs e)
        {
            AgregarEmoticon();
        }

        private void enviarmensaje_Click(object sender, EventArgs e)
        {
           datos d= new datos(tipo.chat,miIP);
            d.msj.Add(nickname);
            d.msj.Add(mensaje.Text);
            master.Send(d.toBytes());

        }

        private void mensaje_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enviarmensaje_Click(sender, e);
                System.Windows.Forms.SendKeys.Send("{BACKSPACE}");
            }
        }

        private void principal_Load(object sender, EventArgs e)
        {
            CrearEmoticones();
        }
        private void TD4W_Click(object sender, EventArgs e)
        {
            datos d = new datos(tipo.zumbido, miIP);
            master.Send(d.toBytes());
        }

        #endregion

        private void zumbido(bool n)
        { 
            player.Play();
        }

        #region emoticones
        private void escribirmsj(string text)
        {
           
            if (!Directory.Exists("historial\\"))
            {
                Directory.CreateDirectory("historial\\");
            }

            if (!File.Exists("conversacion.txt"))
            {

                StreamWriter escrito = File.AppendText("historial\\" + "conversacion.txt");
                String contenido = text;
                //escribimos. 
                escrito.WriteLine(contenido.ToString());
                escrito.Flush();
                //Cerramos 
                escrito.Close();
                //Vaciamos 
                this.mensaje.Text = "";
                leer();
            }
            else
            {
                StreamWriter escrito = File.AppendText("historial\\" + "conversacion.txt");
                String contenido = text;
                //escribimos. 
                escrito.WriteLine(contenido.ToString());
                escrito.Flush();
                //Cerramos 
                escrito.Close();
                //Vaciamos 
                this.mensaje.Text = "";
                leer();
            }
            
        }

        private void leer()
        {
            this.campomensaje.Clear();
            StreamReader leido = File.OpenText("historial\\" + "conversacion.txt");
            //Variable que contendrá el archivo 
            string contenido = null;
            //Leemos todo el archivo 
            contenido = leido.ReadToEnd();
            //Lo mostramos 
            this.campomensaje.Text= contenido.ToString();
            //Cerramos 
            leido.Close(); 
        }

        public void CrearEmoticones()
        {
            emoticons = new Hashtable(16);
            emoticons.Add(":)", "smile");
            emoticons.Add(":D", "grin");
            emoticons.Add(":o", "surprised");
            emoticons.Add(":p", "tongue_smile");
            emoticons.Add(";)", "wink");
            emoticons.Add(":(", "sad");
            emoticons.Add(":s", "confused");
            emoticons.Add(":|", "dissapointed");
            emoticons.Add(":'(", "crying");
            emoticons.Add(":$", "shy");
            emoticons.Add("(H)", "cool");
            emoticons.Add(":@", "angry");
            emoticons.Add("(A)", "angel");
            emoticons.Add("(6)", "devil");
            emoticons.Add(":#", "dont_tell");
            emoticons.Add("8|", "teeth");
        }

        public void AgregarEmoticon()
        {
            foreach (string emoticon in emoticons.Keys)
            {
                while (campomensaje.Text.Contains(emoticon))
                {
                    int ind = campomensaje.Text.IndexOf(emoticon);
                    campomensaje.Select(ind, emoticon.Length);
                    StreamReader sr = File.OpenText("emoticons/" + emoticons[emoticon] + ".rtf");
                    campomensaje.SelectedRtf = sr.ReadToEnd();
                    sr.Close();
                    campomensaje.SelectionStart = campomensaje.TextLength;
                    campomensaje.ScrollToCaret();
                }
            }
        }

        #region clic icons

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (p_icons.Visible == false)
            {
                p_icons.Visible = true;
            }
            else
            {
                p_icons.Visible = false;
            }


        }



        private void confuse_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":s";
            p_icons.Visible = false;
        }

        private void cool_Click(object sender, EventArgs e)
        {
            mensaje.Text += "(H)";
            p_icons.Visible = false;
        }

        private void cry_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":'(";
            p_icons.Visible = false;
        }

        private void devil_Click(object sender, EventArgs e)
        {
            mensaje.Text += "(6)";
            p_icons.Visible = false;
        }

        private void grin_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":D";
            p_icons.Visible = false;
        }

        private void sad_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":(";
            p_icons.Visible = false;
        }

        private void shy_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":$";
            p_icons.Visible = false;
        }

        private void smile_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":)";
            p_icons.Visible = false;
        }

        private void surprised_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":o";
            p_icons.Visible = false;
        }

        private void teeh_Click(object sender, EventArgs e)
        {
            mensaje.Text += "8|";
            p_icons.Visible = false;
        }

        private void tonge_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":p";
            p_icons.Visible = false;
        }

        private void wink_Click(object sender, EventArgs e)
        {
            mensaje.Text += ";)";
            p_icons.Visible = false;
        }

        private void angry_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":@";
            p_icons.Visible = false;
        }

        private void sot_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":#";
            p_icons.Visible = false;
        }

        private void dissa_Click(object sender, EventArgs e)
        {
            mensaje.Text += ":|";
            p_icons.Visible = false;
        }

        private void angel_Click(object sender, EventArgs e)
        {
            mensaje.Text += "(A)";
            p_icons.Visible = false;
        }
        #endregion

        #endregion

        public void datos_entrando()
        {
            byte[] buffer;
            int readBytes;

            while(true)
            {
                try
                {
                    buffer = new byte[master.SendBufferSize];
                    readBytes = master.Receive(buffer);

                    if (readBytes > 0)
                    {
                        direccionador(new datos(buffer));
                    }
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("Hubo un Error en la Conexión al recibir datos =(");
                    Application.Exit();
                    break;
                }
            }

        }

        public void direccionador(datos d)
        {

            switch (d.tipomsj)
            {

                case tipo.chat:
                    #region chatgrupal
                    string text = d.msj[0] + ": " + d.msj[1];

                    try{
                        SetTextCallback dd = new SetTextCallback(escribirmsj);
                        
                        this.Invoke(dd, new object[] { text });
                    }
                    catch
                    {
                        MessageBox.Show("Error al Escribir mensaje en archivo, Intentelo Nuevamente");
                    }
                    break;
                    #endregion 

                case tipo.privadocrear:
                   
                    //d.remitente
                    chap ms = new chap(nickname,d.remitente);
                    ms.Show();

                    break;

                case tipo.zumbido:
                    #region Zumbido
                    bool a=true;
                    try
                    {
                        SetZumbido dd = new SetZumbido(zumbido);

                        this.Invoke(dd, new object[] {a});
                    }
                    catch
                    {
                        MessageBox.Show("Error al recibir Zumbido, Intentelo Nuevamente");
                    }
                    break;
                    #endregion
                case tipo.confirmacion :

                //#region confirmacion
                //    d=new datos(tipo.confirmacion);
                //    d.nickname=this.nickname;
                //    d.remitente=miIP;
                //    d.estado = this.estado;
                //    master.Send(d.toBytes());
                //    
                //#endregion

                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (rb_estadoAusemte.Checked== true)
                estado = rb_estadoAusemte.Text;
            if (rb_estadoDisponible.Checked == true)
                estado = rb_estadoDisponible.Text;
            if (rb_estadoOcupado.Checked == true)
                estado = rb_estadoOcupado.Text;
            etiqueta.Text = nickname + "-" + estado;
        }



    }
}
