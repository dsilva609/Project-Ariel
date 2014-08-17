using Autofac;
using Autofac.Integration.Mvc;
using ProjectAriel.Common;
using ProjectAriel.DAL;
using ProjectAriel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ProjectAriel.App_Start
{
	public class AutofacConfiguration
	{
		public static void Configure()
		{
			var container = new ContainerBuilder();
			container.RegisterControllers(Assembly.GetExecutingAssembly())
				.PropertiesAutowired();
			container.RegisterFilterProvider();

			container.RegisterType<ProjectArielContext>();
			container.RegisterType<ProjectArielContextWrapper>().AsSelf().PropertiesAutowired();
			container.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
				.InNamespaceOf<Repository>()
				.AsSelf()
				.PropertiesAutowired();

			DependencyResolver.SetResolver(new AutofacDependencyResolver(container.Build()));
		}
	}
}