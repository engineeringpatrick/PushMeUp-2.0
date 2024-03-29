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

namespace PushMeUp_2._0_by_Deniso
{
    /// <summary>
    /// Interaction logic for BackupCard.xaml
    /// </summary>
    public partial class BackupCard : UserControl
    {
        public Uri ImageSource
        {
            get { return (Uri)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(Uri), typeof(BackupCard));


        public string BackupName
        {
            get { return (string)GetValue(BackupNameProperty); }
            set { SetValue(BackupNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackupName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackupNameProperty =
            DependencyProperty.Register("BackupName", typeof(string), typeof(BackupCard));



        public BackupCard()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            BackupControl parent = Helper.GetAncestorOfType<BackupControl>(this);
            if(parent != null)
            {
                parent.BackupCard_Click(sender, e);
            }
        }
    }
}
