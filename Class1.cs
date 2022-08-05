using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;


namespace Sampleplugin
{
	public class Class1 : IPlugin
	{
		public void Execute(IServiceProvider serviceprovider)
		{
			IPluginExecutionContext context = (IPluginExecutionContext)serviceprovider.GetService(typeof(IPluginExecutionContext));
			IOrganizationServiceFactory factory = (IOrganizationServiceFactory)serviceprovider.GetService(typeof(IOrganizationServiceFactory));
			IOrganizationService trace = factory.CreateOrganizationService(context.UserId);
			ITracingService Trace = (ITracingService)serviceprovider.GetService(typeof(ITracingService));
			try
			{
				if (context.InputParameters.Contains("Targets") && context.InputParameters["Target"] is Entity)
				{
					Entity targetEntity = (context.InputParameters["Target"] as Entity);
					Random randomNumber = new Random();
					int accnumber = randomNumber.Next();
					targetEntity["accountnumber"] = accnumber.ToString();
				}
				libr
			}
			catch (Exception ex)
			{
				throw new InvalidPluginExecutionException(ex.Message);
			}

		}
	} }
