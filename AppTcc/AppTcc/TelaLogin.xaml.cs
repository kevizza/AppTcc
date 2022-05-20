using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTcc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaLogin : ContentPage
    {
        public TelaLogin()
        {
            InitializeComponent();
            //Navigation.nag
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(txtemail.Text=="admin" && txtsenha.Text == "123")
            {
                Navigation.PushAsync(new PaginaInicial());
            }   
            else 
            {   
                DisplayAlert("Epa..", "E-Mail ou Senha incorreto!", "Ok");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PaginaRegistro());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EsqueciSenha());
        }
    }
}