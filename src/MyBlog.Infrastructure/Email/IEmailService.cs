using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Infrastructure.Email
{
    public interface IEmailService
    {
        void SendMail(string from, string to, string subject, string body);
    }
}
