using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Mvc;

namespace BolloreTest.Controllers
{
    class InspectorAttribute : ActionFilterAttribute, IActionFilter 
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            bool isLying = false;
            
            object[] filters = filterContext.ActionDescriptor.GetCustomAttributes(true);
            foreach (var item in filters)
            {
                if (filters.ToString().Contains("Menteur")) isLying = true;
            }
            System.Reflection.Assembly asm = Assembly.GetExecutingAssembly();

          List<MethodInfo> result =  asm.GetTypes()
                .Where(type => typeof(AvengersController).IsAssignableFrom(type)) //filter controllers
                .SelectMany(type => type.GetMethods())
                .Where(method => method.IsPublic && !method.IsDefined(typeof(NonActionAttribute))).ToList();

            throw new NotImplementedException();
        }
    }
}
