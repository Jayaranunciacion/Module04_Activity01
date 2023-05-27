using Module4_Act1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module4_Act1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Open_One(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new One());
        }
        private async void Open_Two(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Two());
        }
    }
}
