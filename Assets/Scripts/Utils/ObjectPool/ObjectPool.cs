using System.Collections.Generic;

namespace Utils.ObjectPool
{
    public class ObjectPool<T> where T : IPoolable<T>
    {
        private List<T> _pool;
        private readonly T _poolableObject;

        public ObjectPool(T poolableObject)
        {
            _poolableObject = poolableObject;
            _pool = new List<T>();
        }

        public void InitializePool(int initialElementsNumber = 10)
        {
            for (int i = 0; i < initialElementsNumber; i++)
            {
                AddObject();
            }
        }

        protected virtual T AddObject()
        {
            T newObject = _poolableObject.Clone();
            newObject.Deactivate();
            _pool.Add(newObject);
            return newObject;
        }

        public virtual T TakeObject()
        {
            foreach (var obj in _pool)
            {
                if (!obj.IsActive())
                {
                    return obj;
                }
            }

            T newObject = AddObject();
            return newObject;
        }

        public virtual void ReturnObject(T obj)
        {
            obj.Deactivate();
        } 
    }
}