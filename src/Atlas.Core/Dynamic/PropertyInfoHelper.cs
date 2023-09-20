﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Atlas.Core.Dynamic
{
    public static class PropertyInfoHelper
    {
        public static PropertyInfo? GetPropertyInfo(Type type, string propertyName)
        {
            if(type == null) throw new ArgumentNullException(nameof(type));
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));

            var propertyInfos = GetPropertyInfos(type);
            return propertyInfos.FirstOrDefault(p => p.Name.Equals(propertyName));
        }

        public static IEnumerable<PropertyInfo> GetPropertyInfos(Type type)
        {
            List<PropertyInfo> propertyInfoResults = new();

            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                if (SupportedProperty(propertyInfo))
                {
                    propertyInfoResults.Add(propertyInfo);
                }
            }

            return propertyInfoResults;
        }

        /// <summary>
        /// Support public value types, strings, classes generic lists (IList<>).
        /// Does not support interfaces, abstract classes or collections that do not inherit from IList<>.
        /// </summary>
        /// <param name="propertyInfo">The PropertyInfo to evaluate.</param>
        /// <returns>True if the property is supported, else returns false.</returns>
        private static bool SupportedProperty(PropertyInfo propertyInfo)
        {
            var propertyType = propertyInfo.PropertyType;

            if (propertyType.IsPublic
                && !propertyType.IsAbstract
                && !propertyType.IsInterface)
            {
                if (propertyType.IsValueType
                     || propertyType == typeof(string))
                {
                    return true;
                }
                else if (propertyType.IsClass)
                {
                    if (propertyType.GetInterfaces()
                        .Any(i => i.GetTypeInfo().Name.Equals(typeof(IEnumerable).Name)))
                    {
                        if (propertyType.GetInterfaces()
                            .Any(i => i.IsGenericType
                            && i.GetGenericTypeDefinition().Name.Equals(typeof(IList<>).Name)))
                        {
                            return true;
                        }

                        return false;
                    }

                    return true;
                }
            }

            return true;
        }
    }
}
