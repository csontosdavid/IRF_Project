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
            
                Label resztvevok = new Label()
                {
                    Width = 100,
                    Height = 40,
                    Location = new Point(20, 20),
                    Text = "Résztvevő tanulók:",

                };
                this.Controls.Add(resztvevok);

                TextBox kereso = new TextBox()
                {
                    Width = 300,
                    Height = 40,
                    Location = new Point(140, 20)

                };
                this.Controls.Add(kereso);

                Button kereses = new Button()
                {
                    Width = 300,
                    Height = 40,
                    Location = new Point(460, 20),
                    Text = "Keresés",
                };
                this.Controls.Add(kereses);

                Button betoltes = new Button()
                {
                    Width = 300,
                    Height = 40,
                    Location = new Point(780, 20),
                    Text = "Adatok betöltése",
                };
                this.Controls.Add(betoltes);

                Button sorsolas = new Button()
                {
                    Width = 300,
                    Height = 40,
                    Location = new Point(780, 80),
                    Text = "Sorsolás",
                };
                this.Controls.Add(sorsolas);

                Button exportalas = new Button()
                {
                    Width = 300,
                    Height = 40,
                    Location = new Point(780, 140),
                    Text = "Adatok exportálása",
                };
                this.Controls.Add(exportalas);

                ListBox tanulok = new ListBox()
                {
                    Width = 500,
                    Height = 500,
                    Location = new Point(20, 80)
                };
                this.Controls.Add(tanulok);
            
            

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
            //kereso.Text = Students[0].Name;

            tanulok.DataSource = Students;
            tanulok.DisplayMember = "Name";

        }

      
    }
}