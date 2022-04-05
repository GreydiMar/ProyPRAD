using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private async void btn_places_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TBPageContacts());
        }

        private async void btn_contacts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TBPageContacts());
        }

        private void btn_salvar_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Clicked_1(object sender, EventArgs e)
        {

        }

        private void btn_sitios_Clicked(object sender, EventArgs e)
        {

        }
    }
}