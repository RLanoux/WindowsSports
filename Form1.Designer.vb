<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSportList = New System.Windows.Forms.ComboBox()
        Me.picSport = New System.Windows.Forms.PictureBox()
        Me.btnMtc = New System.Windows.Forms.Button()
        CType(Me.picSport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pick the sport that you like:"
        '
        'cboSportList
        '
        Me.cboSportList.FormattingEnabled = True
        Me.cboSportList.Location = New System.Drawing.Point(153, 6)
        Me.cboSportList.Name = "cboSportList"
        Me.cboSportList.Size = New System.Drawing.Size(146, 21)
        Me.cboSportList.Sorted = True
        Me.cboSportList.TabIndex = 1
        '
        'picSport
        '
        Me.picSport.Location = New System.Drawing.Point(15, 33)
        Me.picSport.Name = "picSport"
        Me.picSport.Size = New System.Drawing.Size(500, 500)
        Me.picSport.TabIndex = 2
        Me.picSport.TabStop = False
        '
        'btnMtc
        '
        Me.btnMtc.Location = New System.Drawing.Point(429, 6)
        Me.btnMtc.Name = "btnMtc"
        Me.btnMtc.Size = New System.Drawing.Size(86, 21)
        Me.btnMtc.TabIndex = 4
        Me.btnMtc.Text = "Maintenance"
        Me.btnMtc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 546)
        Me.Controls.Add(Me.btnMtc)
        Me.Controls.Add(Me.picSport)
        Me.Controls.Add(Me.cboSportList)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sports List"
        CType(Me.picSport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSportList As System.Windows.Forms.ComboBox
    Friend WithEvents picSport As System.Windows.Forms.PictureBox
    Friend WithEvents btnMtc As System.Windows.Forms.Button

End Class
