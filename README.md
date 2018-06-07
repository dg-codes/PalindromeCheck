# PalindromeCheck

The current project is a console application, but it can easly be extended into a web service that can be called by desktop and web and even mobile applications.

Being a console application, when run, the program expects the user to provide an input via the CLI. 

Given a string as input, the program will return the top 3 (sorted descending by their length) palindromes contained in the string.

In this solution I have tried to go for a decoupled implementation, so that the code will be easly extendable. 
I have decided to go for small methods to make the code more readable and maintainable.

On building this app, I've had a TDD aproach and I aimed to follow the SOLID and DRY principles.

In order to achieve my goal I have decided to have a custom built object model that will fit my needs. The object model (Palindrome) is backed by an interface called ISubstring (which is currently empty) to allow for easy future expansion.
In order to support sorting on a list of Palindrome objects, the class implements IComparable&lt;Palindrome&gt;. It also overrides the ToString() method to return the information in the desired format.

<b>Languages and Tools:</b>

<i>Programing Language:</i> C# <br/>
<i>IDE:</i> Visual Studio 2017 <br/>
<i>.NET Framework verion:</i> 4.6.1 <br/>
<i>Unit Testing Framework</i> xUnit 2.3.1<br/>


<b>How to run the code:</b>

The project can be cloned or downloaded as a zip. If the solution is open using Visual Studio, NuGet should be able to restore/download any packages needed by the application.

If NuGet will not be able to download the required packages, a list of the used packages can be find in the packages.config file
