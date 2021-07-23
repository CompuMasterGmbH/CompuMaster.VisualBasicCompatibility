using System;

namespace CompuMaster.VisualBasicCompatibility
{
    public static class Information
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

        public enum VariantType : int
        {
            Array = 8192,
            Boolean = 11,
            Byte = 17,
            Char = 18,
            Currency = 6,
            DataObject = 13,
            Date = 7,
            Decimal = 14,
            Double = 5,
            Empty = 0,
            Error = 10,
            Integer = 3,
            Long = 20,
            Null = 1,
            Object = 9,
            Short = 2,
            Single = 4,
            String = 8,
            UserDefinedType = 36,
            Variant = 12
        }
    }
}
