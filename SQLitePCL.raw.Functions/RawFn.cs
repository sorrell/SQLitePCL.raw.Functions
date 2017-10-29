using System;
using SQLitePCL.core.Functions;

namespace SQLitePCL.Functions
{
    public static class RawFn
    {
        public static void Init(sqlite3 dbcon)
        {
            raw.sqlite3_create_function(dbcon, "REGEXP", 2, null, RegexIsMatch_Func);
            raw.sqlite3_create_function(dbcon, "ISDATETIME", 2, null, DateIsValid_Func);
            raw.sqlite3_create_function(dbcon, "ISBOOL", 1, null, IsBool_Func);
            raw.sqlite3_create_function(dbcon, "ISBYTE", 1, null, IsByte_Func);
            raw.sqlite3_create_function(dbcon, "ISSBYTE", 1, null, IsSbyte_Func);
            raw.sqlite3_create_function(dbcon, "ISSHORT", 1, null, IsShort_Func);
            raw.sqlite3_create_function(dbcon, "ISUSHORT", 1, null, IsUshort_Func);
            raw.sqlite3_create_function(dbcon, "ISINT", 1, null, IsInt_Func);
            raw.sqlite3_create_function(dbcon, "ISUINT", 1, null, IsUint_Func);
            raw.sqlite3_create_function(dbcon, "ISLONG", 1, null, IsLong_Func);
            raw.sqlite3_create_function(dbcon, "ISULONG", 1, null, IsUlong_Func);
            raw.sqlite3_create_function(dbcon, "ISFLOAT", 1, null, IsFloat_Func);
            raw.sqlite3_create_function(dbcon, "ISDOUBLE", 1, null, IsDouble_Func);
            raw.sqlite3_create_function(dbcon, "ISDECIMAL", 1, null, IsDecimal_Func);
            raw.sqlite3_create_function(dbcon, "ISCHAR", 1, null, IsChar_Func);
            raw.sqlite3_create_function(dbcon, "ISGUID", 1, null, IsGuid_Func);
            raw.sqlite3_create_function(dbcon, "ISISOTIMESPAN", 1, null, IsISO8610Timespan_Func);
            raw.sqlite3_create_function(dbcon, "ISDOTNETTIMESPAN", 1, null, IsDotNetTimespan_Func);
            raw.sqlite3_create_function(dbcon, "ISNONPOSINT", 1, null, IsNonPositiveInt_Func);
            raw.sqlite3_create_function(dbcon, "ISNONNEGINT", 1, null, IsNonNegativeInt_Func);
            raw.sqlite3_create_function(dbcon, "ISPOSINT", 1, null, IsPositiveInt_Func);
            raw.sqlite3_create_function(dbcon, "ISNEGINT", 1, null, IsNegativeInt_Func);
            raw.sqlite3_create_function(dbcon, "ISURI", 2, null, IsUri_Func);
            raw.sqlite3_create_function(dbcon, "DATECHK", 4, null, DateCompare_Func);
            raw.sqlite3_create_function(dbcon, "COMPARE", 4, null, CompareVals_Func);
            raw.sqlite3_create_function(dbcon, "UUID", 0, null, GetUuid_Func);
            raw.sqlite3_create_function(dbcon, "ROW_NUMBER", 1, null, GetRowNumber_Func);
        }

        private static void RegexIsMatch_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var regexStr = raw.sqlite3_value_text(args[1]);
            var result = Convert.ToInt32(CoreFn.RegexIsMatch(val, regexStr));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void DateIsValid_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var dateFmt = raw.sqlite3_value_text(args[1]);
            var result = Convert.ToInt32(CoreFn.DateIsValid(val, dateFmt));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsBool_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsBool(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsUri_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var uriType = raw.sqlite3_value_text(args[1]);
            var result = Convert.ToInt32(CoreFn.IsUri(val, uriType));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsInt_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsInt(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsUint_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsUint(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsLong_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsLong(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsUlong_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsUlong(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsByte_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsByte(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsSbyte_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsSbyte(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsShort_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsShort(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsUshort_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsUshort(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsFloat_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsFloat(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsDouble_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsDouble(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsDecimal_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsDecimal(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsChar_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsChar(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsISO8610Timespan_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsISO8601Timespan(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsDotNetTimespan_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsDotNetTimespan(val));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void IsGuid_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsGuid(val));
            raw.sqlite3_result_int(ctx, result);
        }


        private static void DateCompare_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val1 = raw.sqlite3_value_text(args[0]);
            var dateFmt = raw.sqlite3_value_text(args[1]);
            var operation = raw.sqlite3_value_text(args[2]);
            var val2 = raw.sqlite3_value_text(args[3]);
            var result = Convert.ToInt32(CoreFn.DateCompare(val1, dateFmt, operation, val2));
            raw.sqlite3_result_int(ctx, result);
        }

        // Comparison Functions
        private static void CompareVals_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var a = raw.sqlite3_value_text(args[0]);
            var comparator = raw.sqlite3_value_text(args[1]);
            var b = raw.sqlite3_value_text(args[2]);
            var colType = raw.sqlite3_value_text(args[3]);
            var result = Convert.ToInt32(CoreFn.CompareVals(a, comparator, b, colType));
            raw.sqlite3_result_int(ctx, result);
        }

        private static void GetUuid_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            raw.sqlite3_result_text(ctx, CoreFn.GetGuid().ToString());
        }

        private static void GetRowNumber_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var key = raw.sqlite3_value_text(args[0]);
            raw.sqlite3_result_int(ctx, CoreFn.GetRowNumber(key));
        }

        // XML specific functions
        private static void IsNonPositiveInt_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsNonPositiveInt(val));
            raw.sqlite3_result_int(ctx, result);
        }
        private static void IsNonNegativeInt_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsNonNegativeInt(val));
            raw.sqlite3_result_int(ctx, result);
        }
        private static void IsPositiveInt_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsPositiveInt(val));
            raw.sqlite3_result_int(ctx, result);
        }
        private static void IsNegativeInt_Func(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            var val = raw.sqlite3_value_text(args[0]);
            var result = Convert.ToInt32(CoreFn.IsNegativeInt(val));
            raw.sqlite3_result_int(ctx, result);
        }
    }
}