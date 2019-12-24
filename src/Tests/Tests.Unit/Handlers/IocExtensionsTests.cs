using System.Threading;
using System.Threading.Tasks;
using ApiPackages.Handlers;
using FluentAssertions;
using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Tests.Unit.Handlers
{
    public class IocExtensionsTests
    {
        readonly ServiceProvider provider = new ServiceCollection()
            .AddHandlers<IocExtensionsTests>()
            .BuildServiceProvider();

        [Fact]
        public void AddHandlers_AddsMediatorRequirements()
        {
            provider.GetRequiredService<IMediator>().Should().NotBeNull();
            provider.GetRequiredService<ServiceFactory>().Should().NotBeNull();
            provider.GetRequiredService<IPipelineBehavior<object, object>>()
                .Should().NotBeNull();
        }

        [Fact]
        public void AddHandlers_AddsHandlersFromAssembly()
        {
            provider.GetRequiredService<IRequestHandler<IRequest<object>, object>>()
                .Should().BeOfType<TestHandler>();
        }

        [Fact]
        public void AddHandlers_AddsPreAndPostProcessorsFromAssembly()
        {
            provider.GetRequiredService<IRequestPreProcessor<object>>()
                .Should().BeOfType<TestPreProcessor>();
            provider.GetRequiredService<IRequestPostProcessor<IRequest<object>, object>>()
                .Should().BeOfType<TestPostProcessor>();
        }
    }

    class TestHandler : IRequestHandler<IRequest<object>, object>
    {
        public Task<object> Handle(IRequest<object> request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

    class TestPreProcessor : IRequestPreProcessor<object>
    {
        public Task Process(object request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }

    class TestPostProcessor : IRequestPostProcessor<IRequest<object>, object>
    {
        public Task Process(IRequest<object> request, object response, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
