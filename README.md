## Factory Pattern
- When you see **new**, what do you think ?
- Why shoud you write code with interface ?
- Identity ... part and ... them from what stays the same
- Object composition allows us to ... at runtime
- Does abstract creator know about concrete product classes ?
- What is **parallel class hierarchies** in factory pattern ?

> The Factory Method Pattern deﬁnes an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class deferinstantiation to subclasses.

## The Dependency Inversion Principle

> **Design Principle** Depend upon abstractions. Do not depend upon concrete classes
Similar
> Program to an interface, not to an impelentations
- Does high level module depend on low level module ?
- What should high level, low level module depend ?


* When create a func think about its clients
* When switch a func to class or class to func think about OOP(factory pattern vs static method factory)
* Parameterized types don’t seem “type-safe.” (factory pattern) encapsulate what varies