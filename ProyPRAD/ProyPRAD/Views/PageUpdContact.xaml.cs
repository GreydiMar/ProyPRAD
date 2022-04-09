using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyPRAD.Models;
using ProyPRAD.Controllers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using System.IO;

namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageUpdContact : ContentPage
    {
        Plugin.Media.Abstractions.MediaFile photo = null;
        public PageUpdContact()
        {
            InitializeComponent();
        }

      
        private Byte[] traeImagenByteArray()
        {
            if (photo != null)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    Stream stream = photo.GetStream();
                    stream.CopyTo(memory);
                    return memory.ToArray();
                }
            }
            return null;
        }

        private async void btnfoto_Clicked(object sender, EventArgs e)
        {
            photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "FotosApp",
                Name = "test.jpg",
                SaveToAlbum = true
            });

            if (photo != null)
            {
                Foto.Source = ImageSource.FromStream(() =>
                {
                    return photo.GetStream();
                });

            }
        }

        private async void btSalvar_Clicked(object sender, EventArgs e)
        {
            if (photo == null)
                return;

            var contactos = new Contacts()

            {
                Id = Convert.ToInt32(Id.Text),
                Foto = traeImagenByteArray(),
                Nombres = nombres.Text,
                Apellidos = apellidos.Text,
                Telefono = Convert.ToDouble(telefono.Text),
                Edad = Convert.ToDouble(edad.Text),
                Pais = pais.SelectedItem.ToString(),
                Nota = nota.Text,
            };

            await DateBase.AddContacto(contactos);

            if (await DateBase.AddContacto(contactos) > 0)
                await DisplayAlert("Aviso", "Contacto Adicionado", "OK");
            else
                await DisplayAlert("Aviso", "ha ocurrido un error", "OK");
        }


    }
}
