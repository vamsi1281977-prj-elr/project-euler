' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\d.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Const kBase As Integer = 10

  Function ReverseDigits(ByVal va As Integer) As Integer
    Dim la = 0
    While va > 0
      Dim lb = va Mod kBase
      va = va \ kBase
      la = (la * kBase) + lb
    End While
    Return la
  End Function

  Function Solve(ByVal va As Integer, ByVal vb As Integer) As Integer
    Dim la = 0
    For ia = va To vb
      For ib = ia To vb
        Dim lb = ia * ib
        Dim lc = ReverseDigits(lb)
        If lb = lc Then
          la = Math.Max(la, lb)
        End If
      Next
    Next
    Return la
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(100, 999)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
