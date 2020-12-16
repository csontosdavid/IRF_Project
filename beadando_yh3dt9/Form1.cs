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
        List<StudentData> Huzottnev = new List<StudentData>();
        List<string> Ajandek = new List<string>();
        public Form1()
        {
            InitializeComponent();
            

            
            //kereso.Text = Students[0].Name;

            listBox1.DataSource = Students;
            listBox1.DisplayMember = "Name";

            

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
            var sorsolas = Enumerable.Range(0, letszam-1).OrderBy(x => rnd.Next()).Take(letszam).ToList();
            MessageBox.Show("Sorsolás megtörtént!");
            for (int i = 0; i < letszam-1; i++)
            {
                Students[i].Pair = sorsolas[i];
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {          
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                foreach (var student in Students)
                {
                    sw.Write(student.Name);
                    sw.Write(" őt húzta: ");
                    sw.Write(Students[student.Pair].Name);
                    sw.WriteLine();

                }
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            int othuzta = new int() ;
            othuzta = Students[listBox1.SelectedIndex].Pair -1;
            MessageBox.Show(Students[listBox1.SelectedIndex].Name + " őt húzta: " + Students[othuzta].Name);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int eztkapja = new int();
            eztkapja = Students[listBox1.SelectedIndex].Gift;
            if (eztkapja == 1) MessageBox.Show(Students[listBox1.SelectedIndex].Name + " Bögrét szeretnekapni!");
            else if (eztkapja == 2) MessageBox.Show(Students[listBox1.SelectedIndex].Name + " Labdát szeretne kapni!");
            else if (eztkapja == 3) MessageBox.Show(Students[listBox1.SelectedIndex].Name + " Puzzle-t szeretne kapni!");
            else if (eztkapja == 4) MessageBox.Show(Students[listBox1.SelectedIndex].Name + " Csokit szeretne kapni");
            else if (eztkapja == 5) MessageBox.Show(Students[listBox1.SelectedIndex].Name + " Játékbabát szeretne kapni");
            else if (eztkapja == 6) MessageBox.Show(Students[listBox1.SelectedIndex].Name + " Kisautót szeretne kapni");
            else if (eztkapja == 7) MessageBox.Show(Students[listBox1.SelectedIndex].Name + " Virgácsot szeretne kapni");

        }
    }
}