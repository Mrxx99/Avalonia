using System;
using Avalonia.Layout;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxLayoutableEvents
    {
        private readonly Layoutable _layoutable;

        public RxLayoutableEvents(Layoutable layoutable)
        {
            _layoutable = layoutable;
        }

        public IObservable<EventArgs> LayoutUpdated
            => AvaloniaObservableExtensions.FromEvent(
                    handler => _layoutable.LayoutUpdated += handler,
                    handler => _layoutable.LayoutUpdated -= handler);
    }
}