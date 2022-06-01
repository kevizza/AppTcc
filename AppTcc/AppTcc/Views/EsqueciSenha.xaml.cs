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
    public partial class EsqueciSenha : ContentPage
    {
        public EsqueciSenha()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}