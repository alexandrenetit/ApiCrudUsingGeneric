using System;
using System.Collections.Generic;
using System.Linq;
using ApiCrudUsingGeneric.IService;
using ApiCrudUsingGeneric.Models;

namespace ApiCrudUsingGeneric.Service
{
    public class TeacherService : IGenericService<Teacher>
    {
        List<Teacher> _teachers = new List<Teacher>();

        public TeacherService()
        {
            for (int i = 1; i < 9; i++)
            {
                _teachers.Add(new Teacher
                {
                    TeacherId = i,
                    Name = "Stu" + i,
                    Subject = "Sub" + i
                });
            }
        }

        public List<Teacher> Delete(int id)
        {
            _teachers.RemoveAll(x => x.TeacherId == id);
            return _teachers;
        }

        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public Teacher GetById(int id)
        {
            return _teachers.Where(x => x.TeacherId == id).SingleOrDefault();
        }

        public List<Teacher> Insert(Teacher item)
        {
            _teachers.Add(item);
            return _teachers;
        }
    }
}