/* Write your T-SQL query statement below */
SELECT firstName , lastName ,city ,state from Person LEFT JOIN Address on Person.personId =Address.personId