using CIBuddy;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JenkinsBuddy
{
    public partial class JBMainPage : ContentPage
    {
        public IList<Hosts> SavedHosts { get; private set; }
                
        public JBMainPage()
        {
            InitializeComponent();
            
            SavedHosts = new List<Hosts>();
            SavedHosts.Add(new Hosts{ Name = "Test1" });
            
            BindingContext = this;
        }
        
        void OnAddClicked(object sender, EventArgs e) {
            //await Navigation.PushAsync(new JBMainPage());            
        }
    }
}
