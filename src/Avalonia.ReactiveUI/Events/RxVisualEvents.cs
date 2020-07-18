using System;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxVisualEvents : RxStyledElementEvents
    {
        private readonly Visual _visual;

        public RxVisualEvents(Visual visual) : base(visual)
        {
            _visual = visual;
        }

        public IObservable<VisualTreeAttachmentEventArgs> AttachedToVisualTree
            => AvaloniaObservableExtensions.FromEvent<VisualTreeAttachmentEventArgs>(
                    handler => _visual.AttachedToVisualTree += handler,
                    handler => _visual.AttachedToVisualTree -= handler);

        public IObservable<VisualTreeAttachmentEventArgs> DetachedFromVisualTree
            => AvaloniaObservableExtensions.FromEvent<VisualTreeAttachmentEventArgs>(
                    handler => _visual.DetachedFromVisualTree += handler,
                    handler => _visual.DetachedFromVisualTree -= handler);
    }
}