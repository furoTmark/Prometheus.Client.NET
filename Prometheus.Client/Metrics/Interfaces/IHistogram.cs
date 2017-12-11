namespace Prometheus.Client.Metrics.Interfaces
{
    public interface IHistogram
    {
        void Observe(double value);
    }
}
