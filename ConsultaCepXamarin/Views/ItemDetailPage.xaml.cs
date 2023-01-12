using ConsultaCepXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ConsultaCepXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}