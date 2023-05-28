<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.usrCount = New System.Windows.Forms.Button()
        Me.GameName = New System.Windows.Forms.Button()
        Me.GameSales = New System.Windows.Forms.Button()
        Me.DeveloperRating = New System.Windows.Forms.Button()
        Me.CriticScore = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(111, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game Infomation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'usrCount
        '
        Me.usrCount.BackColor = System.Drawing.Color.DimGray
        Me.usrCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.usrCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrCount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.usrCount.Location = New System.Drawing.Point(117, 295)
        Me.usrCount.Name = "usrCount"
        Me.usrCount.Size = New System.Drawing.Size(200, 40)
        Me.usrCount.TabIndex = 1
        Me.usrCount.Text = "User Score Count"
        Me.usrCount.UseVisualStyleBackColor = False
        '
        'GameName
        '
        Me.GameName.BackColor = System.Drawing.Color.DimGray
        Me.GameName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GameName.Location = New System.Drawing.Point(117, 207)
        Me.GameName.Name = "GameName"
        Me.GameName.Size = New System.Drawing.Size(200, 40)
        Me.GameName.TabIndex = 2
        Me.GameName.Text = "Game Name"
        Me.GameName.UseVisualStyleBackColor = False
        '
        'GameSales
        '
        Me.GameSales.BackColor = System.Drawing.Color.DimGray
        Me.GameSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GameSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameSales.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GameSales.Location = New System.Drawing.Point(491, 203)
        Me.GameSales.Name = "GameSales"
        Me.GameSales.Size = New System.Drawing.Size(200, 44)
        Me.GameSales.TabIndex = 3
        Me.GameSales.Text = "Game Sales"
        Me.GameSales.UseVisualStyleBackColor = False
        '
        'DeveloperRating
        '
        Me.DeveloperRating.BackColor = System.Drawing.Color.DimGray
        Me.DeveloperRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeveloperRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeveloperRating.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.DeveloperRating.Location = New System.Drawing.Point(491, 295)
        Me.DeveloperRating.Name = "DeveloperRating"
        Me.DeveloperRating.Size = New System.Drawing.Size(200, 44)
        Me.DeveloperRating.TabIndex = 4
        Me.DeveloperRating.Text = "Developer Rating"
        Me.DeveloperRating.UseVisualStyleBackColor = False
        '
        'CriticScore
        '
        Me.CriticScore.BackColor = System.Drawing.Color.DimGray
        Me.CriticScore.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.CriticScore.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CriticScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CriticScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CriticScore.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CriticScore.Location = New System.Drawing.Point(305, 398)
        Me.CriticScore.Name = "CriticScore"
        Me.CriticScore.Size = New System.Drawing.Size(200, 44)
        Me.CriticScore.TabIndex = 5
        Me.CriticScore.Text = "Critic Score"
        Me.CriticScore.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(372, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(318, 34)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Management System"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(696, 475)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(804, 523)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CriticScore)
        Me.Controls.Add(Me.DeveloperRating)
        Me.Controls.Add(Me.GameSales)
        Me.Controls.Add(Me.GameName)
        Me.Controls.Add(Me.usrCount)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents usrCount As Button
    Friend WithEvents GameName As Button
    Friend WithEvents GameSales As Button
    Friend WithEvents DeveloperRating As Button
    Friend WithEvents CriticScore As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
End Class
