using Sheng.Enterprise.Infrastructure;
using System;
using System.Collections.Generic;

namespace Sheng.Enterprise.Web.Models
{
	public class OrganizationalStructureViewModel
	{
		public Domain Domain
		{
			get;
			set;
		}

		public List<Organization> OrganizationList
		{
			get;
			set;
		}
	}
}
