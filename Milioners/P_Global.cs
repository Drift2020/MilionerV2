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

            _view.ShowDialog =  Add_Edit_form.ShowDialog().ToString();
        }
        private void EditQuestion(object sender, EventArgs e)
        {

            Add_Edit Add_Edit_form = new Add_Edit(false);

            P_Edit loginPresenter = new P_Edit(Add_Edit_form);

            _view.ShowDialog =Add_Edit_form.ShowDialog().ToString();       
        }
        private void StartGame(object sender, EventArgs e)
        {

        }
        private void ExitGame(object sender, EventArgs e)
        {

        }
        private void StopGame(object sender, EventArgs e)
        {

        }

        private void UpdateView()
        {

        }
    }
}
