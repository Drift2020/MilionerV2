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


            // UpdateView();
        }
        private void RandomAnsver()
        {
            
            Random j = new Random();
            List<int> list_rand = new List<int>();


            for (int i = 0; i < 4; i++)
            {
                list_rand.Add(j.Next(0, 1));       
            }
            for (int i = 1; i < list_rand.Count(); i++)
            {
                for (int i1 = 0; i1 < list_rand.Count(); i1++)
                {
                    if (list_rand[i] == list_rand[i1] && i != i1)
                    {
                        i1 = -1;
                        int temp = list_rand[i];
                        while (temp == list_rand[i])
                            list_rand[i] = j.Next(0, 3);
                    }
                }
            }


            _view.Ansver_AS = SetAnsver(_view.Ansver_AS, list_rand[0]);
            _view.Ansver_BS = SetAnsver(_view.Ansver_BS, list_rand[1]);
            _view.Ansver_CS = SetAnsver(_view.Ansver_CS, list_rand[2]);
            _view.Ansver_DS = SetAnsver(_view.Ansver_DS, list_rand[3]);
            //_view.Ansver_AS = c1.Element(numberQuestion).Answer_1;

            //_view.Ansver_BS = c1.Element(numberQuestion).Answer_2;

            //_view.Ansver_CS = c1.Element(numberQuestion).Answer_3;

            //_view.Ansver_DS = c1.Element(numberQuestion).Answer_4;

        }
       private string SetAnsver(string vs, int n)
       {
            switch(n){
                case 1:
                    vs = c1.Element(numberQuestion).Answer_1;
                    break;
                case 2:
                    vs = c1.Element(numberQuestion).Answer_2;
                    break;
                case 3:
                    vs = c1.Element(numberQuestion).Answer_3;
                    break;
                case 4:
                    vs = c1.Element(numberQuestion).Answer_4;
                    break;
            }
            return vs;
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
                            i1 = 0;
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

                    }
                    else
                    {
                        ++numberQuestion;
                        _view.SetColorNewElement(14 - numberQuestion);
                        UpdateView();
                    }
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
