﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
<<<<<<< HEAD
using Windows.UI.ViewManagement;
=======
>>>>>>> origin/master
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
<<<<<<< HEAD
using System.Diagnostics;
=======

>>>>>>> origin/master
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Kakuro
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
<<<<<<< HEAD
            ApplicationView.PreferredLaunchViewSize = new Size(340, 640);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private void MainPage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.WriteLine("hello");
        }
=======
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
        
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(BlankPage2));
        }

        private void howToPlayBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }

        private void creditsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

>>>>>>> origin/master
    }
}
