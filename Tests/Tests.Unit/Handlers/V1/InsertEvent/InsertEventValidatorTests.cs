using System;
using FluentAssertions;
using FluentValidation;
using GCalendar.Handlers.V1.InsertEvent;
using Xunit;

namespace Tests.Unit.Handlers.V1.InsertEvent
{
    public class InsertEventValidatorTests
    {
        readonly InsertEventValidator validator = new InsertEventValidator();
        readonly InsertEventCommand command = new InsertEventCommand(
            Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString(),
            DateTime.Now.AddDays(1),
            DateTime.Now.AddDays(2),
            "Title"
        );

        [Fact]
        public void ForValidEvent_DoesNotThrowException()
        {
            FluentActions.Invoking(() => validator.Validate(command))
                .Should().NotThrow();
        }

        [Fact]
        public void ForNullEvent_ThrowsValidationException()
        {            
            FluentActions.Invoking(() => validator.Validate(default(InsertEventCommand)!))
                .Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ForId_IsValidated(string id)
        {
            command.SetPropertyNoSetter(nameof(command.Id), id);

            FluentActions.Invoking(() => validator.ValidateAndThrow(command))
                .Should().Throw<ValidationException>();
        }
    }
}