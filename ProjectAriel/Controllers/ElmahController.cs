using ProjectAriel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAriel.Controllers
{
	public partial class ElmahController : Controller
	{
		public virtual ActionResult Index(string type)
		{
			return new ElmahResult(type);
		}
	}
}