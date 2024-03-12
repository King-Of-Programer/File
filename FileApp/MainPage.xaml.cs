using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FileApp
{
    public partial class MainPage : ContentPage
    {
        int _loginCount = 0;
        public MainPage()
        {
            InitializeComponent();
            object log = null;
            App.Current.Properties.TryGetValue("loginCount", out log);
            if (log != null)
            {
                _loginCount = (int)log;
            }
            loginCountLabel.Text = $"Количество входов: {_loginCount}";
            _loginCount++;
            App.Current.Properties["loginCount"] = _loginCount;
        }
    }
}
