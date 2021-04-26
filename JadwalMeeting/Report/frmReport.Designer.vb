<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Tbl_JadwalMeetingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JadwalMeetingDataSet = New JadwalMeeting.JadwalMeetingDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tbl_JadwalMeetingTableAdapter = New JadwalMeeting.JadwalMeetingDataSetTableAdapters.Tbl_JadwalMeetingTableAdapter()
        CType(Me.Tbl_JadwalMeetingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JadwalMeetingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tbl_JadwalMeetingBindingSource
        '
        Me.Tbl_JadwalMeetingBindingSource.DataMember = "Tbl_JadwalMeeting"
        Me.Tbl_JadwalMeetingBindingSource.DataSource = Me.JadwalMeetingDataSet
        '
        'JadwalMeetingDataSet
        '
        Me.JadwalMeetingDataSet.DataSetName = "JadwalMeetingDataSet"
        Me.JadwalMeetingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "JadwalMeetingDataSet"
        ReportDataSource1.Value = Me.Tbl_JadwalMeetingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "JadwalMeeting.RPT_JadwalMeeting.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1149, 641)
        Me.ReportViewer1.TabIndex = 0
        '
        'Tbl_JadwalMeetingTableAdapter
        '
        Me.Tbl_JadwalMeetingTableAdapter.ClearBeforeFill = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 646)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT"
        CType(Me.Tbl_JadwalMeetingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JadwalMeetingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tbl_JadwalMeetingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JadwalMeetingDataSet As JadwalMeeting.JadwalMeetingDataSet
    Friend WithEvents Tbl_JadwalMeetingTableAdapter As JadwalMeeting.JadwalMeetingDataSetTableAdapters.Tbl_JadwalMeetingTableAdapter
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
