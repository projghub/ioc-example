using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IocExample
{
    public interface IContainer
    {
        void Register<T, TImplementation>();
        void Register<T, TImplementation>(LifestyleType lifestyleType);
        T Resolve<T>();
    }

    public class Container : IContainer
    {
        private readonly IList<IOCObject> iocObjects = new List<IOCObject>();

        public Container()
        {
            iocObjects = new List<IOCObject>();
        }

        public void Register<T, TImplementation>()
        {
            Register<T, TImplementation>(LifestyleType.Transient);
        }

        public void Register<T, TImplementation>(LifestyleType lifestyleType)
        {
            if (iocObjects.FirstOrDefault(x => x._type == typeof(T)) != null)
                throw new TypeExistsException("Type already exists");

            iocObjects.Add(new IOCObject(typeof(T), typeof(TImplementation), lifestyleType));
        }

        public T Resolve<T>()
        {
            var MyObject = iocObjects.FirstOrDefault(x => x._type == typeof(T));
            if (MyObject == null)
                throw new UnknownTypeException(string.Format("Unknown Type: {0}", typeof(T).Name));

            if (MyObject.Instance == null || MyObject._lifestyleType == LifestyleType.Transient)
            {
                MyObject.CreateInstance();
            }

            return (T) MyObject.Instance;
        }

        public bool typeExists(Type type)
        {
            return iocObjects.FirstOrDefault(x => x._type == type) != null;
        }
    }
}