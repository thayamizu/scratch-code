using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreRelationSample.Models
{   

    /// <summary>
    /// BlogContext
    /// </summary>
    public class BlogContext: DbContext
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="options"></param>
        public BlogContext(DbContextOptions<BlogContext> options)
            :   base(options) 
        {

        }

        ///<summary>
        /// モデル生成時に呼ばれるライフサイクルメソッド
        ///</summary>
        ///<param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // データのシードを定義
            modelBuilder.Entity<Blog>().HasData(
                new {Id = 1, Title="ブログ村1", Url="https://xxx.yyy.zzz", isActive=true, },
                new {Id = 2, Title="ブログ村2", Url="https://aaa.bbb.ccc", isActive=true, },
                new {Id = 3, Title="ブログ村3", Url="https://ddd.eee.fff", isActive=false, }
            );

            modelBuilder.Entity<Post>().HasData(
                new {Id = 1, Title="エントリ", Contents="foobar", BlogId=1, },
                new {Id = 2, Title="エントリ", Contents="hogehoge", BlogId=1, },
                new {Id = 3, Title="エントリ", Contents="piyopiyo", BlogId=2, }
            );
            
        }

        /// <summary>
        /// DbSet
        /// </summary>
        /// <value></value>
        public DbSet<Blog> Blog {get; set;}

        /// <summary>
        /// DbSet
        /// </summary>
        /// <value></value>
        public DbSet<Post> Post {get; set;}
    }   
}