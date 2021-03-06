﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace oclockvn.Extenstions
{
    public static class QueryExtension
    {
        public static IQueryable<T> Including<T>(this IQueryable<T> self, params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            return includeProperties.Aggregate(self, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
