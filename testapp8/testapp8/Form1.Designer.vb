<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        Button1 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(572, 62)
        Label1.TabIndex = 0
        Label1.Text = "Trollbox Native App Setup"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(485, 186)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(172, 24)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "what i am doing here"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(646, 20)
        Label2.TabIndex = 2
        Label2.Text = "This is the TNAS (Trollbox Native App Setup) this setup will install the TNA (Trollbox Native App)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(223, 20)
        Label3.TabIndex = 3
        Label3.Text = "so just click the install button pls"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(38, 200)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(160, 20)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "github repo of the app"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(43, 240)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(170, 20)
        LinkLabel2.TabIndex = 5
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "github repo of the setup"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(619, 375)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "Install"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(31, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(606, 62)
        Label4.TabIndex = 7
        Label4.Text = "Installing... (DO NOT CLOSE)"
        Label4.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(CheckBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Setup"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label

End Class
