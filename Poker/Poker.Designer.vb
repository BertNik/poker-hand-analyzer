<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPoker))
        Me.lblCrd1 = New System.Windows.Forms.Label()
        Me.lblCrd2 = New System.Windows.Forms.Label()
        Me.lblCrd3 = New System.Windows.Forms.Label()
        Me.lblCrd4 = New System.Windows.Forms.Label()
        Me.lblCrd5 = New System.Windows.Forms.Label()
        Me.lblDenomination = New System.Windows.Forms.Label()
        Me.lblSuit = New System.Windows.Forms.Label()
        Me.btnDisplayHand = New System.Windows.Forms.Button()
        Me.txtBoxDisplayHand = New System.Windows.Forms.TextBox()
        Me.txtBoxDispBinary = New System.Windows.Forms.RichTextBox()
        Me.comBoxSuit01 = New System.Windows.Forms.ComboBox()
        Me.comBoxSuit02 = New System.Windows.Forms.ComboBox()
        Me.comBoxSuit03 = New System.Windows.Forms.ComboBox()
        Me.comBoxSuit04 = New System.Windows.Forms.ComboBox()
        Me.comBoxSuit05 = New System.Windows.Forms.ComboBox()
        Me.comBoxDenom01 = New System.Windows.Forms.ComboBox()
        Me.comBoxDenom02 = New System.Windows.Forms.ComboBox()
        Me.comBoxDenom03 = New System.Windows.Forms.ComboBox()
        Me.comBoxDenom04 = New System.Windows.Forms.ComboBox()
        Me.comBoxDenom05 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCrd1
        '
        Me.lblCrd1.AutoSize = True
        Me.lblCrd1.Location = New System.Drawing.Point(11, 23)
        Me.lblCrd1.Name = "lblCrd1"
        Me.lblCrd1.Size = New System.Drawing.Size(41, 13)
        Me.lblCrd1.TabIndex = 5
        Me.lblCrd1.Text = "Card 1:"
        '
        'lblCrd2
        '
        Me.lblCrd2.AutoSize = True
        Me.lblCrd2.Location = New System.Drawing.Point(11, 50)
        Me.lblCrd2.Name = "lblCrd2"
        Me.lblCrd2.Size = New System.Drawing.Size(41, 13)
        Me.lblCrd2.TabIndex = 6
        Me.lblCrd2.Text = "Card 2:"
        '
        'lblCrd3
        '
        Me.lblCrd3.AutoSize = True
        Me.lblCrd3.Location = New System.Drawing.Point(11, 77)
        Me.lblCrd3.Name = "lblCrd3"
        Me.lblCrd3.Size = New System.Drawing.Size(41, 13)
        Me.lblCrd3.TabIndex = 7
        Me.lblCrd3.Text = "Card 3:"
        '
        'lblCrd4
        '
        Me.lblCrd4.AutoSize = True
        Me.lblCrd4.Location = New System.Drawing.Point(11, 104)
        Me.lblCrd4.Name = "lblCrd4"
        Me.lblCrd4.Size = New System.Drawing.Size(41, 13)
        Me.lblCrd4.TabIndex = 8
        Me.lblCrd4.Text = "Card 4:"
        '
        'lblCrd5
        '
        Me.lblCrd5.AutoSize = True
        Me.lblCrd5.Location = New System.Drawing.Point(11, 131)
        Me.lblCrd5.Name = "lblCrd5"
        Me.lblCrd5.Size = New System.Drawing.Size(41, 13)
        Me.lblCrd5.TabIndex = 9
        Me.lblCrd5.Text = "Card 5:"
        '
        'lblDenomination
        '
        Me.lblDenomination.Location = New System.Drawing.Point(59, 8)
        Me.lblDenomination.Name = "lblDenomination"
        Me.lblDenomination.Size = New System.Drawing.Size(122, 13)
        Me.lblDenomination.TabIndex = 15
        Me.lblDenomination.Text = "Denomination"
        Me.lblDenomination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSuit
        '
        Me.lblSuit.Location = New System.Drawing.Point(187, 8)
        Me.lblSuit.Name = "lblSuit"
        Me.lblSuit.Size = New System.Drawing.Size(117, 13)
        Me.lblSuit.TabIndex = 16
        Me.lblSuit.Text = "Suit"
        Me.lblSuit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDisplayHand
        '
        Me.btnDisplayHand.Location = New System.Drawing.Point(14, 161)
        Me.btnDisplayHand.Name = "btnDisplayHand"
        Me.btnDisplayHand.Size = New System.Drawing.Size(84, 25)
        Me.btnDisplayHand.TabIndex = 10
        Me.btnDisplayHand.Text = "Display Hand"
        Me.btnDisplayHand.UseVisualStyleBackColor = True
        '
        'txtBoxDisplayHand
        '
        Me.txtBoxDisplayHand.BackColor = System.Drawing.Color.White
        Me.txtBoxDisplayHand.Location = New System.Drawing.Point(187, 163)
        Me.txtBoxDisplayHand.Name = "txtBoxDisplayHand"
        Me.txtBoxDisplayHand.ReadOnly = True
        Me.txtBoxDisplayHand.Size = New System.Drawing.Size(119, 20)
        Me.txtBoxDisplayHand.TabIndex = 18
        '
        'txtBoxDispBinary
        '
        Me.txtBoxDispBinary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxDispBinary.Location = New System.Drawing.Point(322, 24)
        Me.txtBoxDispBinary.Name = "txtBoxDispBinary"
        Me.txtBoxDispBinary.ReadOnly = True
        Me.txtBoxDispBinary.Size = New System.Drawing.Size(689, 129)
        Me.txtBoxDispBinary.TabIndex = 19
        Me.txtBoxDispBinary.Text = ""
        '
        'comBoxSuit01
        '
        Me.comBoxSuit01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxSuit01.FormattingEnabled = True
        Me.comBoxSuit01.Items.AddRange(New Object() {"Club", "Diamond", "Heart", "Spade"})
        Me.comBoxSuit01.Location = New System.Drawing.Point(187, 23)
        Me.comBoxSuit01.Name = "comBoxSuit01"
        Me.comBoxSuit01.Size = New System.Drawing.Size(119, 21)
        Me.comBoxSuit01.TabIndex = 1
        '
        'comBoxSuit02
        '
        Me.comBoxSuit02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxSuit02.FormattingEnabled = True
        Me.comBoxSuit02.Items.AddRange(New Object() {"Club", "Diamond", "Heart", "Spade"})
        Me.comBoxSuit02.Location = New System.Drawing.Point(187, 50)
        Me.comBoxSuit02.Name = "comBoxSuit02"
        Me.comBoxSuit02.Size = New System.Drawing.Size(119, 21)
        Me.comBoxSuit02.TabIndex = 3
        '
        'comBoxSuit03
        '
        Me.comBoxSuit03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxSuit03.FormattingEnabled = True
        Me.comBoxSuit03.Items.AddRange(New Object() {"Club", "Diamond", "Heart", "Spade"})
        Me.comBoxSuit03.Location = New System.Drawing.Point(187, 77)
        Me.comBoxSuit03.Name = "comBoxSuit03"
        Me.comBoxSuit03.Size = New System.Drawing.Size(119, 21)
        Me.comBoxSuit03.TabIndex = 5
        '
        'comBoxSuit04
        '
        Me.comBoxSuit04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxSuit04.FormattingEnabled = True
        Me.comBoxSuit04.Items.AddRange(New Object() {"Club", "Diamond", "Heart", "Spade"})
        Me.comBoxSuit04.Location = New System.Drawing.Point(187, 104)
        Me.comBoxSuit04.Name = "comBoxSuit04"
        Me.comBoxSuit04.Size = New System.Drawing.Size(119, 21)
        Me.comBoxSuit04.TabIndex = 7
        '
        'comBoxSuit05
        '
        Me.comBoxSuit05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxSuit05.FormattingEnabled = True
        Me.comBoxSuit05.Items.AddRange(New Object() {"Club", "Diamond", "Heart", "Spade"})
        Me.comBoxSuit05.Location = New System.Drawing.Point(187, 131)
        Me.comBoxSuit05.Name = "comBoxSuit05"
        Me.comBoxSuit05.Size = New System.Drawing.Size(119, 21)
        Me.comBoxSuit05.TabIndex = 9
        '
        'comBoxDenom01
        '
        Me.comBoxDenom01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxDenom01.FormattingEnabled = True
        Me.comBoxDenom01.Items.AddRange(New Object() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"})
        Me.comBoxDenom01.Location = New System.Drawing.Point(62, 23)
        Me.comBoxDenom01.Name = "comBoxDenom01"
        Me.comBoxDenom01.Size = New System.Drawing.Size(119, 21)
        Me.comBoxDenom01.TabIndex = 0
        '
        'comBoxDenom02
        '
        Me.comBoxDenom02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxDenom02.FormattingEnabled = True
        Me.comBoxDenom02.Items.AddRange(New Object() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"})
        Me.comBoxDenom02.Location = New System.Drawing.Point(62, 50)
        Me.comBoxDenom02.Name = "comBoxDenom02"
        Me.comBoxDenom02.Size = New System.Drawing.Size(119, 21)
        Me.comBoxDenom02.TabIndex = 2
        '
        'comBoxDenom03
        '
        Me.comBoxDenom03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxDenom03.FormattingEnabled = True
        Me.comBoxDenom03.Items.AddRange(New Object() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"})
        Me.comBoxDenom03.Location = New System.Drawing.Point(62, 77)
        Me.comBoxDenom03.Name = "comBoxDenom03"
        Me.comBoxDenom03.Size = New System.Drawing.Size(119, 21)
        Me.comBoxDenom03.TabIndex = 4
        '
        'comBoxDenom04
        '
        Me.comBoxDenom04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxDenom04.FormattingEnabled = True
        Me.comBoxDenom04.Items.AddRange(New Object() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"})
        Me.comBoxDenom04.Location = New System.Drawing.Point(62, 104)
        Me.comBoxDenom04.Name = "comBoxDenom04"
        Me.comBoxDenom04.Size = New System.Drawing.Size(119, 21)
        Me.comBoxDenom04.TabIndex = 6
        '
        'comBoxDenom05
        '
        Me.comBoxDenom05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBoxDenom05.FormattingEnabled = True
        Me.comBoxDenom05.Items.AddRange(New Object() {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"})
        Me.comBoxDenom05.Location = New System.Drawing.Point(62, 131)
        Me.comBoxDenom05.Name = "comBoxDenom05"
        Me.comBoxDenom05.Size = New System.Drawing.Size(119, 21)
        Me.comBoxDenom05.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(104, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Your Hand:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPoker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 195)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comBoxDenom05)
        Me.Controls.Add(Me.comBoxDenom04)
        Me.Controls.Add(Me.comBoxDenom03)
        Me.Controls.Add(Me.comBoxDenom02)
        Me.Controls.Add(Me.comBoxDenom01)
        Me.Controls.Add(Me.comBoxSuit05)
        Me.Controls.Add(Me.comBoxSuit04)
        Me.Controls.Add(Me.comBoxSuit03)
        Me.Controls.Add(Me.comBoxSuit02)
        Me.Controls.Add(Me.comBoxSuit01)
        Me.Controls.Add(Me.txtBoxDispBinary)
        Me.Controls.Add(Me.txtBoxDisplayHand)
        Me.Controls.Add(Me.btnDisplayHand)
        Me.Controls.Add(Me.lblSuit)
        Me.Controls.Add(Me.lblDenomination)
        Me.Controls.Add(Me.lblCrd5)
        Me.Controls.Add(Me.lblCrd4)
        Me.Controls.Add(Me.lblCrd3)
        Me.Controls.Add(Me.lblCrd2)
        Me.Controls.Add(Me.lblCrd1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1039, 235)
        Me.Name = "frmPoker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Poker Hand Analyzer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCrd1 As Label
    Friend WithEvents lblCrd2 As Label
    Friend WithEvents lblCrd3 As Label
    Friend WithEvents lblCrd4 As Label
    Friend WithEvents lblCrd5 As Label
    Friend WithEvents lblDenomination As Label
    Friend WithEvents lblSuit As Label
    Friend WithEvents btnDisplayHand As Button
    Friend WithEvents txtBoxDisplayHand As TextBox
    Friend WithEvents txtBoxDispBinary As RichTextBox
    Friend WithEvents comBoxSuit01 As ComboBox
    Friend WithEvents comBoxSuit02 As ComboBox
    Friend WithEvents comBoxSuit03 As ComboBox
    Friend WithEvents comBoxSuit04 As ComboBox
    Friend WithEvents comBoxSuit05 As ComboBox
    Friend WithEvents comBoxDenom01 As ComboBox
    Friend WithEvents comBoxDenom02 As ComboBox
    Friend WithEvents comBoxDenom03 As ComboBox
    Friend WithEvents comBoxDenom04 As ComboBox
    Friend WithEvents comBoxDenom05 As ComboBox
    Friend WithEvents Label1 As Label
End Class
