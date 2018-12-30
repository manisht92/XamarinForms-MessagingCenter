using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinMessagingCenter
{
    public partial class TargetPage : ContentPage
    {
        public TargetPage()
        {
            InitializeComponent();
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            MessagingCenter.Send(this, "SliderValueChanged", e.NewValue);
        }
    }
}
