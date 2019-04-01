Public Class Form1

	Dim LabelArray(100) As Label
	Dim Player1 As Integer = 1
	Dim Player2 As Integer = 1






	Sub New()

		' This call is required by the designer.
		InitializeComponent()

		LabelArray(1) = Label1
		LabelArray(2) = Label2
		LabelArray(3) = Label3
		LabelArray(4) = Label4
		LabelArray(5) = Label5
		LabelArray(6) = Label6
		LabelArray(7) = Label7
		LabelArray(8) = Label8
		LabelArray(9) = Label9
		LabelArray(10) = Label10

		LabelArray(11) = Label11
		LabelArray(12) = Label12
		LabelArray(13) = Label13
		LabelArray(14) = Label14
		LabelArray(15) = Label15
		LabelArray(16) = Label16
		LabelArray(17) = Label17
		LabelArray(18) = Label18
		LabelArray(19) = Label19
		LabelArray(20) = Label20

		LabelArray(21) = Label21
		LabelArray(22) = Label22
		LabelArray(23) = Label23
		LabelArray(24) = Label24
		LabelArray(25) = Label25
		LabelArray(26) = Label26
		LabelArray(27) = Label27
		LabelArray(28) = Label28
		LabelArray(29) = Label29
		LabelArray(30) = Label30

		LabelArray(31) = Label31

		LabelArray(32) = Label32
		LabelArray(33) = Label33
		LabelArray(34) = Label34
		LabelArray(35) = Label35
		LabelArray(36) = Label36
		LabelArray(37) = Label37
		LabelArray(38) = Label38
		LabelArray(39) = Label39
		LabelArray(40) = Label40

		LabelArray(41) = Label41

		LabelArray(42) = Label42
		LabelArray(43) = Label43
		LabelArray(44) = Label44
		LabelArray(45) = Label45
		LabelArray(46) = Label46
		LabelArray(47) = Label47
		LabelArray(48) = Label48
		LabelArray(49) = Label49
		LabelArray(50) = Label50





		' Add any initialization after the InitializeComponent() call.

	End Sub
	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


		If (Player1 < 50 AndAlso Player2 < 50) Then

			LabelArray(Player1).Text = "Label" & Player1

			Randomize()
			Dim num2 As Integer = CInt(Int((6 * Rnd()) + 1))
			If (num2 = 1) Then
				Dice1.Visible = True
				Dice2.Visible = False
				Dice3.Visible = False
				Dice4.Visible = False
				Dice5.Visible = False
				Dice6.Visible = False
			ElseIf (num2 = 2) Then
				Dice1.Visible = False
				Dice2.Visible = True
				Dice3.Visible = False
				Dice4.Visible = False
				Dice5.Visible = False
				Dice6.Visible = False
			ElseIf (num2 = 3) Then
				Dice1.Visible = False
				Dice2.Visible = False
				Dice3.Visible = True
				Dice4.Visible = False
				Dice5.Visible = False
				Dice6.Visible = False
			ElseIf (num2 = 4) Then
				Dice1.Visible = False
				Dice2.Visible = False
				Dice3.Visible = False
				Dice4.Visible = True
				Dice5.Visible = False
				Dice6.Visible = False
			ElseIf (num2 = 5) Then
				Dice1.Visible = False

				Dice2.Visible = False
				Dice3.Visible = False
				Dice4.Visible = False
				Dice5.Visible = True
				Dice6.Visible = False
			ElseIf (num2 = 6) Then
				Dice1.Visible = False
			Dice2.Visible = False
			Dice3.Visible = False
			Dice4.Visible = False
			Dice5.Visible = False
			Dice6.Visible = True
		End If

			Player1 += num2
			If (Player1 >= 50) Then
				titelLable.Text = "PLAyer 1 won"
				DisplayLable.Text = "Player1 has Rolled " & num2
			Else

				DisplayLable.Text = Player1
			End If




		End If


	End Sub

	Private Sub Label47_Click(sender As Object, e As EventArgs) Handles Label47.Click

	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub Label51_Click(sender As Object, e As EventArgs) Handles titelLable.Click

	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		If (Player1 < 50 AndAlso Player2 < 50) Then

			LabelArray(Player2).Text = "Label" & Player1

			Randomize()
			Dim num1 As Integer = CInt(Int((6 * Rnd()) + 1))
			If (num1 = 1) Then
				Dice1.Visible = True
				Dice2.Visible = False
				Dice3.Visible = False
				Dice4.Visible = False
				Dice5.Visible = False
				Dice6.Visible = False
			ElseIf (num1 = 2) Then
				Dice1.Visible = False
				Dice2.Visible = True
				Dice3.Visible = False
				Dice4.Visible = False
				Dice5.Visible = False
				Dice6.Visible = False
			ElseIf (num1 = 3) Then
				Dice1.Visible = False
				Dice2.Visible = False
				Dice3.Visible = True
				Dice4.Visible = False
				Dice5.Visible = False
				Dice6.Visible = False
			ElseIf (num1 = 4) Then
				Dice1.Visible = False
				Dice2.Visible = False
				Dice3.Visible = False
				Dice4.Visible = True
				Dice5.Visible = False
				Dice6.Visible = False
			ElseIf (num1 = 5) Then
				Dice1.Visible = False

				Dice2.Visible = False
				Dice3.Visible = False
				Dice4.Visible = False
				Dice5.Visible = True
				Dice6.Visible = False
			ElseIf (num1 = 6) Then
				Dice1.Visible = False
				Dice2.Visible = False
				Dice3.Visible = False
				Dice4.Visible = False
				Dice5.Visible = False
				Dice6.Visible = True
			End If

			Player2 += num1
			If (Player2 >= 50) Then
				titelLable.Text = "PLer2 won"
				DisplayLable.Text = "Player2 has Rolled " & num1

			Else
				LabelArray(Player2).Text = "HERE I AM"
				DisplayLable.Text = "Player2 has Rolled " & num1
			End If
		End If


	End Sub

	Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles Dice3.Click

	End Sub

	Private Sub Label51_Click_1(sender As Object, e As EventArgs) Handles DisplayLable.Click

	End Sub
End Class
