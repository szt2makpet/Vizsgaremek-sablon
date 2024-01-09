using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
            };
            List<GepAdatok> gepek = new List<GepAdatok>
            {
                new GepAdatok
                {
                    Id=Guid.NewGuid(),
                    Gepneve="B-550",
                    Foglaltturista=23,
                    Foglalt1oszt=43,
                    Elsoosztulohelyek=7,
                    Turistaulohelyek = 45
                },
                new GepAdatok
                {
                    Id=Guid.NewGuid(),
                    Gepneve="ZF-870",
                    Foglaltturista=43,
                    Foglalt1oszt=63,
                    Elsoosztulohelyek=4,
                    Turistaulohelyek = 12
                }
            };

            // Students
            modelBuilder.Entity<Student>().HasData(students);

            // GépAdatok
            modelBuilder.Entity<GepAdatok>().HasData(gepek);

        }
    }
}
