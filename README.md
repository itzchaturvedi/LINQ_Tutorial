# LINQ_Tutorial

| Author      | Email                | GitHub                |
|-------------|----------------------|-----------------------|
| Priyanshu Kuldeep    |  itzchaturvedi@gmail.com   | [github.com/itzchaturvedi](https://github.com/itzchaturvedi) |


_ **LINQ** _

1. LINQ stands for Language Integrated Query.

2. LINQ in C# is used to work with data access from data sources such as objects, data sets, SQL Server, and XML etc.

3. LINQ is a data querying API with SQL like query syntaxes.

4. Microsoft's query language is fully integrated and offers easy data access from in-memory objects, collections, databases, XML docs, and many more.

5. LINQ allows writing queries even without the knowledge of query languages like SQL, XML etc.

6. It is through a set of extensions, LINQ ably integrates queries in C# and Visual Basic.

7. LINQ provides functions to query cached data from all kinds of data sources.

8. The data source could be a collection of objects, database or XML files.

9. It is introduced in C# version 3.0 as a major part of .NET framework 3.5 in 2007.

_From the point of view of SQL:_
 Select \* From mytable where age \> 20;

_From the point of view of LINQ:_

From i in age where i \> 20 select i

_ **Sorting the Result** _

_From the point of view of SQL_:

Select \* from mytable where age \> 20 order by age asc/desc

_From ther point of view of LINQ:_

From i in age where i \> 20 order by i select i (Ascending)

From i in age where i \> 20 orderby i descending select i (Descending)

1. Using System.Linq;
2. This namespace is compulsory when working with LINQ statements.
3. When we create a console app in visual studio System.Linq namespace is added by default.
4. If we don't provide this namespace compile time error will occur.

_ **Advantages of LINQ** _

1. LINQ offers an object-based, language-integrated way to query over data no matter where that data came from. So through LINQ we can query database, XML as well as collections.
2. Compile time syntax checking.
3. It allow u to query collections like array, enumerable classes etc in the native language of your application, like VB or C# in much the same way as you would query a database using SQL.
4. User does not need to learn new query languages for a different type of data source or data format.
5. It increases the readability of the code.
6. Query can be reused.
7. It gives type checking of the obj at compile time.
8. It provides IntelliSense for generic collections.
9. It can be used with array or collections.
10. LINQ supports filtering, sorting, ordering, grouping.
11. It makes easy debugging because it is integrated with C# language.
12. It provides easy transformation means you can easily convert one data type into another data type like transforming SQL data into XML data.

_ **LINQ TO SQL in C#** _

1. LINQ in C# is used to work with data access from data sources such as objects, data sets, SQL Server, and XML etc.

2. Previously Microsoft introduced SQL query language to interact with only one data source called SQL Server database.

3. But now Microsoft introduced LINQ query language than can be used wide variety of data sources.

4. LINQ is divided into several categories or you can say that there are different type of LINQ.

_ **Types of LINQ** _

1. LINQ to objects (Arrays, Collections)
2. LINQ to Databases ( LINQ to SQL, LINQ to ADO.NET, LINQ To Entities)
3. LINQ to XML (XML Files)

LINQ to Databases

- LINQ to SQL

1. It is a query language used in C# programming language, introduced in DotNet Framework 3.5
2. It is used for working with relational database management system eg – SQL Server.
3. But when we talk about **LINQ to Entites** then we can use different relational database management system like SQL Server, Orale and so on.
4. It is not just only about querying the data but it also allows us to perform CRUD operations like insert, update, delete and read operations from database.

C – Create – Insert

R – Read – Select

U – Update – Update

D – Delete – Delete

1. By using LINQ to SQL we can also work with stored procedures.
2. We have already a concept of ADO.NET by which we can interact with SQL Server with the help of ADO.NET.
3. Then why we should have to use LINQ over the ADO.NET

_ **Using ADO.NET With SQL Server** _

1. SQL Queries are checked during runtime.
  - Your SQL queries defined by ADO.NET's sqlcommand is executed by sql server database engine not by C# compiler.
  - When we writing sql queries using ADO.NET you might have noted that we write queries in double quotes, it means we have writing them as a string.
  - Strings are not compiled by C#, that string is sent to database engine and executed by that SQL server database engine.
  - Then database engine is going to verify that query is right or wrong, If query is wrong it will raise exception because exception are raised during runtime.
  - As a C# developer, it is not a best practice to put the extra burden to database engine.
2. No intelliSense support

- Because all work are done by the database engine so that's why C# compiler did not know what intelliSense should be displayed to a developer.

3. It is not type safe.

- In this case, you need to know all the columns and its data types.

4. Debugging of SQL statements will be a nightmare.

- SQL queries are present in " " and are executed on database engine that's why no debugging is possible.
- Because all the code will be sent to the database engine and then database engine verifies and provide you the errors which were occur during runtime.

5. SQL queries is a combination of Object oriented and Relational.

- "INSERT INTO PRODUCTS VALUES (' "+TextBox1.Text + " ',, "+ TextBox2.Text + " ');";

_ **USING LINQ WITH SQL SERVER** _

1. LINQ Queries are checked during compile time

- LINQ queries are not compiled by database engine, it is compiled by C# because LINQ is integrated in C#.
- LINQ queries are executed and verified by LINQ query engine which is provided in our DotNet Framework.
- LINQ is purely defined in our DotNet languages like C# or VB.NET, it means you write LINQ queries in C# syntax.
- It means LINQ queries are compiled in native language of a developer like C# or VB.NET.

2. There is Intellisense support

- LINQ queries are executed by C# compiler so the compiler knows the data types of Database objects and also displays appropriate intelliSense to a developer.

3. It is type safe.

- In this case, all the data types of columns are already known by the C# compiler that's why you have to pass only appropriate values.

4. Debugging of LINQ queries is possible

- LINQ queries are executed by C# compiler so the compiler knows the errors and displays it on compile time then we can easily debug.

5. 100% object oriented code.

**When we used LINQ TO SQL** :_
 
 They converts as below tables

| **Relational Type**     | **Object Oriented Type** |
| ---                     | --- |
| Table                   | Class |
| Column                  | Property |
| Row                     | Object/ Instance |
| Stored Procedure        | Method |

1. If you want to work with LINQ to SQL, First you have to convert or map all the relational obj of database into object oriented types. Which is possible with the above table.
2. And This process is called **ORM (Object Relational Mapping)**
3. To perform ORM we have to use a tool called OR Designer.
