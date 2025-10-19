' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\l.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Function Tau(ByVal va As Integer) As Integer
    If va < 1 Then
      Throw New Exception("Tau:a")
    Else
      Dim la = 1
      Dim lb = la * la
      Dim lc = 0
      Dim ld = 1 + (va Mod 2)
      While lb <= va
        If (va Mod la) = 0 Then
          Dim le = va \ la
          lc = lc + If(la <> le, 2, 1)
        End If
        la = la + ld
        lb = la * la
      End While
      Return lc
    End If
  End Function

  Function TauPrime(ByVal va As Integer) As Integer
    Dim la = If((va Mod 2) = 0, va \ 2, va)
    Return Tau(la)
  End Function

  Function TauTriangular(ByVal va As Integer) As Integer
    Return TauPrime(va) * TauPrime(va + 1)
  End Function

  Function Triangular(ByVal va As Integer) As Integer
    Return If((va Mod 2) = 0, (va \ 2) * (va + 1), va * ((va + 1) \ 2))
  End Function

  Function Solve(ByVal va As Integer) As Integer
    Dim la = 1
    While TauTriangular(la) <= va
      la = la + 1
    End While
    Return Triangular(la)
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(500)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
