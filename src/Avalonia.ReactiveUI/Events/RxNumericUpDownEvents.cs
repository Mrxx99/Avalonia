using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxNumericUpDownEvents : RxTemplatedControlEvents, IRxNumericUpDownRoutedEvents
    {
        private readonly NumericUpDown _numericUpDown;

        public RxNumericUpDownEvents(NumericUpDown numericUpDown) : base(numericUpDown)
        {
            _numericUpDown = numericUpDown;
        }

        public new IRxNumericUpDownRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<SpinEventArgs> Spinned
            => AvaloniaObservableExtensions.FromEvent<SpinEventArgs>(
                handler => _numericUpDown.Spinned += handler,
                handler => _numericUpDown.Spinned -= handler);

        public IObservable<NumericUpDownValueChangedEventArgs> ValueChanged => NumericUpDown.ValueChangedEvent.ToObservable(_numericUpDown, RoutingStrategy);
    }

    public interface IRxNumericUpDownRoutedEvents : IRxTemplatedControlRoutedEvents
    {
        IObservable<NumericUpDownValueChangedEventArgs> ValueChanged { get; }
    }
}