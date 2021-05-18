using System.ComponentModel;
using Xamarin.Forms;
using xamarinApp.ViewModels;

namespace xamarinApp.Views
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