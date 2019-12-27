using System;
using Contracts.Calendar;
using FluentAssertions;
using FluentValidation;
using GCalendar.Api.V1;
using NodaTime;
using Xunit;

namespace Tests.Unit.Handlers.V1.InsertEvent
{
    public class EventValidatorTests
    {
        readonly EventValidator validator = new EventValidator();
        readonly Event command = new Event
        {
            Id = Guid.NewGuid().ToString(),
            CalendarId = Guid.NewGuid().ToString(),
            Start = new Start()
            {
                Ticks = DateTime.Now.Ticks,
                TimeZone = DateTimeZone.Utc.ToString()
            },
            End = new End()
            {
                Ticks = DateTime.Now.Ticks,
                TimeZone = DateTimeZone.Utc.ToString()
            },
            Title = "Title"
        };

        [Fact]
        public void ForValidEvent_DoesNotThrowException()
        {
            FluentActions.Invoking(() => validator.Validate(command))
                .Should().NotThrow();
        }

        [Fact]
        public void ForNullEvent_ThrowsValidationException()
        {
            FluentActions.Invoking(() => validator.Validate(default(Event)!))
                .Should().Throw<ArgumentNullException>();
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("ValidId", true)]
        public void ForId_IsValidated(string value, bool isValid)
        {
            command.SetPropertyNoSetter(nameof(command.Id), value, GetFieldName);
            CheckValidation(isValid);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("ValidId", true)]
        public void ForCalendarId_IsValidated(string value, bool isValid)
        {
            command.SetPropertyNoSetter(nameof(command.CalendarId), value, GetFieldName);
            CheckValidation(isValid);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("ValidTitle", true)]
        public void ForTitle_IsValidated(string value, bool isValid)
        {
            command.SetPropertyNoSetter(nameof(command.Title), value, GetFieldName);
            CheckValidation(isValid);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData(default, false)]
        public void ForStart_IsValidated(Start value, bool isValid)
        {
            command.SetPropertyNoSetter(nameof(command.Start), value, GetFieldName);
            CheckValidation(isValid);
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData(default, false)]
        public void ForEnd_IsValidated(End value, bool isValid)
        {
            command.SetPropertyNoSetter(nameof(command.End), value, GetFieldName);
            CheckValidation(isValid);
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

        string GetFieldName(string property)
        {
            property = char.ToLower(property[0]) + property.Substring(1);
            return property + "_";
        }
    }
}