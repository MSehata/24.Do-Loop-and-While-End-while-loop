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
        btnClose = New Button()
        btnWhile = New Button()
        btnDO = New Button()
        MyListBox = New ListBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(333, 395)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 0
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnWhile
        ' 
        btnWhile.Location = New Point(455, 316)
        btnWhile.Name = "btnWhile"
        btnWhile.Size = New Size(94, 29)
        btnWhile.TabIndex = 0
        btnWhile.Text = "WHILE END WHILE"
        btnWhile.UseVisualStyleBackColor = True
        ' 
        ' btnDO
        ' 
        btnDO.Location = New Point(224, 316)
        btnDO.Name = "btnDO"
        btnDO.Size = New Size(94, 29)
        btnDO.TabIndex = 0
        btnDO.Text = "DO"
        btnDO.UseVisualStyleBackColor = True
        ' 
        ' MyListBox
        ' 
        MyListBox.FormattingEnabled = True
        MyListBox.ItemHeight = 20
        MyListBox.Location = New Point(281, 51)
        MyListBox.Name = "MyListBox"
        MyListBox.Size = New Size(213, 244)
        MyListBox.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(126, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(499, 36)
        Label1.TabIndex = 2
        Label1.Text = "Adding numbers Using a loop"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(MyListBox)
        Controls.Add(btnDO)
        Controls.Add(btnWhile)
        Controls.Add(btnClose)
        Name = "Form1"
        Text = "Adding numbers using a Loop"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnWhile As Button
    Friend WithEvents btnDO As Button
    Friend WithEvents MyListBox As ListBox
    Friend WithEvents Label1 As Label
End Class
