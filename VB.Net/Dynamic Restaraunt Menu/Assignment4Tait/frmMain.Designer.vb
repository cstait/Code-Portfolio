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
        Me.lblDishes = New System.Windows.Forms.Label()
        Me.lblPrepped = New System.Windows.Forms.Label()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.lblAllPrepped = New System.Windows.Forms.Label()
        Me.lstPreppedItems = New System.Windows.Forms.ListBox()
        Me.lstAllRaw = New System.Windows.Forms.ListBox()
        Me.lstDishes = New System.Windows.Forms.ListBox()
        Me.lstPreppedDish = New System.Windows.Forms.ListBox()
        Me.lstRaw = New System.Windows.Forms.ListBox()
        Me.btnAddDish = New System.Windows.Forms.Button()
        Me.btnAddRaw = New System.Windows.Forms.Button()
        Me.btnAddPrepped = New System.Windows.Forms.Button()
        Me.txtAddRaw = New System.Windows.Forms.TextBox()
        Me.txtAddDish = New System.Windows.Forms.TextBox()
        Me.txtAddPrepped = New System.Windows.Forms.TextBox()
        Me.lblAllRaw = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDishes
        '
        Me.lblDishes.AutoSize = True
        Me.lblDishes.Location = New System.Drawing.Point(48, 9)
        Me.lblDishes.Name = "lblDishes"
        Me.lblDishes.Size = New System.Drawing.Size(87, 13)
        Me.lblDishes.TabIndex = 0
        Me.lblDishes.Text = "List of All Dishes:"
        '
        'lblPrepped
        '
        Me.lblPrepped.AutoSize = True
        Me.lblPrepped.Location = New System.Drawing.Point(48, 206)
        Me.lblPrepped.Name = "lblPrepped"
        Me.lblPrepped.Size = New System.Drawing.Size(158, 13)
        Me.lblPrepped.TabIndex = 1
        Me.lblPrepped.Text = "Prepped Items in Selected Dish:"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Location = New System.Drawing.Point(48, 383)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(209, 13)
        Me.lblRaw.TabIndex = 2
        Me.lblRaw.Text = "Raw Ingredients in Selected Prepped Item:"
        '
        'lblAllPrepped
        '
        Me.lblAllPrepped.AutoSize = True
        Me.lblAllPrepped.Location = New System.Drawing.Point(693, 206)
        Me.lblAllPrepped.Name = "lblAllPrepped"
        Me.lblAllPrepped.Size = New System.Drawing.Size(123, 13)
        Me.lblAllPrepped.TabIndex = 3
        Me.lblAllPrepped.Text = "List of All Prepped Items:"
        '
        'lstPreppedItems
        '
        Me.lstPreppedItems.FormattingEnabled = True
        Me.lstPreppedItems.Location = New System.Drawing.Point(696, 222)
        Me.lstPreppedItems.Name = "lstPreppedItems"
        Me.lstPreppedItems.Size = New System.Drawing.Size(322, 95)
        Me.lstPreppedItems.TabIndex = 4
        '
        'lstAllRaw
        '
        Me.lstAllRaw.FormattingEnabled = True
        Me.lstAllRaw.Location = New System.Drawing.Point(696, 402)
        Me.lstAllRaw.Name = "lstAllRaw"
        Me.lstAllRaw.Size = New System.Drawing.Size(322, 95)
        Me.lstAllRaw.TabIndex = 5
        '
        'lstDishes
        '
        Me.lstDishes.FormattingEnabled = True
        Me.lstDishes.Location = New System.Drawing.Point(51, 26)
        Me.lstDishes.Name = "lstDishes"
        Me.lstDishes.Size = New System.Drawing.Size(967, 121)
        Me.lstDishes.TabIndex = 6
        '
        'lstPreppedDish
        '
        Me.lstPreppedDish.FormattingEnabled = True
        Me.lstPreppedDish.Location = New System.Drawing.Point(51, 222)
        Me.lstPreppedDish.Name = "lstPreppedDish"
        Me.lstPreppedDish.Size = New System.Drawing.Size(322, 95)
        Me.lstPreppedDish.TabIndex = 7
        '
        'lstRaw
        '
        Me.lstRaw.FormattingEnabled = True
        Me.lstRaw.Location = New System.Drawing.Point(51, 402)
        Me.lstRaw.Name = "lstRaw"
        Me.lstRaw.Size = New System.Drawing.Size(322, 95)
        Me.lstRaw.TabIndex = 8
        '
        'btnAddDish
        '
        Me.btnAddDish.Location = New System.Drawing.Point(696, 153)
        Me.btnAddDish.Name = "btnAddDish"
        Me.btnAddDish.Size = New System.Drawing.Size(75, 48)
        Me.btnAddDish.TabIndex = 9
        Me.btnAddDish.Text = "Add New Dish"
        Me.btnAddDish.UseVisualStyleBackColor = True
        '
        'btnAddRaw
        '
        Me.btnAddRaw.Location = New System.Drawing.Point(696, 323)
        Me.btnAddRaw.Name = "btnAddRaw"
        Me.btnAddRaw.Size = New System.Drawing.Size(75, 48)
        Me.btnAddRaw.TabIndex = 10
        Me.btnAddRaw.Text = "Add New Prepped Item"
        Me.btnAddRaw.UseVisualStyleBackColor = True
        '
        'btnAddPrepped
        '
        Me.btnAddPrepped.Location = New System.Drawing.Point(696, 503)
        Me.btnAddPrepped.Name = "btnAddPrepped"
        Me.btnAddPrepped.Size = New System.Drawing.Size(75, 48)
        Me.btnAddPrepped.TabIndex = 11
        Me.btnAddPrepped.Text = "Add new Raw ingredient"
        Me.btnAddPrepped.UseVisualStyleBackColor = True
        '
        'txtAddRaw
        '
        Me.txtAddRaw.Location = New System.Drawing.Point(777, 503)
        Me.txtAddRaw.Name = "txtAddRaw"
        Me.txtAddRaw.Size = New System.Drawing.Size(241, 20)
        Me.txtAddRaw.TabIndex = 16
        '
        'txtAddDish
        '
        Me.txtAddDish.Location = New System.Drawing.Point(777, 155)
        Me.txtAddDish.Name = "txtAddDish"
        Me.txtAddDish.Size = New System.Drawing.Size(241, 20)
        Me.txtAddDish.TabIndex = 17
        '
        'txtAddPrepped
        '
        Me.txtAddPrepped.Location = New System.Drawing.Point(777, 325)
        Me.txtAddPrepped.Name = "txtAddPrepped"
        Me.txtAddPrepped.Size = New System.Drawing.Size(241, 20)
        Me.txtAddPrepped.TabIndex = 18
        '
        'lblAllRaw
        '
        Me.lblAllRaw.AutoSize = True
        Me.lblAllRaw.Location = New System.Drawing.Point(693, 386)
        Me.lblAllRaw.Name = "lblAllRaw"
        Me.lblAllRaw.Size = New System.Drawing.Size(132, 13)
        Me.lblAllRaw.TabIndex = 19
        Me.lblAllRaw.Text = "List of All Raw Ingredients:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 582)
        Me.Controls.Add(Me.lblAllRaw)
        Me.Controls.Add(Me.txtAddPrepped)
        Me.Controls.Add(Me.txtAddDish)
        Me.Controls.Add(Me.txtAddRaw)
        Me.Controls.Add(Me.btnAddPrepped)
        Me.Controls.Add(Me.btnAddRaw)
        Me.Controls.Add(Me.btnAddDish)
        Me.Controls.Add(Me.lstRaw)
        Me.Controls.Add(Me.lstPreppedDish)
        Me.Controls.Add(Me.lstDishes)
        Me.Controls.Add(Me.lstAllRaw)
        Me.Controls.Add(Me.lstPreppedItems)
        Me.Controls.Add(Me.lblAllPrepped)
        Me.Controls.Add(Me.lblRaw)
        Me.Controls.Add(Me.lblPrepped)
        Me.Controls.Add(Me.lblDishes)
        Me.Name = "frmMain"
        Me.Text = "Chef SouSad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDishes As System.Windows.Forms.Label
    Friend WithEvents lblPrepped As System.Windows.Forms.Label
    Friend WithEvents lblRaw As System.Windows.Forms.Label
    Friend WithEvents lblAllPrepped As System.Windows.Forms.Label
    Friend WithEvents lstPreppedItems As System.Windows.Forms.ListBox
    Friend WithEvents lstAllRaw As System.Windows.Forms.ListBox
    Friend WithEvents lstDishes As System.Windows.Forms.ListBox
    Friend WithEvents lstPreppedDish As System.Windows.Forms.ListBox
    Friend WithEvents lstRaw As System.Windows.Forms.ListBox
    Friend WithEvents btnAddDish As System.Windows.Forms.Button
    Friend WithEvents btnAddRaw As System.Windows.Forms.Button
    Friend WithEvents btnAddPrepped As System.Windows.Forms.Button
    Friend WithEvents txtAddRaw As System.Windows.Forms.TextBox
    Friend WithEvents txtAddDish As System.Windows.Forms.TextBox
    Friend WithEvents txtAddPrepped As System.Windows.Forms.TextBox
    Friend WithEvents lblAllRaw As System.Windows.Forms.Label

End Class
