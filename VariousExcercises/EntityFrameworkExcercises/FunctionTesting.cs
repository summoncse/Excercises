﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkExcercises.Entities;

namespace EntityFrameworkExcercises
{
    [TestClass]
    public class FunctionTesting
    {
        [TestMethod]
        public void GetStudentWithNavigationPro()
        {
            using (var context = new MyDbContext())
            {
                var st = context.Students
                                .Include(i=> i.StudentSubjects)
                                    .ThenInclude(i=> i.Subject)
                                .ToList();       
            }
        }

        [TestMethod]
        public void Update()
        {
            using (var context = new MyDbContext())
            {
                var st = context.Students.Single(i=> i.Id == 1);
                st.SetFirstName("Mofaggol23");

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void Insert()
        {
            using (var context = new MyDbContext())
            {
                var st = new Student(firstName: "Matthias", lastName: "Stahl", department: "GroupWare", university: "Quipu");

                context.Students.Add(st);

                context.SaveChanges();
            }
        }

    }
}
