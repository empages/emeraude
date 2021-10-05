using System.Collections.Generic;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.EmPages.Schema
{
    /// <summary>
    /// Contract of value pipe. Pipe is value interceptor that converts specified data by using specific context logic provided by the implementation class.
    /// </summary>
    public interface IValuePipe
    {
        /// <summary>
        /// Prepares pipe cache for data management optimization.
        /// </summary>
        /// <param name="targetObjects"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task PrepareAsync(IEnumerable<object> targetObjects, string[] parameters);

        /// <summary>
        /// Converts specified value based on the context logic of the pipe.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        Task<object> ConvertAsync(object value);
    }
}