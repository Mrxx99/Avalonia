using System;
using Avalonia.Controls;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxWindowBaseEvents : RxTopLevelEvents
    {
        private readonly WindowBase _windowBase;

        public RxWindowBaseEvents(WindowBase windowBase) : base(windowBase)
        {
            _windowBase = windowBase;
        }

        public IObservable<EventArgs> Activated
            => AvaloniaObservableExtensions.FromEvent(
                handler => _windowBase.Activated += handler,
                handler => _windowBase.Activated -= handler);

        public IObservable<EventArgs> Deactivated
            => AvaloniaObservableExtensions.FromEvent(
                handler => _windowBase.Deactivated += handler,
                handler => _windowBase.Deactivated -= handler);

        public IObservable<PixelPointEventArgs> PositionChanged
            => AvaloniaObservableExtensions.FromEvent<PixelPointEventArgs>(
                handler => _windowBase.PositionChanged += handler,
                handler => _windowBase.PositionChanged -= handler);
    }
}