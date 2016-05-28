using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;

namespace Automobile
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string b = textBox1.Text;
            b = b.Replace(' ', '+');







            WebRequest request = WebRequest.Create(
              "https://api.havenondemand.com/1/api/sync/analyzesentiment/v1?text="+b+"&language=eng&apikey=f8969450-709e-4fdc-9942-21ba99beb405");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            int l = responseFromServer.Length;
            // Display the content.
            //textBox1.Text=responseFromServer;
            Console.WriteLine(responseFromServer);
            String extract = "\"sentiment\": ";
            int a = responseFromServer.LastIndexOf(extract);
            //MessageBox.Show(a.ToString());
            //MessageBox.Show(l.ToString());
            String m = responseFromServer.Substring(a+14,8);
            String c = responseFromServer.Substring(a + 41, 6);
            //double value = Double.Parse(m);
            MessageBox.Show(m);
            MessageBox.Show(c);

            // Clean up the streams and the response.
            reader.Close();
            response.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 ob = new Form6();
            this.Hide();
            ob.Show();
        }
    }
}
