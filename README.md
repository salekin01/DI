# Dependency Injection (Concept Understanding)
Dependency injection is a programming technique that makes a class independent of its dependencies.

# Example
class A uses some methods of class B. Then its said that class A has a dependency of class B. Before we can use methods of other classes, we first need to create the object of that class (i.e. class A needs to create an instance of class B).

So, transferring the task of creating the object to someone else and directly using the dependency is called dependency injection. When using dependency injection, objects are given their dependencies at run time rather than compile time.

# DI Type
constructor injection: the dependencies are provided through a class constructor. In this project, constructor injection is been used.

# Calling Flow
program.cs -> BusinessLogicImplementation.cs -> IService.cs -> PaymentService.cs
