Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing

Namespace OddAndEvenRowAppearances
    Public Class RowStyleHelper
        Private previousValue As Object

        Private isPreviousPaobjected As Boolean


        Private columnName_Renamed As String


        Private rowColor_Renamed As Color = Color.Aqua

        Public Property RowColor() As Color
            Get
                Return rowColor_Renamed
            End Get
            Set(ByVal value As Color)
                rowColor_Renamed = value
            End Set
        End Property

        Private gridView As GridView

        Public Property GrView() As GridView
            Get
                Return gridView
            End Get
            Set(ByVal value As GridView)
                gridView = value
            End Set
        End Property

        Public Property ColumnName() As String
            Get
                Return columnName_Renamed
            End Get
            Set(ByVal value As String)
                columnName_Renamed = value
            End Set
        End Property

        Public Sub New(ByVal gridView As GridView, ByVal columnName As String)
            GrView = gridView
            Me.ColumnName = columnName
            Attach()
        End Sub

        Public Sub Attach()
            AddHandler GrView.RowStyle, AddressOf GridView_RowStyle
        End Sub

        Public Sub Detach()
            RemoveHandler GrView.RowStyle, AddressOf GridView_RowStyle
        End Sub

        Private Sub GridView_RowStyle(ByVal sender As Object, ByVal e As RowStyleEventArgs)
            Dim view As GridView = TryCast(sender, GridView)

            If e.RowHandle = -1 Then
                Return
            End If

            Dim currentCellValue As Object = view.GetRowCellValue(e.RowHandle, columnName_Renamed)

            If e.RowHandle = 0 Then
                e.Appearance.BackColor = RowColor
                isPreviousPaobjected = True
                previousValue = currentCellValue
                Return
            End If
            isPreviousPaobjected = DetectPreviousRow(view, e.RowHandle)
            If previousValue.Equals(currentCellValue) Then
                If isPreviousPaobjected Then
                    e.Appearance.BackColor = RowColor
                End If
            Else
                If Not isPreviousPaobjected Then
                    e.Appearance.BackColor = RowColor
                End If
            End If
            previousValue = currentCellValue
        End Sub

        Private Function DetectPreviousRow(ByVal view As GridView, ByVal rowHandle As Integer) As Boolean
            Dim previuosRowIsPaobjected As Boolean = True
            Dim prevValue As Object = view.GetRowCellValue(0, columnName_Renamed)
            For i As Integer = 1 To rowHandle - 1
                Dim tempCellValue As Object = view.GetRowCellValue(i, columnName_Renamed)

                If Not prevValue.Equals(tempCellValue) Then
                    If Not previuosRowIsPaobjected Then
                        previuosRowIsPaobjected = True
                    Else
                        previuosRowIsPaobjected = False
                    End If
                End If
                prevValue = tempCellValue
            Next i
            previousValue = prevValue
            Return previuosRowIsPaobjected
        End Function
    End Class
End Namespace
