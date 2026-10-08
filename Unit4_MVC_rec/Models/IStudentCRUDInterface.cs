using System.Collections.Generic;

namespace Unit4_MVC_rec.Models
{
    public interface IStudentCRUDInterface
    {
        List<IStudentInterface> getAllStudents();
        IStudentInterface? getStudentById(int id);
        IStudentInterface getOneStudent(int index);
        void AddStudent(IStudentInterface newStudent);
        void UpdateStudent(int studentId, IStudentInterface updatedStudent);
        void DeleteStudent(int studentId);
    }
}