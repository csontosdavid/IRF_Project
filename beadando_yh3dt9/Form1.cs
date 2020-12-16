using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using beadando_yh3dt9.Entities;


namespace beadando_yh3dt9
{
    public partial class Form1 : Form
    {
        BindingList<StudentData> Students = new BindingList<StudentData>();


        public Form1()
        {
            InitializeComponent();
            
            
            
            //kereso.Text = Students[0].Name;

            //listBox1.DataSource = Students;
            //listBox1.DisplayMember = "Name";

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "XML Files|*.xml";
            ofd.DefaultExt = "xml";
            ofd.AddExtension = true;
            if (ofd.ShowDialog() != DialogResult.OK) return;

            StreamReader sr = new StreamReader("Students.xml");

            var xmlString = sr.ReadToEnd();
            //MessageBox.Show(xmlString);

            var xml = new XmlDocument();
            xml.LoadXml(xmlString);

            foreach (XmlElement element in xml.DocumentElement)
            {
                
                var student = new StudentData();
                Students.Add(student);

                var idElement = (XmlElement)element.ChildNodes[0];
                if (idElement == null)
                    continue;
                student.ID = int.Parse(idElement.InnerText);

                var nameElement = (XmlElement)element.ChildNodes[1];
                if (nameElement == null)
                    continue;
                student.Name = nameElement.InnerText;

                var addressElement = (XmlElement)element.ChildNodes[2];
                if (addressElement == null)
                    continue;
                student.Address = addressElement.InnerText;

                var giftElement = (XmlElement)element.ChildNodes[3];
                if (giftElement == null)
                    continue;
                student.Gift = int.Parse(giftElement.InnerText);

                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var letszam = Students.Count();           
            var rnd = new Random();
            var randomNumbers = Enumerable.Range(1, letszam).OrderBy(x => rnd.Next()).Take(letszam).ToList();
            listBox1.DataSource = randomNumbers;
        }

        
        
    }
}