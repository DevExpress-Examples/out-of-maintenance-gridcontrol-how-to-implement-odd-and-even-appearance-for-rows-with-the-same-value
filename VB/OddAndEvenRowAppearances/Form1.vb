Imports DevExpress.XtraGrid.Columns
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace OddAndEvenRowAppearances
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'carsDBDataSet.Orders' table. You can move, or remove it, as needed.
            Me.ordersTableAdapter.Fill(Me.carsDBDataSet_Renamed.Orders)
            Dim helper As New RowStyleHelper(gridView1, "PaymentType")
            Dim keyColumn As GridColumn = gridView1.Columns("PaymentType")
            keyColumn.AppearanceCell.Font = New Font(keyColumn.AppearanceCell.Font, FontStyle.Bold)
        End Sub
    End Class
End Namespace
