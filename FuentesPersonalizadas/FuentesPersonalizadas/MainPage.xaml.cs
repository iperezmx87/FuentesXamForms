using System.ComponentModel;
using Xamarin.Forms;

namespace FuentesPersonalizadas
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // cargando el icono desde codigo

            imgIcono2.Source = new FontImageSource
            {
                FontFamily = (OnPlatform<string>)Application.Current.Resources["MaterialFontFamily"],
                Size = 30,
                Color = Color.Brown,
                Glyph = IconFont.GoogleAllo
            };
        }
    }
}
