namespace GameLogic.Enemies
{
    public interface ISpawner
    {
        void StartSpawn(float spawnRate);
        void StopSpawn();
    }
}