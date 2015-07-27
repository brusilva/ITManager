<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCmdSql
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnLigar = New System.Windows.Forms.Button()
        Me.btnExecutar = New System.Windows.Forms.Button()
        Me.txbRespostaSql = New System.Windows.Forms.TextBox()
        Me.txbLigação = New System.Windows.Forms.TextBox()
        Me.txbCmdSql = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Ligação SQL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Comando SQL:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Resultado:"
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(646, 312)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 9
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnLigar
        '
        Me.btnLigar.Location = New System.Drawing.Point(646, 60)
        Me.btnLigar.Name = "btnLigar"
        Me.btnLigar.Size = New System.Drawing.Size(75, 23)
        Me.btnLigar.TabIndex = 8
        Me.btnLigar.Text = "L&igar"
        Me.btnLigar.UseVisualStyleBackColor = True
        '
        'btnExecutar
        '
        Me.btnExecutar.Location = New System.Drawing.Point(646, 186)
        Me.btnExecutar.Name = "btnExecutar"
        Me.btnExecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnExecutar.TabIndex = 7
        Me.btnExecutar.Text = "&Executar"
        Me.btnExecutar.UseVisualStyleBackColor = True
        '
        'txbRespostaSql
        '
        Me.txbRespostaSql.Location = New System.Drawing.Point(12, 228)
        Me.txbRespostaSql.Multiline = True
        Me.txbRespostaSql.Name = "txbRespostaSql"
        Me.txbRespostaSql.Size = New System.Drawing.Size(628, 107)
        Me.txbRespostaSql.TabIndex = 4
        '
        'txbLigação
        '
        Me.txbLigação.Location = New System.Drawing.Point(12, 28)
        Me.txbLigação.Multiline = True
        Me.txbLigação.Name = "txbLigação"
        Me.txbLigação.Size = New System.Drawing.Size(628, 55)
        Me.txbLigação.TabIndex = 5
        '
        'txbCmdSql
        '
        Me.txbCmdSql.Location = New System.Drawing.Point(12, 102)
        Me.txbCmdSql.Multiline = True
        Me.txbCmdSql.Name = "txbCmdSql"
        Me.txbCmdSql.Size = New System.Drawing.Size(628, 107)
        Me.txbCmdSql.TabIndex = 6
        '
        'frmCmdSql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 351)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnLigar)
        Me.Controls.Add(Me.btnExecutar)
        Me.Controls.Add(Me.txbRespostaSql)
        Me.Controls.Add(Me.txbLigação)
        Me.Controls.Add(Me.txbCmdSql)
        Me.Name = "frmCmdSql"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comandos SQL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnLigar As System.Windows.Forms.Button
    Friend WithEvents btnExecutar As System.Windows.Forms.Button
    Friend WithEvents txbRespostaSql As System.Windows.Forms.TextBox
    Friend WithEvents txbLigação As System.Windows.Forms.TextBox
    Friend WithEvents txbCmdSql As System.Windows.Forms.TextBox
End Class
