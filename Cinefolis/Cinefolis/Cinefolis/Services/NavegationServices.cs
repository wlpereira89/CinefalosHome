using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cinefolis.Services
{
    class NavegationServices : INavegation
    {

        Task INavegation.NavigateToLogin => App.Current.MainPage.Navigation.PushAsync(new Views.View1()); //App.Current.MainPage.Navigation.PushAsync(new Views.View1());
                                                                                                          //App.Current.MainPage.Navigation.PushAsync(new Views.View1());
        Task INavegation.NavigateToRegister => App.Current.MainPage.Navigation.PushAsync(new Views.View1());

        public Task NavigateToTimeLine()
        {
            throw new NotImplementedException();
        }
    }
 }

