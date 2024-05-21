<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        BtnTambah = New Button()
        TxtMenu = New TextBox()
        GroupBox2 = New GroupBox()
        ListOrder = New ListBox()
        BtnPesan = New Button()
        TxtJumlah = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        CboNama = New ComboBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ControlDark
        GroupBox1.Controls.Add(BtnTambah)
        GroupBox1.Controls.Add(TxtMenu)
        GroupBox1.Location = New Point(0, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(328, 147)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Menu"
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Location = New Point(75, 79)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(170, 34)
        BtnTambah.TabIndex = 1
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' TxtMenu
        ' 
        TxtMenu.Location = New Point(12, 30)
        TxtMenu.Name = "TxtMenu"
        TxtMenu.Size = New Size(291, 31)
        TxtMenu.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.AppWorkspace
        GroupBox2.Controls.Add(ListOrder)
        GroupBox2.Controls.Add(BtnPesan)
        GroupBox2.Controls.Add(TxtJumlah)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(CboNama)
        GroupBox2.Location = New Point(372, 1)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(311, 373)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pemesanan"
        ' 
        ' ListOrder
        ' 
        ListOrder.FormattingEnabled = True
        ListOrder.ItemHeight = 25
        ListOrder.Location = New Point(20, 182)
        ListOrder.Name = "ListOrder"
        ListOrder.Size = New Size(272, 179)
        ListOrder.TabIndex = 3
        ' 
        ' BtnPesan
        ' 
        BtnPesan.Location = New Point(93, 110)
        BtnPesan.Name = "BtnPesan"
        BtnPesan.Size = New Size(198, 61)
        BtnPesan.TabIndex = 2
        BtnPesan.Text = "Pesan"
        BtnPesan.UseVisualStyleBackColor = True
        ' 
        ' TxtJumlah
        ' 
        TxtJumlah.Location = New Point(20, 137)
        TxtJumlah.Name = "TxtJumlah"
        TxtJumlah.Size = New Size(67, 31)
        TxtJumlah.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 25)
        Label2.TabIndex = 2
        Label2.Text = "Jumlah"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 25)
        Label1.TabIndex = 1
        Label1.Text = "Nama Makanan/Minuman"
        ' 
        ' CboNama
        ' 
        CboNama.FormattingEnabled = True
        CboNama.Location = New Point(20, 67)
        CboNama.Name = "CboNama"
        CboNama.Size = New Size(271, 33)
        CboNama.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(703, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Pertemuan 3"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtMenu As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CboNama As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnPesan As Button
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents ListOrder As ListBox

End Class
