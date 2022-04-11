using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NerdStore.Core.DomainObjects
{
    public class AssertionConcern
    {
        public static void ValidateEquals(object obj1, object obj2, string message)
        {
            if(!obj1.Equals(obj2))
            {
                throw new DomainException(message);
            }
        }
        public static void ValidadeNotEquals(object obj1, object obj2, string message)
        {
            if (obj1.Equals(obj2))
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateCharacters(string value, int max, string message)
        {
            var length = value.Trim().Length;
            if (length > max)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateCharacters(string value,int min, int max, string message)
        {
            var length = value.Trim().Length;
            if (length < min || length > max)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidadeExpression(string pattern, string value, string message) 
        {
            var regex = new Regex(pattern);
            if(!regex.IsMatch(value))
            {
                throw new DomainException(message);
            }
        }
        public static void ValidadeEmpty(string value, string message)
        {
            if(value == null || value.Trim().Length == 0)
            {
                throw new DomainException(message);
            }
        }
    }
}
