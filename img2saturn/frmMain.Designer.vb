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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tsMain = New System.Windows.Forms.ToolStrip()
        Me.tsbLoad = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbConvert = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tspbProcessing = New System.Windows.Forms.ToolStripProgressBar()
        Me.lvImages = New System.Windows.Forms.ListView()
        Me.chFilePath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chOutputFile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ilIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.tsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLoad, Me.ToolStripSeparator1, Me.tsbConvert, Me.ToolStripSeparator2, Me.tsbAbout, Me.ToolStripSeparator3, Me.tspbProcessing})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(794, 25)
        Me.tsMain.TabIndex = 0
        '
        'tsbLoad
        '
        Me.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLoad.Image = Global.img2saturn.My.Resources.Resources.folder__arrow
        Me.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLoad.Name = "tsbLoad"
        Me.tsbLoad.Size = New System.Drawing.Size(23, 22)
        Me.tsbLoad.Text = "Load Image(s)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbConvert
        '
        Me.tsbConvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbConvert.Image = Global.img2saturn.My.Resources.Resources.spectrum_absorption
        Me.tsbConvert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConvert.Name = "tsbConvert"
        Me.tsbConvert.Size = New System.Drawing.Size(23, 22)
        Me.tsbConvert.Text = "Process"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbAbout.Image = Global.img2saturn.My.Resources.Resources.information
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(23, 22)
        Me.tsbAbout.Text = "About"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tspbProcessing
        '
        Me.tspbProcessing.Name = "tspbProcessing"
        Me.tspbProcessing.Size = New System.Drawing.Size(100, 22)
        '
        'lvImages
        '
        Me.lvImages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvImages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFilePath, Me.chOutputFile, Me.chStatus})
        Me.lvImages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvImages.HideSelection = False
        Me.lvImages.Location = New System.Drawing.Point(12, 28)
        Me.lvImages.Name = "lvImages"
        Me.lvImages.Size = New System.Drawing.Size(770, 402)
        Me.lvImages.SmallImageList = Me.ilIcons
        Me.lvImages.TabIndex = 1
        Me.lvImages.UseCompatibleStateImageBehavior = False
        Me.lvImages.View = System.Windows.Forms.View.Details
        '
        'chFilePath
        '
        Me.chFilePath.Text = "File Path"
        Me.chFilePath.Width = 438
        '
        'chOutputFile
        '
        Me.chOutputFile.Text = "Output File"
        Me.chOutputFile.Width = 115
        '
        'chStatus
        '
        Me.chStatus.Text = "Status"
        Me.chStatus.Width = 123
        '
        'ilIcons
        '
        Me.ilIcons.ImageStream = CType(resources.GetObject("ilIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.ilIcons.Images.SetKeyName(0, "image.png")
        Me.ilIcons.Images.SetKeyName(1, "tick-circle.png")
        Me.ilIcons.Images.SetKeyName(2, "cross-circle.png")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 442)
        Me.Controls.Add(Me.lvImages)
        Me.Controls.Add(Me.tsMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "img2saturn"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents tsbLoad As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbConvert As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbAbout As ToolStripButton
    Friend WithEvents lvImages As ListView
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tspbProcessing As ToolStripProgressBar
    Friend WithEvents ilIcons As ImageList
    Friend WithEvents chFilePath As ColumnHeader
    Friend WithEvents chOutputFile As ColumnHeader
    Friend WithEvents chStatus As ColumnHeader
End Class
