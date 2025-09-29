' Project Euler Problem 002
' ~~~~~~~~~~~~~~~~~~~~~~~~~
' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\b.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Function Solve(ByVal va As Integer) As Integer
    Dim la = 0
    Dim lb = 1
    Dim lc = 0
    While la <= va
      If (la Mod 2) = 0 Then
        lc = la + lc
      End If
      Dim ld = la + lb
      la = lb
      lb = ld
    End While
    Return lc
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(4000000)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
