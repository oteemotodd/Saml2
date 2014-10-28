﻿using Kentor.AuthServices.Configuration;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;

namespace Kentor.AuthServices.WebSSO
{
    class NotFoundCommand : ICommand
    {
        public CommandResult Run(HttpRequestData request, IOptions options)
        {
            return new CommandResult()
            {
                HttpStatusCode = HttpStatusCode.NotFound
            };
        }
    }
}
