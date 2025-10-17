# prjInventoryManagement
## Project Overview

This project demonstrates fundamental C# programming concepts including custom types, extension methods, LINQ queries, and anonymous types.
The program allows users to manage product inventory, calculate total stock value, and identify low-stock items using extension methods and LINQ.

## Features

Product Management: Store and manage product data including ID, Name, Quantity, and Price.

Total Inventory Value: Calculate the cumulative value of all inventory items using an extension method.

Low Stock Detection: Identify products below a specified quantity threshold.

LINQ Queries: Use LINQ with anonymous types to display selected product information (e.g., product names and prices).

Extensible Design: Demonstrates reusable functionality through extension methods.

## Pointer Types in C#

Pointer types in C# store memory addresses rather than actual values and are declared using the asterisk (*) symbol (for example, int* ptr;).
They are mainly used for interoperability with unmanaged C/C++ code, performance-critical operations that require direct memory access, and when working with fixed-size buffers or native libraries.

Pointer types require an unsafe context because they bypass the Common Language Runtime’s (CLR) memory safety and garbage collection protections. By requiring explicit unsafe declarations, the compiler ensures that developers take responsibility for manual memory management—helping prevent memory corruption, buffer overflows, and security vulnerabilities while maintaining C#’s default safety-first approach.

Microsoft Learn. (n.d.). Unsafe code, pointers, and function pointers in C#. Retrieved from https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code
Microsoft Learn. (n.d.). unsafe keyword (C# reference). Retrieved from https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unsafe