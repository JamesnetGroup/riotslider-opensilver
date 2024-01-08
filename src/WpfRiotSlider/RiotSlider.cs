using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfRiotSlider
{
    public class RiotSlider : Slider
    {
        static RiotSlider()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RiotSlider), new FrameworkPropertyMetadata(typeof(RiotSlider)));
        }
    }
}
