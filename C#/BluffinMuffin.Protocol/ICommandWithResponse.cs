using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffinMuffin.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface ICommandWithResponse<TResponse> where TResponse : IResponse
    {
    }
}
