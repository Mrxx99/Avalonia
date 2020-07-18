using System;
using System.Reactive.Linq;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{

    public class RxInputElementEvents : RxInteractiveEvents, IRxInputElementRoutedEvents
    {
        private readonly InputElement _inputElement;

        public RxInputElementEvents(InputElement inputElement) : base(inputElement)
        {
            _inputElement = inputElement;
        }

        public new IRxInputElementRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<RoutedEventArgs> DoubleTapped => InputElement.DoubleTappedEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<GotFocusEventArgs> GotFocus => InputElement.GotFocusEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<RoutedEventArgs> LostFocus => InputElement.LostFocusEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<KeyEventArgs> KeyDown => InputElement.KeyDownEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<KeyEventArgs> KeyUp => InputElement.KeyUpEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<PointerCaptureLostEventArgs> PointerCaptureLost => InputElement.PointerCaptureLostEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<PointerEventArgs> PointerEnter => InputElement.PointerEnterEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<PointerEventArgs> PointerLeave => InputElement.PointerLeaveEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<PointerEventArgs> PointerMoved => InputElement.PointerMovedEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<PointerPressedEventArgs> PointerPressed => InputElement.PointerPressedEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<PointerReleasedEventArgs> PointerReleased => InputElement.PointerReleasedEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<PointerWheelEventArgs> PointerWheelChanged => InputElement.PointerWheelChangedEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<RoutedEventArgs> Tapped => InputElement.TappedEvent.ToObservable(_inputElement, RoutingStrategy);

        public IObservable<TextInputEventArgs> TextInput => InputElement.TextInputEvent.ToObservable(_inputElement, RoutingStrategy);
    }

    public interface IRxInputElementRoutedEvents : IRxInteractiveRoutedEvents
    {
        IObservable<RoutedEventArgs> DoubleTapped { get; }
        IObservable<GotFocusEventArgs> GotFocus { get; }
        IObservable<KeyEventArgs> KeyDown { get; }
        IObservable<KeyEventArgs> KeyUp { get; }
        IObservable<RoutedEventArgs> LostFocus { get; }
        IObservable<PointerCaptureLostEventArgs> PointerCaptureLost { get; }
        IObservable<PointerEventArgs> PointerEnter { get; }
        IObservable<PointerEventArgs> PointerLeave { get; }
        IObservable<PointerEventArgs> PointerMoved { get; }
        IObservable<PointerPressedEventArgs> PointerPressed { get; }
        IObservable<PointerReleasedEventArgs> PointerReleased { get; }
        IObservable<PointerWheelEventArgs> PointerWheelChanged { get; }
        IObservable<RoutedEventArgs> Tapped { get; }
        IObservable<TextInputEventArgs> TextInput { get; }
    }
}
