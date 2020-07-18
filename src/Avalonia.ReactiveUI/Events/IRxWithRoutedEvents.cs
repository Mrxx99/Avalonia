using Avalonia.Interactivity;

namespace Avalonia
{
    public interface IRxWithRoutedEvents
    {
        RoutingStrategies RoutingStrategy { get; }
    }
}