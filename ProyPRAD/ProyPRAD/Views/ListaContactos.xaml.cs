﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyPRAD.Controllers;
using ProyPRAD.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyPRAD.Models;


namespace ProyPRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaContactos : ContentPage
    {
        public ListaContactos()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listacontactos.ItemsSource = await DateBase.ObtenerListaContactos();
        }

        private async void btnActualizar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageUpdContact());
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageDelContact());
        }
    }
}