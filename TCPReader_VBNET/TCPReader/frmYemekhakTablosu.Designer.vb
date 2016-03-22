<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYemekhakTablosu
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
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dataGridView1.Location = New System.Drawing.Point(0, 482)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(874, 44)
        Me.dataGridView1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.dataGridView1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 66)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(874, 526)
        Me.panel1.TabIndex = 3
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.numericUpDown1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox1.Location = New System.Drawing.Point(0, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(874, 66)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        '
        'button2
        '
        Me.button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.button2.Location = New System.Drawing.Point(682, 16)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(97, 47)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Getir"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.button1.Location = New System.Drawing.Point(779, 16)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(92, 47)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Gönder"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(90, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Tablo Numarası : "
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(105, 16)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {63, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(81, 20)
        Me.numericUpDown1.TabIndex = 0
        '
        'frmYemekhakTablosu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 592)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "frmYemekhakTablosu"
        Me.Text = "frmYemekhakTablosu"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
