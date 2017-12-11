namespace Prometheus.Client.Metrics.Interfaces
{
    public interface IGauge
    {
        void Inc(double increment = 1);
        void Set(double value);
        void Dec(double decrement = 1);
        double Value { get; }
    }
}
