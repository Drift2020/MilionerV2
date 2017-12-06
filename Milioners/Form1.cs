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
    public partial class Form1 : Form, I_Global
    {
        string[] money = new string[]{"100", "200",
            "300", "500", "1000",
            "2000","4000","8000","16000","32000","64000","125000","250000","500000","1000000"};
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
        public event EventHandler<EventArgs> AnsverClick;
        public string ShowDialog
        {
            set; get;
        }
        public Button Start { set { button1 = value; }get { return button1; } }
        public Button ExitG { set{button2=value;} get { return button2; }}
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
        public Label CallLabelS { set { CallLabel = value; } get { return CallLabel; } }

        public PictureBox AnsverPictureBoxS { set { AnsverPictureBox= value; } get { return AnsverPictureBox ; } }
        public Label AnsverLabelS { set { AnsverLabel= value; } get { return AnsverLabel ; } }
        public GroupBox HelpBarS { set { HelpBar= value; } get { return HelpBar; } }
        public string Ansver { set; get; }

        public void Error(string z, string s)
        {
            MessageBox.Show(s, z, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Exitf()
        {
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

          

            NumberlistViewS.View = View.Details;

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
            NumberlistViewS.FullRowSelect = true;
            NumberlistViewS.Columns.Add(columnHeader1);
            NumberlistViewS.Columns.Add(columnHeader2);
         
            for (int count = 0; count < money.Length; count++)
            {

                // Создадим элемент списка, указав в конструкторе текст элемента списка
                ListViewItem listItem = new ListViewItem((14-count + 1).ToString());

                // Для элемента списка зададим подэлемент (второй столбец в табличном представлении)
                listItem.SubItems.Add(money[14-count]);
                // Созданный элемент списка присоединим к списку

               

                NumberlistViewS.Items.Add(listItem);
            }

            StartGame?.Invoke(this, EventArgs.Empty);
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
            if (Add_Edit_form.ShowDialog() == DialogResult.OK)
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

            ExitGame?.Invoke(this, EventArgs.Empty);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ExitGame?.Invoke(this, EventArgs.Empty);
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
        private void AnsverClic(object sender, EventArgs e)
        {

            Button temp = sender as Button;
            Ansver = temp.Text;
            AnsverClick?.Invoke(this, EventArgs.Empty);

        }

   
    }
}
