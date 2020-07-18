using System;
using System.Reactive.Linq;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxInteractiveEvents : RxLayoutableEvents, IRxInteractiveRoutedEvents, IRxWithRoutedEvents
    {
        private readonly Interactive _interactive;
        public RoutingStrategies RoutingStrategy { get; protected set; } = RoutingStrategies.Direct | RoutingStrategies.Bubble;

        public RxInteractiveEvents(Interactive interactive) : base(interactive)
        {
            _interactive = interactive;
        }

        public IRxInteractiveRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        #region DragDrop

        public IObservable<DragEventArgs> DragEnter => DragDrop.DragEnterEvent.ToObservable(_interactive, RoutingStrategy);

        public IObservable<RoutedEventArgs> DragLeave => DragDrop.DragLeaveEvent.ToObservable(_interactive, RoutingStrategy);

        public IObservable<DragEventArgs> DragOver => DragDrop.DragOverEvent.ToObservable(_interactive, RoutingStrategy);

        public IObservable<DragEventArgs> Drop => DragDrop.DropEvent.ToObservable(_interactive, RoutingStrategy);

        #endregion
    }

    public interface IRxInteractiveRoutedEvents
    {
        IObservable<RoutedEventArgs> DragLeave { get; }
        IObservable<DragEventArgs> DragOver { get; }
        IObservable<DragEventArgs> Drop { get; }
    }
}