using System;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxAvaloniaObjectEvents
    {
        private readonly AvaloniaObject _avaloniaObject;

        public RxAvaloniaObjectEvents(AvaloniaObject avaloniaObject)
        {
            _avaloniaObject = avaloniaObject;
        }


        public IObservable<AvaloniaPropertyChangedEventArgs> PropertyChanged
            => AvaloniaObservableExtensions.FromEvent<AvaloniaPropertyChangedEventArgs>(
                handler => _avaloniaObject.PropertyChanged += handler,
                handler => _avaloniaObject.PropertyChanged -= handler);
    }
}