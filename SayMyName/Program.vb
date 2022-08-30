'Xavier Hoskins
'RCET 0265
'Spring 2022
'Say My Name

Option Explicit On
Option Strict On

Imports System

Module Program
    Sub Main(args As String())
        Dim userInput As String

        Console.WriteLine("Please enter your name:")
        userInput = Console.ReadLine()
        Console.Write("Your name is ")
        Console.WriteLine(userInput)

    End Sub
End Module
