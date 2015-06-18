using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLinQ
{
    public partial class Form1 : Form
    {
        Person[] persons  = {
                          new Person { Name = "Meier", Age = 34 },
                          new Person { Name = "Müller", Age = 51 },
                          new Person { Name = "Schmidt", Age = 30 },
                          new Person { Name = "Fischer", Age = 25 },
                          new Person { Name = "Schulz", Age = 67 },
                        };
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            var query = from pers in persons
                        where pers.Age >= 50
                        select pers; 
        }

        private void buttonBsp1_Click(object sender, EventArgs e)
        {
            //LinQ
            persons[3].Age = 52;
            var query = from pers in persons
                        where pers.Age >= 50
                        select pers;
            richTextBoxAusgabe.Text = String.Empty;
            foreach (var item in query)
                richTextBoxAusgabe.Text += String.Format("{0,-15}{1}\n", item.Name, item.Age);
            
        }

        private void buttonBsp2_Click(object sender, EventArgs e)
        {
            persons[3].Age = 53;
            //Lambda-Expressions
            var query = persons
            .Where(p => p.Age >= 50);
            //.Select(p => p);
            richTextBoxAusgabe.Text = String.Empty;
            foreach (var item in query)
                richTextBoxAusgabe.Text += String.Format("{0,-15}{1}\n", item.Name, item.Age);
        }
    }
}
