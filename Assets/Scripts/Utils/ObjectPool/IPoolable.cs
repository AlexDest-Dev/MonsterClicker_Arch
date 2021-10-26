namespace Utils.ObjectPool
{
    public interface IPoolable
    {
        public void Activate();
        public void Deactivate();
        public bool IsActive();
    }
}