using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Tests.Unit
{
    public static class ReflectionUtils
    {
        public static void SetPropertyNoSetter<T>(this object obj, string propertyName, [AllowNull]T value, Func<string, string>? fieldFunc = default)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
                throw new System.ArgumentException("message", nameof(propertyName));

            var fieldName = fieldFunc?.Invoke(propertyName) ?? GetFieldName(propertyName);
            var type = obj.GetType();
            var field = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);

            if (field is null)
                throw new NullReferenceException("Unable to find backing field for property " + propertyName);

            field.SetValue(obj, value);
        }

        static string GetFieldName(string property) => 
            $"<{property}>k__BackingField";
    }
}