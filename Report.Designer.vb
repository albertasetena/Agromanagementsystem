<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agro_Management_SystemDataSet = New Agro_Management_System.Agro_Management_SystemDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CropBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LivestockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New Agro_Management_System.Agro_Management_SystemDataSetTableAdapters.ProductTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agro_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CropBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivestockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.Agro_Management_SystemDataSet
        '
        'Agro_Management_SystemDataSet
        '
        Me.Agro_Management_SystemDataSet.DataSetName = "Agro_Management_SystemDataSet"
        Me.Agro_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Preport"
        ReportDataSource2.Value = Me.ProductBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "Agro_Management_System.Preport.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(684, 385)
        Me.ReportViewer2.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Location = New System.Drawing.Point(617, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.ClientSize = New System.Drawing.Size(684, 385)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Report"
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agro_Management_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CropBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivestockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CropBindingSource As BindingSource
    Friend WithEvents Agro_Management_SystemDataSet As Agro_Management_SystemDataSet
    Friend WithEvents LivestockBindingSource As BindingSource

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As Agro_Management_SystemDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnExit As Button
End Class
