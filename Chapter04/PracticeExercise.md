# Exercise 4.1 - Test your knowledge

1. What does the C# keyword **void** mean?
    * **A:** You use void as the return type of a method (or a local function) to specify that the method doesn't return a value. (https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/void)

2. How many parameters can a method have?
    * **A:** As many as you want (https://www.w3schools.com/cs/cs_method_parameters.asp)

3. In VS Code, whatis the difference between pressing *F5*, *Ctrl+F5*, *Shift+F5*, and *Ctrl+Shift+F5*?
    * **A:** Debugging shortcuts
    * **F5** - Continue; Continue running the program from the current position until it ends or hits another breakpoint.
    * **Ctrl+F5** - Run without debugging
    * **Shift+F5** - Stop the program
    * **Ctrl+Shift+F5** - Restart; Stop and then immediately restart the program

4. Where does the *Trace.WriteLine* method write its output to?
    * **A:** Trace is used to add logging that gets written during both development and runtime. A trace listener is a type that can be configured to write output anywhere you like when the *Trace.WriteLine* method is called. One trace listener, the *DefaultTraceListener* class, is configured automatically and writes to VS Code's **DEBUG CONSOLE** window. You can configure others manually using code. *(129-130)*

5. What are the five trace levels?
    * **A:** 
    * TraceLevel.Error: Output error-handling messages.
    * TraceLevel.Info Output: informational messages, warnings, and error-handling messages.
    * TraceLevel.Off: Output no tracing and debugging messages.
    * TraceLevel.Verbose: Output all debugging and tracing messages.
    * TraceLevel.Warning: Output warnings and error-handling messages.    
    * (http://net-informations.com/faq/net/trace.htm#:~:text=Five%20levels%20range%20from%20None,%2C%20and%20error%2Dhandling%20messages.)
    * (https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.traceswitch.level?view=netcore-3.1)
    * https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.tracelevel?view=netcore-3.1

6. What is the difference between *debug* and *trace*?
    * **A:** When running with the Debug configuration, both *Debug* and *Trace* are active and will show their output in **DEBUG CONSOLE**. When running with the Release configuration, only the *Trace* output is shown. You can therefore use *Debug.WriteLine* calls liberally throughout your code, knowing they will be stripped out automatically when you build the release version of your application.

7. When writing a unit test, what are the three A's?
    * **A:** *p.137-138*
    * **Arrange:** This part will declare and instantiate variables for input and output
    * **Act:** This part will execute the unit that you are testing. In our case, this means calling the method that we want to test (in reference to book example)
    * **Assert:** This part will make one or more assertions about the output. An assertion is a belief that if not true indicates a failed test. For example, when adding 2 and 2 we would expect the result would be 4.

8. When writing a unit test using *xUnit*, what attribute must you decorate the test methods with?
    * **A:** The Fact Attribute 
    * "https://visualstudiomagazine.com/articles/2018/11/01/xunit-tests-in-net-core.aspx"

9. What dotnet command executes *xUnit* tests?
    * **A:** *dotnet test*

10. What is TDD?
    * **A:** Creating unit tests before writing code. 
    * *More info:* (https://en.wikipedia.org/wiki/Test-driven_development)

###############################################################################################################

# Exercise 4.2 - Practice writing functions with debugging and unit testing

* *see PrimeFactors and PrimeFactorsUnitTests*

* (http://www.blackwasp.co.uk/PrimeFactors.aspx)

###############################################################################################################

# Exercise 4.3 - Explore Topics

* **Debugging in VS Code** *https://code.visualstudio.com/docs/editor/debugging*
* **Instructions for setting up the .NET Core Debugger** *https://github.com/OmniSharp/omnisharp-vscode/blob/master/debugger.md*
* **System.Diagnostics Namespace** *https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics?view=dotnet-plat-ext-3.1*
* **Unit testing in .NET Core and .NET Standard** *https://docs.microsoft.com/en-us/dotnet/core/testing/?pivots=mstest*
* **xUnit.net** *https://xunit.github.io/*
