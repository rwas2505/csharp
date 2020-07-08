# Chapter 05
## Building Your Own Types with Object-Oriented Programming

### *Exercise 5.2 - Explore Topics*

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

7. What does the C# *ref* keyword do?

8. What does overloading mean?

9. What is the difference between a field and a property?

10. How do you make a method parameter optional?


######################################################################################
