namespace mvcRakuten.Models{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            /**
            modelBuilder.Entity<Student>().HasData(
                new Student { ID = 1, Name = "张三" },
                new Student { ID = 2, Name = "李四" },
                new Student { ID = 3, Name = "王五" });
                */
        }
    }
}