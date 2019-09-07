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
using System.Windows.Shapes;

namespace ScriptPlayer.Dialogs
{
    /// <summary>
    /// Interaction logic for SectionDialog.xaml
    /// </summary>
    public partial class SectionDialog : Window
    {
        public static readonly DependencyProperty TimeFromProperty = DependencyProperty.Register(
            "TimeFrom", typeof(TimeSpan), typeof(SectionDialog), new PropertyMetadata(default(TimeSpan)));

        public TimeSpan TimeFrom
        {
            get { return (TimeSpan) GetValue(TimeFromProperty); }
            set { SetValue(TimeFromProperty, value); }
        }

        public static readonly DependencyProperty TimeToProperty = DependencyProperty.Register(
            "TimeTo", typeof(TimeSpan), typeof(SectionDialog), new PropertyMetadata(default(TimeSpan)));

        public TimeSpan TimeTo
        {
            get { return (TimeSpan) GetValue(TimeToProperty); }
            set { SetValue(TimeToProperty, value); }
        }

        public SectionDialog()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Button) sender).Focus();

            if (Validation.GetHasError(this))
            {
                MessageBox.Show("Check your input - something is wrong", "Input Error", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            DialogResult = true;
        }
    }
}
