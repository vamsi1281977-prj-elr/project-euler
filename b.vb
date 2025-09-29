' Project Euler Problem 002
' ~~~~~~~~~~~~~~~~~~~~~~~~~
'
' https://betaprojects.com/solutions/project-euler/project-euler-problem-002-solution/
'
' For this problem we will generate fibonacci numbers and sum up the even
' fibonacci numbers.
'
' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\b.vb

Option Explicit On ' Ensure typos are caught at compile time.
Option Infer    On ' Local variable type inference at compile time.
Option Strict   On ' No unsafe type conversions.

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
