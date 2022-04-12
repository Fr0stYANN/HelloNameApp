using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloNameApp.CustomChanges
{
    public class VladRoutingModelConvention : IControllerModelConvention
    {
        private readonly string _newLastWord = "ControllerVlad";

        public void Apply(ControllerModel controller)
        {
            controller.ControllerName = controller.ControllerName.Replace(_newLastWord,"");
        }
    }
}
