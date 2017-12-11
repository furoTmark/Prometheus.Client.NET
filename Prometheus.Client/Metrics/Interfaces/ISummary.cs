namespace Prometheus.Client.Metrics.Interfaces
{
    public interface ISummary
    {
        void Observe(double value);
    }
}
