using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            myButton.Clicked += (s, e) =>
            {
                myLabel.Text = myEntry.Text;
            };
        }

        //private void myButton_Clicked(object sender, EventArgs e)
        //{
        //    myLabel.Text = myEntry.Text;
        //}
    }
}
