using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxButtonEvents : RxTemplatedControlEvents, IRxButtonRoutedEvents
    {
        private readonly Button _button;

        public RxButtonEvents(Button button) : base(button)
        {
            _button = button;
        }

        public new IRxButtonRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<RoutedEventArgs> Click => Button.ClickEvent.ToObservable(_button, RoutingStrategy);
    }

    public interface IRxButtonRoutedEvents : IRxTemplatedControlRoutedEvents
    {
        IObservable<RoutedEventArgs> Click { get; }
    }
}