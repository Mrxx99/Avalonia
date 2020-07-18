using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxSpinnerEvents : RxTemplatedControlEvents, IRxSpinnerRoutedEvents
    {
        private readonly Spinner _spinner;

        public RxSpinnerEvents(Spinner spinner) : base(spinner)
        {
            _spinner = spinner;
        }

        public new IRxSpinnerRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<SpinEventArgs> Spin => Spinner.SpinEvent.ToObservable(_spinner, RoutingStrategy);
    }

    public interface IRxSpinnerRoutedEvents : IRxTemplatedControlRoutedEvents
    {
        IObservable<SpinEventArgs> Spin { get; }
    }

}