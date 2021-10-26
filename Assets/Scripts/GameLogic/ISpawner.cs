namespace GameLogic
{
    public interface ISpawner
    {
        void StartSpawn(float spawnRate);
        void StopSpawn();
    }
}