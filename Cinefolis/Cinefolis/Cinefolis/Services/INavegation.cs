using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinefolis.Services
{
    interface INavegation
    {
        /*
        Task NavigateToLogin    (string viewName, Object param);
        Task NavigateToRegister (string viewName, Object param);
        */

        Task NavigateToLogin { get; }

        Task NavigateToRegister { get; }

        Task NavigateToTimeLine();
    }
}
