﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDGWindow
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CDGWindow))
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(300, 216)
    Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'CDGWindow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.Black
    Me.ClientSize = New System.Drawing.Size(300, 216)
    Me.Controls.Add(Me.PictureBox1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.KeyPreview = True
    Me.Name = "CDGWindow"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Karaoke"
    Me.TopMost = True
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
