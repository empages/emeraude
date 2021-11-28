using System;
using Moq;

namespace Emeraude.Tests.Base
{
    public static class TestsUtilities
    {
        public static IServiceProvider GetServiceProviderForServiceWithImplementation<TService, TImplementation>(TImplementation instance)
            where TImplementation : class, TService
        {
            var serviceProviderMock = new Mock<IServiceProvider>();
            serviceProviderMock
                .Setup(x => x.GetService(typeof(TService)))
                .Returns(instance);

            return serviceProviderMock.Object;
        }
    }
}