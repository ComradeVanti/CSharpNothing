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

    }

}