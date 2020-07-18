using System;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxToggleButtonEvents : RxButtonEvents, IRxToggleButtonRoutedEvents
    {
        private readonly ToggleButton _toggleButton;

        public RxToggleButtonEvents(ToggleButton toggleButton) : base(toggleButton)
        {
            _toggleButton = toggleButton;
        }

        public new IRxToggleButtonRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<RoutedEventArgs> Checked => ToggleButton.CheckedEvent.ToObservable(_toggleButton, RoutingStrategy);
        public IObservable<RoutedEventArgs> Indeterminate => ToggleButton.IndeterminateEvent.ToObservable(_toggleButton, RoutingStrategy);
        public IObservable<RoutedEventArgs> UnChecked => ToggleButton.UncheckedEvent.ToObservable(_toggleButton, RoutingStrategy);
    }

    public interface IRxToggleButtonRoutedEvents : IRxButtonRoutedEvents
    {
        IObservable<RoutedEventArgs> Checked { get; }
        IObservable<RoutedEventArgs> Indeterminate { get; }
        IObservable<RoutedEventArgs> UnChecked { get; }
    }
}