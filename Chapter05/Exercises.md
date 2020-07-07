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

3. What does a constructor do?

4. Why should you apply the *[Flags]* attribute to an *enum* type when you want to store combined values?

5. Why is the *partial* keyword useful?

6. What is a tuple?

7. What does the C# *ref* keyword do?

8. What does overloading mean?

9. What is the difference between a field and a property?

10. How do you make a method parameter optional?


######################################################################################
