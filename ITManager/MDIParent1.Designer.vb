<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.TabelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilizadoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssetsToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssetsToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlocaçõesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabelasToolStripMenuItem, Me.EditMenu, Me.EmpresasToolStripMenuItem1, Me.UtilizadoresToolStripMenuItem1, Me.ContratosToolStripMenuItem1, Me.AssetsToolStripMenuItem2, Me.AlocaçõesToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1001, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'TabelasToolStripMenuItem
        '
        Me.TabelasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.TabelasToolStripMenuItem.Name = "TabelasToolStripMenuItem"
        Me.TabelasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.TabelasToolStripMenuItem.Text = "Ficheiro"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Enabled = False
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(49, 20)
        Me.EditMenu.Text = "Editar"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SettingsToolStripMenuItem.Text = "Definições SQL"
        '
        'EmpresasToolStripMenuItem1
        '
        Me.EmpresasToolStripMenuItem1.Name = "EmpresasToolStripMenuItem1"
        Me.EmpresasToolStripMenuItem1.Size = New System.Drawing.Size(69, 20)
        Me.EmpresasToolStripMenuItem1.Text = "Empresas"
        '
        'UtilizadoresToolStripMenuItem1
        '
        Me.UtilizadoresToolStripMenuItem1.Name = "UtilizadoresToolStripMenuItem1"
        Me.UtilizadoresToolStripMenuItem1.Size = New System.Drawing.Size(80, 20)
        Me.UtilizadoresToolStripMenuItem1.Text = "Utilizadores"
        '
        'ContratosToolStripMenuItem1
        '
        Me.ContratosToolStripMenuItem1.Name = "ContratosToolStripMenuItem1"
        Me.ContratosToolStripMenuItem1.Size = New System.Drawing.Size(71, 20)
        Me.ContratosToolStripMenuItem1.Text = "Contratos"
        '
        'AssetsToolStripMenuItem2
        '
        Me.AssetsToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssetsToolStripMenuItem3, Me.TiposToolStripMenuItem})
        Me.AssetsToolStripMenuItem2.Name = "AssetsToolStripMenuItem2"
        Me.AssetsToolStripMenuItem2.Size = New System.Drawing.Size(52, 20)
        Me.AssetsToolStripMenuItem2.Text = "Assets"
        '
        'AssetsToolStripMenuItem3
        '
        Me.AssetsToolStripMenuItem3.Name = "AssetsToolStripMenuItem3"
        Me.AssetsToolStripMenuItem3.Size = New System.Drawing.Size(107, 22)
        Me.AssetsToolStripMenuItem3.Text = "Assets"
        '
        'TiposToolStripMenuItem
        '
        Me.TiposToolStripMenuItem.Name = "TiposToolStripMenuItem"
        Me.TiposToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.TiposToolStripMenuItem.Text = "Tipos"
        '
        'AlocaçõesToolStripMenuItem1
        '
        Me.AlocaçõesToolStripMenuItem1.Name = "AlocaçõesToolStripMenuItem1"
        Me.AlocaçõesToolStripMenuItem1.Size = New System.Drawing.Size(73, 20)
        Me.AlocaçõesToolStripMenuItem1.Text = "Alocações"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 559)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1001, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 581)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IT Manager"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilizadoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssetsToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssetsToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlocaçõesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
