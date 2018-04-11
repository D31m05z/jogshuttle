Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Xml.Serialization

Public Class Form1
    Dim MaxSensitivity As Byte = 4
    Dim CurrentSensitivity As Byte = 0
    Dim JogLoop As Byte
    Dim i As Byte
    Dim wkSETTING As New Setting
    Dim CurrentMode As Byte = 0

    Public Shared Sub Main()
        Application.Run(New Form())
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        Me.ShowInTaskbar = False

        ''====================èâä˙âªìÆçÏ====================
        deserializeSample()
        LoadSettingList()
        ComboBox4.SelectedIndex = wkSETTING.wkPREFERENCE.wkMODE_BUTTON
        ComboBox3.SelectedIndex = wkSETTING.wkPREFERENCE.wkSENS_BUTTON

        Dim size As Integer _
             = Marshal.SizeOf(GetType(RawInputDevice))
        Dim devices(0) As RawInputDevice
        ' UsagePage=13 ,Usage=1 Ç≈ÉRÉìÉVÉÖÅ[É}êßå‰ÉfÉoÉCÉXÇéwÇ∑
        devices(0).UsagePage = &HC
        devices(0).Usage = 1
        'Flags=256Ç≈ëºÉAÉvÉäÇÃÉAÉNÉeÉBÉuÉEÉBÉìÉhÉEè„Ç≈Ç‡WM_INPUTÇ™ìÆçÏ
        devices(0).Flags = 256
        'WM_INPUT ÇéÛÇØéÊÇÈÉEÉBÉìÉhÉE
        devices(0).Target = Me.Handle

        'WM_INPUT ÇóLå¯Ç…Ç∑ÇÈÉfÉoÉCÉXåQÅAdevices ÇÃêîÅA
        '  RawInputDevice ÇÃç\ë¢ëÃÉTÉCÉY
        RegisterRawInputDevices(devices, 1, size)
    End Sub


    ''====================à»â∫HIDêßå‰ïîï™====================

    Private Sub ProcessInputKey(ByRef m As Message)
        Const RidInput As Integer = &H10000003
        Dim headerSize As Integer _
            = Marshal.SizeOf(GetType(RawInputHeader))
        Dim size As Integer _
            = Marshal.SizeOf(GetType(RawInput))
        Dim input As RawInput
        GetRawInputData(m.LParam, RidInput, _
                        input, size, headerSize)
        Dim HID As RawHID = input.HID

        Select Case HID.Data
            Case 258
                For JogLoop = 0 To CByte(2 ^ CurrentSensitivity)
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCLOCK)
                    JogLoop = CByte(JogLoop + 1)
                Next
            Case 65282
                For JogLoop = 0 To CByte(2 ^ CurrentSensitivity)
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCOUNTER_CLOCK)
                    JogLoop = CByte(JogLoop + 1)
                Next
            Case 2097153
                If ComboBox3.SelectedIndex = 0 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 0 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCENTER = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCENTER)
                End If
            Case 1048577
                If ComboBox3.SelectedIndex = 1 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 1 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkPLAY = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkPLAY)
                End If
            Case 8193
                If ComboBox3.SelectedIndex = 2 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 2 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkIN = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkIN)
                End If
            Case 524289
                If ComboBox3.SelectedIndex = 3 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 3 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkOUT = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkOUT)
                End If
            Case 16385
                If ComboBox3.SelectedIndex = 4 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 4 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkADD = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkADD)
                End If
            Case 131073
                If ComboBox3.SelectedIndex = 5 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 5 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkDECK = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkDECK)
                End If
            Case 2049
                If ComboBox3.SelectedIndex = 6 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 6 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkREVERSE = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkREVERSE)
                End If
            Case 262145
                If ComboBox3.SelectedIndex = 7 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 7 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFOWARD = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFOWARD)
                End If
            Case 4097
                If ComboBox3.SelectedIndex = 8 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 8 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCAP = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCAP)
                End If
            Case 1025
                If ComboBox3.SelectedIndex = 9 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 9 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkONE_DOTS = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkONE_DOTS)
                End If
            Case 65537
                If ComboBox3.SelectedIndex = 10 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 10 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkTWO_DOTS = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkTWO_DOTS)
                End If
            Case 513
                If ComboBox3.SelectedIndex = 11 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 11 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkTHREE_DOTS = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkTHREE_DOTS)
                End If
            Case 32769
                If ComboBox3.SelectedIndex = 12 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 12 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFOUR_DOTS = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFOUR_DOTS)
                End If
            Case 257
                If ComboBox3.SelectedIndex = 13 Then
                    ChangeSensitivity()
                ElseIf ComboBox4.SelectedIndex = 13 Then
                    ChangeMode(CByte(CurrentMode + 1))
                ElseIf wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFIVE_DOTS = "{SPACE}" Then
                    SendKeys.Send(Space(1))
                Else
                    SendKeys.Send(wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFIVE_DOTS)
                End If
        End Select
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WmInput As Integer = &HFF
        If m.Msg = WmInput Then
            Me.ProcessInputKey(m)
        End If
        MyBase.WndProc(m)
    End Sub

    Private Declare Function RegisterRawInputDevices _
        Lib "user32.dll" ( _
        ByVal devices As RawInputDevice(), _
        ByVal number As Integer, ByVal size As Integer) As Integer

    Private Declare Function GetRawInputData Lib "user32.dll" ( _
        ByVal rawInput As IntPtr, ByVal command As Integer, _
        ByRef data As RawInput, ByRef size As Integer, _
        ByVal headerSize As Integer) As Integer

    Private Structure RawInputDevice
        Public UsagePage As Short
        Public Usage As Short
        Public Flags As UInteger
        Public Target As IntPtr
    End Structure

    Private Structure RawInputHeader
        Public Type As Integer
        Public Size As Integer
        Public Device As IntPtr
        Public WParam As IntPtr
    End Structure

    Private Structure RawInput
        Public Header As RawInputHeader
        Public HID As RawHID
    End Structure

    Private Structure RawHID
        Public Size As UInteger
        Public Count As UInteger
        Public Data As UInteger
    End Structure

    ''=====================Ç±Ç±Ç‹Ç≈HIDêßå‰ïîï™====================


    ''====================ä¥ìxïœçX====================
    Private Sub ChangeSensitivity()
        If CurrentSensitivity >= wkSETTING.wkPREFERENCE.wkMAX_SENSITIVITE - 1 Then
            CurrentSensitivity = 0
        Else
            CurrentSensitivity = CByte(CurrentSensitivity + 1)
        End If
        UpdateSettingDisplay()


        'ÉoÉãÅ[ÉìÉqÉìÉgÇÃÉ^ÉCÉgÉã
        NotifyIcon1.BalloonTipTitle = "CANOPUS Jog/Shuttle Controller"
        'ÉoÉãÅ[ÉìÉqÉìÉgÇ…ï\é¶Ç∑ÇÈÉÅÉbÉZÅ[ÉW
        NotifyIcon1.BalloonTipText = "Sensitivity of the Jog Dial has changed to LEVEL " + CByte(CurrentSensitivity + 1).ToString()
        'ÉoÉãÅ[ÉìÉqÉìÉgÇ…ï\é¶Ç∑ÇÈÉAÉCÉRÉì
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        'ÉoÉãÅ[ÉìÉqÉìÉgÇï\é¶Ç∑ÇÈ
        'ï\é¶Ç∑ÇÈéûä‘ÇÉ~ÉäïbÇ≈éwíËÇ∑ÇÈ
        NotifyIcon1.ShowBalloonTip(0)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        CurrentSensitivity = CByte(ComboBox2.SelectedIndex)
    End Sub


    ''====================ìÆçÏÉÇÅ[ÉhïœçX====================
    Private Sub ChangeMode(ByVal modenumber As Byte)
        If modenumber > wkSETTING.wkAppData.GetLength(0) - 1 Then
            CurrentMode = 0
        Else
            CurrentMode = modenumber
        End If

        CurrentSensitivity = 0
        UpdateSettingDisplay()


        'ÉoÉãÅ[ÉìÉqÉìÉgÇÃÉ^ÉCÉgÉã
        NotifyIcon1.BalloonTipTitle = "CANOPUS Jog/Shuttle Controller"
        'ÉoÉãÅ[ÉìÉqÉìÉgÇ…ï\é¶Ç∑ÇÈÉÅÉbÉZÅ[ÉW
        NotifyIcon1.BalloonTipText = "Now in """ + wkSETTING.wkAppData(CurrentMode).wkNAME + """ mode"
        'ÉoÉãÅ[ÉìÉqÉìÉgÇ…ï\é¶Ç∑ÇÈÉAÉCÉRÉì
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        'ÉoÉãÅ[ÉìÉqÉìÉgÇï\é¶Ç∑ÇÈ
        'ï\é¶Ç∑ÇÈéûä‘ÇÉ~ÉäïbÇ≈éwíËÇ∑ÇÈ
        NotifyIcon1.ShowBalloonTip(0)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ChangeMode(CByte(ComboBox1.SelectedIndex))
    End Sub


    ''====================ÉÅÉjÉÖÅ[èâä˙âª====================
    Private Sub LoadSettingList()
        For i = 0 To CByte(wkSETTING.wkAppData.GetLength(0) - 1)
            ComboBox1.Items.Add(wkSETTING.wkAppData(i).wkNAME)
            'ContextMenuStrip.Items.Add(wkSETTING.wkAppData(i).wkNAME)
        Next

        For i = 0 To CByte(wkSETTING.wkPREFERENCE.wkMAX_SENSITIVITE - 1)
            ComboBox2.Items.Add(i + 1)
        Next

        ''ìÆçÏÉÇÅ[ÉhêÿÇËë÷Ç¶ÉäÉXÉg
        ComboBox3.Items().Add("É_ÉCÉ")
        ComboBox3.Items().Add(">||")
        ComboBox3.Items().Add("IN")
        ComboBox3.Items().Add("OUT")
        ComboBox3.Items().Add("ADD/DIV")
        ComboBox3.Items().Add("DECK/FILE")
        ComboBox3.Items().Add("<<")
        ComboBox3.Items().Add(">>")
        ComboBox3.Items().Add("CAP/UNDO")
        ComboBox3.Items().Add("ÅE")
        ComboBox3.Items().Add("ÅEÅE")
        ComboBox3.Items().Add("ÅEÅEÅE")
        ComboBox3.Items().Add("ÅEÅEÅEÅE")
        ComboBox3.Items().Add("ÅEÅEÅEÅEÅE")
        ComboBox3.Items().Add("Ç»Çµ")

        ''ä¥ìxêÿÇË'÷Ç¶ÉäÉXÉg
        ComboBox4.Items().Add("É_ÉCÉ")
        ComboBox4.Items().Add(" >||")
        ComboBox4.Items().Add("IN")
        ComboBox4.Items().Add("OUT")
        ComboBox4.Items().Add("ADD/DIV")
        ComboBox4.Items().Add("DECK/FILE")
        ComboBox4.Items().Add("<<")
        ComboBox4.Items().Add(">>")
        ComboBox4.Items().Add("CAP/UNDO")
        ComboBox4.Items().Add("ÅE")
        ComboBox4.Items().Add("ÅEÅE")
        ComboBox4.Items().Add("ÅEÅEÅE")
        ComboBox4.Items().Add("ÅEÅEÅEÅE")
        ComboBox4.Items().Add("ÅEÅEÅEÅEÅE")
        ComboBox4.Items().Add("Ç»Çµ")

        UpdateSettingDisplay()
    End Sub


    ''====================ê›íËâÊñ çXêV====================
    Private Sub UpdateSettingDisplay()
        TextBox1.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkONE_DOTS
        TextBox2.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkTWO_DOTS
        TextBox3.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkTHREE_DOTS
        TextBox4.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFOUR_DOTS
        TextBox5.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFIVE_DOTS

        TextBox6.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkDECK
        TextBox7.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkREVERSE
        TextBox8.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkFOWARD
        TextBox9.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCAP


        TextBox10.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkADD
        TextBox11.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkOUT
        TextBox12.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkIN
        TextBox13.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkPLAY

        TextBox14.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCLOCK
        TextBox15.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCOUNTER_CLOCK
        TextBox16.Text = wkSETTING.wkAppData(CurrentMode).wkBUTTONS.wkCENTER

        ComboBox2.SelectedIndex = CurrentSensitivity
        ComboBox1.SelectedIndex = CurrentMode
    End Sub


    ''====================É^ÉXÉNÉgÉåÅ[èàóù====================
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Visible = True
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        NotifyIcon1.Visible = False ' ÉAÉCÉRÉì
        Application.Exit() ' ÉAÉvÉäÉPÅ[ÉVÉáÉìÇÃèIóπ
    End Sub

    Private Sub SetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupToolStripMenuItem.Click
        Me.Visible = True
    End Sub


    ''====================ê›íËâÊñ É{É^Éìèàóù====================
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        NotifyIcon1.Visible = False ' ÉAÉCÉRÉìÇÉgÉåÉCÇ©ÇÁéÊÇËèúÇ≠
        Application.Exit() ' ÉAÉvÉäÉPÅ[ÉVÉáÉìÇÃèIóπ
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("EXPLORER.EXE", "/select,settings.xml")
    End Sub

    ''====================ê›íËXMLÉtÉ@ÉCÉãèàóù====================
    <XmlRoot("Setting")> _
    Public Class Setting
        <XmlElement("AppData")> _
        Public wkAppData() As AppData
        <XmlElement("Preference")> _
        Public wkPREFERENCE As Preference
    End Class

    Public Class AppData
        <XmlAttribute("ID")> _
        Public ID As Integer
        <XmlElement("NAME")> _
        Public wkNAME As String
        <XmlElement("CLASSIFICATION")> _
        Public wkCLASS As String
        <XmlElement("BUTTONS")> _
        Public wkBUTTONS As BUTTONS
    End Class

    Public Class Preference
        <XmlElement("MODE_BUTTON")> _
        Public wkMODE_BUTTON As Byte
        <XmlElement("SENS_BUTTON")> _
        Public wkSENS_BUTTON As Byte
        <XmlElement("DEFAULT_MODE")> _
        Public wkDEFAULT_MODE As Byte
        <XmlElement("MAX_SENSITIVITE")> _
        Public wkMAX_SENSITIVITE As Byte
    End Class

    Public Class BUTTONS
        <XmlElement("CLOCK")> _
        Public wkCLOCK As String
        <XmlElement("COUNTER_CLOCK")> _
        Public wkCOUNTER_CLOCK As String
        <XmlElement("CENTER")> _
        Public wkCENTER As String
        <XmlElement("PLAY")> _
        Public wkPLAY As String
        <XmlElement("IN")> _
        Public wkIN As String
        <XmlElement("OUT")> _
        Public wkOUT As String
        <XmlElement("ADD")> _
        Public wkADD As String
        <XmlElement("DECK")> _
        Public wkDECK As String
        <XmlElement("REVERSE")> _
        Public wkREVERSE As String
        <XmlElement("FOWARD")> _
        Public wkFOWARD As String
        <XmlElement("CAP")> _
        Public wkCAP As String
        <XmlElement("ONE_DOTS")> _
        Public wkONE_DOTS As String
        <XmlElement("TWO_DOTS")> _
        Public wkTWO_DOTS As String
        <XmlElement("THREE_DOTS")> _
        Public wkTHREE_DOTS As String
        <XmlElement("FOUR_DOTS")> _
        Public wkFOUR_DOTS As String
        <XmlElement("FIVE_DOTS")> _
        Public wkFIVE_DOTS As String
    End Class

    Private Sub deserializeSample()
        Dim serializer As XmlSerializer = New XmlSerializer(GetType(Setting))
        Dim stream As FileStream = New FileStream("settings.xml", FileMode.Open)
        Try
            wkSETTING = CType(serializer.Deserialize(stream), Setting)
        Finally
            stream.Close()
        End Try
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim f As New Form2
        f.Owner = Me
        f.Show()
    End Sub
End Class