' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\g.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Function IsPrime(ByVal va As Integer) As Boolean
    If va < 2 Then
      Return False
    ElseIf va < 4 Then
      Return True
    ElseIf (va Mod 2) = 0 Then
      Return False
    ElseIf (va Mod 3) = 0 Then
      Return False
    Else
      Dim la = 5
      Dim lb = la * la
      While lb <= va
        If (va Mod la) = 0 Then
          Return False
        End If
        la = la + 2
        If (va Mod la) = 0 Then
          Return False
        End If
        la = la + 4
        lb = la * la
      End While
      Return True
    End If
  End Function

  Function Solve(ByVal va As Integer) As Integer
    Dim la = 0
    Dim lb = 0
    While la < va
      lb = lb + If(lb = 2, 1, 2)
      la = la + If(IsPrime(lb), 1, 0)
    End While
    Return lb
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(10001)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
