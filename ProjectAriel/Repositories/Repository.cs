using ProjectAriel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectAriel.Repositories
{
	public class Repository
	{
		public ProjectArielContextWrapper Database { get; set; }

		~Repository()
		{
			Database.Dispose();
		}
	}
}