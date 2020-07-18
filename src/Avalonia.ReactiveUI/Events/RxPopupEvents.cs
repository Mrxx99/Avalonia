using System;
using Avalonia.Controls.Primitives;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxPopupEvents : RxInputElementEvents
    {
        private readonly Popup _popup;

        public RxPopupEvents(Popup popup) : base(popup)
        {
            _popup = popup;
        }

        public IObservable<PopupClosedEventArgs> Closed
            => AvaloniaObservableExtensions.FromEvent<PopupClosedEventArgs>(
                handler => _popup.Closed += handler,
                handler => _popup.Closed -= handler);

        public IObservable<EventArgs> Opened
            => AvaloniaObservableExtensions.FromEvent(
                handler => _popup.Opened += handler,
                handler => _popup.Opened -= handler);
    }
}
