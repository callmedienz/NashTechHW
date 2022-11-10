 select * from employees e
 select * from departments d

--bai 1 
Select distinct last_name, hire_date  
from [dbo].[employees] 
where department_id in
(select department_id from employees where last_name = 'Zlotkey') and last_name = 'Zlotkey'

--bai 2
Select distinct employee_id, last_name, salary 
from [dbo].[employees] 
where salary > (select avg(salary) from [dbo].[employees])  
order by salary asc;  

--bai 3 
select employee_id, last_name
from employees 
Where department_id in (select department_id from employees where last_name like '%u%')

--bai 4
select last_name, e.department_id, job_id FROM employees e
JOIN departments d on e.department_id = d.department_id
where d.location_id = 1700;

--bai them 
select e.last_name, e.department_id, e.job_id
from employees e 
join departments d on e.department_id = d.department_id
join locations l on l.location_id = d.location_id
where city = 'Seattle'

--bai 5
Select last_name, salary from employees
where manager_id in (select employee_id from employees where last_name = 'King');

--bai 6
select  department_id,last_name, job_id
from employees
where department_id in
(select department_id from departments where department_name = 'Executive')

--bai 7
Select distinct employee_id, last_name, salary 
from [dbo].[employees] 
where salary > (select avg(salary) from [dbo].[employees])  
union
select employee_id, last_name
from employees 
Where department_id in (select department_id from employees where last_name like '%u%')



--bai 8
select cast(MAX(salary)as numeric) as Maximum, 
cast(MIN(salary)as numeric) as Minimum, 
cast(SUM(salary)as numeric) as Sum,
cast(AVG(salary)as numeric) as Average
from employees

--bai9
SELECT Upper(last_name) as "Last Name",
LEN(last_name) as "Length"
FROM employees
WHERE last_name LIKE 'J%'
OR last_name LIKE 'M%'
OR last_name LIKE 'A%'
ORDER BY last_name ;

--bai10
select employee_id, 
last_name, 
salary, 
Cast(salary*(1+15.5/100) as numeric(10,0)) AS "New Salary"
from employees;

--bai 11
select last_name, department_id null as department_name from employees
union

--bai 12