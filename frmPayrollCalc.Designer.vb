<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayrollCalc))
        Me.picPayroll = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblSubHeading = New System.Windows.Forms.Label()
        Me.lblEnterGross = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblFed = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPayroll
        '
        Me.picPayroll.Image = CType(resources.GetObject("picPayroll.Image"), System.Drawing.Image)
        Me.picPayroll.Location = New System.Drawing.Point(-1, -1)
        Me.picPayroll.Name = "picPayroll"
        Me.picPayroll.Size = New System.Drawing.Size(378, 211)
        Me.picPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPayroll.TabIndex = 0
        Me.picPayroll.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(521, 36)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(51, 17)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Label1"
        '
        'lblSubHeading
        '
        Me.lblSubHeading.AutoSize = True
        Me.lblSubHeading.Location = New System.Drawing.Point(521, 138)
        Me.lblSubHeading.Name = "lblSubHeading"
        Me.lblSubHeading.Size = New System.Drawing.Size(51, 17)
        Me.lblSubHeading.TabIndex = 2
        Me.lblSubHeading.Text = "Label2"
        '
        'lblEnterGross
        '
        Me.lblEnterGross.AutoSize = True
        Me.lblEnterGross.Location = New System.Drawing.Point(214, 241)
        Me.lblEnterGross.Name = "lblEnterGross"
        Me.lblEnterGross.Size = New System.Drawing.Size(51, 17)
        Me.lblEnterGross.TabIndex = 3
        Me.lblEnterGross.Text = "Label3"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(462, 241)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 22)
        Me.txtGrossPay.TabIndex = 4
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Location = New System.Drawing.Point(107, 412)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(51, 17)
        Me.lblFICA.TabIndex = 5
        Me.lblFICA.Text = "Label4"
        '
        'lblFed
        '
        Me.lblFed.AutoSize = True
        Me.lblFed.Location = New System.Drawing.Point(356, 412)
        Me.lblFed.Name = "lblFed"
        Me.lblFed.Size = New System.Drawing.Size(51, 17)
        Me.lblFed.TabIndex = 6
        Me.lblFed.Text = "Label5"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(611, 412)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(51, 17)
        Me.lblState.TabIndex = 7
        Me.lblState.Text = "Label6"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Location = New System.Drawing.Point(326, 487)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(51, 17)
        Me.lblNetIncome.TabIndex = 8
        Me.lblNetIncome.Text = "Label7"
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.Location = New System.Drawing.Point(92, 330)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnTaxCalc.TabIndex = 9
        Me.btnTaxCalc.Text = "Button1"
        Me.btnTaxCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(347, 330)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Button2"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(601, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Button3"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPayrollCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 540)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFed)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblEnterGross)
        Me.Controls.Add(Me.lblSubHeading)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picPayroll)
        Me.Name = "frmPayrollCalc"
        Me.Text = "Payroll Calculator"
        CType(Me.picPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPayroll As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblEnterGross As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFed As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
