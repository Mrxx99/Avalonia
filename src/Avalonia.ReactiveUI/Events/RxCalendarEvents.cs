using System;
using Avalonia.Controls;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxCalendarEvents
    {
        private Calendar _calendar;

        public RxCalendarEvents(Calendar calendar)
        {
            _calendar = calendar;
        }

        public IObservable<CalendarDateChangedEventArgs> DisplayDateChanged
            => AvaloniaObservableExtensions.FromEvent<CalendarDateChangedEventArgs>(
                handler => _calendar.DisplayDateChanged += handler,
                handler => _calendar.DisplayDateChanged -= handler);

        public IObservable<CalendarModeChangedEventArgs> DisplayModeChanged
            => AvaloniaObservableExtensions.FromEvent<CalendarModeChangedEventArgs>(
                handler => _calendar.DisplayModeChanged += handler,
                handler => _calendar.DisplayModeChanged -= handler);

        public IObservable<SelectionChangedEventArgs> SelectedDatesChanged
            => AvaloniaObservableExtensions.FromEvent<SelectionChangedEventArgs>(
                handler => _calendar.SelectedDatesChanged += handler,
                handler => _calendar.SelectedDatesChanged -= handler);
    }
}