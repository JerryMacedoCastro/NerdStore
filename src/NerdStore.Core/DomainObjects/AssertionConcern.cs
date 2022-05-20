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
            if (!obj1.Equals(obj2))
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateNotEquals(object obj1, object obj2, string message)
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
        public static void ValidateCharacters(string value, int min, int max, string message)
        {
            var length = value.Trim().Length;
            if (length < min || length > max)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateExpression(string pattern, string value, string message)
        {
            var regex = new Regex(pattern);
            if (!regex.IsMatch(value))
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateEmpty(string value, string message)
        {
            if (value == null || value.Trim().Length == 0)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateNull(object obj, string message)
        {
            if (obj == null)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateMinMax(double value, double min, double max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateMinMax(float value, float min, float max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateMinMax(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateMinMax(long value, long min, long max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateMinMax(decimal value, decimal min, decimal max, string message)
        {
            if (value < min || value > max)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateLessOrEqualThanMin(long value, long min, string message)
        {
            if (value <= min)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateLessOrEqualThanMin(double value, double min, string message)
        {
            if (value <= min)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateLessOrEqualThanMin(int value, int min, string message)
        {
            if (value <= min)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateLessOrEqualThanMin(decimal value, decimal min, string message)
        {
            if (value < min)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateFalse(bool value, string message)
        {
            if (value)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateTrue(bool value, string message)
        {
            if (!value)
            {
                throw new DomainException(message);
            }
        }
    }
}
