namespace Utils.ObjectPool
{
    public interface IClonable<T>
    {
        public T Clone();
    }
}