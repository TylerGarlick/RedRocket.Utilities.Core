RedRocket Utilities 
========================

The RedRocket Utility project houses many helper methods that are common throughout the framework.  The goal of the utility project is to minimize external dependencies and provide common functionality, also allowing the utility framework to be used outside of the RedRocket infrastructure.

Installation
-------------
Install via NuGet (Either via manage packages, or Package Manager Console)

    Install-Package RedRocket.Utilities.Core

##String Extensions
To see a more through usages see the accompanying tests
https://github.com/TylerGarlick/RedRocket.Utilities.Core/blob/master/RedRocket.Utilities.Core.Tests/StringExtensionTests.cs


__String Formating with .P(object[] args)__
The P() extension method is a direct equivelent of string.Format()
```csharp
string.Format("{0} {1}, "Hello", "World"); 
// Result:  "Hello World"

"{0} {1}".P("Hello", "World");
// Result: "Hello World"

"Total Number of Orders: {0}".P(25);
// Result: "Total Number of Orders: 25"

var someStringWithSomeFormatting = "This is my {0} string";
someStringWithSomeFormatting.P("fawesome");
// Result: "This is my fawesome string"
```

__String Formating with .ToCamelCase(string[] args)__
The ToCamelCase() extension method takes a string and a split args, and turns it into a camel cased string.
```csharp
"hello_world".ToCamelCase("_");
// Result: "HelloWorld"

// You can add as many seperating characters as needed.  Very flexible.
"hello_world  1".ToCamelCase("_", " ");
// Result: "HelloWorld1"
```
