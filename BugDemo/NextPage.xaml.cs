using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BugDemo
{
    public partial class NextPage : ContentPage
    {
        public NextPage()
        {
            InitializeComponent();
        }

        async void BackButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync(false);
        }

        async void AnimatedBackButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync(true);
        }
    }
}
