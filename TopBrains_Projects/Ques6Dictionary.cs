/*
Question
6
Dictionary
Description
Dictionary Lookup
Given a dictionary of (EmployeeId, Salary) and a list of EmployeeIds, return the total salary.

Input
Ids: {1, 4, 5}
Dictionary: {1:20000, 4:40000, 5:15000}

Output
75000
*/
using System;
using System.Collections.Generic;

class Dict
{
    static void Main()
    {
        // Dictionary of EmployeeId and Salary
        Dictionary<int, int> salaryDict = new Dictionary<int, int>()
        {
            { 1, 20000 },
            { 4, 40000 },
            { 5, 15000 }
        };

        // List of Employee Ids
        List<int> ids = new List<int> { 1, 4, 5 };

        int totalSalary = 0;

        foreach (int id in ids)
        {
            if (salaryDict.ContainsKey(id))
            {
                totalSalary += salaryDict[id];
            }
        }

        Console.WriteLine(totalSalary);
    }
}
