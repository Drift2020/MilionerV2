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

        event EventHandler<EventArgs> NewQuestion;
        event EventHandler<EventArgs> EditQuestion;
        event EventHandler<EventArgs> DellQuestion;

        string ShowDialog
        {
            set; get;
        }
        void Exitf();



        Button FlagS { set ; get;}
        Button ExitS { set; get; }
        Button StopS { set; get; }
        Label QuestTableS { set; get; }
        ListView NumberlistViewS { set; get; }
        Button Ansver_AS { set; get; }
        bool Ansver_BS { set; get; }
        bool Ansver_CS { set; get; }
        bool Ansver_DS { set; get; }
        bool FandFS { set; get; }
        bool HelpCallS { set; get; }
        bool HelpRoomS { set; get; }
        bool HelpVariantS { set; get; }

        bool CallPictureBoxS { set; get; }
        bool CallLabelS { set; get; }

        bool AnsverPictureBoxS { set; get; }
        bool AnsverLabelS { set; get; }
        bool HelpBarS { set; get; }

    }
}
