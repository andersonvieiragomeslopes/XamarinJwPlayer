using Xamarin.Forms;

namespace JwPlayerXamarin.Controls
{
    public class JwPlayerControlView : View
    {
        public static readonly BindableProperty SourceProperty =
            BindableProperty.Create(nameof(Souce), typeof(string), typeof(JwPlayerControlView), null);

        public string Souce {
            set { SetValue(SourceProperty, value); }
            get { return (string)GetValue(SourceProperty); }
        }

    }
}
