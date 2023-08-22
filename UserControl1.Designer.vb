<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.HH = New System.Windows.Forms.Label()
        Me.MM = New System.Windows.Forms.Label()
        Me.SS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.start_btn = New System.Windows.Forms.Button()
        Me.stop_btn = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.RESET_BTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HH
        '
        Me.HH.AutoSize = True
        Me.HH.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HH.Location = New System.Drawing.Point(118, 106)
        Me.HH.Name = "HH"
        Me.HH.Size = New System.Drawing.Size(41, 29)
        Me.HH.TabIndex = 0
        Me.HH.Text = "00"
        Me.HH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MM
        '
        Me.MM.AutoSize = True
        Me.MM.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MM.Location = New System.Drawing.Point(296, 109)
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(41, 29)
        Me.MM.TabIndex = 1
        Me.MM.Text = "00"
        Me.MM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SS
        '
        Me.SS.AutoSize = True
        Me.SS.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SS.Location = New System.Drawing.Point(491, 106)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(41, 29)
        Me.SS.TabIndex = 2
        Me.SS.Text = "00"
        Me.SS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(204, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = ":"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.Timer1.ImageSize = New System.Drawing.Size(16, 16)
        Me.Timer1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'start_btn
        '
        Me.start_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_btn.Location = New System.Drawing.Point(42, 237)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(159, 58)
        Me.start_btn.TabIndex = 5
        Me.start_btn.Text = "START"
        Me.start_btn.UseVisualStyleBackColor = True
        '
        'stop_btn
        '
        Me.stop_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stop_btn.Location = New System.Drawing.Point(465, 237)
        Me.stop_btn.Name = "stop_btn"
        Me.stop_btn.Size = New System.Drawing.Size(134, 58)
        Me.stop_btn.TabIndex = 6
        Me.stop_btn.Text = "STOP"
        Me.stop_btn.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'RESET_BTN
        '
        Me.RESET_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESET_BTN.Location = New System.Drawing.Point(267, 237)
        Me.RESET_BTN.Name = "RESET_BTN"
        Me.RESET_BTN.Size = New System.Drawing.Size(119, 58)
        Me.RESET_BTN.TabIndex = 7
        Me.RESET_BTN.Text = "RESET"
        Me.RESET_BTN.UseVisualStyleBackColor = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.Controls.Add(Me.RESET_BTN)
        Me.Controls.Add(Me.stop_btn)
        Me.Controls.Add(Me.start_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.MM)
        Me.Controls.Add(Me.HH)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(673, 413)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HH As Label
    Friend WithEvents MM As Label
    Friend WithEvents SS As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As ImageList
    Friend WithEvents Label5 As Label
    Friend WithEvents start_btn As Button
    Friend WithEvents stop_btn As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents RESET_BTN As Button
End Class
