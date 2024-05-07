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
        txtInitialAmount = New TextBox()
        txtAmountExpected = New TextBox()
        txtTimeInvolved = New TextBox()
        txtInterestRate = New TextBox()
        lblCalculate = New Button()
        lblClear = New Button()
        lblExit = New Button()
        lblInitialAmount = New Label()
        lblInterestRate = New Label()
        Label3 = New Label()
        lblAmountExpected = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtInitialAmount
        ' 
        txtInitialAmount.BackColor = SystemColors.Window
        txtInitialAmount.Location = New Point(217, 63)
        txtInitialAmount.Name = "txtInitialAmount"
        txtInitialAmount.Size = New Size(100, 23)
        txtInitialAmount.TabIndex = 0
        ' 
        ' txtAmountExpected
        ' 
        txtAmountExpected.Location = New Point(544, 146)
        txtAmountExpected.Name = "txtAmountExpected"
        txtAmountExpected.Size = New Size(100, 23)
        txtAmountExpected.TabIndex = 1
        ' 
        ' txtTimeInvolved
        ' 
        txtTimeInvolved.Location = New Point(217, 214)
        txtTimeInvolved.Name = "txtTimeInvolved"
        txtTimeInvolved.Size = New Size(100, 23)
        txtTimeInvolved.TabIndex = 2
        ' 
        ' txtInterestRate
        ' 
        txtInterestRate.Location = New Point(217, 133)
        txtInterestRate.Name = "txtInterestRate"
        txtInterestRate.Size = New Size(100, 23)
        txtInterestRate.TabIndex = 3
        ' 
        ' lblCalculate
        ' 
        lblCalculate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCalculate.Location = New Point(155, 301)
        lblCalculate.Name = "lblCalculate"
        lblCalculate.Size = New Size(116, 23)
        lblCalculate.TabIndex = 4
        lblCalculate.Text = "CALCULATE"
        lblCalculate.UseVisualStyleBackColor = True
        ' 
        ' lblClear
        ' 
        lblClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblClear.Location = New Point(354, 301)
        lblClear.Name = "lblClear"
        lblClear.Size = New Size(116, 23)
        lblClear.TabIndex = 5
        lblClear.Text = "CLEAR"
        lblClear.UseVisualStyleBackColor = True
        ' 
        ' lblExit
        ' 
        lblExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExit.Location = New Point(558, 301)
        lblExit.Name = "lblExit"
        lblExit.Size = New Size(116, 23)
        lblExit.TabIndex = 6
        lblExit.Text = "EXIT"
        lblExit.UseVisualStyleBackColor = True
        ' 
        ' lblInitialAmount
        ' 
        lblInitialAmount.AutoSize = True
        lblInitialAmount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInitialAmount.Location = New Point(88, 71)
        lblInitialAmount.Name = "lblInitialAmount"
        lblInitialAmount.Size = New Size(123, 15)
        lblInitialAmount.TabIndex = 7
        lblInitialAmount.Text = "INITIAL AMOUNT (P)"
        ' 
        ' lblInterestRate
        ' 
        lblInterestRate.AutoSize = True
        lblInterestRate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInterestRate.Location = New Point(31, 141)
        lblInterestRate.Name = "lblInterestRate"
        lblInterestRate.Size = New Size(180, 15)
        lblInterestRate.TabIndex = 8
        lblInterestRate.Text = "INTEREST RATE IN PERCENT (R)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(44, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 15)
        Label3.TabIndex = 9
        Label3.Text = "TIME INVOLVED IN YEARS (t)"
        ' 
        ' lblAmountExpected
        ' 
        lblAmountExpected.AutoSize = True
        lblAmountExpected.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAmountExpected.Location = New Point(337, 149)
        lblAmountExpected.Name = "lblAmountExpected"
        lblAmountExpected.Size = New Size(201, 15)
        lblAmountExpected.TabIndex = 10
        lblAmountExpected.Text = "AMOUNT OF MONEY EXPECTED (A)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = My.Resources.Resources.Compound_interest_logo_png2
        PictureBox1.Location = New Point(1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(803, 373)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(lblAmountExpected)
        Controls.Add(Label3)
        Controls.Add(lblInterestRate)
        Controls.Add(lblInitialAmount)
        Controls.Add(lblExit)
        Controls.Add(lblClear)
        Controls.Add(lblCalculate)
        Controls.Add(txtInterestRate)
        Controls.Add(txtTimeInvolved)
        Controls.Add(txtAmountExpected)
        Controls.Add(txtInitialAmount)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "COMPOUND INTEREST CALCULATOR     A = P * ((1 + (r / n)) ^ (n * t))     r = R / 100     n = 1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInitialAmount As TextBox
    Friend WithEvents txtAmountExpected As TextBox
    Friend WithEvents txtTimeInvolved As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents lblCalculate As Button
    Friend WithEvents lblClear As Button
    Friend WithEvents lblExit As Button
    Friend WithEvents lblInitialAmount As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAmountExpected As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
