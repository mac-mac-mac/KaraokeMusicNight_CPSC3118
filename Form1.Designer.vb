<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KaraokeMusicNight
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
        Me.picMusic = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.cboSelection = New System.Windows.Forms.ComboBox()
        Me.lblSongsHours = New System.Windows.Forms.Label()
        Me.txtInputNum = New System.Windows.Forms.TextBox()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.picMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMusic
        '
        Me.picMusic.BackgroundImage = Global.KaraokeMusicNight_CPSC3118.My.Resources.Resources.karaoke
        Me.picMusic.Location = New System.Drawing.Point(0, 0)
        Me.picMusic.Name = "picMusic"
        Me.picMusic.Size = New System.Drawing.Size(350, 457)
        Me.picMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMusic.TabIndex = 0
        Me.picMusic.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(430, 30)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(286, 32)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Karaoke Music Night"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSelection
        '
        Me.cboSelection.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelection.FormattingEnabled = True
        Me.cboSelection.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboSelection.Location = New System.Drawing.Point(372, 87)
        Me.cboSelection.Name = "cboSelection"
        Me.cboSelection.Size = New System.Drawing.Size(407, 29)
        Me.cboSelection.TabIndex = 2
        '
        'lblSongsHours
        '
        Me.lblSongsHours.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongsHours.ForeColor = System.Drawing.Color.White
        Me.lblSongsHours.Location = New System.Drawing.Point(412, 185)
        Me.lblSongsHours.Name = "lblSongsHours"
        Me.lblSongsHours.Size = New System.Drawing.Size(339, 32)
        Me.lblSongsHours.TabIndex = 3
        Me.lblSongsHours.Text = "Hourly Rental of Karaoke Room:"
        Me.lblSongsHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInputNum
        '
        Me.txtInputNum.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputNum.Location = New System.Drawing.Point(543, 230)
        Me.txtInputNum.Name = "txtInputNum"
        Me.txtInputNum.Size = New System.Drawing.Size(64, 33)
        Me.txtInputNum.TabIndex = 4
        '
        'btnTotalCost
        '
        Me.btnTotalCost.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCost.Location = New System.Drawing.Point(396, 304)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(150, 50)
        Me.btnTotalCost.TabIndex = 5
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(601, 304)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 50)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(392, 384)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(359, 32)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.Text = "Total Cost of Karaoke Night - $X.XX"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KaraokeMusicNight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 457)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTotalCost)
        Me.Controls.Add(Me.txtInputNum)
        Me.Controls.Add(Me.lblSongsHours)
        Me.Controls.Add(Me.cboSelection)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picMusic)
        Me.Name = "KaraokeMusicNight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karaoke Music Night"
        CType(Me.picMusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMusic As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents cboSelection As ComboBox
    Friend WithEvents lblSongsHours As Label
    Friend WithEvents txtInputNum As TextBox
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCost As Label
End Class
