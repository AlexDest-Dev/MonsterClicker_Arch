using UnityEngine;

namespace Infrastructure.Services
{
    public interface IAssetProvider : IService
    {
        TMono LoadPrefab<TMono>(string path) where TMono : Object;
        TMono Instantiate<TMono>(string path) where TMono : Object;
        TMono Instantiate<TMono>(string path, Vector3 position) where TMono : Object;
    }
}