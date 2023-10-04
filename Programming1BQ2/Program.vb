Imports System
Imports System.Math

Module Program
  Sub Main(args As String())
    Console.Write("Enter the side length of the square: ")
    Dim sideLength As Double

    If Double.TryParse(Console.ReadLine(), sideLength) AndAlso sideLength >= 0 Then
      Dim square As New Square(sideLength)


      Console.WriteLine($"Perimeter of your Squre = {square.Perimeter} CM")
      Console.WriteLine($"Area of your Squre = {square.Area} CM")
      Console.WriteLine($"Diagonal of your Squre = {square.Diagonal} CM")
    Else
      Console.WriteLine("Invalid input. Please enter a non-negative number.")
    End If
  End Sub
End Module

Public Class Square
  Private _side As Double

  Public Sub New(sideLength As Double)
    If sideLength < 0 Then
      Throw New ArgumentException("Side length must be non-negative.")
    End If
    _side = sideLength
  End Sub

  Public Property Side() As Double
    Get
      Return _side
    End Get
    Set(value As Double)
      If value < 0 Then
        Throw New ArgumentException("Side length must be non-negative.")
      End If
      _side = value
    End Set
  End Property

  Public ReadOnly Property Perimeter() As Double
    Get
      Return 4 * _side
    End Get
  End Property

  Public ReadOnly Property Area() As Double
    Get
      Return _side * _side
    End Get
  End Property

  Public ReadOnly Property Diagonal() As Double
    Get
      Return Sqrt(2 * _side * _side)
    End Get
  End Property
End Class
