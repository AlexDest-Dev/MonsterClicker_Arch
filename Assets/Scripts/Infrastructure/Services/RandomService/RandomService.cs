using UnityEngine;
using Utils;

namespace Infrastructure.Services.RandomService
{
    public class RandomService : IRandomService
    {
        public Vector3 GetRandomPosition()
        {
            float x = Random.Range(-100, 100);
            float y = Random.Range(-100, 100);
            float z = Random.Range(-100, 100);
            return new Vector3(x, y, z);
        }

        public Vector3 GetRandomPosition(Vector3Bounds2D bounds)
        {
            ref Vector3 leftDownBound = ref bounds.LeftDownBound;
            ref Vector3 rightUpBound = ref bounds.RightUpBound;
            float x = Random.Range(leftDownBound.x, rightUpBound.x);
            float y = Random.Range(leftDownBound.y, rightUpBound.y);
            float z = Random.Range(leftDownBound.z, rightUpBound.z);
            return new Vector3(x, y, z);
        }
    }
}