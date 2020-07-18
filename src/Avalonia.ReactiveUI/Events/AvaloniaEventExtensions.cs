using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Layout;

namespace Avalonia
{
    public static class AvaloniaEventExtensions
    {
        // base types
        public static RxAvaloniaObjectEvents Events(this AvaloniaObject avaloniaObject) => new RxAvaloniaObjectEvents(avaloniaObject);
        public static RxStyledElementEvents Events(this StyledElement styledElement) => new RxStyledElementEvents(styledElement);
        public static RxVisualEvents Events(this Visual visual) => new RxVisualEvents(visual);
        public static RxLayoutableEvents Events(this Layoutable layoutable) => new RxLayoutableEvents(layoutable);
        public static RxInteractiveEvents Events(this Interactive interactive) => new RxInteractiveEvents(interactive);
        public static RxInputElementEvents Events(this InputElement inputElement) => new RxInputElementEvents(inputElement);
        public static RxTemplatedControlEvents Events(this TemplatedControl templatedControl) => new RxTemplatedControlEvents(templatedControl);
        public static RxMenuBaseEvents Events(this MenuBase menuBase) => new RxMenuBaseEvents(menuBase);

        // controls
        public static RxButtonEvents Events(this Button button) => new RxButtonEvents(button);
        public static RxToggleButtonEvents Events(this ToggleButton toggleButton) => new RxToggleButtonEvents(toggleButton);
        public static RxSelectingItemsControlEvents Events(this SelectingItemsControl selectingItemsControl) => new RxSelectingItemsControlEvents(selectingItemsControl);
        public static RxContextMenuEvents Events(this ContextMenu contextMenu) => new RxContextMenuEvents(contextMenu);
        public static RxPopupEvents Events(this Popup popup) => new RxPopupEvents(popup);
        public static RxCalendarEvents Events(this Calendar calendar) => new RxCalendarEvents(calendar);
        public static RxScrollBarEvents Events(this ScrollBar scrollBar) => new RxScrollBarEvents(scrollBar);
        public static RxNumericUpDownEvents Events(this NumericUpDown numericUpDown) => new RxNumericUpDownEvents(numericUpDown);
        public static RxTreeViewEvents Events(this TreeView treeView) => new RxTreeViewEvents(treeView);
        public static RxTopLevelEvents Events(this TopLevel topLevel) => new RxTopLevelEvents(topLevel);
        public static RxWindowBaseEvents Events(this WindowBase windowBase) => new RxWindowBaseEvents(windowBase);
        public static RxWindowEvents Events(this Window window) => new RxWindowEvents(window);
        public static RxThumbEvents Events(this Thumb thumb) => new RxThumbEvents(thumb);
        public static RxSpinnerEvents Events(this Spinner spinner) => new RxSpinnerEvents(spinner);
    }
}
