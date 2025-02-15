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
    }
}
