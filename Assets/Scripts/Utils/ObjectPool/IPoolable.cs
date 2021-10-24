namespace Utils.ObjectPool
{
    public interface IPoolable<T> : IClonable<T>
    {
        public void Activate();
        public void Deactivate();
        public bool IsActive();
    }
}