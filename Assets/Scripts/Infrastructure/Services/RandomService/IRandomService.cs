using UnityEngine;
using Utils;

namespace Infrastructure.Services.RandomService
{
    public interface IRandomService : IService
    {
        Vector3 GetRandomPosition();
        Vector3 GetRandomPosition(Vector3Bounds2D bounds);
    }
}