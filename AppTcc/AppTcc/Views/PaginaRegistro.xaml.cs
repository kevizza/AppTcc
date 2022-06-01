using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTcc.Model;
using AppTcc.Helper;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTcc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaRegistro : ContentPage
    {
        public PaginaRegistro()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            {
                Usuario t = new Usuario();
                t.username = txtnomeregistro.Text;
                t.email = txtemailregistro.Text;
                t.senha = txtsenha.Text;
                


                await App.Database.Save(t);

                await Navigation.PushAsync(new TelaLogin());
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogin());
        }
    }
}