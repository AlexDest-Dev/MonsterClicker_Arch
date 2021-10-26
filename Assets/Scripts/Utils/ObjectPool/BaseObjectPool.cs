using System.Collections.Generic;

namespace Utils.ObjectPool
{
    public abstract class BaseObjectPool<TObject> : IObjectPool<TObject> where TObject : IPoolable
    {
        private List<TObject> _pool;

        public BaseObjectPool()
        {
            _pool = new List<TObject>();
        }

        public void InitializePool(int initialElementsNumber = 10)
        {
            for (int i = 0; i < initialElementsNumber; i++)
            {
                AddObject();
            }
        }

        protected abstract TObject AddObject();

        public virtual TObject TakeObject()
        {
            foreach (var obj in _pool)
            {
                if (!obj.IsActive())
                {
                    return obj;
                }
            }

            TObject newObject = AddObject();
            return newObject;
        }

        public virtual void ReturnObject(TObject obj)
        {
            obj.Deactivate();
        } 
    }
}