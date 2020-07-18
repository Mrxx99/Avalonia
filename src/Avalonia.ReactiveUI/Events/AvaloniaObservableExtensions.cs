using System;
using System.Reactive.Linq;
using Avalonia.Interactivity;

namespace Avalonia.ReactiveUI.Events
{
    public static class AvaloniaObservableExtensions
    {
        public const RoutingStrategies DefaultRoutingStrategy = RoutingStrategies.Direct | RoutingStrategies.Bubble;

        public static IObservable<TEventArgs> FromEvent<TEventArgs>(Action<EventHandler<TEventArgs>> addHandler, Action<EventHandler<TEventArgs>> removeHandler) where TEventArgs : EventArgs
        {
            return Observable.FromEvent((Action<TEventArgs> handler) => (sender, e) => handler(e), addHandler, removeHandler);
        }

        public static IObservable<EventArgs> FromEvent(Action<EventHandler> addHandler, Action<EventHandler> removeHandler)
        {
            return Observable.FromEvent((Action<EventArgs> handler) => (sender, e) => handler(e), addHandler, removeHandler);
        }

        public static IObservable<TEventArgs> ToObservable<TEventArgs>(this RoutedEvent<TEventArgs> routedEvent, IInteractive handlingObject, RoutingStrategies routingStrategy = DefaultRoutingStrategy)
            where TEventArgs : RoutedEventArgs
        {
            return Observable.FromEvent<EventHandler<TEventArgs>, TEventArgs>(
                (Action<TEventArgs> handler) => (sender, e) => handler(e),
                handler => handlingObject.AddHandler(routedEvent, handler, routingStrategy),
                handler => handlingObject.RemoveHandler(routedEvent, handler));
        }

        public static IObservable<RoutedEventArgs> ToObservable(this RoutedEvent routedEvent, IInteractive handlingObject, RoutingStrategies routingStrategy = DefaultRoutingStrategy)
        {
            return Observable.FromEvent<EventHandler<RoutedEventArgs>, RoutedEventArgs>(
                (Action<RoutedEventArgs> handler) => (sender, e) => handler(e),
                handler => handlingObject.AddHandler(routedEvent, handler, routingStrategy),
                handler => handlingObject.RemoveHandler(routedEvent, handler));
        }
    }
}
