using System;
using Avalonia.Controls;
using Avalonia.LogicalTree;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxStyledElementEvents : RxAvaloniaObjectEvents
    {
        private readonly StyledElement _styledElement;

        public RxStyledElementEvents(StyledElement styledElement) : base(styledElement)
        {
            _styledElement = styledElement;
        }

        public IObservable<LogicalTreeAttachmentEventArgs> AttachedToLogicalTree
            => AvaloniaObservableExtensions.FromEvent<LogicalTreeAttachmentEventArgs>(
                handler => _styledElement.AttachedToLogicalTree += handler,
                handler => _styledElement.AttachedToLogicalTree -= handler);

        public IObservable<LogicalTreeAttachmentEventArgs> DetachedFromLogicalTree
            => AvaloniaObservableExtensions.FromEvent<LogicalTreeAttachmentEventArgs>(
                handler => _styledElement.DetachedFromLogicalTree += handler,
                handler => _styledElement.DetachedFromLogicalTree -= handler);

        public IObservable<EventArgs> DataContextChanged
            => AvaloniaObservableExtensions.FromEvent(
                handler => _styledElement.DataContextChanged += handler,
                handler => _styledElement.DataContextChanged -= handler);

        public IObservable<EventArgs> Initialized
            => AvaloniaObservableExtensions.FromEvent(
                handler => _styledElement.DataContextChanged += handler,
                handler => _styledElement.DataContextChanged -= handler);

        public IObservable<ResourcesChangedEventArgs> ResourcesChanged
            => AvaloniaObservableExtensions.FromEvent<ResourcesChangedEventArgs>(
                handler => _styledElement.ResourcesChanged += handler,
                handler => _styledElement.ResourcesChanged -= handler);
    }
}