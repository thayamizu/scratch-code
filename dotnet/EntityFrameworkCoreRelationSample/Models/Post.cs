using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreRelationSample.Models
{
    /// <summary>
    /// Postエンティティ
    /// </summary>
    public class Post
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
        /// Content
        /// </summary>
        /// <value></value>
        public string Contents { get; set; }

        /// <summary>
        /// Blog 
        /// </summary>
        /// <value></value>
        public int BlogId { get; set; } 
        
        /// <summary>
        /// Blog 
        /// </summary>
        /// <value></value>
        public Blog Blog { get; set; }

    }
}