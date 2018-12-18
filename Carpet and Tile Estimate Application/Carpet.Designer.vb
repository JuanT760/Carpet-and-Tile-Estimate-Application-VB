<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carpet
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
        Me.chk1Bed = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBedroom = New System.Windows.Forms.Label()
        Me.lblEstimate = New System.Windows.Forms.Label()
        Me.lblDisplayEst = New System.Windows.Forms.Label()
        Me.chk2Bed = New System.Windows.Forms.CheckBox()
        Me.chk3Bed = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk1Living = New System.Windows.Forms.CheckBox()
        Me.chk2Living = New System.Windows.Forms.CheckBox()
        Me.chk3Living = New System.Windows.Forms.CheckBox()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.chkSenior = New System.Windows.Forms.CheckBox()
        Me.chkBuisness = New System.Windows.Forms.CheckBox()
        Me.chkHeavyStains = New System.Windows.Forms.CheckBox()
        Me.lblDiscounts = New System.Windows.Forms.Label()
        Me.chkFamily = New System.Windows.Forms.CheckBox()
        Me.chkRug = New System.Windows.Forms.CheckBox()
        Me.btnShowTile = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk1Bed
        '
        Me.chk1Bed.AutoSize = True
        Me.chk1Bed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.chk1Bed.Location = New System.Drawing.Point(12, 254)
        Me.chk1Bed.Name = "chk1Bed"
        Me.chk1Bed.Size = New System.Drawing.Size(201, 30)
        Me.chk1Bed.TabIndex = 0
        Me.chk1Bed.Text = "&1 Bedroom ($40)"
        Me.chk1Bed.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(361, 519)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(133, 66)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(546, 519)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 66)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBedroom
        '
        Me.lblBedroom.AutoSize = True
        Me.lblBedroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBedroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBedroom.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBedroom.Location = New System.Drawing.Point(47, 213)
        Me.lblBedroom.Name = "lblBedroom"
        Me.lblBedroom.Size = New System.Drawing.Size(127, 26)
        Me.lblBedroom.TabIndex = 16
        Me.lblBedroom.Text = "Bedrooms:"
        '
        'lblEstimate
        '
        Me.lblEstimate.AutoSize = True
        Me.lblEstimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstimate.Location = New System.Drawing.Point(357, 451)
        Me.lblEstimate.Name = "lblEstimate"
        Me.lblEstimate.Size = New System.Drawing.Size(169, 26)
        Me.lblEstimate.TabIndex = 11
        Me.lblEstimate.Text = "Estimate Cost:"
        '
        'lblDisplayEst
        '
        Me.lblDisplayEst.BackColor = System.Drawing.SystemColors.Info
        Me.lblDisplayEst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayEst.Location = New System.Drawing.Point(546, 437)
        Me.lblDisplayEst.Name = "lblDisplayEst"
        Me.lblDisplayEst.Size = New System.Drawing.Size(139, 40)
        Me.lblDisplayEst.TabIndex = 12
        '
        'chk2Bed
        '
        Me.chk2Bed.AutoSize = True
        Me.chk2Bed.Location = New System.Drawing.Point(12, 301)
        Me.chk2Bed.Name = "chk2Bed"
        Me.chk2Bed.Size = New System.Drawing.Size(212, 30)
        Me.chk2Bed.TabIndex = 1
        Me.chk2Bed.Text = "&2 Bedrooms ($80)"
        Me.chk2Bed.UseVisualStyleBackColor = True
        '
        'chk3Bed
        '
        Me.chk3Bed.AutoSize = True
        Me.chk3Bed.Location = New System.Drawing.Point(13, 354)
        Me.chk3Bed.Name = "chk3Bed"
        Me.chk3Bed.Size = New System.Drawing.Size(224, 30)
        Me.chk3Bed.TabIndex = 2
        Me.chk3Bed.Text = "&3 Bedrooms ($120)"
        Me.chk3Bed.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(285, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 26)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Living Room:"
        '
        'chk1Living
        '
        Me.chk1Living.AutoSize = True
        Me.chk1Living.Location = New System.Drawing.Point(268, 254)
        Me.chk1Living.Name = "chk1Living"
        Me.chk1Living.Size = New System.Drawing.Size(234, 30)
        Me.chk1Living.TabIndex = 3
        Me.chk1Living.Text = "&1 Living Room ($70)"
        Me.chk1Living.UseVisualStyleBackColor = True
        '
        'chk2Living
        '
        Me.chk2Living.AutoSize = True
        Me.chk2Living.Location = New System.Drawing.Point(269, 301)
        Me.chk2Living.Name = "chk2Living"
        Me.chk2Living.Size = New System.Drawing.Size(257, 30)
        Me.chk2Living.TabIndex = 4
        Me.chk2Living.Text = "&2 Living Rooms ($140)"
        Me.chk2Living.UseVisualStyleBackColor = True
        '
        'chk3Living
        '
        Me.chk3Living.AutoSize = True
        Me.chk3Living.Location = New System.Drawing.Point(268, 353)
        Me.chk3Living.Name = "chk3Living"
        Me.chk3Living.Size = New System.Drawing.Size(257, 30)
        Me.chk3Living.TabIndex = 5
        Me.chk3Living.Text = "&3 Living Rooms ($210)"
        Me.chk3Living.UseVisualStyleBackColor = True
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOther.ForeColor = System.Drawing.Color.Peru
        Me.lblOther.Location = New System.Drawing.Point(565, 213)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(78, 26)
        Me.lblOther.TabIndex = 18
        Me.lblOther.Text = "Other:"
        '
        'chkSenior
        '
        Me.chkSenior.AutoSize = True
        Me.chkSenior.Location = New System.Drawing.Point(36, 491)
        Me.chkSenior.Name = "chkSenior"
        Me.chkSenior.Size = New System.Drawing.Size(192, 30)
        Me.chkSenior.TabIndex = 9
        Me.chkSenior.Text = "&Senior Discount"
        Me.chkSenior.UseVisualStyleBackColor = True
        '
        'chkBuisness
        '
        Me.chkBuisness.AutoSize = True
        Me.chkBuisness.Location = New System.Drawing.Point(570, 301)
        Me.chkBuisness.Name = "chkBuisness"
        Me.chkBuisness.Size = New System.Drawing.Size(183, 30)
        Me.chkBuisness.TabIndex = 7
        Me.chkBuisness.Text = "&Buisness ($65)"
        Me.chkBuisness.UseVisualStyleBackColor = True
        '
        'chkHeavyStains
        '
        Me.chkHeavyStains.AutoSize = True
        Me.chkHeavyStains.Location = New System.Drawing.Point(570, 353)
        Me.chkHeavyStains.Name = "chkHeavyStains"
        Me.chkHeavyStains.Size = New System.Drawing.Size(223, 30)
        Me.chkHeavyStains.TabIndex = 8
        Me.chkHeavyStains.Text = "&Heavy Stains ($25)"
        Me.chkHeavyStains.UseVisualStyleBackColor = True
        '
        'lblDiscounts
        '
        Me.lblDiscounts.AutoSize = True
        Me.lblDiscounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.916231!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscounts.ForeColor = System.Drawing.Color.Red
        Me.lblDiscounts.Location = New System.Drawing.Point(66, 451)
        Me.lblDiscounts.Name = "lblDiscounts"
        Me.lblDiscounts.Size = New System.Drawing.Size(124, 26)
        Me.lblDiscounts.TabIndex = 15
        Me.lblDiscounts.Text = "Discounts:"
        '
        'chkFamily
        '
        Me.chkFamily.AutoSize = True
        Me.chkFamily.Location = New System.Drawing.Point(36, 528)
        Me.chkFamily.Name = "chkFamily"
        Me.chkFamily.Size = New System.Drawing.Size(103, 30)
        Me.chkFamily.TabIndex = 10
        Me.chkFamily.Text = "&Family"
        Me.chkFamily.UseVisualStyleBackColor = True
        '
        'chkRug
        '
        Me.chkRug.AutoSize = True
        Me.chkRug.Location = New System.Drawing.Point(570, 253)
        Me.chkRug.Name = "chkRug"
        Me.chkRug.Size = New System.Drawing.Size(134, 30)
        Me.chkRug.TabIndex = 6
        Me.chkRug.Text = "&Rug ($10)"
        Me.chkRug.UseVisualStyleBackColor = True
        '
        'btnShowTile
        '
        Me.btnShowTile.Location = New System.Drawing.Point(705, 437)
        Me.btnShowTile.Name = "btnShowTile"
        Me.btnShowTile.Size = New System.Drawing.Size(101, 148)
        Me.btnShowTile.TabIndex = 19
        Me.btnShowTile.Text = "Tile"
        Me.btnShowTile.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Carpet_and_Tile_Estimate_Application.My.Resources.Resources._534301_orig
        Me.PictureBox1.Location = New System.Drawing.Point(268, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(561, 216)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 188)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(253, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 191)
        Me.Panel2.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(3, 216)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(234, 188)
        Me.Panel3.TabIndex = 22
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(3, 437)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(290, 148)
        Me.Panel4.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(335, 410)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(483, 185)
        Me.Panel5.TabIndex = 24
        '
        'Carpet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 597)
        Me.Controls.Add(Me.btnShowTile)
        Me.Controls.Add(Me.chkRug)
        Me.Controls.Add(Me.chkFamily)
        Me.Controls.Add(Me.lblDiscounts)
        Me.Controls.Add(Me.chkHeavyStains)
        Me.Controls.Add(Me.chkBuisness)
        Me.Controls.Add(Me.chkSenior)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.chk3Living)
        Me.Controls.Add(Me.chk2Living)
        Me.Controls.Add(Me.chk1Living)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk3Bed)
        Me.Controls.Add(Me.chk2Bed)
        Me.Controls.Add(Me.lblDisplayEst)
        Me.Controls.Add(Me.lblEstimate)
        Me.Controls.Add(Me.lblBedroom)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.chk1Bed)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "Carpet"
        Me.Text = "Carpet Estimate"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chk1Bed As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblBedroom As Label
    Friend WithEvents lblEstimate As Label
    Friend WithEvents lblDisplayEst As Label
    Friend WithEvents chk2Bed As CheckBox
    Friend WithEvents chk3Bed As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chk1Living As CheckBox
    Friend WithEvents chk2Living As CheckBox
    Friend WithEvents chk3Living As CheckBox
    Friend WithEvents lblOther As Label
    Friend WithEvents chkSenior As CheckBox
    Friend WithEvents chkBuisness As CheckBox
    Friend WithEvents chkHeavyStains As CheckBox
    Friend WithEvents lblDiscounts As Label
    Friend WithEvents chkFamily As CheckBox
    Friend WithEvents chkRug As CheckBox
    Friend WithEvents btnShowTile As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
