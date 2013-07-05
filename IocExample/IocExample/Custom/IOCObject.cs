using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IocExample
{
    public class IOCObject
    {
        public object Instance { get; private set; }
        public Type _type { get; private set; }
        public Type _implementation { get; private set; }
        public LifestyleType _lifestyleType { get; private set; }

        public IOCObject(Type type, Type implementation, LifestyleType lifestyleType)
        {
            _type = type;
            _implementation = implementation;
            _lifestyleType = lifestyleType;
        }

        public void CreateInstance(params object[] args)
        {
            this.Instance = Activator.CreateInstance(this._type, args);
        }
    }
}