﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarcassinLight
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationService nav = Frame.NavigationService;
            nav.Navigate(new Pupitre());
        }

        private void Pupitre_click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = Frame.NavigationService;
            nav.Navigate(new Pupitre());
        }



    }
}
