using Catelog.API.Contracts;

namespace Catelog.API.DataProvider
{
    public class CatelogDbSettings : ICatelogDbSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
