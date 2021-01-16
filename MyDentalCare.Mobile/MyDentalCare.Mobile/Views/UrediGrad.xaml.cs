﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDentalCare.Mobile.ViewModels;
using MyDentalCare.Model;
using MyDentalCare.Model.Requests;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyDentalCare.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UrediGrad : ContentPage
    {
        private APIService _grad = new APIService("grad");
        UrediGradViewModel model = new UrediGradViewModel();
        public UrediGrad(Grad grad)
        {
            InitializeComponent();
            BindingContext = model = new UrediGradViewModel() { Grad = grad };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = model;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.Naziv.Text, @"^[a-zA-Z ]+$") && this.Naziv.Text.Length < 4)
            {
                await DisplayAlert("Greška", "Naziv ne može biti manji od 4 karaktera!", "OK");
            }
            else
            {
                try
                {
                    GradUpsertRequest request = new GradUpsertRequest();
                    request.Naziv = this.Naziv.Text;
                    request.PostanskiBroj = this.PostanskiBroj.Text;
                    Drzava drzava = this.DrzavaPicker.SelectedItem as Drzava;
                    request.DrzavaId = drzava.DrzavaId;
                    await _grad.Update<dynamic>(model.Grad.GradId, request);
                    await DisplayAlert("OK", "Uspješno izmjenjeno!", "OK");
                    await Navigation.PushAsync(new PrikazGradova());
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }
        }
    }
}