using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milioners
{
    public delegate void MyDelegate();
    public partial class Form1 : Form
    {
      
        public Form1()
        {
          
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void CreatQvest_Click(object sender, EventArgs e)
        {
            Add_Edit Add_Edit_form = new Add_Edit(true);

            P_Add loginPresenter = new P_Add(Add_Edit_form);

            if (Add_Edit_form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Edit_Quest_Click(object sender, EventArgs e)
        {

            Add_Edit Add_Edit_form = new Add_Edit(false);

            P_Edit loginPresenter = new P_Edit(Add_Edit_form);

            if (Add_Edit_form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("вопрос изменён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
