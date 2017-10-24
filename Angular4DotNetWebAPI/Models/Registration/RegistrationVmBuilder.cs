using Angular4DotNetWebAPI.Models.Courses;
using Angular4DotNetWebAPI.Models.Instructors;

namespace Angular4DotNetWebAPI.Models.Registration
{
    public class RegistrationVmBuilder
    {
        public CoursesVm[] GetCoursesVms()
        {
            var courses = new[]
            {
                new CoursesVm
                {
                    Number = "CREA101",
                    Name = "Care of magical creatures",
                    Instructor = "Rubeus Hagrid"
                },
                new CoursesVm
                {
                    Number = "DARK502",
                    Name = "Defence against the Dark Arts",
                    Instructor = "Servus Snape"
                },
                new CoursesVm
                {
                    Number = "TRAN201",
                    Name = "Transfiguration",
                    Instructor = "Minevra McGonagall"
                },
            };

            //converts to lowercase properties names 'Number' => 'number'
            //var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            //var serializedObject = JsonConvert.SerializeObject(courses, Formatting.None, settings);
            //return serializedObject;

            return courses;
        }
        public InstructorVm[] GetInstructorsVms()
        {
            var instructors = new[]
                {
                    new InstructorVm {Name = "Rubeus Hagrid", Email = "hagrid@hogwarts.com", RoomNumber = 1001},
                    new InstructorVm {Name = "Severus Snape", Email = "snape@hogwarts.com", RoomNumber = 105},
                    new InstructorVm {Name = "Minerva McGonagall", Email = "mcgonagall@hogwarts.com", RoomNumber = 102},
                };

            //var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            //var serializedInstructors = JsonConvert.SerializeObject(instructors, Formatting.None, settings);
            //return serializedInstructors;

            return instructors;
        }
    }
}