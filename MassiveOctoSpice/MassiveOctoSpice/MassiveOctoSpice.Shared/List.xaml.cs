﻿using MassiveOctoSpice.Common;
using MassiveOctoSpice.Models;
using MassiveOctoSpice.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MassiveOctoSpice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class List : Page
    {
        public List()
        {
            DataContext = new ListOfMapViewModel();
            InitializeComponent();
        }

        private ListOfMapViewModel Context
        {
            get
            {
                return DataContext as ListOfMapViewModel;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Context.Load.Execute(null);
        }
    }
}
