#pragma checksum "/Users/patrik.nusszer/Desktop/Nusstudios/Views/Articles/paradigms_brief_history.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31aee509099926d6d6771438d800aa7ce77a54e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_paradigms_brief_history), @"mvc.1.0.view", @"/Views/Articles/paradigms_brief_history.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/patrik.nusszer/Desktop/Nusstudios/Views/_ViewImports.cshtml"
using Nusstudios;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31aee509099926d6d6771438d800aa7ce77a54e0", @"/Views/Articles/paradigms_brief_history.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2753723ec3b7f1744cac33670045c6f2e6d4ce3", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_paradigms_brief_history : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("keywords", async() => {
                WriteLiteral(@"
	<meta name=""keywords"" content=""programming paradigms, history, overview, concepts"" />
	<meta name=""keywords"" content=""procedural, imperative, declarative, functional, structured, object oriented"" />
	<meta name=""keywords"" content=""abstraction, modularirty, code reuse, inheritance, polymorphism"" />
	<meta name=""keywords"" content=""Liskov substitution principle, substitutability, dynamically typed, statically typed, duck typing"" />
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("topheading", async() => {
                WriteLiteral("\r\n    Programming paradigms\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("subheading", async() => {
                WriteLiteral("\r\n    Brief historical overview\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("description", async() => {
                WriteLiteral(@"
	After our kind first started programming, we could not help
	but realise how could we do it even better, just like we do in case
	of literally anything else.<br>
	<br>
	That is why a programming paradigm that was invented after another
	in time is not necessarily a completely different way to code but a
	better one, an almost clear improvement over the previous.<br>
	<br>
	That is why you might come across people saying: procedural programming
	is a subset of imperative. Because it has everything in fact that imperative
	has, it just adds a new feature that makes your code more readable,
	scalable, manageable.<br>
	<br>
	In imperative programming your application is a piece of commands
	sequentially executed, lacking any sort of complex hierarchy.<br>
	<br>
	Now imagine that you write some lines of code that has a specific purpose.
	This aggregate of lines is just one of the many in your imperative program.
	But it is present at multiple points of your application
	because you need to pe");
                WriteLiteral(@"rform that task again but with always different parameters.
	When you need to make a change to that particular task, you would need to look up
	each of its occurrences and apply the update.<br>
	<br>
	That is not to say it will take you some time to make out where to draw the line
	between these different subtasks over and over again because they are
	really just part of a single sequence of code in a purely imperative program.<br>
	<br>
	It is actually procedural programming that first came up with the idea of
	abstraction and modularity, the latter also known as code reuse.<br>
	<br>
	Procedural programming was a solution for both of the abovementioned issues.
	It lets you declare procedures. A procedure is a given amount of lines
	that has a specific task which was given a name.
	You can call this procedure by its name just like you would call
	a person by name :).
	And then calling it will execute its code/implementation.
	These procedures are modular, reusable, you can call it wherever y");
                WriteLiteral(@"ou need it,
	and you can pass it parameters that are special to/distinctive of the given call.
	Code reuse will make your code lighter because a procedure name is most probably shorter
	than the implementation.
	You only need to change that given block of code to change its behaviour everywhere.<br>
	<br>
	It is not just modular, it is also an abstraction.
	Abstraction looks at a more important subset of traits of a certain something,
	and neglects others.<br>
	You would say there is a subset of traits which are preserved/abstracted,
	and a subset of traits which are neglected/abstracted away.<br>
	<br>
	If you do not execute a given block of code but instead you call it by a name,
	you essentially abstract/preserve functionality of the code block,
	while you abstract away/neglect its implementation detail.<br>
	<br>
	This means that a procedure is an abstraction regardless of the exact name you give it.<br>
	<br>
	But it is even more of an abstraction if you give it a name which also
	abst");
                WriteLiteral(@"racts/summarises what it essentially does, in a short character sequence.<br>
	And actually every developer does so because we are humans :)<br>
	<br>
	After procedural paradigm, structured paradigm follows.<br>
	Imagine that sometimes you will need to repeat a given block of code until a certain
	condition holds true. This time the program will make a backwards jump to the first
	command of that given block.<br>
	Or sometimes you need to skip a block of code given some condition. That is forwards jump.<br>
	Purely procedural and imperative paradigms enable the developer to jump anywhere
	inside the application without restrictions.<br>
	The problem is not with jumping, it is its unrestricted nature.<br>
	Over time the developer would lose track of how the execution is flowing from a command
	to another leading to what you might have already heard: spaghetti code.<br>
	<br>
	That unrestricted jumping was addressed by the structured programming paradigm.<br>
	It meant the introduction of block s");
                WriteLiteral(@"tructured programming languages where
	you could arrange blocks of commands into a hierarchy.<br>
	<br>
	The forwards jump became the so called ""if"" control compound statement (block).<br>
	The ""do-while"" control compound statement is the simple backwards jump.<br>
	The ""for"" and ""while"" control compound statements, the former being a
	specialisation of the latter, are combinations thereof.
	They are a backwards jump preceded by a forwards jump.<br>
	<br>
	This sort of block structuring theoretically speaking disables jumping from inside
	of a block outside, and jumping from outside inside the block arbitrarily.<br>
	<br>
	If we have a forwards jump, it might ""skip over"" its block and will indeed
	always jump into that outside block which has the next command inside the application
	to be executed. This only means that you can actually jump to a
	command of an outside block but it is controlled by the commonsense of block structuring
	and so you can not do it in an arbitrary manner.<br>
	<br>");
                WriteLiteral(@"
	So can we really say that structured programming paradigm is a subset of both procedural paradigm?<br>
	Well, it depends.<br>
	<br>
	Some languages support arbitrary jumping inside applications but since this is one of the
	most common antipatterns in the programming world it is either discouraged if allowed,
	or it is completely absent from the language.<br>
	<br>
	If a language implements structured paradigm, then we can state in strict mathematical
	sense that it is a subset of procedural paradigm if it supports arbitrary jumping,
	and if not we can still say it roughly is, but not in a strict sense.<br>
	<br>
	Block structuring also introduced special types of blocks which are not necessarily
	control compound statements.<br>
	Exception handling for example involves ""try"" and ""catch"" blocks.<br>
	You can have a ""synchronised"" block which is thread-safe.<br>
	A ""struct"" is also a block which is also key element of purely structured languages such as C.<br>
	It is a modular reusable bundl");
                WriteLiteral(@"e of public variables. It is already adequate for buildig
	compositional hierarchies which are more sophisticated in Object-Oriented languages.<br>
	You can have an anonymous blocks too which has nothing special purpose except scope management.<br>
	<br>
	By the way scopes.<r>
	In an imperative language, the only restriction of a the availability of variables
	is that you can not use a variable before its declaration.<br>
	<br>
	But since a block in structured programming is also a block-scope, it adds an extra
	restriction to that. A variable declared inside a block is only available in its own
	local scope (block) and its inner (subordinate/child) scopes (blocks).<br>
	Therefore it is not accessible in outer scopes (blocks) even if it was declared at an
	earlier point of execution flow.<br>
	<br>
	The next and currently superior programming paradigm is Object Orientation.<br>
	It is a subset of structured paradigm.<br>
	<br>
	It introduces even stronger modularisation conventions, code reus");
                WriteLiteral(@"e and software modeling.<br>
	<br>
	A structured ""struct"" in C is just a bundle of public variables.<br>
	It might have pointers to procedures but the procedure itself is not deeply integrated with the bundle.<br>
	<br>
	An OO ""class"" and ""struct"" naturally enable adding procedures to them which are
	able to operate on other members of the bundle.<br>
	They have access modifiers meaning that the developer can choose which of the members are available
	to the user of the bundle and which are reserved for the bundle itself.<br>
	This way you can hide implementation detail from the user and prevent unrestricted modification to members.<br>
	<br>
	This what you have just read is called Encapsulation, one of the key concepts of OO.<br>
	It builds on top of the idea of C ""struct"" bundles, redefining them as a collection of states
	and behaviours that are meant to operate on them.<br>
	Access modification is also key part of it, hiding members from the user that are only important in
	the inner operat");
                WriteLiteral(@"ion of the bundle.<br>
	<br>
	Inheritance is another key concept.<br>
	If a class inherits from another it will acquire all its members.<br>
	At first it is important to mention that it makes sense as a form of code reuse in itself.<br>
	<br>
	We use inheritance during the processes of abstraction & generalisation, and specialisation.<br>
	We are building taxonomic hierarchies of bundles.<br>
	<br>
	Substitutability is the concept of assigning subtypes of a class to a variable whose
	type is that class because we know that each of the subclasses possess the members of that class.<br>
	<br>
	Inheritance is indispensible for an OO language which is statically typed because it explicitly
	declares that this class is such a type which must have the superclass members.<br>
	<br>
	Dinamically typed languages also have inheritance but since such a language does not care about types,
	it is not required for substitutability, and the fact that some bundle has all the members of
	another one is the sol");
                WriteLiteral(@"e responsibility of the developer.<br>
	<br>
	This of course also means that substitutability is possible in any language but in case of
	dinamically typed languages it does not come naturally and is very hard to enforce.<br>
	<br>
	For some time actually, I intuitively believed that OO is for statically typed languages only,
	until I found out JavaScript is considered to be Object Oriented which left me quite surprised.<br>
	<br>
	This alone is enough to demonstrate why dinamically typed languages are not created for very compound
	projects, and shows that statically typed languages are easier to maintain and therefore superior.<br>
	<br>
	Polymorphism is another OO concept.<br>
	There is the category of static polymorphism which is very fast.<br>
	It is using the same procedure or operator with different number of and types of parameters.<br>
	The types of parameters are always known at compile time in case of statically typed languages,
	therefore it is relatively fast.<br>
	Runtime polymor");
                WriteLiteral(@"phism is never fast because the call to a given procedure is resolved during runtime.<br>
	Actually in case of statically typed languages, it is knwon at compile time that the procedure
	exists on the object, but the specific implementation depends on the actual subtype it holds
	and it is not trivial at compile time and can change during runtime.<br>
	<br>
	So runtime polymorphism is the ability of the subtype to override the parent implementation of
	a procedure.<br>
	<br>
	The most common example teachers come up with is class Shape and its subtypes Quadrilateral, Triangle and Square.<br>
	Class Shape has a function named ""getArea"" which is marked abstract and has no implementation because
	if we the only thing we know about something is that it is a Shape, then we can clearly say that
	we can calculate its area but we can not tell how because it heavily depends on the subtype.<br>
	That is why the function is declared inside the class, but lacks any implementation.<br>
	<br>
	So calling an a");
                WriteLiteral(@"bstract procedure means that the appropriate implementation or I could say
	""version"" is gonna be looked up based on which of the subtypes is assigned to variable from
	whose type they all inherit.<br>
	<br>
	That is not to say our Shape class is also marked abstract and we can not make a copy of it because
	it is nonfunctional on its own due to having procedures without implementation.<br>
	Its sole purpose is code reuse, substitution, runtime polymorphism.<br>
	These 3 things together give what we call ""Liskov substitution principle"".<br>
	<br>
	So that is the story of how the original Imperative programming paradigm evolved over time.<br>
	<br>
	Another mainstream paradigm is called ""Functional"".<br>
	<br>
	Its concepts are:<br>
	Avoidance of shared mutable state and side effects: pure functions.<br>
	First class and higher order functions.<br>
	<br>
	The goal of a pure function is that its result is always the same for the same parameters.<br>
	Shared mutable states and random functions ");
                WriteLiteral(@"might stand in the way of pure functions.<br>
	<br>
	A shared mutable state might depend on the parameters of a function call, and if that function
	also depends on the shared mutable state then it can alter the outcome of a consequent call
	to that function in a way that it not just depends on current parameters but previous ones.<br>
	<br>
	A shared mutable state might also be used by more than 1 functions which just increases dependence
	upon each other.<br>
	<br>
	A first class function is one that can be assigned to a variable, and a higher order function<br>
	accepts first class function parameters and or returns them.<br>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("btnname", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("url", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
