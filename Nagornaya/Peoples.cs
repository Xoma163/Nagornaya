using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Nagornaya
{
    public partial class Peoples : Form
    {
        public List<String> peopleBefore { get; }
        public List<String> peopleAfter { get; }


        public Peoples()
        {
            InitializeComponent();
            peopleBefore = new List<String>();
            peopleAfter = new List<String>();
        }

        public void addPeople()
        {
            using (StreamReader sr = new StreamReader("Peoples.txt"))
            {
                string sLine = "";
                while (sLine != null)
                {
                    sLine = sr.ReadLine();
                    if (sLine != null)
                    {
                        richTextBox1.AppendText(sLine + Environment.NewLine);
                        peopleBefore.Add(sLine);
                        Height += 22;
                    }
                }
                sr.Close();
            }
        }

        private void Peoples_FormClosing(object sender, FormClosingEventArgs e)
        {
            for(int i = 0; i < richTextBox1.Lines.Count(); i++)
                if(richTextBox1.Lines[i]!="")
                peopleAfter.Add(richTextBox1.Lines[i]);


        }
    }

    
}
