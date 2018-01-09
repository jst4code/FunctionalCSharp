using System;

namespace Jst4Code.FunctionalCS
{
	public static class PartialFuncExtensions
	{
		#region Partial<T1, T2, TResult>
		
        public static Func<T2, TResult> Partial<T1, T2, TResult>(
            this Func<T1, T2, TResult> function, T1 value1) =>
                (value2) => function(value1, value2);
		
		#endregion
		
		#region Partial<T1, T2, T3, TResult>
		
        public static Func<T3, TResult> Partial<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> function, T1 value1, T2 value2) =>
                (value3) => function(value1, value2, value3);
		
        public static Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> function, T1 value1) =>
                (value2, value3) => function(value1, value2, value3);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, TResult>
		
        public static Func<T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4) => function(value1, value2, value3, value4);
		
        public static Func<T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function, T1 value1, T2 value2) =>
                (value3, value4) => function(value1, value2, value3, value4);
		
        public static Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function, T1 value1) =>
                (value2, value3, value4) => function(value1, value2, value3, value4);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, TResult>
		
        public static Func<T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5) => function(value1, value2, value3, value4, value5);
		
        public static Func<T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5) => function(value1, value2, value3, value4, value5);
		
        public static Func<T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5) => function(value1, value2, value3, value4, value5);
		
        public static Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function, T1 value1) =>
                (value2, value3, value4, value5) => function(value1, value2, value3, value4, value5);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, TResult>
		
        public static Func<T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6) => function(value1, value2, value3, value4, value5, value6);
		
        public static Func<T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6) => function(value1, value2, value3, value4, value5, value6);
		
        public static Func<T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6) => function(value1, value2, value3, value4, value5, value6);
		
        public static Func<T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6) => function(value1, value2, value3, value4, value5, value6);
		
        public static Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6) => function(value1, value2, value3, value4, value5, value6);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, TResult>
		
        public static Func<T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7) => function(value1, value2, value3, value4, value5, value6, value7);
		
        public static Func<T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
		
        public static Func<T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
		
        public static Func<T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
		
        public static Func<T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
		
        public static Func<T2, T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7) => function(value1, value2, value3, value4, value5, value6, value7);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
		
        public static Func<T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
		
        public static Func<T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
		
        public static Func<T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
		
        public static Func<T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
		
        public static Func<T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
		
        public static Func<T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8) => function(value1, value2, value3, value4, value5, value6, value7, value8);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
		
        public static Func<T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
		
        public static Func<T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
		
        public static Func<T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
		
        public static Func<T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
		
        public static Func<T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
		
        public static Func<T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
		
        public static Func<T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
		
        public static Func<T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
        public static Func<T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
        public static Func<T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
        public static Func<T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
        public static Func<T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
        public static Func<T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
        public static Func<T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
		
        public static Func<T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
		
        public static Func<T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
		
        public static Func<T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
		
        public static Func<T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
		
        public static Func<T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) =>
                (value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15);
		
		#endregion
		
		#region Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
		
        public static Func<T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14, T15 value15) =>
                (value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13, T14 value14) =>
                (value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12, T13 value13) =>
                (value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11, T12 value12) =>
                (value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10, T11 value11) =>
                (value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9, T10 value10) =>
                (value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8, T9 value9) =>
                (value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8) =>
                (value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7) =>
                (value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6) =>
                (value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5) =>
                (value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3, T4 value4) =>
                (value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2, T3 value3) =>
                (value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1, T2 value2) =>
                (value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 value1) =>
                (value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16) => function(value1, value2, value3, value4, value5, value6, value7, value8, value9, value10, value11, value12, value13, value14, value15, value16);
		
		#endregion
		
	}
}