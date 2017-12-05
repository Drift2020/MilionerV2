using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            set;get;
        }

    }
}
