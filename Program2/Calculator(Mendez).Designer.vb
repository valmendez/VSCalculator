<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.rdbAdd = New System.Windows.Forms.RadioButton()
        Me.rdbSubtract = New System.Windows.Forms.RadioButton()
        Me.rdbMultiply = New System.Windows.Forms.RadioButton()
        Me.rdbDivide = New System.Windows.Forms.RadioButton()
        Me.rdbExponent = New System.Windows.Forms.RadioButton()
        Me.LabelSign = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(103, 14)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(116, 21)
        Me.txtnum1.TabIndex = 0
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(103, 103)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(116, 21)
        Me.txtnum2.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(37, 280)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 27)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAnswer
        '
        Me.btnAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer.Location = New System.Drawing.Point(231, 276)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(87, 27)
        Me.btnAnswer.TabIndex = 20
        Me.btnAnswer.Text = "EQUAL(=)"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbExponent)
        Me.GroupBox1.Controls.Add(Me.rdbDivide)
        Me.GroupBox1.Controls.Add(Me.rdbMultiply)
        Me.GroupBox1.Controls.Add(Me.rdbSubtract)
        Me.GroupBox1.Controls.Add(Me.rdbAdd)
        Me.GroupBox1.Location = New System.Drawing.Point(276, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 261)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an operation:"
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1.Location = New System.Drawing.Point(34, 14)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(53, 13)
        Me.lblNumber1.TabIndex = 23
        Me.lblNumber1.Text = "Number1:"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.Location = New System.Drawing.Point(34, 103)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(56, 13)
        Me.lblNumber2.TabIndex = 24
        Me.lblNumber2.Text = "Number 2:"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(324, 280)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(164, 21)
        Me.txtAnswer.TabIndex = 25
        '
        'rdbAdd
        '
        Me.rdbAdd.AutoSize = True
        Me.rdbAdd.Checked = True
        Me.rdbAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdd.Location = New System.Drawing.Point(7, 44)
        Me.rdbAdd.Name = "rdbAdd"
        Me.rdbAdd.Size = New System.Drawing.Size(64, 19)
        Me.rdbAdd.TabIndex = 0
        Me.rdbAdd.TabStop = True
        Me.rdbAdd.Text = "Add (+)"
        Me.rdbAdd.UseVisualStyleBackColor = True
        '
        'rdbSubtract
        '
        Me.rdbSubtract.AutoSize = True
        Me.rdbSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbSubtract.Location = New System.Drawing.Point(7, 70)
        Me.rdbSubtract.Name = "rdbSubtract"
        Me.rdbSubtract.Size = New System.Drawing.Size(85, 19)
        Me.rdbSubtract.TabIndex = 1
        Me.rdbSubtract.Text = "Subtract (-)"
        Me.rdbSubtract.UseVisualStyleBackColor = True
        '
        'rdbMultiply
        '
        Me.rdbMultiply.AutoSize = True
        Me.rdbMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMultiply.Location = New System.Drawing.Point(7, 97)
        Me.rdbMultiply.Name = "rdbMultiply"
        Me.rdbMultiply.Size = New System.Drawing.Size(84, 19)
        Me.rdbMultiply.TabIndex = 2
        Me.rdbMultiply.Text = "Multiply (x)"
        Me.rdbMultiply.UseVisualStyleBackColor = True
        '
        'rdbDivide
        '
        Me.rdbDivide.AutoSize = True
        Me.rdbDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDivide.Location = New System.Drawing.Point(7, 123)
        Me.rdbDivide.Name = "rdbDivide"
        Me.rdbDivide.Size = New System.Drawing.Size(73, 19)
        Me.rdbDivide.TabIndex = 3
        Me.rdbDivide.Text = "Divide (/)"
        Me.rdbDivide.UseVisualStyleBackColor = True
        '
        'rdbExponent
        '
        Me.rdbExponent.AutoSize = True
        Me.rdbExponent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbExponent.Location = New System.Drawing.Point(7, 150)
        Me.rdbExponent.Name = "rdbExponent"
        Me.rdbExponent.Size = New System.Drawing.Size(94, 19)
        Me.rdbExponent.TabIndex = 4
        Me.rdbExponent.Text = "Exponent (^)"
        Me.rdbExponent.UseVisualStyleBackColor = True
        '
        'LabelSign
        '
        Me.LabelSign.AutoSize = True
        Me.LabelSign.Location = New System.Drawing.Point(34, 57)
        Me.LabelSign.Name = "LabelSign"
        Me.LabelSign.Size = New System.Drawing.Size(14, 15)
        Me.LabelSign.TabIndex = 5
        Me.LabelSign.Text = "+"
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(401, 313)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(87, 27)
        Me.btnQuit.TabIndex = 26
        Me.btnQuit.Text = "EXIT"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 352)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.LabelSign)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCalculator"
        Me.Text = "Calculator(Mendez)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAnswer As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents rdbExponent As RadioButton
    Friend WithEvents rdbDivide As RadioButton
    Friend WithEvents rdbMultiply As RadioButton
    Friend WithEvents rdbSubtract As RadioButton
    Friend WithEvents rdbAdd As RadioButton
    Friend WithEvents LabelSign As Label
    Friend WithEvents btnQuit As Button
End Class
