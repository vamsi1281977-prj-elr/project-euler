' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\f.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Function Solve(ByVal va As Integer) As Integer
    Dim la = 0
    Dim lb = 0
    For ia = 0 To va 
      Dim lc = ia * ia
      la = la + ia
      lb = lb + lc
    Next
    Dim ld = la * la
    Dim le = ld - lb
    Return le
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(100)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
