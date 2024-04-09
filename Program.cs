namespace ConsoleAppreflection;
    using System;

public class CapacityLimitException : Exception
{
    public CapacityLimitException() : base("Capacitylimit exceptiondur") { }
}

public interface IPerson
{
    string Name { get; set; }
    int Age { get; set; }
    string ShowInfo();
}

public class Employee : IPerson
{
    private static int _idCounter = 0;

    public string Name { get; set; }
    public int Age { get; set; }
    public int Id { get; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Id = _idCounter++;
    }

    public string ShowInfo()
    {
        return $"ID: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}

public class Department
{
    private string _name;
    private int _employeeLimit;
    private Employee[] _employees;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int EmployeeLimit
    {
        get { return _employeeLimit; }
        set { _employeeLimit = value; }
    }

    public Employee[] Employees
    {
        get { return _employees; }
    }

    public Department(string name, int employeeLimit)
    {
        _name = name;
        _employeeLimit = employeeLimit;
        _employees = new Employee[_employeeLimit];
    }

    public void AddEmployee(Employee employee)
    {
        bool isEmployeeAdded = false;
        for (int i = 0; i < _employees.Length; i++)
        {
            if (_employees[i] == null)
            {
                _employees[i] = employee;
                isEmployeeAdded = true;
                break;
            }
        }

        if (!isEmployeeAdded)
        {
            throw new CapacityLimitException();
        }
    }

    public Employee this[int index]
    {
        get
        {
            if (index < 0 || index >= _employees.Length)
            {
                throw new IndexOutOfRangeException("Index artiqdir");
            }
            return _employees[index];
        }
        set
        {
            if (index < 0 || index >= _employees.Length)
            {
                throw new IndexOutOfRangeException("Index sehvdir");
            }
            _employees[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Department department = new Department("IT", 3);
            Employee employee1 = new Employee("John", 30, 5);
            Employee employee2 = new Employee("Alice", 25, 6);
            Employee employee3 = new Employee("Bob", 35, 70);
            Employee employee4 = new Employee("Emily", 28, 550);

            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
      
            department.AddEmployee(employee4);
        }
        catch (CapacityLimitException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


