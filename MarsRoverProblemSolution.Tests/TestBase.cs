using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblemSolution.Tests
{
    public abstract class TestBase
    {
        public virtual IServiceProvider Initialize(Action<IServiceCollection> action = null)
        {
            var services = new ServiceCollection();

            action?.Invoke(services);

            var provider = services.BuildServiceProvider();

            return provider;
        }
    }
}
