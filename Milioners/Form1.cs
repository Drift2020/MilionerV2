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
        public Button FlagS { set { Flag = value; } get { return Flag; } }
        public Button ExitS { set { Exit= value; } get { return Exit; } }
        public Button StopS { set { Stop= value; } get { return Stop; } }
        public Label QuestTableS { set { QuestTable= value; } get { return QuestTable; } }
        public ListView NumberlistViewS { set { NumberlistView= value; } get { return NumberlistView; } }
        public Button Ansver_AS { set { Ansver_A= value; } get { return Ansver_A; } }
        public Button Ansver_BS { set { Ansver_B= value; } get { return Ansver_B; } }
        public Button Ansver_CS { set { Ansver_C= value; } get { return Ansver_C;} }
        public Button Ansver_DS { set { Ansver_D= value; } get { return Ansver_D ; } }
        public Button FandFS { set { FandF= value; } get { return FandF; } }
        public Button HelpCallS { set { HelpCall= value; } get { return HelpCall; } }
        public Button HelpRoomS { set { HelpRoom= value; } get { return HelpRoom; } }
        public GroupBox HelpVariantS { set { HelpVariant= value; } get { return HelpVariant; } }

        public PictureBox CallPictureBoxS { set { CallPictureBox= value; } get { return CallPictureBox; } }
        public Label CallLabelS { set { CallLabel= value; } get { return CallLabel; } }

        public PictureBox AnsverPictureBoxS { set { AnsverPictureBox= value; } get { return AnsverPictureBox ; } }
        public Label AnsverLabelS { set { AnsverLabel= value; } get { return AnsverLabel ; } }
        public GroupBox HelpBarS { set { HelpBar= value; } get { return HelpBar; } }



        public void Exitf()
        {
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            ExitGame?.Invoke(this, EventArgs.Empty);
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

            ExitGame?.Invoke(this, EventArgs.Empty);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ExitGame?.Invoke(this, EventArgs.Empty);
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
