using MongoDB.Driver;
using MongoDB.Bson;
using WebApplication2.Model;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApplication2.Classes

{
    public class EmployeeClass
    {
        Connection db = new Connection();
        public void Add(Employee employee)
        {
            db.Employee().InsertOne(employee);
        }
        public List<EmployeeDto> list() 
        {
            List<Employee> emp = db.Employee().Find(FilterDefinition<Employee>.Empty).ToList();
            var employeeDtos = emp.Select(e => new EmployeeDto
            {
                id = e.id.ToString(), 
                name = e.name,
                age= e.age,
                salary = e.salary,

            }).ToList();

            return employeeDtos;
        }
        public void update(ObjectId id , Employee employee) 
        {
            Employee oldemployee = db.Employee().Find(e => e.id == id).FirstOrDefault();

            var update = Builders<Employee>.Update
                .Set(e => e.name , employee.name)
                .Set(e => e.age, employee.age)
                .Set(e => e.salary, employee.salary);

            var filter = Builders<Employee>.Filter.Eq(e => e.id , oldemployee.id);

            db.Employee().UpdateOne(filter, update);
        }
        public void delete(ObjectId id) 
        {
            Employee emp = db.Employee().Find(e => e.id == id ).FirstOrDefault();
            var filter = Builders<Employee>.Filter.Eq(e => e.id , emp.id);

            db.Employee().DeleteOne(filter);
        }
    }
}
