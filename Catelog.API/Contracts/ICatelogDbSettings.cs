namespace Catelog.API.Contracts
{
    public interface ICatelogDbSettings
    {
        string ConnectionString { get; set; }

        string DatabaseName { get; set; }

        string CollectionName { get; set; }
    }
}
