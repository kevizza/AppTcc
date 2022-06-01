using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTcc.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEntrar : ContentPage
    {
        public PaginaEntrar()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TelaLogin());
        }
    }
}