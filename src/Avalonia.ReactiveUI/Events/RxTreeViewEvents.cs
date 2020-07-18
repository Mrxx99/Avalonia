using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxTreeViewEvents : RxTemplatedControlEvents, IRxTreeViewRoutedEvents
    {
        private readonly TreeView _treeView;

        public RxTreeViewEvents(TreeView treeView) : base(treeView)
        {
            _treeView = treeView;
        }

        public new IRxTreeViewRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<SelectionChangedEventArgs> SelectionChanged => SelectingItemsControl.SelectionChangedEvent.ToObservable(_treeView, RoutingStrategy);
    }

    public interface IRxTreeViewRoutedEvents : IRxTemplatedControlRoutedEvents
    {
        IObservable<SelectionChangedEventArgs> SelectionChanged { get; }
    }
}