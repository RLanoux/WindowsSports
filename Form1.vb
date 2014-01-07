Imports System.IO

Public Class Form1

    Private Const FILEPATH As String = "H:\Programming\VB Programs\WindowsSports\WindowsSports"
    Private Const DATAFILE As String = "Sports.txt"
    Private sFullPath As String = FILEPATH & "/" & DATAFILE
    Dim moSR As StreamReader = Nothing
    Dim moSW As StreamWriter = Nothing

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadSport()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSport()
        cboSportList.Items.Clear()
    End Sub

    Private Sub LoadSport()

        'Check to make sure the data file exists
        If File.Exists(sFullPath) Then
            moSR = New StreamReader(sFullPath)
            Dim sTemp As String = moSR.ReadLine()
            While Not (sTemp = String.Empty)
                cboSportList.Items.Add(sTemp)
                sTemp = moSR.ReadLine()
            End While
            moSR.Close()
        End If
    End Sub

    Private Sub SaveSport()
        moSW = New StreamWriter(sFullPath, False)
        For Each Item As String In cboSportList.Items
            moSW.WriteLine(Item)

            'Check to make sure the data folder exists
            If Not Directory.Exists(FILEPATH) Then
                Directory.CreateDirectory(FILEPATH)
            End If
        Next
        moSW.Close()
    End Sub

    Private Sub cboSportList_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSportList.SelectedIndexChanged
        Select Case (Trim(cboSportList.Text))
            Case "Badminton"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Badminton.jpg")
            Case "Baseball"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Baseball.jpg")
            Case "Cricket"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Cricket.jpg")
            Case "Football"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Football.jpg")
            Case "Lacrosse"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Lacrosse.jpg")
            Case "NASCAR"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Nascar.jpg")
            Case "Polo"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Polo.jpg")
            Case "Quidditch"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Quidditch.jpg")
            Case "Rugby"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Rugby.jpg")
            Case "Swimming"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Swimming.jpg")
            Case "Tennis"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Tennis.jpg")
            Case "Volleyball"
                picSport.Load("H:\Programming\VB Programs\WindowsSports\WindowsSports\Volleyball.jpg")
        End Select
    End Sub

    Private Sub btnMtc_Click(sender As System.Object, e As System.EventArgs) Handles btnMtc.Click
        Mtc.Show()
    End Sub
End Class
