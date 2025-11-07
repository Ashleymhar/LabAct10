<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lstSorted = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(251, 126)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(276, 152)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(276, 181)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(276, 210)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Read Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lstSorted
        '
        Me.lstSorted.FormattingEnabled = True
        Me.lstSorted.Location = New System.Drawing.Point(99, 126)
        Me.lstSorted.Name = "lstSorted"
        Me.lstSorted.Size = New System.Drawing.Size(120, 95)
        Me.lstSorted.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstSorted)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtNumber)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents lstSorted As ListBox
End Class
