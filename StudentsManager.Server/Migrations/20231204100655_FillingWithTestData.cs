using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsManager.Server.Migrations
{
    /// <inheritdoc />
    public partial class FillingWithTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                INSERT INTO Disciplines (Id, Category, Name)
                VALUES 
                  (NEWID(), 'Science', 'Physics'),
                  (NEWID(), 'Math', 'Calculus'),
                  (NEWID(), 'History', 'World History'),
                  (NEWID(), 'Language', 'English');

                INSERT INTO StudentsGroups (Id, Name)
                VALUES 
                  (NEWID(), 'Group A'),
                  (NEWID(), 'Group B'),
                  (NEWID(), 'Group C');

                INSERT INTO Teachers (Id, AcademicDegree, BirthDate, FirstName, Gender, LastName)
                VALUES 
                  (NEWID(), 'Ph.D.', '1980-01-15', 'John', 0, 'Doe'),
                  (NEWID(), 'M.Sc.', '1975-05-22', 'Jane', 1, 'Smith'),
                  (NEWID(), 'Ph.D.', '1982-11-10', 'Alex', 0, 'Johnson');

                INSERT INTO Students (Id, BirthDate, Course, FirstName, Gender, GroupId, LastName)
                VALUES 
                  (NEWID(), '1995-03-20', 3, 'Michael', 0, (SELECT Id FROM StudentsGroups WHERE Name = 'Group A'), 'Brown'),
                  (NEWID(), '1998-07-12', 2, 'Emma', 1, (SELECT Id FROM StudentsGroups WHERE Name = 'Group B'), 'Williams'),
                  (NEWID(), '1997-09-05', 4, 'Daniel', 0, (SELECT Id FROM StudentsGroups WHERE Name = 'Group C'), 'Jones');

                INSERT INTO StudentsGroupDisciplines (Id, DisciplineId, StudentsGroupId, TeacherId)
                VALUES 
                  (NEWID(), (SELECT Id FROM Disciplines WHERE Name = 'Physics'), (SELECT Id FROM StudentsGroups WHERE Name = 'Group A'), (SELECT Id FROM Teachers WHERE FirstName = 'John')),
                  (NEWID(), (SELECT Id FROM Disciplines WHERE Name = 'Calculus'), (SELECT Id FROM StudentsGroups WHERE Name = 'Group B'), (SELECT Id FROM Teachers WHERE FirstName = 'Jane')),
                  (NEWID(), (SELECT Id FROM Disciplines WHERE Name = 'World History'), (SELECT Id FROM StudentsGroups WHERE Name = 'Group C'), (SELECT Id FROM Teachers WHERE FirstName = 'Alex'));

            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
