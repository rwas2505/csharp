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