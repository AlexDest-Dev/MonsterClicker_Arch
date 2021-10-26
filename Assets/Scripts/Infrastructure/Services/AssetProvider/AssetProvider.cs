using UnityEngine;

namespace Infrastructure.Services.AssetProvider
{
    public class AssetProvider : IAssetProvider
    {
        public TMono LoadPrefab<TMono>(string path) where TMono : Object
        {
            return Resources.Load<TMono>(path);
        }

        public TMono Instantiate<TMono>(string path) where TMono : Object
        {
            throw new System.NotImplementedException();
        }

        public TMono Instantiate<TMono>(string path, Vector3 position) where TMono : Object
        {
            throw new System.NotImplementedException();
        }
    }
}