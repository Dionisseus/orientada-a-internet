using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;


namespace Informacion
{
    [Serializable]

    public class datos
    {
        public tipo tipomsj;
        public IPAddress remitente;
        public List<string> msj;
        public string nickname;
        public string estado;
        public IPAddress destino;

        public List<datos> us;

        public datos(tipo tipomsj)
        {
            this.tipomsj = tipomsj;
        }

        public datos(tipo tipomsj, IPAddress remitente)
        {
            msj = new List<string>();
            this.remitente = remitente;
            this.tipomsj = tipomsj;
        }

        public datos(tipo tipomsj, IPAddress remitente,IPAddress destino)
        {
            msj = new List<string>();
            this.remitente=remitente;
            this.destino = destino;
            this.tipomsj=tipomsj;
        }

        public datos(byte[] datosbytes)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(datosbytes);

            datos d = (datos)bf.Deserialize(ms);
            ms.Close();
            this.msj = d.msj;
            this.remitente = d.remitente;
            this.tipomsj = d.tipomsj;

        }

        public byte[] toBytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, this);
            byte[] bytes = ms.ToArray();
            ms.Close();
            return bytes;
        }

        public static IPAddress obtenerip()
        {
            try
            {
                IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
                foreach (IPAddress i in ips)
                {
                    if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return i;
                    }
                }
                return IPAddress.Parse("127.0.0.1");
            }
            catch
            {
               //("Error al tratar de obtener IP, Intentelo mas tarde");
                return null;
            }
        }

        public static string obtenersvr(string host)
        {
            try
            {
                IPAddress[] ips = Dns.GetHostAddresses(host);
                foreach (IPAddress i in ips)
                {
                    if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return i.ToString();
                    }
                }

                return "127.0.0.1";
            }
            catch
            {
                //("Error al tratar de obtener IP de Servidor, Intentelo mas tarde");
                return null;
            }
        }

    }

    public enum tipo
    {
        chat,
        privadocrear,
        privadoconfirmado,
        zumbido,
        confirmacion,
        estado,
        add,
        delete
    }

}