<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmrKontorFiyatListesi
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
        Me.btnGonder = New System.Windows.Forms.Button()
        Me.txtListeAdi = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnGetir = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(0, 60)
        Me.dataGridView1.MultiSelect = False
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataGridView1.Size = New System.Drawing.Size(896, 575)
        Me.dataGridView1.TabIndex = 3
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btnGonder)
        Me.panel1.Controls.Add(Me.txtListeAdi)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Controls.Add(Me.btnGetir)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.numericUpDown1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(896, 60)
        Me.panel1.TabIndex = 2
        '
        'btnGonder
        '
        Me.btnGonder.Location = New System.Drawing.Point(725, 12)
        Me.btnGonder.Name = "btnGonder"
        Me.btnGonder.Size = New System.Drawing.Size(75, 23)
        Me.btnGonder.TabIndex = 7
        Me.btnGonder.Text = "Gönder"
        Me.btnGonder.UseVisualStyleBackColor = True
        '
        'txtListeAdi
        '
        Me.txtListeAdi.Location = New System.Drawing.Point(494, 13)
        Me.txtListeAdi.Name = "txtListeAdi"
        Me.txtListeAdi.Size = New System.Drawing.Size(216, 20)
        Me.txtListeAdi.TabIndex = 6
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(431, 19)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Liste Adı : "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(267, 18)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(36, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Gün : "
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"})
        Me.comboBox1.Location = New System.Drawing.Point(304, 13)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(120, 21)
        Me.comboBox1.TabIndex = 3
        '
        'btnGetir
        '
        Me.btnGetir.Location = New System.Drawing.Point(185, 12)
        Me.btnGetir.Name = "btnGetir"
        Me.btnGetir.Size = New System.Drawing.Size(75, 23)
        Me.btnGetir.TabIndex = 2
        Me.btnGetir.Text = "Getir"
        Me.btnGetir.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Tablo No : "
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(90, 14)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(89, 20)
        Me.numericUpDown1.TabIndex = 0
        '
        'fmrKontorFiyatListesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 635)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "fmrKontorFiyatListesi"
        Me.Text = "fmrKontorFiyatListesi"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents btnGonder As System.Windows.Forms.Button
    Private WithEvents txtListeAdi As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents btnGetir As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
