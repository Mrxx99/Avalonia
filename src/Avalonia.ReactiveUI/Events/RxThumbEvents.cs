using System;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxThumbEvents : RxTemplatedControlEvents, IRxThumbRoutedEvents
    {
        private readonly Thumb _thumb;

        public RxThumbEvents(Thumb thumb) : base(thumb)
        {
            _thumb = thumb;
        }

        public new IRxThumbRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<VectorEventArgs> DragCompleted => Thumb.DragCompletedEvent.ToObservable(_thumb, RoutingStrategy);

        public IObservable<VectorEventArgs> DragDelta => Thumb.DragDeltaEvent.ToObservable(_thumb, RoutingStrategy);

        public IObservable<VectorEventArgs> DragStarted => Thumb.DragStartedEvent.ToObservable(_thumb, RoutingStrategy);
    }

    public interface IRxThumbRoutedEvents : IRxTemplatedControlRoutedEvents
    {
        IObservable<VectorEventArgs> DragCompleted { get; }
        IObservable<VectorEventArgs> DragDelta { get; }
        IObservable<VectorEventArgs> DragStarted { get; }
    }
}