﻿using System;
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
        public int min=1;
        public int max=2;
        public int value=1;

       
        public Add_Edit()
        {
            InitializeComponent();
        }

        public Add_Edit(bool add)
        {
            InitializeComponent();
            if (add)
            {
                NameQuest.Visible = false;
                numericUpDown1.Visible = false;
                this.Text = "Создание вопрос";
            }
            else
            {
                NameQuest.Visible = true;
                numericUpDown1.Visible = true;
                this.Text = "Изменение вопроса";

                value = Int32.Parse(numericUpDown1.Value.ToString());
                NumderQuest?.Invoke(this, EventArgs.Empty);
                numericUpDown1.Minimum = min;

                numericUpDown1.Maximum = max;


            }
           
        }

        
        public event EventHandler<EventArgs> Quest;
        public event EventHandler<EventArgs> NumderQuest;

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

        public void Acsept_Add()
        {       
            DialogResult = DialogResult.OK;
        }
        public void Dont_Add()
        {
            MessageBox.Show("Ошибка при заполнении поля.", "Добавление вопроса",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Acsept_Edit()
        {
            DialogResult = DialogResult.OK;
        }
        public void Dont_Edit()
        {
            MessageBox.Show("Ошибка при заполнении поля.", "Изменение вопроса",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quest?.Invoke(this, EventArgs.Empty);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            value = Int32.Parse(numericUpDown1.Value.ToString());
           
            NumderQuest?.Invoke(this, EventArgs.Empty);
            numericUpDown1.Maximum = max;
        }
    }
}
