﻿using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digipolis.Correlation
{
    public static class CorrelationAppBuilderExtensions
    {
        public static IApplicationBuilder UseCorrelation(this IApplicationBuilder app)
        {
            app.UseMiddleware<CorrelationMiddleware>();

            return app;
        }
    }
}
