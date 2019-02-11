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
        private int maxLen = 10;
        public howTo(int maxLen)
        {
            this.maxLen = maxLen;
            InitializeComponent();
        }

        public void clear()
        {
            richTextBox1.Clear();
        }
        public void addRow(String user1,String strelka, String user2,String money)
        {
            while (user1.Length < maxLen+1)
                user1 += " ";
            while (user2.Length < maxLen+1)
                user2 += " ";

            richTextBox1.AppendText(user1+strelka+ user2 + money + Environment.NewLine);
            Height += 22;
            
        }
    }
}
