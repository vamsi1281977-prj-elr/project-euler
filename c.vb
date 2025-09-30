' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\c.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Function Solve(ByVal va As Long) As Long
    If va < 2L Then
      Throw New Exception("Solve:a")
    ElseIf va < 4L Then
      Return va
    Else
      Dim la = 2L
      Dim lb = la * la
      While lb <= va
        If (va Mod la) = 0L Then
          va = va \ la
        Else
          la = la + If(la = 2L, 1L, 2L)
          lb = la * la
        End If
      End While
      Return Math.Max(va, la)
    End If
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(600851475143L)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
