﻿using System;

using Windows.UI.Xaml.Controls;

using WTSExceptionTest.ViewModels;

namespace WTSExceptionTest.Views
{
    // TODO WTS: Change the URL for your privacy policy in the Resource File, currently set to https://YourPrivacyUrlGoesHere
    public sealed partial class SettingsPage : Page
    {
        private SettingsViewModel ViewModel => DataContext as SettingsViewModel;

        public SettingsPage()
        {
            InitializeComponent();
        }
    }
}
