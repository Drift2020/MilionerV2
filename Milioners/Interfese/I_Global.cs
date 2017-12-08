using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milioners
{
    public interface I_Global
    {
        event EventHandler<EventArgs> StartGame;
        event EventHandler<EventArgs> ExitGame;
        event EventHandler<EventArgs> StopGame;
        event EventHandler<EventArgs> AnsverClick;
        event EventHandler<EventArgs> NewQuestion;
        event EventHandler<EventArgs> EditQuestion;
        event EventHandler<EventArgs> DellQuestion;

        string ShowDialog
        {
            set; get;
        }
        void Exitf();
        bool StartGameQ{ set; get; }
        string Ansver { set; get; }
        bool Win { set; get; }
        bool Lose { set; get; }
        string Ansver_AS { set; get; }
        string Ansver_BS { set; get; }
        string Ansver_CS { set; get; }
        string Ansver_DS { set; get; }
        string Question { set; get; }
        int NumberQuestion { set; get; }
        void Error(string z, string s);
     

    }
}
