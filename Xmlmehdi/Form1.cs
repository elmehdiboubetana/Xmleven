using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Xmlmehdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Deal> list;
        private void Form1_Load(object sender, EventArgs e)
        {
            list = new List<Deal>();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ecrire();
            MessageBox.Show("Document bien enregistrer");
        }

        public void ecrire()
        {
            try
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.NewLineOnAttributes = true;
                xmlWriterSettings.Indent = true;
                using (XmlWriter w = XmlWriter.Create("Deals.xml",xmlWriterSettings))
                {
                    w.WriteStartDocument();
                    w.WriteStartElement("deals");
                    foreach (var item in list)
                    {
                        w.WriteStartElement("deal");
                        w.WriteElementString("id", item.id);
                        w.WriteElementString("city", item.city);
                        w.WriteElementString("category", item.category);
                        w.WriteElementString("title", item.title);
                        w.WriteElementString("description", item.description);
                        w.WriteElementString("price", item.price.ToString());
                        w.WriteElementString("discount", item.discount.ToString());
                        w.WriteElementString("StarTime", item.StarTime.ToShortDateString()+ " "+item.StarTime.ToLongTimeString());
                        w.WriteElementString("EndTime", item.EndTime.ToShortDateString() + " " + item.EndTime.ToLongTimeString());
                        w.WriteElementString("MarchantName", item.MarchantName);
                        w.WriteElementString("MarchantAdresse", item.MarchantAdresse);
                        w.WriteElementString("MarchantPhone", item.MarchanPhone.Trim());
                        w.WriteElementString("img", item.img);
                        w.WriteElementString("LinkView", item.LinkView);
                        w.WriteElementString("LinkAchat", item.LinkAchat);
                        w.WriteEndElement();
                    }
                    w.WriteEndElement();
                    w.WriteEndDocument();
                    vider();
                }
            }
            catch
            {
                MessageBox.Show("il y a des erreurs");
                vider();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Deal d = new Deal();
                d.id = textBox1.Text;
                d.city = textBox6.Text;
                d.category = textBox9.Text;
                d.title = richTextBox1.Text;
                d.description = richTextBox2.Text;
                d.price = Convert.ToDouble(textBox10.Text);
                d.discount = Convert.ToDouble(textBox3.Text);
                d.StarTime = dateTimePicker1.Value;
                d.EndTime = dateTimePicker2.Value;
                d.MarchantName = textBox4.Text;
                d.MarchantAdresse = textBox5.Text;
                d.MarchanPhone = maskedTextBox1.Text;
                d.img = textBox13.Text;
                d.LinkView = textBox14.Text;
                d.LinkAchat = textBox15.Text;
                list.Add(d);
                string msg = "Deal Num : " + list.Count.ToString() + " est bien enregister";
                MessageBox.Show(msg);
                label19.Text = list.Count.ToString();
                vider();
            }
            catch
            {
                MessageBox.Show("verifier les champs");
            }
        }

        public void vider()
        {
            textBox1.Text = "";
            textBox10.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox9.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            maskedTextBox1.Text = "";
        }
    }
}
