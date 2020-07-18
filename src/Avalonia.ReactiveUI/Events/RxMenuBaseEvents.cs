using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxMenuBaseEvents : RxSelectingItemsControlEvents, IRxMenuBaseRoutedEvents
    {
        private MenuBase _menuBase;

        public RxMenuBaseEvents(MenuBase menuBase) : base(menuBase)
        {
            _menuBase = menuBase;
        }

        public new IRxMenuBaseRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<RoutedEventArgs> MenuClosed => MenuBase.MenuClosedEvent.ToObservable(_menuBase, RoutingStrategy);
        public IObservable<RoutedEventArgs> MenuOpened => MenuBase.MenuOpenedEvent.ToObservable(_menuBase, RoutingStrategy);
    }

    public interface IRxMenuBaseRoutedEvents
    {
        IObservable<RoutedEventArgs> MenuClosed { get; }
        IObservable<RoutedEventArgs> MenuOpened { get; }
    }
}