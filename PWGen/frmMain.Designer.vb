<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtPasswords = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudLength = New System.Windows.Forms.NumericUpDown()
        Me.chkSymbols = New System.Windows.Forms.CheckBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.nudPasswordCount = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPasswordCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPasswords
        '
        Me.txtPasswords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPasswords.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswords.Location = New System.Drawing.Point(12, 41)
        Me.txtPasswords.Multiline = True
        Me.txtPasswords.Name = "txtPasswords"
        Me.txtPasswords.ReadOnly = True
        Me.txtPasswords.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPasswords.Size = New System.Drawing.Size(652, 191)
        Me.txtPasswords.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length"
        '
        'nudLength
        '
        Me.nudLength.Location = New System.Drawing.Point(59, 11)
        Me.nudLength.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
        Me.nudLength.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudLength.Name = "nudLength"
        Me.nudLength.Size = New System.Drawing.Size(54, 20)
        Me.nudLength.TabIndex = 4
        Me.nudLength.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'chkSymbols
        '
        Me.chkSymbols.AutoSize = True
        Me.chkSymbols.Checked = True
        Me.chkSymbols.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSymbols.Location = New System.Drawing.Point(136, 13)
        Me.chkSymbols.Name = "chkSymbols"
        Me.chkSymbols.Size = New System.Drawing.Size(57, 17)
        Me.chkSymbols.TabIndex = 1
        Me.chkSymbols.Text = "Strong"
        Me.chkSymbols.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(590, 238)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 8
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'nudPasswordCount
        '
        Me.nudPasswordCount.Location = New System.Drawing.Point(326, 10)
        Me.nudPasswordCount.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nudPasswordCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPasswordCount.Name = "nudPasswordCount"
        Me.nudPasswordCount.Size = New System.Drawing.Size(76, 20)
        Me.nudPasswordCount.TabIndex = 3
        Me.nudPasswordCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Passwords"
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.Location = New System.Drawing.Point(509, 238)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 7
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Location = New System.Drawing.Point(9, 238)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(399, 23)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Idle"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCreate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 273)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudPasswordCount)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.chkSymbols)
        Me.Controls.Add(Me.nudLength)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPasswords)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(415, 300)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Generator"
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPasswordCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPasswords As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkSymbols As System.Windows.Forms.CheckBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents nudPasswordCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
