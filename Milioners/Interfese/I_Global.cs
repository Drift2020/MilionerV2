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

        string Ansver { set; get; }
        Button Start { set; get; }
        Button ExitG { set; get; }
        Button FlagS { set ; get;}
        Button ExitS { set; get; }
        Button StopS { set; get; }
        Label QuestTableS { set; get; }
        ListView NumberlistViewS { set; get; }
        Button Ansver_AS { set; get; }
        Button Ansver_BS { set; get; }
        Button Ansver_CS { set; get; }
        Button Ansver_DS { set; get; }
        Button FandFS { set; get; }
        Button HelpCallS { set; get; }
        Button HelpRoomS { set; get; }
        GroupBox HelpVariantS { set; get; }
        void Error(string z, string s);
        PictureBox CallPictureBoxS { set; get; }
        Label CallLabelS { set; get; }

        PictureBox AnsverPictureBoxS { set; get; }
        Label AnsverLabelS { set; get; }
        GroupBox HelpBarS { set; get; }

    }
}
