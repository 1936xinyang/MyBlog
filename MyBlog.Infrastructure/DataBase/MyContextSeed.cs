using Microsoft.Extensions.Logging;
using MyBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.DataBase
{
    public class MyContextSeed
    {
        public static async Task SeedAsync(MyContext mycontext, ILoggerFactory loggerFactory, int retry = 0)
        {
            int retryForAvailability = retry;
            try
            {
                if (!mycontext.Posts.Any())
                {
                    mycontext.Posts.AddRange(new List<Post> {
                    new Post{
                    Title="Title1",
                     Author="Author1",
                     Body="Body1",
                      LastModified=DateTime.Now
                    },
                    new Post{
                    Title="Title2",
                     Author="Author2",
                     Body="Body2",
                      LastModified=DateTime.Now
                    }
                });
                    await mycontext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                    retryForAvailability++;
                var logger = loggerFactory.CreateLogger<MyContextSeed>();
                logger.LogError(ex.Message);
                await SeedAsync(mycontext, loggerFactory, retryForAvailability);
            }
        }
    }
}
