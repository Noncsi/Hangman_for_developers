﻿using System;

namespace Hangman
{
    public static class Words
    {
        public static string[] PickARandom(Random rnd, string[,] array)
        {
            int randomnum = rnd.Next(array.GetLength(0)-1);
            string randomWord = array[randomnum , 0];
            string definition = array[randomnum , 1];
            string[] randomPair = new string[2];
            randomPair[0] = randomWord;
            randomPair[1] = definition;
            return randomPair;
        }

        public static string[,] easy = new string[,] {
            { "Application", "Application in computer software refers to a complete and self-contained program that helps the user accomplish a specific task." },
            { "Algorithm", "A set of logical or mathematical procedures to solve a problem"},
            { "Function", "A set of instructions which are written once to obtain a particular result, and can then be used whenever necessary by 'calling' it." },
            { "Iteration", "A sequence of instructions which are repeated. For example, to perform an action for every item in a list you would 'iterate' over that list. Each time it is repeated is one iteration." },
            { "Loop", "A piece of code which keeps running until a certain condition is fulfilled - or isn't fulfilled in the case of an 'infinite loop' which will crash the system running it." },
            { "Recursion", "When something refers to itself.For example a variable may add something to itself for each iteration of a code loop." },
            { "Run time", "The time during which a program is running." },
            { "Variable", "A way to store a piece of data which can then be modified at any time." },
            { "Array", "A group of related data values (called elements) that are grouped together.All of the array elements must be the same data type." },
            { "Boolean", "A Boolean, bool, or Boolean expression is a value that is either TRUE or FALSE."},
            { "Bug", "A general term used to describe any unexpected problem with hardware or software."},
            { "Class", "With object-oriented programming, this term refers to a set of related objects that share common characteristics. Classes and the ability to create new classes are what make object- oriented programming a powerful and flexible programming model."},
            { "Comment", "A comment is any text in a program's code, script, or another file that is not meant to be seen by the user running the program. However, is seen when viewing the source code."},
            { "Debug", "Refers to the process of examining and removing errors from a program's source code."},
            { "Foreach", "Foreach is a loop statement in programming that performs predefined tasks while or until a predetermined condition is met."},
            { "Integer", "An integer is a numeric value, for example, 1 and 1234 are examples of integers."},
            { "Method", "In programming, a method is a function that is a member of a class/object(in technical terms, it is bound to that class/object).The method has access to the variables and properties defined in the class/object and can perform tasks on any instances of the class/object."},
            { "Pseudocode", "Alternatively referred to as p - code, pseudocode is a computer programming language that resembles plain English that cannot be compiled or executed, but explains a resolution to a problem."},
            { "Random", "Any data or information that has no order."},
            { "Spaghetti code", "Spaghetti code is slang used to describe a program's source code that is difficult to read or follow by a human because of how the original programmer wrote the code."},
            { "Substring", "A prefix or suffix of any string."},
            { "Syntax", "A set of rules for grammar and spelling.In other words, it means using character structures that a computer can interpret."},
            { "Unit test", "A unit test is performed on sections of code in computer programs to make sure they are functioning properly."},
            { "While", "A while loop or repeat loop is a loop statement in programming that performs pre-defined tasks while in the process of doing something else."},
            { "Argument", "Sometimes abbreviated as arg, when referring to programming or the command line an argument is a value that is passed into a command, function, or routine."},
            { "Compile", "Compile is the process of creating an executable program from code written in a compiled programming language. Compiling allows the computer to run and understand the program without the need of the programming software used to create it."}
            };

        public static string[,] medium = new string[,] {
            { "Encapsulation", "Encapsulation is an attribute of an object, and it contains all data which is hidden. That hidden data can be restricted to the members of that class. Levels are Public, Protected, Private, Internal and Protected Internal." },
            { "Polymorphism", "Polymorphism is a concept, which allows us to redefine the way something works, by either changing how it is done or by changing the parts using which it is done. Both the ways have different terms for them." },
            { "Inheritance", "Inheritance is a way to reuse once written code again and again. The class which is inherited is called base calls & the class which inherits is called derived class. So when, a derived class inherits a base class, the derived class can use all the functions which are defined in base class, hence making code reusable." },
            { "Destructor", "Destructor is a method which is automatically called when the object is made of scope or destroyed. Destructor name is also same as class name but with the tilde symbol before the name." },
            { "Constructor", "Constructor is a method used to initialize the state of an object, and it gets invoked at the time of object creation. Rules forconstructor are: Constructor Name should be same as class name, Constructor must have no return type." },
            { "Virtual function", "Virtual functions are member functions whose behavior can be overridden in derived classes." },
            { "Overloading", "Overloaded functions enable programmers to supply different semantics for a function, depending on the types and number of arguments." },
            { "Abstract class", "An abstract class is a class which cannot be instantiated. Creation of an object is not possible withabstract class , but it can be inherited. An abstract class can contain only Abstract method." },
            { "Overriding", "Method overriding is a feature that allows sub class to provide implementation of a method that is already defined in the main class. This will overrides the implementation in the superclass by providing the same method name, same parameter and same return type." },
            { "Interface", "An interface is a collection of abstract method.If the class implements an inheritance, and then thereby inherits all the abstract methods of an interface." },
            { "Access modifier", "Access modifiers are keywords used to specify the declared accessibility of a member or a type. The four access modifiers: public, protected, internal, private" },
            { "Copy constructor", "The copy constructor is a constructor which creates an object by initializing it with an object of the same class, which has been created previously." },
            };

        public static string[,] hard = new string[,] {
            { "Apache Project", " The Apache Project is a collaborative software development effort aimed at creating a robust, commercial-grade, featureful, and freely-available source code implementation of an HTTP (Web) server. The project is jointly managed by a group of volunteers worldwide." }
            };
    }
}