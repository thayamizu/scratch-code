using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreRelationSample.Models
{
    /// <summary>
    /// Blogエンティティ
    /// </summary>
    public class Blog
    {
        /// <summary>
        /// Id
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        /// <value></value>
        public string Title { get; set; }
        
        /// <summary>
        /// URL
        /// </summary>
        /// <value></value>
        public string Url { get; set; }

        /// <summary>
        /// isActive
        /// </summary>
        /// <value></value>
        public bool isActive { get; set; }

        /// <summary>
        /// Posts 
        /// </summary>
        /// <value></value>
        public List<Post> Posts { get; set; }

    }
}