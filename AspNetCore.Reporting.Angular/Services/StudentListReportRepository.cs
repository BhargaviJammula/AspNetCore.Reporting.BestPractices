using System;
using System.Collections.Generic;
using System.Linq;
using AspNetCore.Reporting.Angular.Data;
using AspNetCore.Reporting.Common.Models;

namespace AspNetCore.Reporting.Common.Services {
    public class StudentListReportRepository
    {
        readonly IScopedDbContextProvider<SchoolDbContext> scopedDbContextProvider;

        public StudentListReportRepository() {
            // We use this parameterless constructor in the Data Source Wizard only, and not for the actual instantiation of the repository object.
            throw new NotSupportedException();
        }

        public StudentListReportRepository(IScopedDbContextProvider<SchoolDbContext> scopedDbContextProvider) {
            this.scopedDbContextProvider = scopedDbContextProvider ?? throw new ArgumentNullException(nameof(scopedDbContextProvider));
        }

        public IList<StudentDetailsModel> GetStudents()
        {
            using (var dbContextScope = scopedDbContextProvider.GetDbContextScope())
            {
                var dbContext = dbContextScope.DbContext;
                var model = dbContext.Students.Select(x =>
                    new StudentDetailsModel
                    {
                        StudentID = x.Id,
                        FirstMidName = x.FirstMidName,
                        LastName = x.LastName,
                        City = x.City
                    })
                    .ToList();
                return model;
            }
        }
    }
}
