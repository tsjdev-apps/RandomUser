using Windows.ApplicationModel.Resources;
using RandomUser.Core.Interfaces.Service;

namespace RandomUser.Windows.Service
{
    public class ResourceService : IResourceService
    {
        private readonly ResourceLoader _resLoader = new ResourceLoader();

        public string GetString(string key)
        {
            return _resLoader.GetString(key);
        }
    }
}