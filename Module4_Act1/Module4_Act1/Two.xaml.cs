using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module4_Act1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Two : ContentPage
    {
        public Two()
        {
            InitializeComponent();
        }
        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var data = e.Data.Properties["Text"].ToString();
            var frame = (sender as Element)?.Parent as Frame;
            frame.Content = new Label
            {
                Text = data
            };
        }
        private void DragGestureRecognizer_Drag(object sender, DragStartingEventArgs e)
        {
            var label = (sender as Element)?.Parent as Label;
            e.Data.Properties.Add("Text", label.Text);
        }
    }
}