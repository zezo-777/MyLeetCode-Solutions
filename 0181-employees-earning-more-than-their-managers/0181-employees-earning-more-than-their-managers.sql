/* Write your T-SQL query statement below */
SELECT E.Name as Employee
 FROM Employee E 
JOIN Employee M 
ON  M.id = E.managerId 
WHERE (E.salary>M.salary)

