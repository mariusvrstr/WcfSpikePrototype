
namespace Spike.PipesHost
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using Services;

    public class ServiceManager
    {
        readonly List<ServiceHost> _serviceHosts = new List<ServiceHost>();

        public void OpenAll() {  
            OpenHost<BookService>();  
            OpenHost<AuthorService>();
        }

        public void CloseAll()
        {
            foreach (var serviceHost in _serviceHosts)
                serviceHost.Close();
        }

        private void OpenHost<T>()
        {
            var type = typeof(T);
            var serviceHost = new ServiceHost(type);
            serviceHost.Open();
            _serviceHosts.Add(serviceHost);
        }
    }  
}
