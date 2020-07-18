using System;
using Avalonia.Controls.Primitives;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxScrollBarEvents : RxTemplatedControlEvents
    {
        private readonly ScrollBar _scrollBar;

        public RxScrollBarEvents(ScrollBar scrollBar) : base(scrollBar)
        {
            _scrollBar = scrollBar;
        }

        public IObservable<ScrollEventArgs> Scroll
            => AvaloniaObservableExtensions.FromEvent<ScrollEventArgs>(
                handler => _scrollBar.Scroll += handler,
                handler => _scrollBar.Scroll -= handler);
    }
}