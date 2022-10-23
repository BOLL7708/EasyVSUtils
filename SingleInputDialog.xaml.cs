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

namespace BOLL7708
{
    /// <summary>
    /// Interaction logic for SingleInputDialog.xaml
    /// </summary>
    public partial class SingleInputDialog : Window
    {
        public string labelText;
        public string value;
        public SingleInputDialog(Window owner, string value, string labelText)
        {
            Owner = owner;
            this.value = value;
            this.labelText = $"{labelText}:";
            InitializeComponent();
            Title = $"Set {labelText}";
            labelValue.Content = this.labelText;
            textBoxValue.Text = value;
            textBoxValue.Focus();
            textBoxValue.SelectAll();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            value = textBoxValue.Text;
            DialogResult = value.Length > 0;
        }
    }
}