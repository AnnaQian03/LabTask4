<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTNReserve = New System.Windows.Forms.Button()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label1.Text = "Reserve Now"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.BTNReserve)
        Me.Panel2.Controls.Add(Me.txtTime)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.txtNumber)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(191, -21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(830, 711)
        Me.Panel2.TabIndex = 8
        '
        'BTNReserve
        '
        Me.BTNReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.BTNReserve.Location = New System.Drawing.Point(262, 614)
        Me.BTNReserve.Name = "BTNReserve"
        Me.BTNReserve.Size = New System.Drawing.Size(341, 59)
        Me.BTNReserve.TabIndex = 21
        Me.BTNReserve.Text = "Reserve "
        Me.BTNReserve.UseVisualStyleBackColor = True
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtTime.Location = New System.Drawing.Point(410, 453)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(341, 38)
        Me.txtTime.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label6.Location = New System.Drawing.Point(129, 460)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 31)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Time"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtDate.Location = New System.Drawing.Point(410, 396)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(341, 38)
        Me.txtDate.TabIndex = 18
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtNumber.Location = New System.Drawing.Point(410, 329)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(341, 38)
        Me.txtNumber.TabIndex = 17
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txtName.Location = New System.Drawing.Point(410, 264)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(341, 38)
        Me.txtName.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(129, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 31)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label4.Location = New System.Drawing.Point(129, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 31)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Number of Person"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label3.Location = New System.Drawing.Point(129, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Name"
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
        Me.BTNExit.Location = New System.Drawing.Point(6, 542)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(200, 67)
        Me.BTNExit.TabIndex = 6
        Me.BTNExit.Text = "Exit"
        Me.BTNExit.UseVisualStyleBackColor = True
        '
        'BTNAbout
        '
        Me.BTNAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNAbout.Location = New System.Drawing.Point(6, 469)
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
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 689)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
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
    Friend WithEvents BTNReserve As Button
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
