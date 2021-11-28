using System;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.EventHandlers;
using Emeraude.Tests.Base;
using Emeraude.Tests.Infrastructure.Fakes;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Emeraude.Tests.Infrastructure.Tests
{
    public class IdentityEventManagerTests
    {
        [Fact]
        public async Task TriggerLoginEventAsync_OnCorrectEventData_ShouldHandleEventCorrectly()
        {
            var userId = Guid.NewGuid();

            var loginEventHandlerMock = GetEventHandlerMock<FakeLoginEventHandler, LoginEventArgs>();

            var serviceProvider = TestsUtilities
                .GetServiceProviderForServiceWithImplementation<ILoginEventHandler, FakeLoginEventHandler>(loginEventHandlerMock.Object);
            var eventManager = GetSubject(serviceProvider);
            await eventManager.TriggerLoginEventAsync(userId);
            
            loginEventHandlerMock
                .Verify(x => x.HandleAsync(It.Is<LoginEventArgs>(y => y.UserId == userId)), Times.Once);
        }
        
        [Fact]
        public async Task TriggerExternalLoginEventAsync_OnCorrectEventData_ShouldHandleEventCorrectly()
        {
            var userId = Guid.NewGuid();
            
            var externalLoginEventHandlerMock = GetEventHandlerMock<FakeExternalLoginEventHandler, ExternalLoginEventArgs>();

            var serviceProvider = TestsUtilities
                .GetServiceProviderForServiceWithImplementation<IExternalLoginEventHandler, FakeExternalLoginEventHandler>(externalLoginEventHandlerMock.Object);
            var eventManager = GetSubject(serviceProvider);
            await eventManager.TriggerExternalLoginEventAsync(userId);
            
            externalLoginEventHandlerMock
                .Verify(x => x.HandleAsync(It.Is<ExternalLoginEventArgs>(y => y.UserId == userId)), Times.Once);
        }

        [Fact]
        public async Task TriggerRegisterEventAsync_OnCorrectEventData_ShouldHandleEventCorrectly()
        {
            var userId = Guid.NewGuid();
            var confirmationLink = "https://emeraude.dev/confirmation-link";
            
            var registerEventHandlerMock = GetEventHandlerMock<FakeRegisterEventHandler, RegisterEventArgs>();

            var serviceProvider = TestsUtilities
                .GetServiceProviderForServiceWithImplementation<IRegisterEventHandler, FakeRegisterEventHandler>(registerEventHandlerMock.Object);
            var eventManager = GetSubject(serviceProvider);
            await eventManager.TriggerRegisterEventAsync(userId, confirmationLink);
            
            registerEventHandlerMock
                .Verify(x => x.HandleAsync(It.Is<RegisterEventArgs>(y => y.UserId == userId && y.EmailConfirmationLink == confirmationLink)), Times.Once);
        }
        
        [Fact]
        public async Task TriggerExternalRegisterEventAsync_OnCorrectEventData_ShouldHandleEventCorrectly()
        {
            var userId = Guid.NewGuid();
            
            var externalRegisterEventHandlerMock = GetEventHandlerMock<FakeExternalRegisterEventHandler, ExternalRegisterEventArgs>();

            var serviceProvider = TestsUtilities
                .GetServiceProviderForServiceWithImplementation<IExternalRegisterEventHandler, FakeExternalRegisterEventHandler>(externalRegisterEventHandlerMock.Object);
            var eventManager = GetSubject(serviceProvider);
            await eventManager.TriggerExternalRegisterEventAsync(userId);
            
            externalRegisterEventHandlerMock
                .Verify(x => x.HandleAsync(It.Is<ExternalRegisterEventArgs>(y => y.UserId == userId)), Times.Once);
        }
        
        [Fact]
        public async Task TriggerForgotPasswordEventAsync_OnCorrectEventData_ShouldHandleEventCorrectly()
        {
            var userId = Guid.NewGuid();
            var resetPasswordLink = "https://emeraude.dev/reset-password-link";
            
            var forgotPasswordEventHandlerMock = GetEventHandlerMock<FakeForgotPasswordEventHandler, ForgotPasswordEventArgs>();

            var serviceProvider = TestsUtilities
                .GetServiceProviderForServiceWithImplementation<IForgotPasswordEventHandler, FakeForgotPasswordEventHandler>(forgotPasswordEventHandlerMock.Object);
            var eventManager = GetSubject(serviceProvider);
            await eventManager.TriggerForgotPasswordEventAsync(userId, resetPasswordLink);
            
            forgotPasswordEventHandlerMock
                .Verify(x => x.HandleAsync(It.Is<ForgotPasswordEventArgs>(y => y.UserId == userId && y.ResetPasswordLink == resetPasswordLink)), Times.Once);
        }
        
        [Fact]
        public async Task TriggerResetPasswordEventAsync_OnCorrectEventData_ShouldHandleEventCorrectly()
        {
            var userId = Guid.NewGuid();
            
            var resetPasswordEventHandlerMock = GetEventHandlerMock<FakeResetPasswordEventHandler, ResetPasswordEventArgs>();

            var serviceProvider = TestsUtilities
                .GetServiceProviderForServiceWithImplementation<IResetPasswordEventHandler, FakeResetPasswordEventHandler>(resetPasswordEventHandlerMock.Object);
            var eventManager = GetSubject(serviceProvider);
            await eventManager.TriggerResetPasswordEventAsync(userId);
            
            resetPasswordEventHandlerMock
                .Verify(x => x.HandleAsync(It.Is<ResetPasswordEventArgs>(y => y.UserId == userId)), Times.Once);
        }
        
        [Fact]
        public async Task TriggerConfirmedEmailEventAsync_OnCorrectEventData_ShouldHandleEventCorrectly()
        {
            var userId = Guid.NewGuid();
            
            var confirmedEmailEventHandlerMock = GetEventHandlerMock<FakeConfirmedEmailEventHandler, ConfirmedEmailEventArgs>();

            var serviceProvider = TestsUtilities
                .GetServiceProviderForServiceWithImplementation<IConfirmedEmailEventHandler, FakeConfirmedEmailEventHandler>(confirmedEmailEventHandlerMock.Object);
            var eventManager = GetSubject(serviceProvider);
            await eventManager.TriggerConfirmedEmailEventAsync(userId);
            
            confirmedEmailEventHandlerMock
                .Verify(x => x.HandleAsync(It.Is<ConfirmedEmailEventArgs>(y => y.UserId == userId)), Times.Once);
        }
        
        [Fact]
        public async Task TriggerRequestChangeEmailEventAsync_OnCorrectEventData_ShouldHandleEventCorrectly()
        {
            var userId = Guid.NewGuid();
            var newEmail = "my-admin-user@emeraude.dev";
            var changeEmailLink = "https://emeraude.dev/change-email-link";
            
            var requestChangeEmailEventHandlerMock = GetEventHandlerMock<FakeRequestChangeEmailEventHandler, RequestChangeEmailEventArgs>();

            var serviceProvider = TestsUtilities
                .GetServiceProviderForServiceWithImplementation<IRequestChangeEmailEventHandler, FakeRequestChangeEmailEventHandler>(requestChangeEmailEventHandlerMock.Object);
            var eventManager = GetSubject(serviceProvider);
            await eventManager.TriggerRequestChangeEmailEventAsync(userId, newEmail, changeEmailLink);
            
            requestChangeEmailEventHandlerMock
                .Verify(x => x.HandleAsync(It.Is<RequestChangeEmailEventArgs>(y => y.UserId == userId && y.NewEmail == newEmail && y.EmailConfirmationLink == changeEmailLink)), Times.Once);
        }
        
        private Mock<THandler> GetEventHandlerMock<THandler, TEventArgs>()
            where THandler : class, IIdentityEventHandler<TEventArgs>
            where TEventArgs : IdentityEventArgs
        {
            var eventHandlerMock = new Mock<THandler>();
            eventHandlerMock
                .Setup(x => x.HandleAsync(It.IsAny<TEventArgs>()))
                .Returns(Task.CompletedTask);

            return eventHandlerMock;
        }
        
        private IIdentityEventManager GetSubject(IServiceProvider serviceProvider)
        {
            return new IdentityEventManager(
                serviceProvider,
                Mock.Of<IHttpContextAccessor>(),
                Mock.Of<ILogger<IdentityEventManager>>());
        }
    }
}