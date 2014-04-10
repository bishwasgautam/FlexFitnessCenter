using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlexFitnessCenter.DataAccess;
using FlexFitnessCenter.Web.StructureMap;
using StructureMap;

namespace FlexFitnessCenter.Web.App_Start
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            ControllerBuilder.Current
                .SetControllerFactory(new StructureMapControllerFactory());

           
            //Define default types here
            ObjectFactory.Initialize(x=>
                                         {
                                             x.For(typeof (IRepository<>)).Use(typeof(GenericRepository<>));
                                             x.For(typeof (IDataAccess)).Use(typeof (DataStore));
                                         });
        }
    }
}