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

namespace beadando_yh3dt9.Entities
{
    class Layout
    {
        
        Label resztvevok = new Label()
        {
            Width = 250,
            Height = 40,
            Location = new Point(20,20),
            Text = "Résztvevő tanulók:",

        };
       

        TextBox kereso = new TextBox()
        {
            Width = 600,
            Height = 40,
            Location = new Point (350,20)
            
        };

        Button kereses = new Button()
        {
            Width = 300,
            Height = 40,
            Location = new Point(1000, 20),
            Text = "Keresés",
        };

        Button betoltes = new Button()
        {
            Width = 300,
            Height = 40,
            Location = new Point(1500, 20),
            Text = "Adatok betöltése",
        };

        Button sorsolas = new Button()
        {
            Width = 300,
            Height = 40,
            Location = new Point(1500, 80),
            Text = "Sorsolás",
        };

        Button exportalas = new Button()
        {
            Width = 300,
            Height = 40,
            Location = new Point(1500, 140),
            Text = "Adatok exportálása",
        };

        ListBox tanulok = new ListBox()
        {
            Width = 400,
            Height = 1000,
            Location = new Point (20,80)
        };


    }
}
