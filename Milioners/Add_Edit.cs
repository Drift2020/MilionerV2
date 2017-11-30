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
    public partial class Add_Edit : Form, I_Add_Edit
    {
        public Add_Edit()
        {
            InitializeComponent();
        }

        public Add_Edit(bool add)
        {
            if(add)
            {

            }
            else
            {

            }
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Quest;

        public string Questio {
            set { textBoxQuestion.Text = value; }
            get { return textBoxQuestion.Text.Trim(); }
        }
        public string Answer_1
        {
            set { textBoxAnswer_1.Text = value; }
            get { return textBoxAnswer_1.Text.Trim(); }
        }
        public string Answer_2
        {
            set { textBoxAnswer_2.Text = value; }
            get { return textBoxAnswer_2.Text.Trim(); }
        }
        public string Answer_3
        {
            set { textBoxAnswer_3.Text = value; }
            get { return textBoxAnswer_3.Text.Trim(); }
        }
        public string Answer_4
        {
            set { textBoxAnswer_4.Text = value; }
            get { return textBoxAnswer_4.Text.Trim(); }
        }

        public void AcseptAdd()
        {

            Сontainer c = new Сontainer();

            c.SetSerializer(new XMLSerializer());
            c.Load();
            c.Add(new Question(Questio, Answer_1, Answer_2, Answer_3, Answer_4));
            c.Save();

            DialogResult = DialogResult.OK;
        }

        public void DontAdd()
        {
            MessageBox.Show("Ошибка при заполнении поля.", "Добавление вопроса",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

 



        private void button1_Click(object sender, EventArgs e)
        {
            Quest?.Invoke(this, EventArgs.Empty);
        }

        
    }
}
