using System;
using Avalonia.Controls;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxTopLevelEvents : RxTemplatedControlEvents
    {
        private readonly TopLevel _topLevel;

        public RxTopLevelEvents(TopLevel topLevel) : base(topLevel)
        {
            _topLevel = topLevel;
        }

        public IObservable<EventArgs> Closed
            => AvaloniaObservableExtensions.FromEvent(
                handler => _topLevel.Closed += handler,
                handler => _topLevel.Closed -= handler);

        public IObservable<EventArgs> Opened
            => AvaloniaObservableExtensions.FromEvent(
                handler => _topLevel.Opened += handler,
                handler => _topLevel.Opened -= handler);
    }
}