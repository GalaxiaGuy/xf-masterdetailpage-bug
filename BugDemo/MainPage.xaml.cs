using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BugDemo
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void NextButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Detail.Navigation.PushAsync(new NextPage(), false);
        }

        async void AnimatedNextButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Detail.Navigation.PushAsync(new NextPage(), true);
        }

        void MenuButton_Clicked(System.Object sender, System.EventArgs e)
        {
            RootPage.IsPresented = !RootPage.IsPresented;
        }
    }
}
