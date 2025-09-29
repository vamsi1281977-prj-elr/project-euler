' Project Euler Problem 001
' ~~~~~~~~~~~~~~~~~~~~~~~~~
'
' This problem can be solved in many ways, but we will write the simplest
' possible code to solve this problem. We first sum up the multiples of 3.
' Then, we sum up the multiples of 5 that are not multiples of 3. We need
' to be careful not to double add numbers like 15 that are both multiples
' of 3 and 5.

Option Explicit On ' Ensure typos are caught at compile time.
Option Infer    On ' SML/NJ 97 like type inference at compile time.
Option Strict   On ' No unsafe type conversions.

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
