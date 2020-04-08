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
        public IEnumerable<Models.Blog> Get()
        {
            List<Models.Blog> lists = _context.Blog
                    .Where(e=>e.isActive==true)
                    .ToList();

            return lists;
        }
    }
}
