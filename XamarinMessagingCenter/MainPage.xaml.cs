using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMessagingCenter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new TargetPage());
            MessagingCenter.Subscribe<TargetPage, double>(this, Events.SliderValueChanged, OnSliderValueChanged);
        }

        void OnSliderValueChanged(TargetPage source, double newValue)
        {
            label.Text = newValue.ToString();
        }
    }
}
