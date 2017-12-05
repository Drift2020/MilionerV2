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

        public event EventHandler<EventArgs> StartGame;
        public event EventHandler<EventArgs> NewQuestion;
        public event EventHandler<EventArgs> EditQuestion;
        public event EventHandler<EventArgs> DellQuestion;
        public event EventHandler<EventArgs> ExitGame;
        public event EventHandler<EventArgs> StopGame;
        public string ShowDialog
        {
            set; get;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreatQvest_Click(object sender, EventArgs e)
        {

            NewQuestion?.Invoke(this, EventArgs.Empty);
            if (ShowDialog == DialogResult.OK.ToString())
            {
                MessageBox.Show("Вопрос создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Edit_Quest_Click(object sender, EventArgs e)
        {
            EditQuestion?.Invoke(this, EventArgs.Empty);
            if (ShowDialog == DialogResult.OK.ToString())
            {
                MessageBox.Show("Вопрос создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Dell_Question_Click(object sender, EventArgs e)
        {

            DellQuestion?.Invoke(this, EventArgs.Empty);
            if (ShowDialog == DialogResult.OK.ToString())
            {
                MessageBox.Show("Вопрос удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
