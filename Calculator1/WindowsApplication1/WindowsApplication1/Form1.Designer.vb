<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorialTwo
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
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.lblSecondNumber = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(397, 59)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(58, 20)
        Me.txtFirstNumber.TabIndex = 0
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(560, 122)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(40, 41)
        Me.btnDivide.TabIndex = 3
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(415, 201)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 41)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(415, 122)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(40, 41)
        Me.btnMultiply.TabIndex = 5
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.Location = New System.Drawing.Point(560, 201)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(40, 41)
        Me.btnSubtract.TabIndex = 6
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(560, 59)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(58, 20)
        Me.txtSecondNumber.TabIndex = 7
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.AutoSize = True
        Me.lblFirstNumber.Location = New System.Drawing.Point(389, 22)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(66, 13)
        Me.lblFirstNumber.TabIndex = 8
        Me.lblFirstNumber.Text = "First Number"
        '
        'lblSecondNumber
        '
        Me.lblSecondNumber.AutoSize = True
        Me.lblSecondNumber.Location = New System.Drawing.Point(557, 22)
        Me.lblSecondNumber.Name = "lblSecondNumber"
        Me.lblSecondNumber.Size = New System.Drawing.Size(84, 13)
        Me.lblSecondNumber.TabIndex = 9
        Me.lblSecondNumber.Text = "Second Number"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(415, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(185, 46)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmTutorialTwo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(1020, 424)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblSecondNumber)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Name = "frmTutorialTwo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents txtSecondNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstNumber As System.Windows.Forms.Label
    Friend WithEvents lblSecondNumber As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
