Imports System.Reflection
Imports System.Resources

Namespace ResourceExamples
   Module Example
      Public Sub Main()
         Dim rm As New ResourceManager("GreetingResources", 
                                       GetType(Example).Assembly())
         Console.Write(rm.GetString("prompt"))
         Dim name As String = Console.ReadLine()
         Console.WriteLine(rm.GetString("greeting"), name)                                                                          
      End Sub
   End Module
End Namespace
' The example displays output like the following:
'       Enter your name: Wilberforce
'       Hello, Wilberforce!
' </Snippet1>
