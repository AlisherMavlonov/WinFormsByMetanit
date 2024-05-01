using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Enum;

namespace WinFormsByMetanit.Domain.Extensions
{
    public static class EnumExtension
    {
        public static string GetDisplayName(this System.Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                ?.GetName() ?? "Неопредиленный";
        }
        public static LayerGrass GetEnumValueByDisplayName(this string displayName)
        {
            foreach (var value in LayerGrass.GetValues(typeof(LayerGrass)))
            {
                var enumValue = (LayerGrass)value;
                if (enumValue.GetDisplayName() == displayName)
                {
                    return enumValue;
                }
            }
            throw new ArgumentException($"No enum value with display name '{displayName}' found.");
        }

        public static GlassTypeOdinar GetEnumValue(string allGlassTypeValue)
        {
            foreach (var value in GlassTypeOdinar.GetValues(typeof(GlassTypeOdinar)))
            {
                var enumValue = (GlassTypeOdinar)value;
                if (enumValue.GetDisplayName() == allGlassTypeValue)
                {
                    return enumValue;
                }
            }
            
            throw new ArgumentException($"No enum value with display name '{allGlassTypeValue}' found.");
        }


    }
}
