using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows;

namespace OpenSilverRiotSlider
{
    internal class RiotSlider : Slider
    {
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Thumb thumb = (Thumb)GetTemplateChild("HorizontalThumb");
            thumb.DragStarted += Thumb_DragStarted;
        }

        private void Thumb_DragStarted(object sender, DragStartedEventArgs e)
        {
            VisualStateManager.GoToState(this, "Pressed", true);
        }
    }
}
