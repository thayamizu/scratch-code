using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EntityFrameworkCoreRelationSample.Models;

namespace EntityFrameworkCoreRelationSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly EntityFrameworkCoreRelationSample.Models.BlogContext _context;

        /// <summary>
        /// ロガー
        /// </summary>
        private readonly ILogger<BlogController> _logger;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="context"></param>
        /// <param name="logger"></param>
        public BlogController(EntityFrameworkCoreRelationSample.Models.BlogContext context, ILogger<BlogController> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<dynamic> Get()
        {
            var lists = from blog in _context.Blog
                        join post in _context.Post
                        on blog.Id equals post.BlogId into temp
                        from selects in temp.DefaultIfEmpty()
                        select new
                        {
                            BlogId = blog.Id,
                            PostId = selects.Id,
                            Contents = selects.Contents
                        };

            return lists;
        }
    }
}
