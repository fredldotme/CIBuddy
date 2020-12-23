using Xamarin.Forms;

namespace JenkinsBuddy
{
    public partial class JBApp : Application
    {
        public JBApp()
        {
            InitializeComponent();
            MainPage = new JBMainPage();
        }
    }
}
