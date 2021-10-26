namespace Utils.ObjectPool
{
    public interface IObjectPool<T> where T : IPoolable
    {
        T TakeObject();
        void ReturnObject(T obj);
    }
}