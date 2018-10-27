using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinefolis.Droid.Resources.Login2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View1 : ContentView
    {
        public View1()
        {
            InitializeComponent();
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
            this.Padding = Device.OnPlatform( // Comando: Separação em plataformas(margens).
                new Thickness(10, 20, 10, 10),
                new Thickness(10),
                new Thickness(10)
                );
#pragma warning restore CS0618 // O tipo ou membro é obsoleto

        }
    }
}