using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTable.Models.DBModels;
using System.Data.Entity;
using System.Windows;

namespace TimeTable.Models
{
    class DatabaseProvider
    {
        private DatabaseContext _dbContext = new DatabaseContext();

        #region Groups
        public IList<Group> GetGroups()
            => _dbContext.Groups.ToList();

        public Group GetGroup(string name)
         => _dbContext.Groups.Where(g => g.Name == name).FirstOrDefault();



        public void RemoveGroup(string name)
        {
            var group = _dbContext.Groups.Where(g => g.Name == name).FirstOrDefault();
            _dbContext.Groups.Remove(group);
            _dbContext.SaveChanges();
        }
        public void updateGroup(string name, string newName, int population)
        {
            var group = _dbContext.Groups.Where(g => g.Name == name).FirstOrDefault();
            group.Name = newName;
            group.Population = population;
            _dbContext.SaveChanges();
        }
        #endregion

        #region Disciplines

        public IList<Discipline> GetDisciplines()
            => _dbContext.Disciplines.ToList();

        public Discipline GetDiscipline(string name)
         => _dbContext.Disciplines.Where(d => d.Name == name).FirstOrDefault();



        public void RemoveDiscipline(string name)
        {
            var discipline = _dbContext.Disciplines.Where(d => d.Name == name).FirstOrDefault();
            _dbContext.Disciplines.Remove(discipline);
            _dbContext.SaveChanges();
        }
        public void updateDiscipline(string name, string newName, int population)
        {
            var discipline = _dbContext.Disciplines.Where(d => d.Name == name).FirstOrDefault();
            discipline.Name = newName;
            _dbContext.SaveChanges();
        }

        #endregion

        #region Hours

        public IList<Hour> GetHours()
            => _dbContext.Hours.ToList();

        public Hour GetHour(string groupName)
        {
           return _dbContext.Hours.Where(h => h.Group.Name == groupName).FirstOrDefault();
        } 

        public void RemoveHour(string groupName, string disciplineName)
        {
            var hour = _dbContext.Hours.Where(h => h.Group.Name == groupName && h.Discipline.Name == disciplineName).FirstOrDefault();
            _dbContext.Hours.Remove(hour);
            _dbContext.SaveChanges();
        }
        public void updateHour(string groupName, string disciplineName, int newHours)
        {
            var hour = _dbContext.Hours.Where(h => h.Group.Name == groupName && h.Discipline.Name == disciplineName).FirstOrDefault();
            hour.Hours = newHours;
            _dbContext.SaveChanges();
        }
        #endregion

        #region Teachers
        public IList<Teacher> GetTeachers()
            => _dbContext.Teachers.ToList();

        public Teacher GetTeacher(string name)
         => _dbContext.Teachers.Where(d => d.Name == name).FirstOrDefault();

        public void RemoveTeacher(string name)
        {
            var teacher = _dbContext.Teachers.Where(d => d.Name == name).FirstOrDefault();
            _dbContext.Teachers.Remove(teacher);
            _dbContext.SaveChanges();
        }
        public void updateTeacher(string name, string newName)
        {
            var teacher = _dbContext.Teachers.Where(d => d.Name == name).FirstOrDefault();
            teacher.Name = newName;
            _dbContext.SaveChanges();
        }
        public void updateTeacher(string name, int newLoad)
        {
            var teacher = _dbContext.Teachers.Where(d => d.Name == name).FirstOrDefault();
            teacher.Load = newLoad;
            _dbContext.SaveChanges();
        }
        #endregion
    }
}

