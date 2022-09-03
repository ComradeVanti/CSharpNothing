using System;
using System.Threading.Tasks;

namespace Dev.ComradeVanti
{

    /// <summary>
    ///     Contains useful extension methods
    /// </summary>
    public static class Ext
    {

        /// <summary>
        ///     Converts an empty task to a task of nothing
        /// </summary>
        /// <param name="task">The task to convert</param>
        /// <returns>The task with nothing as its result</returns>
        public static async Task<Nothing> ToNothingTask(this Task task)
        {
            await task;
            return Nothing.atAll;
        }

        /// <summary>
        ///     Converts an action to a function which returns nothing
        /// </summary>
        /// <param name="action">The action</param>
        /// <returns>The function</returns>
        public static Func<Nothing> ToNothingFunc(this Action action) =>
            () =>
            {
                action();
                return Nothing.atAll;
            };

        /// <summary>
        ///     Converts an action to a function which returns nothing
        /// </summary>
        /// <param name="action">The action</param>
        /// <typeparam name="T1">The first parameter type</typeparam>
        /// <returns>The function</returns>
        public static Func<T1, Nothing> ToNothingFunc<T1>(this Action<T1> action) =>
            p1 =>
            {
                action(p1);
                return Nothing.atAll;
            };

        /// <summary>
        ///     Converts an action to a function which returns nothing
        /// </summary>
        /// <param name="action">The action</param>
        /// <typeparam name="T1">The first parameter type</typeparam>
        /// <typeparam name="T2">The second parameter type</typeparam>
        /// <returns>The function</returns>
        public static Func<T1, T2, Nothing> ToNothingFunc<T1, T2>(this Action<T1, T2> action) =>
            (p1, p2) =>
            {
                action(p1, p2);
                return Nothing.atAll;
            };

        /// <summary>
        ///     Converts an action to a function which returns nothing
        /// </summary>
        /// <param name="action">The action</param>
        /// <typeparam name="T1">The first parameter type</typeparam>
        /// <typeparam name="T2">The second parameter type</typeparam>
        /// <typeparam name="T3">The third parameter type</typeparam>
        /// <returns>The function</returns>
        public static Func<T1, T2, T3, Nothing> ToNothingFunc<T1, T2, T3>(this Action<T1, T2, T3> action) =>
            (p1, p2, p3) =>
            {
                action(p1, p2, p3);
                return Nothing.atAll;
            };

    }

}