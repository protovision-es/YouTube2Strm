<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.INDAuto = New System.Windows.Forms.Panel()
        Me.PBXThumbVideo = New System.Windows.Forms.PictureBox()
        Me.LBLUrl = New System.Windows.Forms.Label()
        Me.BTTCrearSTRM = New System.Windows.Forms.Button()
        Me.BTTAutosave = New System.Windows.Forms.Button()
        Me.BTTDelete = New System.Windows.Forms.Button()
        Me.TBXDirectorioSal = New System.Windows.Forms.TextBox()
        Me.BTTDirectorioSal = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PBXStateIcon = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBXClipboardDetect = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BTTOptions = New System.Windows.Forms.Button()
        Me.LBLTitle = New System.Windows.Forms.Label()
        Me.LBLThumInfo = New System.Windows.Forms.Label()
        CType(Me.PBXThumbVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBXStateIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'INDAuto
        '
        Me.INDAuto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.INDAuto.Location = New System.Drawing.Point(173, 321)
        Me.INDAuto.Name = "INDAuto"
        Me.INDAuto.Size = New System.Drawing.Size(12, 18)
        Me.INDAuto.TabIndex = 2
        '
        'PBXThumbVideo
        '
        Me.PBXThumbVideo.BackColor = System.Drawing.Color.DimGray
        Me.PBXThumbVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBXThumbVideo.Image = Global.YouTube2Strm.My.Resources.Resources.dargscreen
        Me.PBXThumbVideo.Location = New System.Drawing.Point(0, 0)
        Me.PBXThumbVideo.Name = "PBXThumbVideo"
        Me.PBXThumbVideo.Size = New System.Drawing.Size(423, 237)
        Me.PBXThumbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBXThumbVideo.TabIndex = 9
        Me.PBXThumbVideo.TabStop = False
        '
        'LBLUrl
        '
        Me.LBLUrl.BackColor = System.Drawing.Color.Gray
        Me.LBLUrl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUrl.Location = New System.Drawing.Point(-1, 237)
        Me.LBLUrl.Name = "LBLUrl"
        Me.LBLUrl.Size = New System.Drawing.Size(425, 37)
        Me.LBLUrl.TabIndex = 11
        Me.LBLUrl.Text = "- - -"
        Me.LBLUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTTCrearSTRM
        '
        Me.BTTCrearSTRM.BackColor = System.Drawing.Color.Transparent
        Me.BTTCrearSTRM.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTTCrearSTRM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTTCrearSTRM.Location = New System.Drawing.Point(373, 315)
        Me.BTTCrearSTRM.Name = "BTTCrearSTRM"
        Me.BTTCrearSTRM.Size = New System.Drawing.Size(46, 30)
        Me.BTTCrearSTRM.TabIndex = 12
        Me.BTTCrearSTRM.Text = "Save"
        Me.BTTCrearSTRM.UseVisualStyleBackColor = False
        '
        'BTTAutosave
        '
        Me.BTTAutosave.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTTAutosave.Location = New System.Drawing.Point(167, 315)
        Me.BTTAutosave.Name = "BTTAutosave"
        Me.BTTAutosave.Size = New System.Drawing.Size(81, 30)
        Me.BTTAutosave.TabIndex = 13
        Me.BTTAutosave.Text = "AutoSave"
        Me.BTTAutosave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTTAutosave.UseVisualStyleBackColor = True
        '
        'BTTDelete
        '
        Me.BTTDelete.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTTDelete.Location = New System.Drawing.Point(312, 315)
        Me.BTTDelete.Name = "BTTDelete"
        Me.BTTDelete.Size = New System.Drawing.Size(58, 30)
        Me.BTTDelete.TabIndex = 14
        Me.BTTDelete.Text = "Delete"
        Me.BTTDelete.UseVisualStyleBackColor = True
        '
        'TBXDirectorioSal
        '
        Me.TBXDirectorioSal.Enabled = False
        Me.TBXDirectorioSal.Location = New System.Drawing.Point(31, 349)
        Me.TBXDirectorioSal.Name = "TBXDirectorioSal"
        Me.TBXDirectorioSal.Size = New System.Drawing.Size(348, 20)
        Me.TBXDirectorioSal.TabIndex = 15
        '
        'BTTDirectorioSal
        '
        Me.BTTDirectorioSal.Location = New System.Drawing.Point(383, 348)
        Me.BTTDirectorioSal.Name = "BTTDirectorioSal"
        Me.BTTDirectorioSal.Size = New System.Drawing.Size(36, 22)
        Me.BTTDirectorioSal.TabIndex = 16
        Me.BTTDirectorioSal.Text = ". . ."
        Me.BTTDirectorioSal.UseVisualStyleBackColor = True
        '
        'PBXStateIcon
        '
        Me.PBXStateIcon.BackColor = System.Drawing.Color.Transparent
        Me.PBXStateIcon.Location = New System.Drawing.Point(383, 196)
        Me.PBXStateIcon.Name = "PBXStateIcon"
        Me.PBXStateIcon.Size = New System.Drawing.Size(30, 30)
        Me.PBXStateIcon.TabIndex = 17
        Me.PBXStateIcon.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "To:"
        '
        'CBXClipboardDetect
        '
        Me.CBXClipboardDetect.AutoSize = True
        Me.CBXClipboardDetect.Checked = True
        Me.CBXClipboardDetect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBXClipboardDetect.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBXClipboardDetect.Location = New System.Drawing.Point(15, 322)
        Me.CBXClipboardDetect.Name = "CBXClipboardDetect"
        Me.CBXClipboardDetect.Size = New System.Drawing.Size(145, 18)
        Me.CBXClipboardDetect.TabIndex = 19
        Me.CBXClipboardDetect.Text = "Auto Clipboard Detect"
        Me.CBXClipboardDetect.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'BTTOptions
        '
        Me.BTTOptions.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTTOptions.Location = New System.Drawing.Point(251, 315)
        Me.BTTOptions.Name = "BTTOptions"
        Me.BTTOptions.Size = New System.Drawing.Size(58, 30)
        Me.BTTOptions.TabIndex = 22
        Me.BTTOptions.Text = "Options"
        Me.BTTOptions.UseVisualStyleBackColor = True
        '
        'LBLTitle
        '
        Me.LBLTitle.BackColor = System.Drawing.Color.DarkGray
        Me.LBLTitle.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.Location = New System.Drawing.Point(-1, 274)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(425, 37)
        Me.LBLTitle.TabIndex = 23
        Me.LBLTitle.Text = "- - -"
        Me.LBLTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBLThumInfo
        '
        Me.LBLThumInfo.BackColor = System.Drawing.Color.Transparent
        Me.LBLThumInfo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLThumInfo.ForeColor = System.Drawing.Color.White
        Me.LBLThumInfo.Location = New System.Drawing.Point(0, 0)
        Me.LBLThumInfo.Name = "LBLThumInfo"
        Me.LBLThumInfo.Size = New System.Drawing.Size(423, 21)
        Me.LBLThumInfo.TabIndex = 24
        Me.LBLThumInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 376)
        Me.Controls.Add(Me.LBLThumInfo)
        Me.Controls.Add(Me.LBLTitle)
        Me.Controls.Add(Me.BTTOptions)
        Me.Controls.Add(Me.LBLUrl)
        Me.Controls.Add(Me.CBXClipboardDetect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBXStateIcon)
        Me.Controls.Add(Me.BTTDirectorioSal)
        Me.Controls.Add(Me.TBXDirectorioSal)
        Me.Controls.Add(Me.BTTDelete)
        Me.Controls.Add(Me.INDAuto)
        Me.Controls.Add(Me.BTTAutosave)
        Me.Controls.Add(Me.BTTCrearSTRM)
        Me.Controls.Add(Me.PBXThumbVideo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(439, 415)
        Me.MinimumSize = New System.Drawing.Size(439, 415)
        Me.Name = "Form1"
        Me.Text = "2Strm"
        CType(Me.PBXThumbVideo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBXStateIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents INDAuto As System.Windows.Forms.Panel
    Friend WithEvents PBXThumbVideo As System.Windows.Forms.PictureBox
    Friend WithEvents LBLUrl As System.Windows.Forms.Label
    Friend WithEvents BTTCrearSTRM As System.Windows.Forms.Button
    Friend WithEvents BTTAutosave As System.Windows.Forms.Button
    Friend WithEvents BTTDelete As System.Windows.Forms.Button
    Friend WithEvents TBXDirectorioSal As System.Windows.Forms.TextBox
    Friend WithEvents BTTDirectorioSal As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents PBXStateIcon As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBXClipboardDetect As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BTTOptions As System.Windows.Forms.Button
    Friend WithEvents LBLTitle As System.Windows.Forms.Label
    Friend WithEvents LBLThumInfo As System.Windows.Forms.Label

End Class
