using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Текстовый_редактор_ПР4
{
    public partial class FindReplace : Form
    {
        public FindReplace(byte i)
        {
            InitializeComponent();
            tabControl1.SelectTab(i);
            tabControl1_Selected(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            this.Text = tabControl1.SelectedTab.Text;
        }
    }
}
