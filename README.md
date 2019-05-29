<h2>Dependency Injection (Concept Understanding)</h2>
  <p>Dependency injection is a programming technique that makes a class independent of its dependencies.</p>

<h2>Example</h2>
  <p>class A uses some methods of class B. Then its said that class A has a dependency of class B. Before we can use methods of other classes, we first need to create the object of that class (i.e. class A needs to create an instance of class B).</p>

  <p>So, transferring the task of creating the object to someone else and directly using the dependency is called dependency injection. When using dependency injection, objects are given their dependencies at run time rather than compile time.</p>

<h2>DI Type</h2>
  <p>constructor injection: the dependencies are provided through a class constructor. In this project, constructor injection is been used.</p>

<h2>Calling Flow</h2>

<pre>
  <code>
    program.cs -> BusinessLogicImplementation.cs -> IService.cs -> PaymentService.cs
  </code>
</pre>

