using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nagornaya
{
    public partial class howTo : Form
    {
        public howTo()
        {
            InitializeComponent();
        }

        public void clear()
        {
            richTextBox1.Clear();
        }
        public void addRow(String user1,String strelka, String user2,String money)
        {
            while (user1.Length != 8)
                user1 += " ";
            while (user2.Length != 8)
                user2 += " ";

            richTextBox1.AppendText(user1+strelka+ user2 + money + Environment.NewLine);
        }
    }
}
