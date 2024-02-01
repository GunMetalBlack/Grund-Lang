# Grund 
## TLDR
You're free to use this if your brain is the size of a wall bust.
Variables are scoped and global, and the standard library is pretty bad; you're welcome.
Its syntax is python c# and java like. 
Anyway, if anyone actually wants to use this burning plastic, documentation below! PS:Make sure to grab the Grund Vscode Extension.
[Documentation](https://github.com/GunMetalBlack/Grund/wiki),
[Grund Speed Tests](https://docs.google.com/spreadsheets/d/1rW4sEgHRKovaxHGaUdG8YHd5OibnwNfNGlLQ4VjN1Rk/edit?usp=sharing)
## Run Instructions
Make sure the file you're sending has the.grd extension. 
After installation, enter your friendly neighborhood command prompt and make sure your in the directory of the installation enter the following command:

``` .\grund somefile.grd ```
You can chain files together to combine mutiple scripts by enter the following command

``` .\grund somefile.grd someother.grd test.grd ```
You can add the Grund.exe to your system path so you can acess it anywhere. The command would look like -
``` grund file.grd ```

## Using the Source code:
You're going to need .net8
Also the antlr runtime and Extension in vscode! Here is the command for the runtime (dotnet add package Antlr4.Runtime.Standard --version 4.13.1)!
Here's how you need to configure antlr settings https://www.youtube.com/watch?v=RcAWYOW7T-Q
Finally cd in to the source of AntlrCSharp as thats the root of the project!


  
