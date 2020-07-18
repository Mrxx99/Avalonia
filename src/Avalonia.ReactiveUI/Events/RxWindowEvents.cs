using System;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxWindowEvents
    {
        private readonly Window _window;

        public RxWindowEvents(Window window)
        {
            _window = window;
        }

        public IObservable<CancelEventArgs> Closing
            => AvaloniaObservableExtensions.FromEvent<CancelEventArgs>(
                handler => _window.Closing += handler,
                handler => _window.Closing -= handler);
    }
}