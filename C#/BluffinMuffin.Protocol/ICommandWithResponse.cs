using System;
using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface ICommandWithResponse<out TResponse> where TResponse : IResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        TResponse Response(bool success, BluffinMessageId msgId, string message);
    }

    /// <summary>
    /// 
    /// </summary>
    public static class ExtensionsICommandWithResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static TResponse ResponseSuccess<TResponse>(this ICommandWithResponse<TResponse> cmd) where TResponse : IResponse
        {
            return cmd.Response(true, BluffinMessageId.None, String.Empty);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="cmd"></param>
        /// <param name="msgId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static TResponse ResponseSuccess<TResponse>(this ICommandWithResponse<TResponse> cmd, BluffinMessageId msgId, string message) where TResponse : IResponse
        {
            return cmd.Response(true, msgId, message);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="cmd"></param>
        /// <param name="msgId"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static TResponse ResponseFailure<TResponse>(this ICommandWithResponse<TResponse> cmd, BluffinMessageId msgId, string message) where TResponse : IResponse
        {
            return cmd.Response(false, msgId, message);
        }
    }
}
