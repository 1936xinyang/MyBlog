using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}
