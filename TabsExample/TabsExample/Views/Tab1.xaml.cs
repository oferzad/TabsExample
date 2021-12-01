﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabsExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tab1 : ContentPage
    {
        public Tab1()
        {
            InitializeComponent();
        }

        private void btnNavigation_Clicked(object sender, EventArgs e)
        {
            Page p = new NavigationItem();
            p.Title = "Navigation Item 1";
            this.Navigation.PushAsync(p);
        }
    }
}