<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tile
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
        Me.lblDisplayEst0 = New System.Windows.Forms.Label()
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblBedroom = New System.Windows.Forms.Label()
        Me.txtBed = New System.Windows.Forms.TextBox()
        Me.txtLiving = New System.Windows.Forms.TextBox()
        Me.lblDisplayEst1 = New System.Windows.Forms.Label()
        Me.lblLiving = New System.Windows.Forms.Label()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDisplayEst0
        '
        Me.lblDisplayEst0.BackColor = System.Drawing.SystemColors.Info
        Me.lblDisplayEst0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayEst0.Location = New System.Drawing.Point(227, 342)
        Me.lblDisplayEst0.Name = "lblDisplayEst0"
        Me.lblDisplayEst0.Size = New System.Drawing.Size(130, 35)
        Me.lblDisplayEst0.TabIndex = 7
        '
        'lblEstimate
        '
        Me.lblEstimate.AutoSize = True
        Me.lblEstimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimate.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblEstimate.Location = New System.Drawing.Point(2, 343)
        Me.lblEstimate.Name = "lblEstimate"
        Me.lblEstimate.Size = New System.Drawing.Size(155, 26)
        Me.lblEstimate.TabIndex = 5
        Me.lblEstimate.Text = "Estimate Cost:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(454, 417)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 69)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(207, 417)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(150, 69)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblBedroom
        '
        Me.lblBedroom.AutoSize = True
        Me.lblBedroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBedroom.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBedroom.Location = New System.Drawing.Point(23, 0)
        Me.lblBedroom.Name = "lblBedroom"
        Me.lblBedroom.Size = New System.Drawing.Size(189, 26)
        Me.lblBedroom.TabIndex = 0
        Me.lblBedroom.Text = "Bedrooms: ($70)"
        '
        'txtBed
        '
        Me.txtBed.Location = New System.Drawing.Point(227, 288)
        Me.txtBed.Name = "txtBed"
        Me.txtBed.Size = New System.Drawing.Size(130, 31)
        Me.txtBed.TabIndex = 0
        '
        'txtLiving
        '
        Me.txtLiving.Location = New System.Drawing.Point(474, 291)
        Me.txtLiving.Name = "txtLiving"
        Me.txtLiving.Size = New System.Drawing.Size(114, 31)
        Me.txtLiving.TabIndex = 1
        '
        'lblDisplayEst1
        '
        Me.lblDisplayEst1.BackColor = System.Drawing.SystemColors.Info
        Me.lblDisplayEst1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayEst1.Location = New System.Drawing.Point(474, 342)
        Me.lblDisplayEst1.Name = "lblDisplayEst1"
        Me.lblDisplayEst1.Size = New System.Drawing.Size(114, 35)
        Me.lblDisplayEst1.TabIndex = 8
        '
        'lblLiving
        '
        Me.lblLiving.AutoSize = True
        Me.lblLiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLiving.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblLiving.Location = New System.Drawing.Point(449, 247)
        Me.lblLiving.Name = "lblLiving"
        Me.lblLiving.Size = New System.Drawing.Size(227, 26)
        Me.lblLiving.TabIndex = 6
        Me.lblLiving.Text = "Living Room: ($120)"
        '
        'picBox1
        '
        Me.picBox1.Image = Global.Carpet_and_Tile_Estimate_Application.My.Resources.Resources.tile_cleaning
        Me.picBox1.Location = New System.Drawing.Point(113, 12)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(438, 224)
        Me.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox1.TabIndex = 0
        Me.picBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Room Amount:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(431, 247)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 152)
        Me.Panel2.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblBedroom)
        Me.Panel1.Location = New System.Drawing.Point(167, 247)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 152)
        Me.Panel1.TabIndex = 9
        '
        'Tile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 499)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLiving)
        Me.Controls.Add(Me.lblDisplayEst1)
        Me.Controls.Add(Me.txtLiving)
        Me.Controls.Add(Me.txtBed)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.lblDisplayEst0)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Tile"
        Me.Text = "Tile Estimate"
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents lblDisplayEst0 As Label
    Friend WithEvents lblEstimate As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblBedroom As Label
    Friend WithEvents txtBed As TextBox
    Friend WithEvents txtLiving As TextBox
    Friend WithEvents lblDisplayEst1 As Label
    Friend WithEvents lblLiving As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
