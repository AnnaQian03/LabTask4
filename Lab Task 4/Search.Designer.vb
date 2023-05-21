<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNReserve = New System.Windows.Forms.Button()
        Me.BTNClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.BTNAbout = New System.Windows.Forms.Button()
        Me.BTNReview = New System.Windows.Forms.Button()
        Me.BTNReservation = New System.Windows.Forms.Button()
        Me.BTNSearch = New System.Windows.Forms.Button()
        Me.BTNRestaurant = New System.Windows.Forms.Button()
        Me.BTNHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Pristina", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(839, 105)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.BTNReserve)
        Me.Panel2.Controls.Add(Me.BTNClear)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtPhoneNumber)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtState)
        Me.Panel2.Controls.Add(Me.txtZip)
        Me.Panel2.Controls.Add(Me.txtAddress)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(191, -21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(831, 710)
        Me.Panel2.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtID.Location = New System.Drawing.Point(304, 264)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(341, 38)
        Me.txtID.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label8.Location = New System.Drawing.Point(23, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 31)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Restaurant ID"
        '
        'BTNReserve
        '
        Me.BTNReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BTNReserve.Location = New System.Drawing.Point(304, 648)
        Me.BTNReserve.Name = "BTNReserve"
        Me.BTNReserve.Size = New System.Drawing.Size(167, 46)
        Me.BTNReserve.TabIndex = 15
        Me.BTNReserve.Text = "Reserve "
        Me.BTNReserve.UseVisualStyleBackColor = True
        '
        'BTNClear
        '
        Me.BTNClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BTNClear.Location = New System.Drawing.Point(478, 648)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(167, 46)
        Me.BTNClear.TabIndex = 14
        Me.BTNClear.Text = "Clear"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Button1.Location = New System.Drawing.Point(304, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(341, 46)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Search Now"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtEmail.Location = New System.Drawing.Point(304, 604)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(341, 38)
        Me.txtEmail.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label7.Location = New System.Drawing.Point(23, 611)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 31)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Email"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(304, 560)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New System.Drawing.Size(341, 38)
        Me.txtPhoneNumber.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(23, 567)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 31)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Phone Number"
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtState.Location = New System.Drawing.Point(304, 516)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(341, 38)
        Me.txtState.TabIndex = 8
        '
        'txtZip
        '
        Me.txtZip.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtZip.Location = New System.Drawing.Point(304, 472)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(341, 38)
        Me.txtZip.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtAddress.Location = New System.Drawing.Point(304, 308)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(341, 153)
        Me.txtAddress.TabIndex = 6
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtSearch.Location = New System.Drawing.Point(304, 134)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(341, 38)
        Me.txtSearch.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(23, 512)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(23, 472)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Zip"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(23, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(23, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "City"
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
        Me.Panel1.Location = New System.Drawing.Point(-9, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 628)
        Me.Panel1.TabIndex = 7
        '
        'BTNExit
        '
        Me.BTNExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNExit.Location = New System.Drawing.Point(6, 541)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(200, 67)
        Me.BTNExit.TabIndex = 6
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'BTNAbout
        '
        Me.BTNAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNAbout.Location = New System.Drawing.Point(6, 468)
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
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 105)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 689)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
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
    Friend WithEvents Button1 As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNClear As Button
    Friend WithEvents BTNReserve As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label8 As Label
End Class
