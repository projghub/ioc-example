using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Web.Routing;

namespace IocExample
{
    //public class ContainerControllerFactory : DefaultControllerFactory
    //{
    //    private readonly Container _container;

    //    private ContainerControllerFactory()
    //    {
    //    }

    //    public ContainerControllerFactory(Container container)
    //    {
    //        _container = container;
    //    }

    //    protected override Type GetControllerType(RequestContext requestContext, string controllerName)
    //    {
    //        return base.GetControllerType(requestContext, controllerName);
    //    }

    //    //why can't I override this??
    //    protected internal override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
    //    {
    //        if (controllerType == null)
    //            throw new HttpException(404, "Page not found");

    //        if (!typeof(IController).IsAssignableFrom(controllerType))
    //            throw new ArgumentException("Type does not subclass IController", "controllerType");

    //        object[] parameters = null;

    //        ConstructorInfo constructor = controllerType.GetConstructors().FirstOrDefault(c => c.GetParameters().Length > 0);
    //        if (constructor != null)
    //        {
    //            ParameterInfo[] parametersInfo = constructor.GetParameters();
    //            parameters = new object[parametersInfo.Length];

    //            for (int i = 0; i < parametersInfo.Length; i++)
    //            {
    //                ParameterInfo parameter = parametersInfo[i];

    //                if (_container.typeExists(parameter) == null)
    //                    throw new ApplicationException("Could not create controller");

    //                parameters[i] = _container.Resolve<parameter>;
    //            }
    //        }

    //        try
    //        {
    //            return (IController) Activator.CreateInstance(controllerType, parameters);
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new InvalidOperationException("Could not create controller", ex);
    //        }
    //    }
    //}
}
