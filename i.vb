' C:\Windows\Microsoft.NET\Framework\v4.0.30319\vbc.exe /langversion:10 .\i.vb

Option Explicit On
Option Infer    On
Option Strict   On

Module ProjectEuler
  Class DivisorPairEnumerator
    Private ReadOnly ma As Integer
    Private mb As Integer
    Private mc As Integer

    Public Sub New(ByVal va As Integer)
      ma = va
      mb = 0
      mc = 1 + (va Mod 2)
    End Sub

    Public Function MoveNext() As Boolean
      mb = mb + If(mb = 0, 1, mc)
      While (mb * mb) <= ma
        If (ma Mod mb) = 0 Then
          Return True
        Else
          mb = mb + mc
        End If
      End While
      Return False
    End Function

    Public ReadOnly Property Current As System.Tuple(Of Integer, Integer)
      Get
        Return System.Tuple.Create(mb, ma \ mb)
      End Get
    End Property
  End Class

  Function Solve(ByVal va As Integer) As Integer
    If (va Mod 2) <> 0 Then
      Throw New Exception("Solve:a")
    End If
    Dim la = New DivisorPairEnumerator(va \ 2)
    While la.MoveNext()
      Dim lb = la.Current
      Dim lc = lb.Item2 - lb.Item1
      If lb.Item1 > lc Then
        Dim ld = lb.Item1 * lb.Item1
        Dim le = lb.Item1 * lc
        Dim lf = lc * lc
        Dim lg = ld - lf
        Dim lh = le + le
        Dim li = ld + lf
        Dim lj = lg * lh * li
        Return lj
      End If
    End While
    Throw New Exception("Solve:b")
  End Function

  Sub Main(ByVal args As String())
    Dim la = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim lb = Solve(1000)
    Dim lc = System.DateTimeOffset.Now.ToUnixTimeMilliseconds()
    Dim ld = lc - la
    System.Console.WriteLine(lb)
    System.Console.WriteLine("Time taken: " & ld & " millis")
  End Sub
End Module
