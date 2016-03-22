<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYemekOgunTablosu
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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGetir = New System.Windows.Forms.Button()
        Me.btnGonder = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtGun = New System.Windows.Forms.ComboBox()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 64)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(902, 535)
        Me.panel1.TabIndex = 3
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnGetir)
        Me.groupBox1.Controls.Add(Me.btnGonder)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtGun)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox1.Location = New System.Drawing.Point(0, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(902, 64)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        '
        'btnGetir
        '
        Me.btnGetir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGetir.Location = New System.Drawing.Point(673, 16)
        Me.btnGetir.Name = "btnGetir"
        Me.btnGetir.Size = New System.Drawing.Size(117, 45)
        Me.btnGetir.TabIndex = 3
        Me.btnGetir.Text = "Getir"
        Me.btnGetir.UseVisualStyleBackColor = True
        '
        'btnGonder
        '
        Me.btnGonder.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGonder.Location = New System.Drawing.Point(790, 16)
        Me.btnGonder.Name = "btnGonder"
        Me.btnGonder.Size = New System.Drawing.Size(109, 45)
        Me.btnGonder.TabIndex = 2
        Me.btnGonder.Text = "Gönder"
        Me.btnGonder.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(36, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Gün : "
        '
        'txtGun
        '
        Me.txtGun.FormattingEnabled = True
        Me.txtGun.Items.AddRange(New Object() {"Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"})
        Me.txtGun.Location = New System.Drawing.Point(54, 19)
        Me.txtGun.Name = "txtGun"
        Me.txtGun.Size = New System.Drawing.Size(121, 21)
        Me.txtGun.TabIndex = 0
        '
        'frmYemekOgunTablosu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 599)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "frmYemekOgunTablosu"
        Me.Text = "frmYemekOgunTablosu"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnGetir As System.Windows.Forms.Button
    Private WithEvents btnGonder As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtGun As System.Windows.Forms.ComboBox
End Class
