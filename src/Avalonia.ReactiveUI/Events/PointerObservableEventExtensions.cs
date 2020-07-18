using System;
using System.Reactive.Linq;
using Avalonia.Input;
using Avalonia.VisualTree;

namespace Avalonia.ReactiveUI.Events
{
    public static class PointerObservableEventExtensions
    {
        public static IObservable<PointerPressedEventArgs> WithMouseButton(this IObservable<PointerPressedEventArgs> observable, MouseButton mouseButton, IVisual relativeTo = null)
        {
            return observable.Where(e => e.GetCurrentPoint(relativeTo).Properties.PointerUpdateKind.GetMouseButton() == mouseButton);
        }

        public static IObservable<PointerReleasedEventArgs> WithMouseButton(this IObservable<PointerReleasedEventArgs> observable, MouseButton mouseButton)
        {
            return observable.Where(e => e.InitialPressMouseButton == mouseButton);
        }
    }
}
