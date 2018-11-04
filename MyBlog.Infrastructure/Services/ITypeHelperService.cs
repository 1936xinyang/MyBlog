using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlog.Infrastructure.Services
{
    public interface ITypeHelperService
    {
        bool TypeHasProperties<T>(string fields);
    }
}
