using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Blazor.Controls
{
    public static class EnumExtensions
    {
        public static string? DisplayName(this Enum value)
        {
            if (value == null)
            {
                return null;
            }
            // Read the Display attribute name
            var name = value.ToString();
            if (name != null)
            {
                var member = value.GetType().GetMember(name)[0];
                var displayAttribute = member.GetCustomAttribute<DisplayAttribute>();
                if (displayAttribute != null)
                {
                    return displayAttribute.GetName();
                }
            }
            return Enum.GetName(value.GetType(), value);
        }
    }
}
