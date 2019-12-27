using System;
using FluentAssertions;
using FluentValidation;
using GCalendar.Handlers.V1.InsertEvent;
using NodaTime;
using Xunit;

namespace Tests.Unit.Handlers.V1.InsertEvent
{
    public class InsertEventValidatorTests
    {
        readonly InsertEventValidator validator = new InsertEventValidator();
        readonly InsertEventCommand command;

        public InsertEventValidatorTests()
        {
            command = new InsertEventCommand(
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString(),
                GetDateTime(1),
                GetDateTime(2),
                "Title"
            );
        }

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
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("ValidId", true)]
        public void ForId_IsValidated(string id, bool isValid)
        {
            command.SetPropertyNoSetter(nameof(command.Id), id);
            CheckValidation(isValid);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("ValidId", true)]
        public void ForCalendarId_IsValidated(string calendarId, bool isValid)
        {
            command.SetPropertyNoSetter(nameof(command.CalendarId), calendarId);
            CheckValidation(isValid);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("ValidTitle", true)]
        public void ForTitle_IsValidated(string title, bool isValid)
        {
            command.SetPropertyNoSetter(nameof(command.Title), title);
            CheckValidation(isValid);
        }
        [Fact]
        public void ForStart_InThePast_IsInvalid()
        {
            command.SetPropertyNoSetter(nameof(command.Start), GetDateTime(-1));
            CheckValidation(false);
        }

        [Fact]
        public void ForEnd_BeforeStart_IsInvalid()
        {
            command.SetPropertyNoSetter(nameof(command.End), GetDateTime(-1));
            CheckValidation(false);
        }

        void CheckValidation(bool isValid)
        {
            if (isValid)
                FluentActions.Invoking(() => validator.ValidateAndThrow(command))
                    .Should().NotThrow();
            else
                FluentActions.Invoking(() => validator.ValidateAndThrow(command))
                    .Should().Throw<ValidationException>();
        }

        ZonedDateTime GetDateTime(int hoursToAdd)
        {
            return new ZonedDateTime(
                Instant.FromDateTimeUtc(DateTime.Now.AddHours(hoursToAdd).ToUniversalTime()),
                DateTimeZone.Utc);
        }
    }
}