using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Media;

namespace Milioners
{
    public delegate void MyDelegate();
    public partial class Form1 : Form, I_Global
    {
        bool win = false;
        bool lose = false;
        bool secondMenu=false;
        float NowTime = 0;
        float EndTime = 40;
       
        Button ClicNow;
        int numberQuestion = 0;
        string[] money = new string[]{"100", "200",
            "300", "500", "1000",
            "2000","4000","8000","16000","32000","64000","125000","250000","500000","1000000"};
        public Form1()
        {         
           InitializeComponent();

         
           
            // public event ElapsedEventHandler Elapsed - это событие происходит по истечении интервала времени
            TimeWindow.Tick += new EventHandler(OnTick);
            TimeRed.Tick += new ElapsedEventHandler(OnTickRed);
            // Начинает вызывать событие Elapsed


            if (secondMenu)
            {

            }
            else
            {
                Flag.Visible = false;
                Exit.Visible = false;
                Stop.Visible = false;
                CallPictureBox.Visible = false;
                CallLabel.Visible = false;
                HelpBar.Visible = false;
                HelpVariant.Visible = false;
                NumberlistView.Visible = false;
                AnsverPictureBox.Visible = false;
                AnsverLabel.Visible = false;
                QuestTable.Visible = false;
                Ansver_A.Visible = false;
                Ansver_B.Visible = false;
                Ansver_C.Visible = false;
                Ansver_D.Visible = false;

            }

        }

        public event EventHandler<EventArgs> StartGame;
        public event EventHandler<EventArgs> NewQuestion;
        public event EventHandler<EventArgs> EditQuestion;
        public event EventHandler<EventArgs> DellQuestion;
        public event EventHandler<EventArgs> ExitGame;
        public event EventHandler<EventArgs> StopGame;
        public event EventHandler<EventArgs> AnsverClick;
        ////////////////////////////////////////////////////////////////
        public string ShowDialog
        {
            set; get;
        }
        public int NumberQuestion { set { numberQuestion = value; } get { return numberQuestion; } }
        public string Ansver_AS { set { Ansver_A.Text= value; } get { return Ansver_A.Text; } }
        public string Ansver_BS { set { Ansver_B.Text = value; } get { return Ansver_B.Text; } }
        public string Ansver_CS { set { Ansver_C.Text = value; } get { return Ansver_C.Text;} }
        public string Ansver_DS { set { Ansver_D.Text = value; } get { return Ansver_D.Text; } }
        public bool Win { set { win = value; } get { return lose; } }
        public bool Lose { set { lose = value; } get { return lose; } }
        public void OnTickRed(object sender, EventArgs e)
        {
            
            if(ClicNow.BackColor==Color.Black)
            {
                ClicNow.BackColor = Color.Red;
            }
            else
            {
                ClicNow.BackColor = Color.Black;
            }
            if (NowTime >= EndTime)
            {

                ClicNow.BackColor = Color.Black;
                TimeRed.Stop();
            }
        }
        public void OnTick(object sender, EventArgs e)
        {
            NowTime += 1;

            if (NowTime >= EndTime)
            {
                SecondWindow(false);
                Start_Window(true);
                TimeWindow.Stop();              
            }
        }
        public void SetColorNewElement(int number)
        {
            if(number==14)
            {
                NumberlistView.Items[number].BackColor = Color.Gold;
            }
            else
            {
                NumberlistView.Items[number].BackColor = Color.Gold;
                NumberlistView.Items[number+1].BackColor = Color.Black;
            }
        }
        public string Ansver { set; get; }
        public string Question { set { QuestTable.Text = value; } get { return QuestTable.Text; } }
        
         ////////////////////////////////////////////////////////////////
       
        public bool StartGameQ
        {
            set { secondMenu = value; }get { return secondMenu; }
        }
        public void Error(string z, string s)
        {
            MessageBox.Show(s, z, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Exitf()
        {
            Close();
        }
        private void SecondWindow(bool t)
        {
            StartGameQ = t;
            Ansver_A.Visible = t;
            Ansver_B.Visible = t;
            Ansver_C.Visible = t;
            Ansver_D.Visible = t;
            Flag.Visible = t;
            Exit.Visible = t;
            Stop.Visible = t;
            QuestTable.Visible = t;
            FandF.Visible = t;
            HelpCall.Visible = t;
            HelpRoom.Visible = t;
            HelpVariant.Visible = t;
            NumberlistView.Visible = t;
        }
        private void LoseGame()
        {
           

            TimeWindow.Start();
            TimeRed.Start();
            SoundPlayer player = new SoundPlayer("../../Resurses/sound/false.wav");
            // player.SoundLocation = "../../sound.wav";
            player.Play();
          
        }
        private void Start_Window(bool t)
        {
            CallPictureBox.Visible = t;
            CallLabel.Visible = t;
            AnsverPictureBox.Visible = t;
            AnsverLabel.Visible = t;
            HelpBar.Visible = t;
            Start.Visible = t;
            ExitG.Visible = t;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            StartGame?.Invoke(this, EventArgs.Empty);
            if (StartGameQ)
            {
               Ansver_A.Visible = true;
               Ansver_B.Visible = true;
               Ansver_C.Visible = true;
               Ansver_D.Visible = true;
               Flag.Visible = true;
               Exit.Visible = true;
               Stop.Visible = true;
               QuestTable.Visible = true;
               FandF.Visible = true;
               HelpCall.Visible = true;
               HelpRoom.Visible = true;
               HelpVariant.Visible = true;
               NumberlistView.Visible = true;

                Start_Window(false);

                NumberlistView.View = View.Details;

                ColumnHeader columnHeader1 = new ColumnHeader();
                // Укажем название столбца      
                // Зададим выравнивание столбца
                columnHeader1.TextAlign = HorizontalAlignment.Left;
                // Установим ширину столбца
                columnHeader1.Width = 70;

                // Создаём второй столбец для табличного режима
                ColumnHeader columnHeader2 = new ColumnHeader();
                // Укажем название столбца
          
                // Зададим выравнивание столбца
                columnHeader2.TextAlign = HorizontalAlignment.Right;
                // Установим ширину столбца
                columnHeader2.Width = 100;

            
                // Добавим столбцы в список
                NumberlistView.FullRowSelect = true;
                NumberlistView.Columns.Clear();
                NumberlistView.Columns.Add(columnHeader1);
                NumberlistView.Columns.Add(columnHeader2);
         
                for (int count = 0; count < money.Length; count++)
                {
                    // Создадим элемент списка, указав в конструкторе текст элемента списка
                    ListViewItem listItem = new ListViewItem((14-count + 1).ToString());

                    // Для элемента списка зададим подэлемент (второй столбец в табличном представлении)
                    if ((15- count) % 5 == 0)
                        listItem.ForeColor = Color.Goldenrod;
                    else
                        listItem.ForeColor = Color.Yellow;

                    listItem.SubItems.Add(money[14-count]);
                    // Созданный элемент списка присоединим к списку
              
                    NumberlistView.Items.Add(listItem);
                }

                NumberQuestion = 14;
                SetColorNewElement(NumberQuestion);
            }
            
        }

        private void CreatQvest_Click(object sender, EventArgs e)
        {
            Add_Edit Add_Edit_form = new Add_Edit(true);

            P_Add loginPresenter = new P_Add(Add_Edit_form);

            //_view.ShowDialog = Add_Edit_form.ShowDialog().ToString();
           // NewQuestion?.Invoke(this, EventArgs.Empty);

            if (Add_Edit_form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Edit_Quest_Click(object sender, EventArgs e)
        {
            Add_Edit Add_Edit_form = new Add_Edit(false);

            P_Edit loginPresenter = new P_Edit(Add_Edit_form);

            // _view.ShowDialog = Add_Edit_form.ShowDialog().ToString();
            //EditQuestion?.Invoke(this, EventArgs.Empty);
            DialogResult resalt = Add_Edit_form.ShowDialog();
            if (resalt == DialogResult.OK)
            {
                MessageBox.Show("Вопрос создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Dell_Question_Click(object sender, EventArgs e)
        {
            Dell Dell_form = new Dell();

            P_Dell loginPresenter = new P_Dell(Dell_form);

            //_view.ShowDialog = Dell_form.ShowDialog().ToString();
            //  DellQuestion?.Invoke(this, EventArgs.Empty);
            if (Dell_form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Вопрос удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Exit_tolbar_Click(object sender, EventArgs e)
        {
            DialogResult resalt = MessageBox.Show("Точно хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(resalt== DialogResult.OK)
            Close();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resalt = MessageBox.Show("Точно хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resalt == DialogResult.OK)
                Close();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult resalt = MessageBox.Show("Точно хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resalt == DialogResult.OK)
                Close();

        }
        private void AnsverClic(object sender, EventArgs e)
        {
            if (!win && !lose)
            {
                Button temp = ClicNow = sender as Button;
                Ansver = temp.Text;

                AnsverClick?.Invoke(this, EventArgs.Empty);

                if (win)
                {
                    win = false;
                }
                else if (lose)
                {
                    LoseGame();
                    lose = false;
                }
                SetColorNewElement(numberQuestion);
            }
        }

        private void Exit_tolbar_Click(object sender, FormClosingEventArgs e)
        {
            TimeWindow.Stop();
            TimeRed.Stop();
            ExitGame?.Invoke(this, EventArgs.Empty);
           
        }
    }
}
