using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinefolis.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class View1 : ContentView
	{
		public View1 ()
		{
            InitializeComponent();
            this.Padding = Device.OnPlatform( // Comando: Separação em plataformas(margens).
                new Thickness(10, 20, 10, 10),
                new Thickness(10),
                new Thickness(10)
                );

            LoginButton.Clicked += LoginButton_Clicked;
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailEntry.ToString()))
            {
                await DisplayAlert("Erro", "digite um email", "Aceitar");
                emailEntry.Focus();
            }
            if (string.IsNullOrEmpty(SenhaEntry.ToString()))
            {
                await DisplayAlert("Erro", "digite uma Senha", "Aceitar");
                emailEntry.Focus();
            }

            this.Login();
            //throw new NotImplementedException();
        }

        private void Login()
        {
            throw new NotImplementedException();
        }

        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Page(View1 v)
        {
            throw new NotImplementedException();
        }
    }
}