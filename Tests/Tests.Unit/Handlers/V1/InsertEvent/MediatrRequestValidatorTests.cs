using System;
using System.Threading;
using FluentAssertions;
using FluentValidation;
using GCalendar.Handlers.V1.InsertEvent;
using NSubstitute;
using Xunit;

namespace Tests.Unit.Handlers.V1.InsertEvent
{
    public class MediatrRequestValidatorTests
    {
        readonly CancellationToken token = CancellationToken.None;
        MediatrRequestValidator<object> _validator = Substitute.For<MediatrRequestValidator<object>>();

        [Fact]
        public void Process_ForValidObject_DoesNotThrowException()
        {
            FluentActions.Invoking(() => _validator.Process(new object(), token))
                .Should().NotThrow();
        }

        [Fact]
        public void Process_ForInvalidObject_ThrowsException()
        {
            _validator.When(v => v.ConfigureValidation())
                .Do(v => _validator.RuleFor(r => r)
                    .Custom((o, a) => throw new ValidationException("")));

            FluentActions.Invoking(() => _validator.Process(new object(), token))
                .Should().ThrowAsync<ValidationException>();
        }

        [Fact]
        public void Process_ConfiguresValidationOnce()
        {
            for (var i = 0; i < 10; i++)
                _validator.Process(new object(), token);

            _validator.Received(1).ConfigureValidation();
        }
    }
}