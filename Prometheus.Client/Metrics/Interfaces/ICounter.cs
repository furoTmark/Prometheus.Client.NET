namespace Prometheus.Client.Metrics.Interfaces
{
    public interface ICounter
    {
        void Inc(double increment = 1);

        double Value { get; }
    }
}
