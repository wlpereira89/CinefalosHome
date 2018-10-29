using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cinefolis.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastrarUsuario : ContentView
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
            this.Padding = Device.OnPlatform( // Comando: Separação em plataformas(margens).
                new Thickness(10, 20, 10, 10),
                new Thickness(10),
                new Thickness(10)
                );

            RegistrarButton.Clicked += RegistrarButton_Clicked;
        }
        //Campos Obrigatorios.
        private void RegistrarButton_Clicked(object sender, EventArgs e)
        {
            bool login = Usuario.cadastrarUsuario(NomeEntry.ToString(), SobrenomeEntry.ToString(), EnderecoEntry.ToString(), "Foto",DetalhesEntry.ToString(), emailEntry.ToString(), SenhaEntry.ToString()); //(string nome, string sobrenome, string endereco, string foto, string detalhes, string login, string senha)

            if(login == true)
            {

            }

        }

    }
}