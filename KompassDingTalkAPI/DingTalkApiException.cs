using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompassDingTalkAPI
{
    public class DingTalkApiException : Exception
    {
        private readonly int _code;

        public DingTalkApiException()
        {
        }

        public DingTalkApiException(string message) : base(message)
        {
        }

        public DingTalkApiException(int code, string message) : base(message)
        {
            _code = code;
        }

        public DingTalkApiException(int code, string message, Exception innerException) : base(message, innerException)
        {
            _code = code;
        }

        public override string ToString()
        {
            if (_code == 0) return base.ToString();
            return "ErrorCode:" + _code + Environment.NewLine + base.ToString();
        }
    }
}
