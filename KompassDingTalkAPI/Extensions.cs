using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI
{
    public static class Extensions
    {
        /// <summary>
        ///     替换字符串,支持大小写忽略
        /// </summary>
        /// <param name="source">字符串</param>
        /// <param name="oldString">需要替换的字符串</param>
        /// <param name="newString">新字符串</param>
        /// <param name="comp"></param>
        /// <returns></returns>
        public static string Replace(this string source, string oldString, string newString,
            StringComparison comp = StringComparison.CurrentCultureIgnoreCase)
        {
            var index = source.IndexOf(oldString, comp);

            var matchFound = index >= 0;

            if (matchFound)
            {
                source = source.Remove(index, oldString.Length);
                source = source.Insert(index, newString);
            }

            if (source.IndexOf(oldString, comp) != -1) source = Replace(source, oldString, newString, comp);
            return source;
        }

        /// <summary>
        /// 如果不成功则抛出异常
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        public static void ThrowExceptionIfNotSuccess<T>(T data) where T : ApiResultBase, new()
        {
            if (data != null && !data.IsSuccess())
            {
                throw new DingTalkApiException(data.ErrorCode, data.ErrorMessage);
            }
        }
    }
}
