# Answers

## Exercise 4

### Classes

In C# classes are reference types, and a common tool for abstraction. The purpose of a class is to define a set of
variables which maintain some state, and a range of methods to act upon and modify this state. In OOP, a class is often
used to model an object, and objects are exist as specific instances of a class.

### Structs

A struct is inherently different from a class. While a class is a reference type, a struct is a value type. It can be
argued that a struct is closer to a primitive type, like an int, than a class. In practice a struct may have all the
same members as a class except for: A parameterless constructor, field initializers, a finalizer, and virtual or
protected members.

### Records

Whereas classes allow for state to be mutable, records do not. Records can be viewed as a subset of classes, which
can be clearly realized given that at compile-time records are classes. In short, records provide specific optimizations
and syntactic sugar to simplify writing and working with immutable objects. An example of such syntatic sugar is that
records provide structural equality by default. Hence, records can be viewed as classes to be used for one specific
purpose
