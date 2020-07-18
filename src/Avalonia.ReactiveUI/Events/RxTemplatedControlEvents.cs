using System;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI.Events;

namespace Avalonia
{
    public class RxTemplatedControlEvents : RxInputElementEvents, IRxTemplatedControlRoutedEvents
    {
        private readonly TemplatedControl _templatedControl;

        public RxTemplatedControlEvents(TemplatedControl templatedControl) : base(templatedControl)
        {
            _templatedControl = templatedControl;
        }

        public new IRxTemplatedControlRoutedEvents Preview
        {
            get
            {
                RoutingStrategy = RoutingStrategies.Tunnel;
                return this;
            }
        }

        public IObservable<TemplateAppliedEventArgs> TemplateApplied => TemplatedControl.TemplateAppliedEvent.ToObservable(_templatedControl, RoutingStrategy);
    }

    public interface IRxTemplatedControlRoutedEvents : IRxInputElementRoutedEvents
    {
        IObservable<TemplateAppliedEventArgs> TemplateApplied { get; }
    }
}