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
using DesktopContactsApp.Classes;

namespace DesktopContactsApp.Controls
{
    /// <summary>
    /// ContactControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ContactControl : UserControl
    {
        private Contact contact;

        public Contact Contact 
        {
            get { return contact; }
            set 
            { 
                contact = value;
                nameTextBlock.Text = contact.Name;
                emailTextBlock.Text = contact.Email;
                phoneTextBlock.Text = contact.Phone;
            }
        }
        public ContactControl()
        {
            InitializeComponent();
        }
    }
}
