<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Review
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Review))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtRating3 = New System.Windows.Forms.TextBox()
        Me.txtRating2 = New System.Windows.Forms.TextBox()
        Me.txtRating1 = New System.Windows.Forms.TextBox()
        Me.txtReview3 = New System.Windows.Forms.TextBox()
        Me.txtReview2 = New System.Windows.Forms.TextBox()
        Me.txtReview1 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.BTNAbout = New System.Windows.Forms.Button()
        Me.BTNReview = New System.Windows.Forms.Button()
        Me.BTNReservation = New System.Windows.Forms.Button()
        Me.BTNSearch = New System.Windows.Forms.Button()
        Me.BTNRestaurant = New System.Windows.Forms.Button()
        Me.BTNHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNRefresh = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Pristina", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(342, 88)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reviews"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.Controls.Add(Me.BTNRefresh)
        Me.Panel2.Controls.Add(Me.txtName1)
        Me.Panel2.Controls.Add(Me.txtName2)
        Me.Panel2.Controls.Add(Me.txtRating3)
        Me.Panel2.Controls.Add(Me.txtRating2)
        Me.Panel2.Controls.Add(Me.txtRating1)
        Me.Panel2.Controls.Add(Me.txtReview3)
        Me.Panel2.Controls.Add(Me.txtReview2)
        Me.Panel2.Controls.Add(Me.txtReview1)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(191, -21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(830, 710)
        Me.Panel2.TabIndex = 8
        '
        'txtName1
        '
        Me.txtName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtName1.Location = New System.Drawing.Point(14, 248)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.ReadOnly = True
        Me.txtName1.Size = New System.Drawing.Size(153, 30)
        Me.txtName1.TabIndex = 16
        '
        'txtName2
        '
        Me.txtName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtName2.Location = New System.Drawing.Point(14, 427)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.ReadOnly = True
        Me.txtName2.Size = New System.Drawing.Size(153, 30)
        Me.txtName2.TabIndex = 15
        '
        'txtRating3
        '
        Me.txtRating3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtRating3.Location = New System.Drawing.Point(183, 620)
        Me.txtRating3.Name = "txtRating3"
        Me.txtRating3.Size = New System.Drawing.Size(219, 30)
        Me.txtRating3.TabIndex = 12
        '
        'txtRating2
        '
        Me.txtRating2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtRating2.Location = New System.Drawing.Point(183, 427)
        Me.txtRating2.Name = "txtRating2"
        Me.txtRating2.ReadOnly = True
        Me.txtRating2.Size = New System.Drawing.Size(219, 30)
        Me.txtRating2.TabIndex = 11
        '
        'txtRating1
        '
        Me.txtRating1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtRating1.Location = New System.Drawing.Point(183, 245)
        Me.txtRating1.Name = "txtRating1"
        Me.txtRating1.ReadOnly = True
        Me.txtRating1.Size = New System.Drawing.Size(219, 30)
        Me.txtRating1.TabIndex = 10
        '
        'txtReview3
        '
        Me.txtReview3.Location = New System.Drawing.Point(183, 514)
        Me.txtReview3.Multiline = True
        Me.txtReview3.Name = "txtReview3"
        Me.txtReview3.Size = New System.Drawing.Size(635, 100)
        Me.txtReview3.TabIndex = 9
        '
        'txtReview2
        '
        Me.txtReview2.Location = New System.Drawing.Point(183, 321)
        Me.txtReview2.Multiline = True
        Me.txtReview2.Name = "txtReview2"
        Me.txtReview2.ReadOnly = True
        Me.txtReview2.Size = New System.Drawing.Size(635, 100)
        Me.txtReview2.TabIndex = 8
        '
        'txtReview1
        '
        Me.txtReview1.Location = New System.Drawing.Point(183, 142)
        Me.txtReview1.Multiline = True
        Me.txtReview1.Name = "txtReview1"
        Me.txtReview1.ReadOnly = True
        Me.txtReview1.Size = New System.Drawing.Size(635, 100)
        Me.txtReview1.TabIndex = 7
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(42, 321)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(42, 142)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BTNAdd)
        Me.Panel3.Controls.Add(Me.txtName3)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Location = New System.Drawing.Point(9, 481)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(818, 226)
        Me.Panel3.TabIndex = 13
        '
        'BTNAdd
        '
        Me.BTNAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNAdd.Location = New System.Drawing.Point(564, 160)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(215, 55)
        Me.BTNAdd.TabIndex = 15
        Me.BTNAdd.Text = "Add Review"
        Me.BTNAdd.UseVisualStyleBackColor = True
        '
        'txtName3
        '
        Me.txtName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtName3.Location = New System.Drawing.Point(3, 140)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(153, 30)
        Me.txtName3.TabIndex = 14
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(31, 34)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
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
        Me.BTNAbout.Location = New System.Drawing.Point(3, 468)
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
        'BTNRefresh
        '
        Me.BTNRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.BTNRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTNRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.BTNRefresh.Image = CType(resources.GetObject("BTNRefresh.Image"), System.Drawing.Image)
        Me.BTNRefresh.Location = New System.Drawing.Point(271, 50)
        Me.BTNRefresh.Name = "BTNRefresh"
        Me.BTNRefresh.Size = New System.Drawing.Size(71, 55)
        Me.BTNRefresh.TabIndex = 17
        Me.BTNRefresh.UseVisualStyleBackColor = True
        '
        'Review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 689)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Review"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtRating3 As TextBox
    Friend WithEvents txtRating2 As TextBox
    Friend WithEvents txtRating1 As TextBox
    Friend WithEvents txtReview3 As TextBox
    Friend WithEvents txtReview2 As TextBox
    Friend WithEvents txtReview1 As TextBox
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTNAdd As Button
    Friend WithEvents txtName3 As TextBox
    Friend WithEvents BTNRefresh As Button
End Class
