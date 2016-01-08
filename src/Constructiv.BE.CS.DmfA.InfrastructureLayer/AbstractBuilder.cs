using System.Dynamic;

namespace Constructiv.BE.CS.DmfA.InfrastructureLayer
{
    public abstract class AbstractBuilder<T>
    {
        protected T Instance { get; }

        protected AbstractBuilder()
        {
            Instance = CreateInstance();
        }

        public abstract T CreateInstance();

        public T Build()
        {
            return Instance;
        }

    }

}
