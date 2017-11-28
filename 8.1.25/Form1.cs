using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace _8._1._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DOIT_Click(object sender, EventArgs e)
        {
            List<int> list = ListUtils.ToList(InputList1.Text);
            ListUtils utils = new ListUtils(list);
            List<int> res = utils.CreateNewList(ListUtils.ToList(InputList2.Text));
           Aswer.Text = ListUtils.ToString(res);
        }
    }
}
