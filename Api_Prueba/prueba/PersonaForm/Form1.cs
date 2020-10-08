using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace PersonaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44359/api/Persona";
        }

        //public class Reply
        //{
        //    public Reply()
        //    {
        //        this.success = 0;
        //        message = "";
        //    }

        //    public int success { get; set; }
        //    public object data { get; set; }
        //    public String menssage { get; set; }

        //}

    //    public string Send<T>(string url, T objectRequest, string method = "POST")
    //    {

    //        try
    //        {
    //            string oReply = "";

    //            JavaScriptSerializer js = new JavaScriptSerializer();

    //            //serializamos el objeto
    //            string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

    //            //peticion
    //            WebRequest request = WebRequest.Create(url);
    //            //headers
    //            request.Method = method;
    //            request.PreAuthenticate = true;
    //            request.ContentType = "application/json;charset=utf-8'";
    //            request.Timeout = 10000; //esto es opcional

    //            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
    //            {
    //                streamWriter.Write(json);
    //                streamWriter.Flush();
    //            }

    //            var httpResponse = (HttpWebResponse)request.GetResponse();
    //            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
    //            {
    //                result = streamReader.ReadToEnd();
    //            }
    //            oReply.success = 1;
    //            //y aquí va nuestra respuesta, la cual es lo que nos regrese el sitio solicitado
    //            oReply.data = result;
    //        }
    //        catch (Exception e)
    //        {

    //            oReply.result = 0;
    //            //en caso de error lo manejamos en el mensaje
    //            oReply.menssage = e.Message;

    //        }

    //        return oReply;
    //    }

    //    private class StreamWriter : IDisposable
    //    {
    //        private System.IO.Stream stream;

    //        public StreamWriter(System.IO.Stream stream)
    //        {
    //            this.stream = stream;
    //        }
    //    }
    //}
}
}
