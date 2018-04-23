Namespace OddAndEvenRowAppearances
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.carsDBDataSet_Renamed = New OddAndEvenRowAppearances.CarsDBDataSet()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPurchaseDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTime = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPaymentType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPaymentAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ordersTableAdapter = New OddAndEvenRowAppearances.CarsDBDataSetTableAdapters.OrdersTableAdapter()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.ordersBindingSource
            Me.gridControl1.Location = New System.Drawing.Point(13, 13)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(690, 323)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' ordersBindingSource
            ' 
            Me.ordersBindingSource.DataMember = "Orders"
            Me.ordersBindingSource.DataSource = Me.carsDBDataSet_Renamed
            ' 
            ' carsDBDataSet
            ' 
            Me.carsDBDataSet_Renamed.DataSetName = "CarsDBDataSet"
            Me.carsDBDataSet_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colCustomerID, Me.colProductID, Me.colPurchaseDate, Me.colTime, Me.colPaymentType, Me.colPaymentAmount, Me.colDescription, Me.colQuantity})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.Visible = True
            Me.colCustomerID.VisibleIndex = 1
            ' 
            ' colProductID
            ' 
            Me.colProductID.FieldName = "ProductID"
            Me.colProductID.Name = "colProductID"
            Me.colProductID.Visible = True
            Me.colProductID.VisibleIndex = 2
            ' 
            ' colPurchaseDate
            ' 
            Me.colPurchaseDate.FieldName = "PurchaseDate"
            Me.colPurchaseDate.Name = "colPurchaseDate"
            Me.colPurchaseDate.Visible = True
            Me.colPurchaseDate.VisibleIndex = 3
            ' 
            ' colTime
            ' 
            Me.colTime.FieldName = "Time"
            Me.colTime.Name = "colTime"
            Me.colTime.Visible = True
            Me.colTime.VisibleIndex = 4
            ' 
            ' colPaymentType
            ' 
            Me.colPaymentType.FieldName = "PaymentType"
            Me.colPaymentType.Name = "colPaymentType"
            Me.colPaymentType.Visible = True
            Me.colPaymentType.VisibleIndex = 5
            ' 
            ' colPaymentAmount
            ' 
            Me.colPaymentAmount.FieldName = "PaymentAmount"
            Me.colPaymentAmount.Name = "colPaymentAmount"
            Me.colPaymentAmount.Visible = True
            Me.colPaymentAmount.VisibleIndex = 6
            ' 
            ' colDescription
            ' 
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 7
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 8
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(715, 348)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private carsDBDataSet_Renamed As CarsDBDataSet
        Private ordersBindingSource As System.Windows.Forms.BindingSource
        Private ordersTableAdapter As CarsDBDataSetTableAdapters.OrdersTableAdapter
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
        Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
        Private colPurchaseDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colTime As DevExpress.XtraGrid.Columns.GridColumn
        Private colPaymentType As DevExpress.XtraGrid.Columns.GridColumn
        Private colPaymentAmount As DevExpress.XtraGrid.Columns.GridColumn
        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

