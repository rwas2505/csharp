# Chapter 05
## Building Your Own Types with Object-Oriented Programming

### *Exercise 5.1 Test your knowledge*

1. What are the six access modifiers and what do they do?
    * **A:**

    * **public:** The type or member can be accessed by any other code in the same assembly or another assembly that references it.

    * **private:** The type or member can be accessed only by code in the same *class* or *struct*. This is the default.

    * **protected:** The type or member can be accessed only by code in the same *class*, or in a *class* that is derived from that *class*. 

    * **internal:** The type or member can be accessed by any code in the same assembly, but not from another assembly.

    * **protected internal:** The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived *class* in another assembly. Equivalent to a fictional access modifier named *internal_or_protected*.

    * **private protected:** The type or member can be accessed only within its declaring assembly, by code in the same *class* or in a type that is derived from that *class*. Equivalent to a fictional access modifier named *internal_and_protected*. Only for C# 7.2 and later.

2. What is the difference between the *static*, *const*, and *readonly* keywords?
    * **A:**
    * ***static:*** Defines a field that only has one value that is shared accross all instances (p.156). This is different than an **instance** member which has a different value for a given field across each instance of a class.

    * ***const:*** Use *const* if the value of a field will never EVER change(like pi). To get the value of a constant field, you must write the nameof the class, not the name of an instance of the class. (i.e Person.Species, not bob.Species).
        * **Good Practice:** Constants should be avoided for two reasons. THe value must be known at compile time, and it must be expressible as a literal string, Boolean, or number value. Every reference to the *const* field is replaced with the literal value at compile time, which will, therefore, not be reflected if the value changes in a future version andyou do not recompile any assemblies that reference it to get the new value.

    * ***readonly:*** A better choice for fields that should not change over *cosnt*.
        * **Good Practice:** Use read-only fields over the *const* fields for two important reasons: the value can be calculated or loaded at runtime and can be expressed using any executable statement. So, a read-only field can be set using a constructor or a field assignment. Every reference to the field is a live reference, so any future chagnes will be correctly reflected by calling code. *(p.159)*
        

3. What does a constructor do?
    * **A:** Fields often need to be initialized at runtime. You do this in a constructor that will be called when you make an instance of the class using the *new* keyword. Constructors execute before any fields are set by the code that is using the type. You can have multiple constructors in a type. This is especially useful to encourage developers to set initial values for fields.

4. Why should you apply the *[Flags]* attribute to an *enum* type when you want to store combined values?
    * **A:** "We should also decorate the *enum* type with *System.Flags* attribute so that when the value is returned it can automatically match with multiple values as a comma-separated *string* instead of returning an *int* value.
    *(https://docs.microsoft.com/en-us/dotnet/api/system.flagsattribute?view=netcore-3.1)*
    *(https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum)*

5. Why is the *partial* keyword useful?
    * **A:** When working on large projects with multiple team members, it is useful to be able to split the definitiion of a complex class across multiple files. You do this using the *partial* keyword.(p.171)*

6. What is a tuple?
    * **A:** A data structure that contains a sequence of elements of different data types. It can be used where you want to have a data structure to hold an object with properties, but you don't want to create a separate type for it.
    (https://www.tutorialsteacher.com/csharp/csharp-tuple#:~:text=The%20Tuple%20class%20was,a%20separate%20type%20for%20it.)

7. What does the C# *ref* keyword do?
* **A:**
The ref keyword indicates a value that is passed by reference. It is used in four different contexts:

* In a method signature and in a method call, to pass an argument to a method by reference. For more information, see Passing an argument by reference.
* In a method signature, to return a value to the caller by reference. For more information, see Reference return values.
* In a member body, to indicate that a reference return value is stored locally as a reference that the caller intends to modify or, in general, a local variable accesses another value by reference. For more information, see Ref locals.
* In a struct declaration to declare a ref struct or a readonly ref struct. For more information, see the ref struct section of the Structure types article
(https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref)

8. What does overloading mean?
    * **A:** Two different methods can have the same name. This is allowed if the methods each have a different signature. This is considered overloading. The quick info for the method in VS Code will tell you that the  method has one (or however many) additional overload.

9. What is the difference between a field and a property?
    * **A:** 
    
    Properties expose fields. Fields should (almost always) be kept private to a class and accessed via get and set properties. Properties provide a level of abstraction allowing you to change the fields while not affecting the external way they are accessed by the things that use your class 

    A field is a variable that is declared directly in a class or struct. A class or struct may have instance fields or static fields or both. Generally, you should use fields only for variables that have private or protected accessibility. Data that your class exposes to client code should be provided through methods, properties and indexers. By using these constructs for indirect access to internal fields, you can guard against invalid input values.

    A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field. Properties can be used as if they are public data members, but they are actually special methods called accessors. This enables data to be accessed easily and still helps promote the safety and flexibility of methods. Properties enable a class to expose a public way of getting and setting values, while hiding implementation or verification code. A get property accessor is used to return the property value, and a set accessor is used to assign a new value.

    (https://stackoverflow.com/questions/295104/what-is-the-difference-between-a-field-and-a-property#:~:text=A%20field%20is%20a%20variable,in%20a%20class%20or%20struct.&text=Properties%20enable%20a%20class%20to,to%20assign%20a%20new%20value.)

    A property is simply a method (or a pair of methods) that acts and looks like a field when you want to gt or set a value, thereby simplifying the syntax. (p.172)

10. How do you make a method parameter optional?
    * **A:** You make a parameter optional by assigning a default value inside the method parameter list. Optional parameters must always come last in the list of parameters. There is one exception to optional parameters always coming last. C# has a *params* keyword that allows you to pass a comma-separated list of parameters of any length as an array. Read more here *(https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/params)*


######################################################################################

### *Exercise 5.2 - Explore Topics*

**Fields (C# programming guide)**https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/fields

**Access Modifiers (C# programming guide)**https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/access-modifiers

**Constructors (C# programming guide)**https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/constructors

**Methods (C# programming guide)**https://docs.microsoft.com/en-us/dotnet/articles/csharp/methods

**Properties (C# programming guide)**https://docs.microsoft.com/en-us/dotnet/articles/csharp/properties



