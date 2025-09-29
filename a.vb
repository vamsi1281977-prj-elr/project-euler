' Project Euler Problem 001
' ~~~~~~~~~~~~~~~~~~~~~~~~~
' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\a.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Function Solve(ByVal va As Integer,
                 ByVal vb As Integer,
                 ByVal vc As Integer) As Integer
    Dim la = 0
    For ia = 0 To vc Step va
      la = la + ia
    Next
    For ib = 0 To vc Step vb
      If (ib Mod va) <> 0 Then
        la = la + ib
      End If
    Next
    Return la
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(3, 5, 999)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
