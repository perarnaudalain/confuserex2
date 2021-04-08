using configuration;
using Xamarin.Forms;

namespace confuserex2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var password = Config.PASSWORD;
        }
    }
}
