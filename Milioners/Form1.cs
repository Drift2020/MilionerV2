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
    public partial class Form1 : Form , I_Global
    {
      
        public Form1()
        {
          
            InitializeComponent();

            Flag.Visible = false;
            Exit.Visible = false;
            Stop.Visible = false;
            QuestTable.Visible = false;
            NumberlistView.Visible = false;
            Ansver_A.Visible = false;
            Ansver_B.Visible = false;
            Ansver_C.Visible = false;
            Ansver_D.Visible = false;
            FandF.Visible = false;
            HelpCall.Visible = false;
            HelpRoom.Visible = false;
            groupBox1.Visible = false;

        }
        public event EventHandler<EventArgs> Conteiner;

        public Сontainer Questio { set; get; }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Dell_Question_Click(object sender, EventArgs e)
        {

            Dell Dell_form = new Dell();

            P_Dell loginPresenter = new P_Dell(Dell_form);

            if (Dell_form.ShowDialog() == DialogResult.OK)
            {
              //  MessageBox.Show("Вопрос удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Exit_tolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
