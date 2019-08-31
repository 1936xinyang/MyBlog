using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Infrastructure.Logging
{
    public interface ILogger
    {
        void Log(string message);
    }
}
