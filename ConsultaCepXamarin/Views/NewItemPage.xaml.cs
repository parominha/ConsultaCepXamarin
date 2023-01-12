﻿using ConsultaCepXamarin.Models;
using ConsultaCepXamarin.Services;
using ConsultaCepXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsultaCepXamarin.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }

        private void MetodoPesquisaCEP(object sender, EventArgs e)
        {
            PesquisaCEP pesquisaCEP = new PesquisaCEP();

            ViaCEP oViacep = new ViaCEP();
            oViacep = pesquisaCEP.Consulta(entry_cep.Text);

            lbl_logradouro.Text = oViacep.logradouro;
        }
    }
}