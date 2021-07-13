using System;

namespace CompuMaster.VisualBasicCompatibility
{
    static internal class Information
    {
        public static bool IsDate(object value)
        {
            if (value == null)
                return false;
            else
                return value.GetType() == typeof(DateTime);
        }

        public static bool IsNumeric(object value)
        {
            if (value == null)
                return false;
            else
                switch (value.GetType().Name)
                {
                    case nameof(System.Byte):
                    case nameof(System.Single):
                    case nameof(System.Double):
                    case nameof(System.Int16):
                    case nameof(System.Int32):
                    case nameof(System.Int64):
                    case nameof(System.Decimal):
                    case nameof(System.Boolean):
                        {
                            return true;
                        }

                    default:
                        {
                            return false;
                        }
                }
        }

        public static bool IsNothing(object value)
        {
            return value == null;
        }

        public static bool IsDBNull(object value)
        {
            return System.DBNull.Value.Equals(value);
        }

        public enum TriState : int
        {
            UseDefault = -2,
            True = -1,
            False = 0
        }
    }
}
