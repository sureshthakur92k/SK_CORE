using SK_CORE.Models;

namespace SK_CORE.Repository
{
    public interface IStudent
    {
      public  List<Student> GetAllStudent();
        public Student GetStudentById(int Id);
    }
}
