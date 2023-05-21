<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.BTNAbout = New System.Windows.Forms.Button()
        Me.BTNReview = New System.Windows.Forms.Button()
        Me.BTNReservation = New System.Windows.Forms.Button()
        Me.BTNSearch = New System.Windows.Forms.Button()
        Me.BTNRestaurant = New System.Windows.Forms.Button()
        Me.BTNHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(199, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(838, 730)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.BTNExit)
        Me.Panel1.Controls.Add(Me.BTNAbout)
        Me.Panel1.Controls.Add(Me.BTNReview)
        Me.Panel1.Controls.Add(Me.BTNReservation)
        Me.Panel1.Controls.Add(Me.BTNSearch)
        Me.Panel1.Controls.Add(Me.BTNRestaurant)
        Me.Panel1.Controls.Add(Me.BTNHome)
        Me.Panel1.Location = New System.Drawing.Point(-1, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 628)
        Me.Panel1.TabIndex = 4
        '
        'BTNExit
        '
        Me.BTNExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNExit.Location = New System.Drawing.Point(0, 558)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(200, 67)
        Me.BTNExit.TabIndex = 6
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'BTNAbout
        '
        Me.BTNAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNAbout.Location = New System.Drawing.Point(0, 485)
        Me.BTNAbout.Name = "BTNAbout"
        Me.BTNAbout.Size = New System.Drawing.Size(200, 67)
        Me.BTNAbout.TabIndex = 5
        Me.BTNAbout.Text = "About"
        Me.BTNAbout.UseVisualStyleBackColor = True
        '
        'BTNReview
        '
        Me.BTNReview.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNReview.Location = New System.Drawing.Point(0, 292)
        Me.BTNReview.Name = "BTNReview"
        Me.BTNReview.Size = New System.Drawing.Size(200, 67)
        Me.BTNReview.TabIndex = 4
        Me.BTNReview.Text = "Review"
        Me.BTNReview.UseVisualStyleBackColor = True
        '
        'BTNReservation
        '
        Me.BTNReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.BTNReservation.Location = New System.Drawing.Point(0, 219)
        Me.BTNReservation.Name = "BTNReservation"
        Me.BTNReservation.Size = New System.Drawing.Size(200, 67)
        Me.BTNReservation.TabIndex = 3
        Me.BTNReservation.Text = "Reservation"
        Me.BTNReservation.UseVisualStyleBackColor = True
        '
        'BTNSearch
        '
        Me.BTNSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNSearch.Location = New System.Drawing.Point(0, 146)
        Me.BTNSearch.Name = "BTNSearch"
        Me.BTNSearch.Size = New System.Drawing.Size(200, 67)
        Me.BTNSearch.TabIndex = 2
        Me.BTNSearch.Text = "Search"
        Me.BTNSearch.UseVisualStyleBackColor = True
        '
        'BTNRestaurant
        '
        Me.BTNRestaurant.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNRestaurant.Location = New System.Drawing.Point(0, 73)
        Me.BTNRestaurant.Name = "BTNRestaurant"
        Me.BTNRestaurant.Size = New System.Drawing.Size(200, 67)
        Me.BTNRestaurant.TabIndex = 1
        Me.BTNRestaurant.Text = "Restaurant"
        Me.BTNRestaurant.UseVisualStyleBackColor = True
        '
        'BTNHome
        '
        Me.BTNHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNHome.Location = New System.Drawing.Point(0, 0)
        Me.BTNHome.Name = "BTNHome"
        Me.BTNHome.Size = New System.Drawing.Size(200, 67)
        Me.BTNHome.TabIndex = 0
        Me.BTNHome.Text = "Home"
        Me.BTNHome.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 105)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(327, 118)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(206, 105)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Pristina", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(839, 105)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "History About Suushi King"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(-3, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(839, 141)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(839, 209)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 728)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNExit As Button
    Friend WithEvents BTNAbout As Button
    Friend WithEvents BTNReview As Button
    Friend WithEvents BTNReservation As Button
    Friend WithEvents BTNSearch As Button
    Friend WithEvents BTNRestaurant As Button
    Friend WithEvents BTNHome As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
