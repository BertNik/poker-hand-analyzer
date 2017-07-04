'Nikolaus Bertino
'Visual Basic Programming 
'Major Project #2 (Poker Hand Analyzer)

'This program is capable of correctly identifying Royal Flush, Straight Flush, 4 of a Kind, Full House, Flush, 
'Straight, 3 of a Kind, 2 Pair, 1 pair and will validate the hand inputted

Public Class frmPoker

    Dim denomiation As New Collection
    Dim suits As New Collection
    Dim cardsAndSuitsArray(3, 12) As Integer
    Dim stringDenomArray As String() = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"}
    Dim suiteDenomArray As String() = {"Club", "Diamond", "Heart", "Spade"}

    'class level counting variables for denominations
    Dim aceCount As Integer = 0
    Dim twoCount As Integer = 0
    Dim threeCount As Integer = 0
    Dim fourCount As Integer = 0
    Dim fiveCount As Integer = 0
    Dim sixCount As Integer = 0
    Dim sevenCount As Integer = 0
    Dim eightCount As Integer = 0
    Dim nineCount As Integer = 0
    Dim tenCount As Integer = 0
    Dim jackCount As Integer = 0
    Dim queenCount As Integer = 0
    Dim kingCount As Integer = 0

    'class level counting variables for suits
    Dim clubCount As Integer = 0
    Dim diamondCount As Integer = 0
    Dim heartCount As Integer = 0
    Dim spadeCount As Integer = 0

    'class level boolean variables for determined pairs
    Dim isPair As Boolean
    Dim isThree As Boolean
    Dim isFour As Boolean
    Dim firstRunOfProgram As Boolean = True

    Public Sub frmPoker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'chooses a default index for comboboxes
        comBoxSuit01.SelectedIndex = 0
        comBoxSuit02.SelectedIndex = 1
        comBoxSuit03.SelectedIndex = 2
        comBoxSuit04.SelectedIndex = 3
        comBoxSuit05.SelectedIndex = 0

        comBoxDenom01.SelectedIndex = 0
        comBoxDenom02.SelectedIndex = 1
        comBoxDenom03.SelectedIndex = 2
        comBoxDenom04.SelectedIndex = 3
        comBoxDenom05.SelectedIndex = 4

        'add cards that are chosen by default to collection
        AddCardsToCollection()
        'print the cards in the collection

        Dim possibleHands As String() = checkHand()

        'print the cards in the collection to the text box
        PrintCardsInCollection(possibleHands)

        'gets values for respective cards and creates the array suggested by the textbook
        getCardsArray()


    End Sub

    Sub btnDisplayHand_Click(sender As Object, e As EventArgs) Handles btnDisplayHand.Click

        Dim rows() As String = suiteDenomArray
        Dim str As String = ""

        'when button is pressed the new cards are added to the collection
        AddCardsToCollection()

        'now write the values of those added cards to the card array
        getCardsArray()

        'check the possible hands
        Dim possibleHands As String() = checkHand()

        'now print cards in collection and display the hand
        PrintCardsInCollection(possibleHands)

    End Sub

    Private Sub PrintCardsInCollection(possibleHands As String())

        Dim str As String = ""
        Dim rows() As String = suiteDenomArray
        Dim dispHand As String = ""
        'Dim possibleHands As String() = checkHand()

        For x = 1 To 5

            For y = x + 1 To 5

                Dim isSuitAndDenomEqual As Boolean = denomiation(x).text & " " & suits(x).text = denomiation(y).text & " " & suits(y).text

                If isSuitAndDenomEqual Then

                    dispHand = "Not Valid Hand"

                    GoTo line

                End If

            Next

        Next

        For Each ele In possibleHands

            If ele <> "" Then

                dispHand = ele

            End If

        Next

        If isPair And isThree Then

            dispHand = "Full House"

        End If

line:

        If dispHand = "" And Not firstRunOfProgram Then

            txtBoxDisplayHand.Text = "No Hand"
            txtBoxDisplayHand.BackColor = Color.LightYellow
            txtBoxDisplayHand.ForeColor = Color.Black

        ElseIf firstRunOfProgram Then

            txtBoxDisplayHand.Text = "The result of your hand"
            firstRunOfProgram = False

        Else
            'conditional formatting for text displayed to visually indicate not a valid hand or valid hand
            If dispHand = "Not Valid Hand" Then

                txtBoxDisplayHand.Text = dispHand
                txtBoxDisplayHand.BackColor = Color.OrangeRed
                txtBoxDisplayHand.ForeColor = Color.Black

            Else

                txtBoxDisplayHand.Text = dispHand
                txtBoxDisplayHand.BackColor = Color.LightGreen
                txtBoxDisplayHand.ForeColor = Color.Black

            End If

            txtBoxDisplayHand.Text = dispHand

        End If

        'creates string to print to textbox which was used for debugging purposes but could potentially have some benefit for later analysis, so it was left in
        str = vbTab & vbTab & stringDenomArray(0) & vbTab & stringDenomArray(1) & vbTab & stringDenomArray(2) & vbTab & stringDenomArray(3) & vbTab & stringDenomArray(4) &
            vbTab & stringDenomArray(5) & vbTab & stringDenomArray(6) & vbTab & stringDenomArray(7) & vbTab & stringDenomArray(8) & vbTab & stringDenomArray(9) & vbTab & stringDenomArray(10) &
            vbTab & stringDenomArray(11) & vbTab & stringDenomArray(12)

        For i = 0 To 3

            str = str & vbCr & rows(i) & vbTab & getCardsArray(i, 0) & vbTab & getCardsArray(i, 1) & vbTab & getCardsArray(i, 2) & vbTab & getCardsArray(i, 3) & vbTab & getCardsArray(i, 4) & vbTab & getCardsArray(i, 5) & vbTab & getCardsArray(i, 6) & vbTab & getCardsArray(i, 7) & vbTab & getCardsArray(i, 8) & vbTab & getCardsArray(i, 9) & vbTab & getCardsArray(i, 10) & vbTab & getCardsArray(i, 11) & vbTab & getCardsArray(i, 12)

        Next

        txtBoxDispBinary.Text = str.Substring(1)

        'reintialize variables for safe measure
        reinitalizeCardsAndSuits()

    End Sub

    Private Function checkForPairs(cards As Integer(,))

        Dim consecRows As Integer = 0
        Dim consecsuites As Integer = 0
        Dim finalResult As String
        Dim pairCount As Integer = 0

        'begin checking for pairs
        For col = 0 To 12

            For row = 0 To 3

                'isOne determines if there is a one at the row of sui and den

                Dim isOne As Boolean = cards(row, col) = 1

                'if there is a one, then we add one to consecDenoms in an attempt to determine how many
                'denominations appear in a row
                If isOne Then

                    consecRows += 1

                End If

            Next

            Select Case consecRows

                Case 2

                    finalResult = "Pair"
                    isPair = True
                    pairCount += 1

                    If pairCount = 2 Then

                        finalResult = "Two Pair"

                    End If

                Case 3

                    finalResult = "Three of a kind"
                    isThree = True

                Case 4

                    finalResult = "Four of a kind"
                    isFour = True

                Case 5

                    finalResult = "Full House"
                    isThree = True

            End Select

            consecRows = 0

        Next

        Return finalResult

    End Function

    Private Function checkForFlush(cards As Integer(,))

        Dim consecDenoms As Integer = 0
        Dim consecsuites As Integer = 0
        Dim finalResult As String

        'now, let's check for flushes
        For sui = 0 To 3

            For den = 0 To 12
                'here, we're using the same algorithm in checkPairs to determine consecutive denoms, however, there is a slight
                'difference in order to account for a Royal Flush which can consist in an Ace and a King, of which, in the cardArray
                'aren't strictly consecutive, so a little bit of a different kind of logic is implemented below, in order to account for that
                Dim isOne As Boolean = cards(sui, den) = 1

                If isOne Then

                    consecDenoms += 1
                    'Now, if the consecDenoms is 5 then we don't need to run this algorithm anymore because we can
                    'only have 5 cards, so we goto beging selecting our case
                    If consecDenoms = 5 Then

                        GoTo BeginSelectingCase

                    End If


                ElseIf consecDenoms = 4 Then
                    'now, if consecDenoms is 4, the program checks to see if two cards of the hand are an Ace and a King
                    'and this would determine if there is a straight with all highcards or a potential Royal Flush that also has all 
                    'high cards
                    isOne = cards(sui, den) = 1

                    If isOne Or (aceCount = 1 And kingCount = 1) Then

                        consecDenoms = 4
                        'in the case that there is 4 and there is an Ace and a King, it would be superflous to continue interating through
                        'these cards because we have enough information to move onto selecting our cases
                        GoTo BeginSelectingCase

                    End If

                Else
                    'in the event there is not a consecutive denomination, then the counter is reset to 0
                    consecDenoms = 0

                End If

            Next

        Next

BeginSelectingCase:

        Select Case consecDenoms

            Case 5

                If (clubCount = 5 Or diamondCount = 5 Or heartCount = 5 Or spadeCount = 5) Then

                    finalResult = "Straight Flush"

                    Return finalResult

                End If

            Case 4

                Dim highCardCount As Integer = 0

                For c = 0 To 12

                    For r = 0 To 3

                        Dim checkRoyalFlush As Boolean = cards(r, c)

                        If checkRoyalFlush Then

                            highCardCount += 1
                            checkRoyalFlush = False

                        End If

                    Next

                    If c = 0 Then

                        c = 8

                    End If

                Next

                If highCardCount = 5 And (clubCount = 5 Or diamondCount = 5 Or heartCount = 5 Or spadeCount = 5) Then

                    finalResult = "Royal Flush"

                ElseIf clubCount = 5 Or diamondCount = 5 Or heartCount = 5 Or spadeCount = 5 Then

                    finalResult = "Flush"

                    Return finalResult

                End If

            Case Else

                If clubCount = 5 Or diamondCount = 5 Or heartCount = 5 Or spadeCount = 5 Then

                    finalResult = "Flush"

                    Return finalResult

                End If

        End Select

        Return finalResult

    End Function

    Private Function checkForStraight(cards)

        Dim consecDenoms As Integer = 0
        Dim consecsuites As Integer = 0
        Dim finalResult As String
        Dim didNotCount As Integer = 0

        For den = 0 To 12

            For x = 0 To 3

                Dim isOne As Boolean = cards(x, den) = 1

                If isOne Then

                    consecDenoms += 1

                    isOne = False

                    If consecDenoms = 5 Then

                        GoTo beginSelectingCase

                    End If

                Else

                    didNotCount += 1

                End If

                If didNotCount = 4 Then

                    consecDenoms = 0

                    Exit For

                End If

            Next x

            didNotCount = 0

        Next den

beginSelectingCase:

        Select Case consecDenoms

            Case 4

                If kingCount = 1 And aceCount = 1 Then
                    finalResult = "Straight"
                End If

            Case 5

                finalResult = "Straight"

        End Select

        consecDenoms = 0

        Return finalResult

    End Function

    Function checkHand() As String()

        'this is where the heart of the poker hand analyzation occurs, where the hands are checked
        Dim cards As Integer(,) = cardsAndSuitsArray
        Dim hasStraight As String
        Dim hasFlush As String

        'first pairs are checked, and the reason for that is if there are pairs, which constitues pair, two pair, or three or four of a kind,
        'then checking other hands seems superflous 
        Dim hasPairs As String = checkForPairs(cards)

        'after checking for pairs, then since there can be a few combinations of pairs like a full house has a pair and a three of a kind,
        'or a two pair will have two different pairs, this conditional statement checks that and makes a determination as such
        If hasPairs <> "Two Pair" And hasPairs <> "Pair" And hasPairs <> "Four of a kind" And hasPairs <> "Three of a kind" Then

            hasFlush = checkForFlush(cards)

            If hasFlush Is Nothing Then

                hasStraight = checkForStraight(cards)

            End If


        End If

        Return (hasPairs & "," & hasStraight & "," & hasFlush).Split(",")

    End Function
    Private Sub reinitalizeCardsAndSuits()

        'reinitialize values
        aceCount = 0
        twoCount = 0
        threeCount = 0
        fourCount = 0
        fiveCount = 0
        sixCount = 0
        sevenCount = 0
        eightCount = 0
        nineCount = 0
        tenCount = 0
        jackCount = 0
        queenCount = 0
        kingCount = 0
        clubCount = 0
        diamondCount = 0
        heartCount = 0
        spadeCount = 0

    End Sub
    Private Sub reinitializeValues()

        'when reinitizlizing, the value of the textbox is cleared
        txtBoxDisplayHand.Text = ""

        'further, the array is also cleared
        Array.Clear(cardsAndSuitsArray, 0, cardsAndSuitsArray.Length)

        'all counts are reinitialized because a new hand has begun
        aceCount = 0
        twoCount = 0
        threeCount = 0
        fourCount = 0
        fiveCount = 0
        sixCount = 0
        sevenCount = 0
        eightCount = 0
        nineCount = 0
        tenCount = 0
        jackCount = 0
        queenCount = 0
        kingCount = 0
        clubCount = 0
        diamondCount = 0
        heartCount = 0
        spadeCount = 0

        'clears the collections so they're not continually added to
        suits.Clear()
        denomiation.Clear()

        'clears the possiblitiy of some combinations of hands
        isFour = False
        isThree = False
        isPair = False

    End Sub
    Sub AddCardsToCollection()

        'when the cards are added to the collection, the values need to be reinitialized to clear any old hands
        reinitializeValues()

        'add suits to suit collection after renitialization occurs
        suits.Add(comBoxSuit01)
        suits.Add(comBoxSuit02)
        suits.Add(comBoxSuit03)
        suits.Add(comBoxSuit04)
        suits.Add(comBoxSuit05)

        'add denoms to denom collection...
        denomiation.Add(comBoxDenom01)
        denomiation.Add(comBoxDenom02)
        denomiation.Add(comBoxDenom03)
        denomiation.Add(comBoxDenom04)
        denomiation.Add(comBoxDenom05)

    End Sub

    Private Sub ComboBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles comBoxDenom04.KeyPress, comBoxDenom03.KeyPress, comBoxDenom02.KeyPress, comBoxDenom01.KeyPress, comBoxSuit05.KeyPress, comBoxSuit04.KeyPress, comBoxSuit03.KeyPress, comBoxSuit02.KeyPress, comBoxDenom05.KeyPress, comBoxSuit01.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnDisplayHand.PerformClick()

        End If

    End Sub
    Private Function WriteToCardArray(str As String()) As Integer(,)

        Dim denom As String
        Dim col As Integer

        'loops through this if/elseif block, exhausting all possiblities, if necessary, in order to associate 
        'the correct denomiation and suit to the correct array value that'll be the 0-3, 0-12 array the text had
        'indicated to create
        For i = 0 To stringDenomArray.Length - 1

            denom = stringDenomArray(i)
            col = i

            'str was delimited by a ":" and the result is str in two parts: the denomiation and the suit
            'This routine determines where these cards belong in the array and places them there
            If str(0) = denom And str(1) = "Club" Then
                cardsAndSuitsArray(0, col) = 1
            ElseIf str(0) = denom And str(1) = "Diamond" Then
                cardsAndSuitsArray(1, col) = 1
            ElseIf str(0) = denom And str(1) = "Heart" Then
                cardsAndSuitsArray(2, col) = 1
            ElseIf str(0) = denom And str(1) = "Spade" Then
                cardsAndSuitsArray(3, col) = 1
            End If

        Next i

        'return the values that have been put into the array
        Return cardsAndSuitsArray

    End Function
    Private Function getCardsArray() As Integer(,)


        Dim cardString As String

        For i = 1 To denomiation.Count
            'from the denomination collection, iterate through these case statements, writing to the cardArray
            Select Case (denomiation(i).text)

                'Please Note: the comments in the Ace case statement can be generalized to all the denominations within
                'this function

                Case "Ace"
                    'create a human readable string for ease of interpretation
                    cardString = "Ace of " & checkSuite(suits(i).text)

                    'write to card array the string value of cardString
                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))

                    'count the number of aces, and this is useful for determing later things in the program, for example,
                    'if there are more than 4 aces, the hand is invalid, or if there are 4, then there are four of a kind...and so on...
                    aceCount += 1

                Case "2"

                    cardString = "Two of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    twoCount += 1

                Case "3"

                    cardString = "Three of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    threeCount += 1

                Case "4"

                    cardString = "Four of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    fourCount += 1

                Case "5"

                    cardString = "Five of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    fiveCount += 1

                Case "6"

                    cardString = "Six of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    sixCount += 1

                Case "7"

                    cardString = "Seven of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    sevenCount += 1

                Case "8"

                    cardString = "Eight of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    eightCount += 1

                Case "9"

                    cardString = "Nine of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    nineCount += 1

                Case "10"

                    cardString = "Ten of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    tenCount += 1

                Case "Jack"

                    cardString = "Jack of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    jackCount += 1

                Case "Queen"

                    cardString = "Queen of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    queenCount += 1

                Case "King"

                    cardString = "King of " & checkSuite(suits(i).text)

                    WriteToCardArray(cardString.Replace(" of ", ":").Split(":"))
                    kingCount += 1

            End Select

        Next

        Return cardsAndSuitsArray

    End Function

    Private Function checkSuite(suit As String)
        'assign suit to denomination based on first character
        Select Case suit.Chars(0).ToString().ToLower

            Case "c"

                suit = "Club"
                clubCount += 1

            Case "d"

                suit = "Diamond"
                diamondCount += 1

            Case "h"

                suit = "Heart"
                heartCount += 1

            Case "s"

                suit = "Spade"
                spadeCount += 1

        End Select

        'return  the suit so that can be associated with the correct denomination
        Return suit

    End Function

End Class
