using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Company
/// </summary>
public class Company
{

    public string Title { get; set; }
    public List<Employee> Employees { get; set; }

}

public class Employee
{
    public string Name { get; set; }
    public EmployeeType EmployeeType { get; set; }
}


public enum EmployeeType
{
    CEO,
    Developer
}