﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AutoMapper.Runtime.Extensions
{
    public static class Mapper
    {
        private static HashSet<Type> primitiveTypes = new HashSet<Type>(new List<Type>()
        {
            typeof(int), typeof(decimal), typeof(string), typeof(Guid), typeof(DateTime), typeof(Enum), typeof(bool), typeof(char),
            typeof(int?), typeof(decimal?), typeof(Guid?), typeof(DateTime?), typeof(bool?), typeof(char?)
        });
        private static HashSet<Tuple<Type, Type>> mappingsCache = new HashSet<Tuple<Type, Type>>();

        private static object locker = new object();

        public static TDestination DeepCopyTo<TDestination>(this object source)
             where TDestination : class
        {
            if (source == null)
                return default(TDestination);

            Type sourceType = source.GetType();
            Type destinationType = typeof(TDestination);

            CreateMap(sourceType, destinationType);

            return (TDestination)AutoMapper.Mapper.Map(source, sourceType, typeof(TDestination));
        }

        public static void Map<TSource, TDestination>(TSource source, TDestination destination)
            where TSource : class
            where TDestination : class
        {
            if (source == default(TSource) || destination == default(TDestination))
                return;

            Type sourceType = source.GetType();
            Type destinationType = destination.GetType();

            CreateMap(sourceType, destinationType);

            AutoMapper.Mapper.Map(source, destination);
        }

        internal static void CreateMap(Type sourceType, Type destinationType)
        {
            Tuple<Type, Type> mappingKey = new Tuple<Type, Type>(sourceType, destinationType);

            if (!mappingsCache.Contains(mappingKey))
            {
                lock (locker)
                {
                    if (!mappingsCache.Contains(mappingKey) && mappingsCache.Add(mappingKey))
                    {
                        MappingAction(sourceType, destinationType);
                    }
                }
            }
        }

        private static void MappingAction(Type sourceType, Type destinationType)
        {
            Type actualSourceType = sourceType;
            Type actualDestinationType = destinationType;

            if (sourceType.IsArray)
                actualSourceType = sourceType.GetElementType();

            if (destinationType.IsArray)
                actualDestinationType = destinationType.GetElementType();

            if (sourceType.IsGenericType && sourceType.GetGenericTypeDefinition() == typeof(List<>))
                actualSourceType = sourceType.GetGenericArguments()[0];

            if (destinationType.IsGenericType && destinationType.GetGenericTypeDefinition() == typeof(List<>))
                actualDestinationType = destinationType.GetGenericArguments()[0];

            if (sourceType.IsGenericType && sourceType.GetGenericTypeDefinition() == typeof(Dictionary<,>))
            {
                Type keySourceType = sourceType.GetGenericArguments()[0];
                Type keyDestinationType = destinationType.GetGenericArguments()[0];

                CreateMap(keySourceType, keyDestinationType);

                Type valueSourceType = sourceType.GetGenericArguments()[1];
                Type valueDestinationType = destinationType.GetGenericArguments()[1];

                CreateMap(valueSourceType, valueDestinationType);
            }
            else
            {
                MapProperties(actualSourceType, actualDestinationType);

                if (!primitiveTypes.Contains(actualSourceType) && !primitiveTypes.Contains(actualDestinationType))
                    typeof(AutoMapper.Mapper)
                           .GetMethods(BindingFlags.Static | BindingFlags.Public)
                           .First(mi => mi.Name == "CreateMap")
                           .MakeGenericMethod(actualSourceType, actualDestinationType)
                           .Invoke(null, null);
            }
        }

        private static void MapProperties(Type sourceType, Type destinationType)
        {
            PropertyInfo[] destinationProperties = GetProperties(destinationType);

            if (destinationProperties.Length > 0)
            {
                PropertyInfo[] sourceProperties = GetProperties(sourceType);

                string[] commonPropertyNames = destinationProperties.Where(dp => sourceProperties.Any(sp => sp.Name == dp.Name)).Select(property => property.Name).ToArray();

                foreach (string propertyName in commonPropertyNames)
                {
                    Type sourcePropertyType = sourceProperties.First(sourceProperty => sourceProperty.Name == propertyName).PropertyType;
                    Type destinationPropertyType = destinationProperties.First(destinationProperty => destinationProperty.Name == propertyName).PropertyType;

                    CreateMap(sourcePropertyType, destinationPropertyType);
                }
            }
        }

        private static PropertyInfo[] GetProperties(Type type)
        {
            return type.GetProperties(BindingFlags.Instance | BindingFlags.Public).Where(property => !primitiveTypes.Contains(property.PropertyType)).ToArray();
        }
    }
}