using System;
using System.Collections.Generic;

namespace ServiceStack.Redis.Interception
{
    public static class CommandInterceptor
    {
        public static Func<RedisNativeClient, byte[][], byte[][]> InterceptSendCommand = null;

        public static Func<RedisNativeClient, int, int> InterceptSafeReadByte = null;

        public static Func<RedisNativeClient, IList<ArraySegment<byte>>, IList<ArraySegment<byte>>> InterceptFlushSendBuffer = null;


        public static Dictionary<string, string> GetState()
        {
            return new Dictionary<string, string>
            {
                { "InterceptSendCommand", (InterceptSendCommand != null).ToString() },
                { "InterceptSafeReadByte", (InterceptSafeReadByte != null).ToString() },
                { "InterceptFlushSendBuffer", (InterceptFlushSendBuffer != null).ToString() },
            };
        }
    }
}