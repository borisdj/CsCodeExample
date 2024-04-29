# CsCodeExample
Examples of c# code in form of a simple tutorial.
Containing:
- Console Output
- Variables
- Declaration
- Arithmetic Operators
- Selection Statements
- Iteration Statements
- Arrays and Lists
- Parsing and Exceptions
- Functions
- Enum
- Classes
- Console Input
- File Read & Write

# Naming Conventions
Local variables - nonCapitalLetter, camelCase.  
Class, Function (Method - in a class) and Property name - CapitalLetter, PascalCase.  
DO choose easy readable identifier (eg. HorizontalAlignment more English-readable than AlignmentHorizontal).  
DO favor readability over brevity (property CanScrollHorizontally better than ScrollableX (obscure X-axis ref).  
DO NOT use underscores (Hungarian notation), hyphens, or any other nonalphanumeric characters.  
AVOID using identifiers that conflict with keywords of widely used programming languages.  

# Programming Principles:
**DRY** - Don't Repeat Yourself  
**YAGNI** - You Aren't Gonna Need It (but have as much as you can out of the box)  
**KISS** - Keep it Simple, Stupid - [Kelly Johnson](https://en.wikipedia.org/wiki/Kelly_Johnson (engineer))  
	"*Good design is as little design as possible.*" - Dieter Rams  
	"*Everything should be made as simple as possible, but not simpler.*" - Albert Einstein  
	"*Complexity is your enemy. Any fool can make something complicated. It's hard to keep things simple.*"-Richard Branson  
	"*Simple can be harder than complex: You have to work hard to get your thinking clean to make it simple.*" - Steve Jobs  
	"*I have made this letter longer than usual, only because I have not had the time to make it shorter.*" - Blaise Pascal  
	"*I have just three things to teach: simplicity, patience, compassion. These three are your greatest treasures.*" - Lao Tzu  

**LoD**   - Law of Demeter or principle of least knowledge  
**SoC**   - Separation of Concerns; Layers: presentation, business(service), DAL - data access layer, DB - database  
**DDD**   - Domain Driven Design  
 _ **RP** - Repository Pattern [msdn/TheRepoPattern](https://msdn.microsoft.com/en-us/library/ff649690.aspx) (allows dependency injection and unit test for EF)  
 _ **DI** - Dependecy Injection (**IoC** - Inversion of Control), loosely-coupled  
**PRG** pattern - Post/Redirect/Get  
**GRASP** - General Responsibility Assignment Software Patterns  

**OOP** - Object Oriented Programming  
**SOLID** (object-oriented design) [SolidInPictures](https://lostechies.com/derickbailey/2009/02/11/solid-development-principles-in-motivational-pictures/):  
[S] SRP - Single Responsibility Principle (a class should have only a single responsibility)  
[O] OCP - Open/Closed Principle (entities[class, function,..] to be open for extension, closed for modification)  
[L] LSP - Liskov Substitution Principle (objects replaceable with subtypes instances without altering correctness)  
[I] ISP - Interface Segregation Principle (many client-specific interfaces are better than one general-purpose interface)  
[D] DIP - Dependency Inversion Principle (Depend upon abstractions, not upon concretions, Dependency injection)  
