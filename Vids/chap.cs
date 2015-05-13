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
    public partial class chap : Form
    {

        IPAddress destino;
        private string nickname;
        private string estado = "Disponible";
        public static Socket master;
        private Hashtable emoticons;
        Thread h;
        SoundPlayer player;


        public chap(string nickname,IPAddress destino)
        {
            InitializeComponent();
            player = new SoundPlayer("TD4W.wav");
            IPAddress[] localIP = Dns.GetHostAddresses("2nd");
            this.destino = destino;
            this.nickname = nickname;

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
                h = new Thread(new ThreadStart(this.datos_entrando));
                this.h.Start();

            }
            catch
            {
                MessageBox.Show("Error al Iniciar Subproceso'Escuchar' Vuelva a Intentar");
                Application.Restart();
            }

        }

        public chap(IPAddress destino,string nickname)
        {
            InitializeComponent();
            player = new SoundPlayer("TD4W.wav");
            IPAddress[] localIP = Dns.GetHostAddresses("2nd");
            this.destino = destino;
            this.nickname = nickname;

            master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                master.Connect(localIP, 1806);
                datos d = new datos(tipo.privadocrear, datos.obtenerip(),destino);
                master.Send(d.toBytes());
                
            }
            catch
            {
                MessageBox.Show("Error al Conectar con el servidor, Vuelva a Intentar");
                Application.Restart();
            }
            try
            {
                h = new Thread(new ThreadStart(this.datos_entrando));
                this.h.Start();

            }
            catch
            {
                MessageBox.Show("Error al Iniciar Subproceso'Escuchar' Vuelva a Intentar");
                Application.Restart();
            }

        }

        private void videoLlamadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Width = 600;
            this.Width = 750;
            hang.Visible = true;
            videorec.Visible = true;
            videosen.Visible = true;
        }

        private void hang_Click(object sender, EventArgs e)
        {
            this.Width = 600;
            hang.Visible = false;
            videorec.Visible = false;
            videosen.Visible = false;
        }


        public void datos_entrando()
        {
            byte[] buffer;
            int readBytes;

            while (true)
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
                    MessageBox.Show("Hubo un Error en la Conexión al recibir datos privados =(");
                    Application.Exit();
                    break;
                }
            }

        }

        private void zumbido(bool n)
        {
            player.Play();
        }

        private void escribirmsj(string text)
        {

            if (!Directory.Exists("historial\\"))
            {
                Directory.CreateDirectory("historial\\");
            }

            if (!File.Exists(datos.obtenerip()+".txt"))
            {

                StreamWriter escrito = File.AppendText("historial\\" + datos.obtenerip() + ".txt");
                String contenido = text;
                //escribimos. 
                escrito.WriteLine(contenido.ToString());
                escrito.Flush();
                //Cerramos 
                escrito.Close();
                //Vaciamos 
                this.messagebox.Text = "";
                leer();
            }
            else
            {
                StreamWriter escrito = File.AppendText("historial\\" + datos.obtenerip() + ".txt");
                String contenido = text;
                //escribimos. 
                escrito.WriteLine(contenido.ToString());
                escrito.Flush();
                //Cerramos 
                escrito.Close();
                //Vaciamos 
                this.messagebox.Text = "";
                leer();
            }

        }

        private void leer()
        {
            this.conversacion.Clear();
            StreamReader leido = File.OpenText("historial\\" + datos.obtenerip() + ".txt");
            //Variable que contendrá el archivo 
            string contenido = null;
            //Leemos todo el archivo 
            contenido = leido.ReadToEnd();
            //Lo mostramos 
            this.conversacion.Text = contenido.ToString();
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
                while (conversacion.Text.Contains(emoticon))
                {
                    int ind = conversacion.Text.IndexOf(emoticon);
                    conversacion.Select(ind, emoticon.Length);
                    StreamReader sr = File.OpenText("emoticons/" + emoticons[emoticon] + ".rtf");
                    conversacion.SelectedRtf = sr.ReadToEnd();
                    sr.Close();
                    conversacion.SelectionStart = conversacion.TextLength;
                    conversacion.ScrollToCaret();
                }
            }
        }

        public void direccionador(datos d)
        {

            switch (d.tipomsj)
            {

                case tipo.privadoconfirmado:

                    if (d.destino == datos.obtenerip())
                    {
                        #region 
                        string text = d.msj[0] + ": " + d.msj[1];

                        try
                        {
                            SetTextCallback dd = new SetTextCallback(escribirmsj);

                            this.Invoke(dd, new object[] { text });
                        }
                        catch
                        {
                            MessageBox.Show("Error al Escribir mensaje en archivo, Intentelo Nuevamente");
                        }
                        break;
                        #endregion 
                    }

                    break;

                case tipo.zumbido:
                    #region Zumbido
                    bool a = true;
                    try
                    {
                        SetZumbido dd = new SetZumbido(zumbido);

                        this.Invoke(dd, new object[] { a });
                    }
                    catch
                    {
                        MessageBox.Show("Error al recibir Zumbido, Intentelo Nuevamente");
                    }
                    break;
                    #endregion

            }
        }

        private void enviarchat_Click(object sender, EventArgs e)
        {
            datos d = new datos(tipo.privadoconfirmado, datos.obtenerip());
            d.destino = destino;
            d.msj.Add(nickname);
            d.msj.Add(messagebox.Text);
            master.Send(d.toBytes());
        }

        private void conversacion_TextChanged(object sender, EventArgs e)
        {
            AgregarEmoticon();
        }

        private void chap_Load(object sender, EventArgs e)
        {
            CrearEmoticones();
        }
    }
}
