using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;

namespace Synapse.Utils
{
    public static class ObjectQueryExtensions
    {
        public static IQueryable<T> Include<T>(this IQueryable<T> query, Expression<Func<T, object>> propSelector) {
            var q = query as ObjectQuery<T>;
            return q != null ? q.Include(GetIncludeString(propSelector)) : query;
        }

        public static string GetIncludeString<T>(Expression<Func<T, object>> propSelector) {
            var fields = new List<string>();
            for (var expr = propSelector.Body as MemberExpression; expr != null; expr = expr.Expression as MemberExpression) {
                fields.Insert(0,expr.Member.Name);
            }
            return String.Join(".", fields);
        }
    }
}

