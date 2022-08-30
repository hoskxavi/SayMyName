'Xavier Hoskins
'RCET 0265
'Spring 2022
'Say My Name
'https://github.com/hoskxavi/SayMyName.git

Option Explicit On
Option Strict On

Imports System

Module Program
    Sub Main(args As String())
        Dim userInput As String

        Console.WriteLine("Please enter your name:")
        userInput = Console.ReadLine()

        If userInput = "Emily" Or userInput = "EMILY" Or userInput = "emily" Then
            Console.WriteLine("Hello Emily")
        ElseIf userInput = "Joe" Or userInput = "JOE" Or userInput = "joe" Then
            Console.WriteLine("Hello Joe")
        ElseIf userInput = "Xavier" Or userInput = "XAVIER" Or userInput = "xavier" Then
            Console.WriteLine("The creator has spoken...")
        ElseIf userInput = "Dave" Or userInput = "DAVE" Or userInput = "dave" Then
            Console.WriteLine("I'm sorry Dave, but I'm afraid I can't do that...")
        Else
            Console.WriteLine("YOU ARE NOT AUTHORIZED")
        End If


    End Sub
End Module
