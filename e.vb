' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\e.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Function GreatestCommonDivisor(ByVal va As Integer,
                                 ByVal vb As Integer) As Integer
    If va < 0 Then
      Return GreatestCommonDivisor((- va), vb)
    ElseIf vb < 0 Then
      Return GreatestCommonDivisor(va, (- vb))
    ElseIf va = 0 Then
      If vb = 0 Then
        Throw New Exception("GreatestCommonDivisor:a")
      Else
        Return vb
      End If
    Else
      While vb > 0
        Dim la = va Mod vb
        va = vb
        vb = la
      End While
      Return va
    End If
  End Function

  Function LeastCommonMultiple(ByVal va As Integer,
                               ByVal vb As Integer) As Integer
    If va < 0 Then
      Throw New Exception("LeastCommonMultiple:a")
    ElseIf vb < 0 Then
      Throw New Exception("LeastCommonMultiple:b")
    Else
      Dim la = GreatestCommonDivisor(va, vb)
      Dim lb = va \ la
      Dim lc = lb * vb
      Return lc
    End If
  End Function

  Function Solve(ByVal va As Integer) As Integer
    Dim la = 1
    For ia = 1 To va
      la = LeastCommonMultiple(la, ia)
    Next
    Return la
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(20)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
