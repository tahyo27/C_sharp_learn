using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    /*
    DbContextOptions<ApplicationDbContext> options
        -> EF Core가 데이터베이스 연결 정보를 포함한 다양한 설정을 전달할 때 사용됨.
           이 options 객체는 ApplicationDbContext가 어떻게 구성되어야 하는지를 설명
    :base(options)
        -> 이는 기본클래스인 DbContext의 생성자를 호출하여 options를 전달 이를통해 ApplicationDbContext가
           DbContext의 생성자에서 제공하는 기능을 사용할 수 있게 함
    */

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { 
                    Id = 1,
                    Title="Went Hiking",
                    Content="Went hiking with Joe!",
                    CreatedDate = new DateTime(2025, 2, 19, 13, 10, 30)
                },
                new DiaryEntry { 
                    Id = 2, 
                    Title = "Went Shopping", 
                    Content = "Went shopping with Joe!", 
                    CreatedDate = new DateTime(2025, 2, 19, 14, 10, 30)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Diving",
                    Content = "Went diving with Joe!",
                    CreatedDate = new DateTime(2025, 2, 19, 15, 10, 30)
                }
            );
        }

        // 테이블을 추가하는 4가지 스텝
        // 1. 모델 클래스를 만든다
        // 2. DB Set을 추가한다
        // 3. add-migration AddDiaryEntryTable
        // 4. 데이터베이스 업데이트
    }   
}
