using System;
using System.ComponentModel;
using System.Reactive.Linq;
using Avalonia.Controls;

namespace Avalonia
{
    public class RxContextMenuEvents : RxMenuBaseEvents
    {
        private readonly ContextMenu _contextMenu;

        public RxContextMenuEvents(ContextMenu contextMenu) : base(contextMenu)
        {
            _contextMenu = contextMenu;
        }

        public IObservable<CancelEventArgs> ContextMenuClosing
            => Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                (Action<CancelEventArgs> handler) => (sender, e) => handler(e),
                handler => _contextMenu.ContextMenuClosing += handler,
                handler => _contextMenu.ContextMenuClosing -= handler);

        public IObservable<CancelEventArgs> ContextMenuOpening
            => Observable.FromEvent<CancelEventHandler, CancelEventArgs>(
                (Action<CancelEventArgs> handler) => (sender, e) => handler(e),
                handler => _contextMenu.ContextMenuOpening += handler,
                handler => _contextMenu.ContextMenuOpening -= handler);
    }
}