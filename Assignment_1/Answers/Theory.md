#

1. .NET framework is a software framework design and developed by Microsoft. It is a virtual machine for compiling and executing programs like C#, F#, VB.NET etc

2. .NET Core is more like a subset of .NET framework because it uses the core functionality of the .NET framework. Below are some differences

- .NET Core is open-sourced and cross-platform, that is, it is compatible with various OS like Windows, Linux and MAC OS while .NET framework was originally created to target the Windows OS

- .NET Core offers high performance and scalability compared to .NET framework

- .NET Core is compatible with open-source mobile app platforms like Xamarin through .NET standard library while .NET framework does not

- .NET Core does not support desktop applications development

3. A managed code needs the CLR for its execution while an unmanaged code does not.

4. An assembly is a collection of one or more files containing type definitions and resource files. The two different types of an assemblies are `weakly named assemblies` and `strongly named assemblies`. The major difference between `weakly named` and `strongly named` assemblies is that a `strongly named assembly` is signed with a publisher’s public/private key pair that uniquely identifies the assembly’s publisher.

5. At runtime, the `CLR` compiles the managed code into native CPU instructions and save it to memory. During execution, the CPU references the block of memory created and executes the code while the program is active.

6. `CLR` means Common Language Runtime which is a runtime environment for compiling managed code to native CPU instructions that can be executed by the computer.

7. The types of classes in C# are `abstract`, `partial`, `sealed` and `static`.

- Abstract classes are declared using the `abstract` keyword and an object can't be created from it, it can only be inherited from a subclass
- Partial classes are prefixed with the `partial` keyword. It cannot be inherited
- Sealed classes are created using the `sealed` keyword. It cannot be inherited and used to restrict properties. It's members can only be accessed an object of the class must be created
- Static classes are created using the `static` keyword. It cannot be inherted and an object can't be created from it.
