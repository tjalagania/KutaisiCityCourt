using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using IPNetwork = System.Net.IPNetwork;

namespace KtCity.filters
{
    public class IPFilter : Attribute, IAsyncResourceFilter
    {
        
        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            var remIp = context.HttpContext.Connection.RemoteIpAddress;
            IPHostEntry ips = Dns.GetHostEntry(Environment.MachineName);
            bool tag = false;
            foreach(var ip in ips.AddressList)
            {
                
                IPNetwork ipp = IPNetwork.Parse(ip, 24);
                tag = ipp.Contains(remIp);
                if (tag)
                {
                   await next();
                    
                }
                
                   
            }
            context.Result = new ForbidResult();
        }
    }
}
