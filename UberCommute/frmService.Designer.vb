<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmService
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
        Panel1 = New Panel()
        lblCost = New Label()
        lblMode = New Label()
        lblCostHeading = New Label()
        lblModeHeading = New Label()
        btnClear = New Button()
        btnCost = New Button()
        txtDays = New TextBox()
        txtCosts = New TextBox()
        lblDaysWorked = New Label()
        lblQuestions = New Label()
        cboMode = New ComboBox()
        lblTitle = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(lblCost)
        Panel1.Controls.Add(lblMode)
        Panel1.Controls.Add(lblCostHeading)
        Panel1.Controls.Add(lblModeHeading)
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnCost)
        Panel1.Controls.Add(txtDays)
        Panel1.Controls.Add(txtCosts)
        Panel1.Controls.Add(lblDaysWorked)
        Panel1.Controls.Add(lblQuestions)
        Panel1.Controls.Add(cboMode)
        Panel1.Controls.Add(lblTitle)
        Panel1.Dock = DockStyle.Left
        Panel1.Font = New Font("Bahnschrift", 15.75F)
        Panel1.ForeColor = Color.White
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(428, 450)
        Panel1.TabIndex = 0
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Location = New Point(273, 411)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(75, 25)
        lblCost.TabIndex = 11
        lblCost.Text = "Label4"
        lblCost.Visible = False
        ' 
        ' lblMode
        ' 
        lblMode.AutoSize = True
        lblMode.Location = New Point(274, 364)
        lblMode.Name = "lblMode"
        lblMode.Size = New Size(74, 25)
        lblMode.TabIndex = 10
        lblMode.Text = "Label3"
        lblMode.Visible = False
        ' 
        ' lblCostHeading
        ' 
        lblCostHeading.AutoSize = True
        lblCostHeading.Location = New Point(103, 411)
        lblCostHeading.Name = "lblCostHeading"
        lblCostHeading.Size = New Size(59, 25)
        lblCostHeading.TabIndex = 9
        lblCostHeading.Text = "Cost:"
        lblCostHeading.Visible = False
        ' 
        ' lblModeHeading
        ' 
        lblModeHeading.AutoSize = True
        lblModeHeading.Location = New Point(80, 364)
        lblModeHeading.Name = "lblModeHeading"
        lblModeHeading.Size = New Size(153, 25)
        lblModeHeading.TabIndex = 8
        lblModeHeading.Text = "Mode of Travel:"
        lblModeHeading.Visible = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DimGray
        btnClear.Font = New Font("Bahnschrift", 15.75F)
        btnClear.Location = New Point(249, 287)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 37)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        btnClear.Visible = False
        ' 
        ' btnCost
        ' 
        btnCost.BackColor = Color.DimGray
        btnCost.Font = New Font("Bahnschrift", 15.75F)
        btnCost.Location = New Point(104, 287)
        btnCost.Name = "btnCost"
        btnCost.Size = New Size(75, 37)
        btnCost.TabIndex = 6
        btnCost.Text = "Cost"
        btnCost.UseVisualStyleBackColor = False
        btnCost.Visible = False
        ' 
        ' txtDays
        ' 
        txtDays.Font = New Font("Bahnschrift", 15.75F)
        txtDays.Location = New Point(336, 193)
        txtDays.Name = "txtDays"
        txtDays.Size = New Size(76, 33)
        txtDays.TabIndex = 5
        txtDays.TextAlign = HorizontalAlignment.Center
        txtDays.Visible = False
        ' 
        ' txtCosts
        ' 
        txtCosts.Font = New Font("Bahnschrift", 15.75F)
        txtCosts.Location = New Point(336, 147)
        txtCosts.Name = "txtCosts"
        txtCosts.Size = New Size(76, 33)
        txtCosts.TabIndex = 4
        txtCosts.TextAlign = HorizontalAlignment.Center
        txtCosts.Visible = False
        ' 
        ' lblDaysWorked
        ' 
        lblDaysWorked.AutoSize = True
        lblDaysWorked.Font = New Font("Bahnschrift", 15.75F)
        lblDaysWorked.Location = New Point(17, 193)
        lblDaysWorked.Name = "lblDaysWorked"
        lblDaysWorked.Size = New Size(70, 25)
        lblDaysWorked.TabIndex = 3
        lblDaysWorked.Text = "Label1"
        lblDaysWorked.Visible = False
        ' 
        ' lblQuestions
        ' 
        lblQuestions.AutoSize = True
        lblQuestions.Font = New Font("Bahnschrift", 15.75F)
        lblQuestions.Location = New Point(17, 147)
        lblQuestions.Name = "lblQuestions"
        lblQuestions.Size = New Size(70, 25)
        lblQuestions.TabIndex = 2
        lblQuestions.Text = "Label1"
        lblQuestions.Visible = False
        ' 
        ' cboMode
        ' 
        cboMode.Font = New Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboMode.FormattingEnabled = True
        cboMode.Items.AddRange(New Object() {"Uber", "Subway", "Bus"})
        cboMode.Location = New Point(123, 79)
        cboMode.Name = "cboMode"
        cboMode.Size = New Size(182, 33)
        cboMode.TabIndex = 1
        cboMode.Text = "Mode of Travel:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Bahnschrift", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(17, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(395, 33)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Uber, Subway, Or Bus Commute"
        ' 
        ' frmService
        ' 
        AcceptButton = btnCost
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.subway
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btnClear
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "frmService"
        Text = "Uber, Subway, Or Bus Commute"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboMode As ComboBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtDays As TextBox
    Friend WithEvents txtCosts As TextBox
    Friend WithEvents lblDaysWorked As Label
    Friend WithEvents lblQuestions As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCost As Button
    Friend WithEvents lblCost As Label
    Friend WithEvents lblMode As Label
    Friend WithEvents lblCostHeading As Label
    Friend WithEvents lblModeHeading As Label

End Class
