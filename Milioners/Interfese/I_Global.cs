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



        event EventHandler<EventArgs> UpdateViewQuestion;
        event EventHandler<EventArgs> FiftyOnFifty;
        string ShowDialog
        {
            set; get;
        }
       
        bool StartGameQ{ set; get; }
        string Ansver { set; get; }
        bool Win { set; get; }
        bool Lose { set; get; }
        bool AnsverTrue { set; get; }
        bool IsFandF { set; get; }
        string Ansver_AS { set; get; }
        string Ansver_BS { set; get; }
        string Ansver_CS { set; get; }
        string Ansver_DS { set; get; }
        string Question { set; get; }
        int NumberQuestion { set; get; }
        float NowTime { set; get; }
        void Error(string z, string s);
     

    }
}
