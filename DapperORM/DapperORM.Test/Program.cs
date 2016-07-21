using DapperORM.Core.Entities;

namespace DapperORM.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }


        public static void Test()
        {
            var user = new User();
            user.UserId = 11;
            user.UserName = "test";
            
        }
    }
}
