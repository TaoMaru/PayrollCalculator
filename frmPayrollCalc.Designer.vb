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
        Me.lblHeading.Font = New System.Drawing.Font("Cooper Black", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(396, 29)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(384, 57)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Payroll Calculator"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSubHeading
        '
        Me.lblSubHeading.Font = New System.Drawing.Font("Cooper Black", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeading.Location = New System.Drawing.Point(456, 104)
        Me.lblSubHeading.Name = "lblSubHeading"
        Me.lblSubHeading.Size = New System.Drawing.Size(242, 88)
        Me.lblSubHeading.TabIndex = 2
        Me.lblSubHeading.Text = "Paycheck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        Me.lblSubHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEnterGross
        '
        Me.lblEnterGross.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterGross.Location = New System.Drawing.Point(177, 253)
        Me.lblEnterGross.Name = "lblEnterGross"
        Me.lblEnterGross.Size = New System.Drawing.Size(200, 29)
        Me.lblEnterGross.TabIndex = 3
        Me.lblEnterGross.Text = "Enter Gross Pay: "
        Me.lblEnterGross.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(462, 253)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(117, 28)
        Me.txtGrossPay.TabIndex = 4
        Me.txtGrossPay.Text = "888888.88"
        '
        'lblFICA
        '
        Me.lblFICA.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(107, 412)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(185, 32)
        Me.lblFICA.TabIndex = 5
        Me.lblFICA.Text = "FICA Tax: "
        '
        'lblFed
        '
        Me.lblFed.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFed.Location = New System.Drawing.Point(356, 412)
        Me.lblFed.Name = "lblFed"
        Me.lblFed.Size = New System.Drawing.Size(185, 32)
        Me.lblFed.TabIndex = 6
        Me.lblFed.Text = "Federal Tax: "
        '
        'lblState
        '
        Me.lblState.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(611, 412)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(185, 32)
        Me.lblState.TabIndex = 7
        Me.lblState.Text = "State Tax: "
        '
        'lblNetIncome
        '
        Me.lblNetIncome.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetIncome.Location = New System.Drawing.Point(269, 487)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(270, 33)
        Me.lblNetIncome.TabIndex = 8
        Me.lblNetIncome.Text = "Net Paycheck Income: "
        Me.lblNetIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTaxCalc.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaxCalc.ForeColor = System.Drawing.Color.White
        Me.btnTaxCalc.Location = New System.Drawing.Point(92, 330)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(138, 35)
        Me.btnTaxCalc.TabIndex = 9
        Me.btnTaxCalc.Text = "Compute Tax"
        Me.btnTaxCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(347, 330)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(138, 35)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(601, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 35)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
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
