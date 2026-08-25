
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Password
    Public Class FixedSizeQueue(Of T) : Inherits Queue(Of T)

        Private _Size As Integer

        Public Property Size() As Integer
            Get
                Return _Size
            End Get
            Private Set(value As Integer)
                _Size = value
            End Set
        End Property

        Public Sub New(Size As Integer)
            _Size = Size
        End Sub

        Public Shadows Sub Enqueue(obj As T)
            MyBase.Enqueue(obj)

            SyncLock Me
                While MyBase.Count > Size
                    MyBase.Dequeue()
                End While
            End SyncLock

        End Sub

    End Class

End Namespace