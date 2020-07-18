using System;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxSelectingItemsControlEvents : RxTemplatedControlEvents, IRxSelectingItemsControlRoutedEvents
    {
        private readonly SelectingItemsControl _selectingItemsControl;

        public RxSelectingItemsControlEvents(SelectingItemsControl selectingItemsControl) : base(selectingItemsControl)
        {
            _selectingItemsControl = selectingItemsControl;
        }

        public new IRxSelectingItemsControlRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<RoutedEventArgs> SelectionChanged => SelectingItemsControl.SelectionChangedEvent.ToObservable(_selectingItemsControl, RoutingStrategy);
    }

    public interface IRxSelectingItemsControlRoutedEvents : IRxTemplatedControlRoutedEvents
    {
        IObservable<RoutedEventArgs> SelectionChanged { get; }
    }
}