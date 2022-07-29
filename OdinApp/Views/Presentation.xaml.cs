using OdinApp.Views.IntroTutorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OdinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Presentation : ContentPage
    {
        public Presentation()
        {
            InitializeComponent();
            Animation();
        }
        public async Task Animation()
        {
            imglogo.Opacity = 0;
            await imglogo.FadeTo(1, 3000);
            App.Current.MainPage = new Intro1();
        }
    }
}