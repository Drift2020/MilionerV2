using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Milioners
{
    class P_Global
    {
        private readonly I_Global _view;
        private readonly Сontainer c = new Сontainer();
        private Сontainer c1 = new Сontainer();
        private int numberQuestion = 0;
        public P_Global(I_Global view)
        {

            c.SetSerializer(new XMLSerializer());
            c.Load();

            _view = view;
            // Презентер подписывается на уведомления о событиях Представления
         
            _view.StartGame += new EventHandler<EventArgs>(StartGame);
            _view.ExitGame += new EventHandler<EventArgs>(ExitGame);
            _view.StopGame += new EventHandler<EventArgs>(StopGame);
            _view.AnsverClick += new EventHandler<EventArgs>(AnsverClic);
            _view.UpdateViewQuestion += new EventHandler<EventArgs>(UpdateViewQuestion);
            _view.FiftyOnFifty += new EventHandler<EventArgs>(FiftyOnFifty);
            // UpdateView();
        }
        private void RandomAnsver()
        {
            
            Random j = new Random();
            int rand = j.Next(0, 3);
            int[,] list_rand = new int[4, 4] { { 3, 2,0,1 }, { 1,3,0,2 }, { 2,0,1,3 },{2,1,3,0 } };

            _view.Ansver_AS = SetAnsver(_view.Ansver_AS, list_rand[rand,0]);
            _view.Ansver_BS = SetAnsver(_view.Ansver_BS, list_rand[rand,1]);
            _view.Ansver_CS = SetAnsver(_view.Ansver_CS, list_rand[rand,2]);
            _view.Ansver_DS = SetAnsver(_view.Ansver_DS, list_rand[rand,3]);       
        }
        private string SetAnsver(string vs, int n)
       {
            switch(n){
                case 0:
                    vs = c1.Element(numberQuestion).Answer_1;
                    break;
                case 1:
                    vs = c1.Element(numberQuestion).Answer_2;
                    break;
                case 2:
                    vs = c1.Element(numberQuestion).Answer_3;
                    break;
                case 3:
                    vs = c1.Element(numberQuestion).Answer_4;
                    break;
            }
            return vs;
       }
        private void UpdateViewQuestion(object sender, EventArgs e)
        {
            
            UpdateView();
            
        }
        private void StartGame(object sender, EventArgs e)
        {
            try
            {
                c.Load();
                if (c.Count() < 15)
                {
                    _view.StartGameQ = false;
                    _view.Error("Ошибка", "У вас меньше 15 вопросов, добавьте вопросы.");
                    return;
                }
                _view.StartGameQ = true;

                c1 = new Сontainer();
                Random j = new Random();
                int k = j.Next(0, c.Count());
                for (int i = 0; i < 15; i++)
                {

                    for (int i1 = 0; i1 < c1.Count(); i1++)
                    {
                        if (c1.Element(i1).Questio == c.Element(k).Questio)
                        {
                            i1 = -1;
                            int temp = k;
                            while (temp == k)
                                k = j.Next(0, c.Count());
                        }
                    }
                    c1.Add(c.Element(k));

                }
                RandomAnsver();
               
                _view.Question = c1.Element(numberQuestion).Questio;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "ошибка", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                c.Save();
            }


        }
        private void AnsverClic(object sender, EventArgs e)
        {
            try
            {
                if (c1.Element(numberQuestion).Answer_1 == _view.Ansver)
                {
                    if (numberQuestion == 14)
                    {
                        _view.Win = true;
                    }
                    else
                    {
                        _view.AnsverTrue = true;
                        ++numberQuestion;
                        --_view.NumberQuestion;
                        
                    }
                }
                else
                {
                    _view.Lose = true;
                }
            }
            catch (Exception ex)
            {
                c.Save();
            }
        }
        private void ExitGame(object sender, EventArgs e)
        {
            c.Save();

        }
        private void StopGame(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiftyOnFifty(object sender, EventArgs e)
        {
            bool ferst = false ,second  = false;
            Random r = new Random();
            int number=r.Next(0, 3);

            while(ferst||second)
            {
                switch (number)
                {
                    case 0:

                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                }

                c1.Element(numberQuestion).Answer_1
            }
        }
        private void UpdateView()
        {
            try
            {
                RandomAnsver();
                _view.Question = c1.Element(numberQuestion).Questio;
            }
            catch (Exception ex)
            {
                c.Save();
            }
        }
    }
}
