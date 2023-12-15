using System.Windows;
using System.Windows.Controls;

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
