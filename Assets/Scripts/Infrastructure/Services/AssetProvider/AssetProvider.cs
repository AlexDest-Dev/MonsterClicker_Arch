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
            TMono prefab = LoadPrefab<TMono>(path);
            return Object.Instantiate(prefab);
        }

        public TMono Instantiate<TMono>(string path, Vector3 position) where TMono : Object
        {
            TMono prefab = LoadPrefab<TMono>(path);
            return Object.Instantiate(prefab, position, Quaternion.identity);
        }
    }
}