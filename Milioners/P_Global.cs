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
        private  Сontainer c1 = new Сontainer();
        public P_Global(I_Global view)
        {

            c.SetSerializer(new XMLSerializer());
            c.Load();

            _view = view;
            // Презентер подписывается на уведомления о событиях Представления
            _view.DellQuestion += new EventHandler<EventArgs>(DellQuestion);
            _view.NewQuestion += new EventHandler<EventArgs>(NewQuestion);
            _view.EditQuestion += new EventHandler<EventArgs>(EditQuestion);
            _view.StartGame += new EventHandler<EventArgs>(StartGame);
            _view.ExitGame += new EventHandler<EventArgs>(ExitGame);
            _view.StopGame += new EventHandler<EventArgs>(StopGame);
            _view.AnsverClick += new EventHandler<EventArgs>(AnsverClic);
            _view.FlagS.Visible = false ;
            _view.ExitS.Visible = false;
            _view.StopS.Visible = false;
            _view.QuestTableS.Visible = false;
            _view.NumberlistViewS.Visible = false;


            _view.Ansver_AS.Visible = false;
            _view.Ansver_BS.Visible = false;
            _view.Ansver_CS.Visible = false;
            _view.Ansver_DS.Visible = false;
            _view.FandFS.Visible = false;
            _view.HelpCallS.Visible = false;
            _view.HelpRoomS.Visible = false;
            _view.HelpVariantS.Visible = false;
            _view.CallPictureBoxS.Visible = false;
            _view.CallLabelS.Visible = false;
            _view.AnsverPictureBoxS.Visible = false;
            _view.AnsverLabelS.Visible = false;
            _view.HelpBarS.Visible = false;

            UpdateView();
        }

        private void DellQuestion(object sender, EventArgs e)
        {

            Dell Dell_form = new Dell();

            P_Dell loginPresenter = new P_Dell(Dell_form);

            _view.ShowDialog = Dell_form.ShowDialog().ToString();

        }
        private void NewQuestion(object sender, EventArgs e)
        {


            Add_Edit Add_Edit_form = new Add_Edit(true);

            P_Add loginPresenter = new P_Add(Add_Edit_form, c);

            _view.ShowDialog = Add_Edit_form.ShowDialog().ToString();
        }
        private void EditQuestion(object sender, EventArgs e)
        {

            Add_Edit Add_Edit_form = new Add_Edit(false);

            P_Edit loginPresenter = new P_Edit(Add_Edit_form,c);

            _view.ShowDialog =Add_Edit_form.ShowDialog().ToString();       
        }
        private void StartGame(object sender, EventArgs e)
        {
            c.Load();
            if (c.Count()<15)
            {
                _view.Error("Ошибка", "У вас меньше 15 вопросов, добавьте вопросы.");
                return;
            }
            _view.Start.Visible = false;
            _view.ExitG.Visible = false;


            _view.FlagS.Visible = true;
            _view.ExitS.Visible = true;
            _view.StopS.Visible = true;
            _view.QuestTableS.Visible = true;
            _view.NumberlistViewS.Visible = true;
            _view.Ansver_AS.Visible = true;
            _view.Ansver_BS.Visible = true;
            _view.Ansver_CS.Visible = true;
            _view.Ansver_DS.Visible = true;
            _view.FandFS.Visible = true;
            _view.HelpCallS.Visible = true;
            _view.HelpRoomS.Visible = true;
            _view.HelpVariantS.Visible = true;

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
                        while(temp==k)
                        k = j.Next(0, c.Count());
                    }
                }
                c1.Add(c.Element(k));
               
            }
            _view.Ansver_AS.Text = c1.Element(0).Answer_1;
            _view.Ansver_BS.Text = c1.Element(0).Answer_2;
            _view.Ansver_CS.Text = c1.Element(0).Answer_3;
            _view.Ansver_DS.Text = c1.Element(0).Answer_4;
            _view.AnsverLabelS.Text = c1.Element(0).Questio;
           

            _view.CallPictureBoxS.Visible = false;
            _view.CallLabelS.Visible = false;
            _view.AnsverPictureBoxS.Visible = false;
            _view.AnsverLabelS.Visible = false;
            _view.HelpBarS.Visible = false;
        }
        private void AnsverClic(object sender, EventArgs e)
        {
            for (int i = 0; i < _view.NumberlistViewS.SelectedIndices.Count; i++)
            {

                // ListView1.Items[i].SubItems - коллекция столбцов
                for (int j = 0; j < _view.NumberlistViewS.Items[i].SubItems.Count; j++)
                {
                    // индекс выделенного элемента списка
                    int selected_index = _view.NumberlistViewS.SelectedIndices[i];
                    // получим значение каждого столбца выделенного элемента списка
                    if (_view.Ansver == c1.Element(selected_index).Answer_1)
                    {
                      
           
                        _view.NumberlistViewS.Items[--selected_index].BackColor = System.Drawing.Color.Yellow;
                    }
                }
            }
          
        }
        private void ExitGame(object sender, EventArgs e)
        {
            c.Save();
            _view.Exitf();
        }
        private void StopGame(object sender, EventArgs e)
        {

        }

        private void UpdateView()
        {

        }
    }
}
