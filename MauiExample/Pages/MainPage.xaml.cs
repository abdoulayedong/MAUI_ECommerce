using MauiExample.Models;
using MauiExample.PageModels;

namespace MauiExample.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}