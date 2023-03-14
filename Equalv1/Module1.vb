Module Module1
    Function Code128(ByVal TheText As String, ByVal CodeLetter As String) As Image
        ' TheText Special variable text to be encrypted
        ' CodeLetter Variable special category to be used

        Dim Binaryz As String = "" 'Will carry a variable text after converting to Binary
        Dim I As Integer
        Dim NumCode As Integer 'Variable account value will carry supplementary text
        If CodeLetter = "A" Or CodeLetter = "a" Then
            NumCode = 103
            Binaryz = "00101111011"
        End If
        If CodeLetter = "B" Or CodeLetter = "b" Then
            NumCode = 104
            Binaryz = "00101101111"
        End If
        If CodeLetter = "C" Or CodeLetter = "c" Then
            NumCode = 105
            Binaryz = "00101100011"
        End If
        'On next character will be entrusting the value Balbeinery by your table CODE 128
        For I = 1 To Len(TheText)
            NumCode = NumCode + ((Asc(Mid(TheText, I, 1)) - 32) * I)
            Select Case Asc(Mid(TheText, I, 1))
                Case 32
                    Binaryz = Binaryz & "00100110011"
                Case 33
                    Binaryz = Binaryz & "00110010011"
                Case 34
                    Binaryz = Binaryz & "00110011001"
                Case 35
                    Binaryz = Binaryz & "01101100111"
                Case 36
                    Binaryz = Binaryz & "01101110011"
                Case 37
                    Binaryz = Binaryz & "01110110011"
                Case 38
                    Binaryz = Binaryz & "01100110111"
                Case 39
                    Binaryz = Binaryz & "01100111011"
                Case 40
                    Binaryz = Binaryz & "01110011011"
                Case 41
                    Binaryz = Binaryz & "00110110111"
                Case 42
                    Binaryz = Binaryz & "00110111011"
                Case 43
                    Binaryz = Binaryz & "00111011011"
                Case 44
                    Binaryz = Binaryz & "01001100011"
                Case 45
                    Binaryz = Binaryz & "01100100011"
                Case 46
                    Binaryz = Binaryz & "01100110001"
                Case 47
                    Binaryz = Binaryz & "01000110011"
                Case 48
                    Binaryz = Binaryz & "01100010011"
                Case 49
                    Binaryz = Binaryz & "01100011001"
                Case 50
                    Binaryz = Binaryz & "00110001101"
                Case 51
                    Binaryz = Binaryz & "00110100011"
                Case 52
                    Binaryz = Binaryz & "00110110001"
                Case 53
                    Binaryz = Binaryz & "00100011011"
                Case 54
                    Binaryz = Binaryz & "00110001011"
                Case 55
                    Binaryz = Binaryz & "00010010001"
                Case 56
                    Binaryz = Binaryz & "00010110011"
                Case 57
                    Binaryz = Binaryz & "00011010011"
                Case 58
                    Binaryz = Binaryz & "00011011001"
                Case 59
                    Binaryz = Binaryz & "00010011011"
                Case 60
                    Binaryz = Binaryz & "00011001011"
                Case 61
                    Binaryz = Binaryz & "00011001101"
                Case 62
                    Binaryz = Binaryz & "00100100111"
                Case 63
                    Binaryz = Binaryz & "00100111001"
                Case 64
                    Binaryz = Binaryz & "00111001001"
                Case 65
                    Binaryz = Binaryz & "01011100111"
                Case 66
                    Binaryz = Binaryz & "01110100111"
                Case 67
                    Binaryz = Binaryz & "01110111001"
                Case 68
                    Binaryz = Binaryz & "01001110111"
                Case 69
                    Binaryz = Binaryz & "01110010111"
                Case 70
                    Binaryz = Binaryz & "01110011101"
                Case 71
                    Binaryz = Binaryz & "00101110111"
                Case 72
                    Binaryz = Binaryz & "00111010111"
                Case 73
                    Binaryz = Binaryz & "00111011101"
                Case 74
                    Binaryz = Binaryz & "01001000111"
                Case 75
                    Binaryz = Binaryz & "01001110001"
                Case 76
                    Binaryz = Binaryz & "01110010001"
                Case 77
                    Binaryz = Binaryz & "01000100111"
                Case 78
                    Binaryz = Binaryz & "01000111001"
                Case 79
                    Binaryz = Binaryz & "01110001001"
                Case 80
                    Binaryz = Binaryz & "00010001001"
                Case 81
                    Binaryz = Binaryz & "00101110001"
                Case 82
                    Binaryz = Binaryz & "00111010001"
                Case 83
                    Binaryz = Binaryz & "00100010111"
                Case 84
                    Binaryz = Binaryz & "00100011101"
                Case 85
                    Binaryz = Binaryz & "00100010001"
                Case 86
                    Binaryz = Binaryz & "00010100111"
                Case 87
                    Binaryz = Binaryz & "00010111001"
                Case 88
                    Binaryz = Binaryz & "00011101001"
                Case 89
                    Binaryz = Binaryz & "00010010111"
                Case 90
                    Binaryz = Binaryz & "00010011101"
                Case 91
                    Binaryz = Binaryz & "00011100101"
                Case 92
                    Binaryz = Binaryz & "00010000101"
                Case 93
                    Binaryz = Binaryz & "00110111101"
                Case 94
                    Binaryz = Binaryz & "00001110101"
                Case 95
                    Binaryz = Binaryz & "01011001111"
                Case 96
                    Binaryz = Binaryz & "01011110011"
                Case 97
                    Binaryz = Binaryz & "01101001111"
                Case 98
                    Binaryz = Binaryz & "01101111001"
                Case 99
                    Binaryz = Binaryz & "01111010011"
                Case 100
                    Binaryz = Binaryz & "01111011001"
                Case 101
                    Binaryz = Binaryz & "01001101111"
                Case 102
                    Binaryz = Binaryz & "01001111011"
                Case 103
                    Binaryz = Binaryz & "01100101111"
                Case 104
                    Binaryz = Binaryz & "01100111101"
                Case 105
                    Binaryz = Binaryz & "01111001011"
                Case 106
                    Binaryz = Binaryz & "01111001101"
                Case 107
                    Binaryz = Binaryz & "00111101101"
                Case 108
                    Binaryz = Binaryz & "00110101111"
                Case 109
                    Binaryz = Binaryz & "00001000101"
                Case 110
                    Binaryz = Binaryz & "00111101011"
                Case 111
                    Binaryz = Binaryz & "01110000101"
                Case 112
                    Binaryz = Binaryz & "01011000011"
                Case 113
                    Binaryz = Binaryz & "01101000011"
                Case 114
                    Binaryz = Binaryz & "01101100001"
                Case 115
                    Binaryz = Binaryz & "01000011011"
                Case 116
                    Binaryz = Binaryz & "01100001011"
                Case 117
                    Binaryz = Binaryz & "01100001101"
                Case 118
                    Binaryz = Binaryz & "00001011011"
                Case 119
                    Binaryz = Binaryz & "00001101011"
                Case 120
                    Binaryz = Binaryz & "00001101101"
                Case 121
                    Binaryz = Binaryz & "00100100001"
                Case 122
                    Binaryz = Binaryz & "00100001001"
                Case 123
                    Binaryz = Binaryz & "00001001001"
                Case 124
                    Binaryz = Binaryz & "01010000111"
                Case 125
                    Binaryz = Binaryz & "01011100001"
                Case 126
                    Binaryz = Binaryz & "01110100001"
                Case 127
                    Binaryz = Binaryz & "01000010111"
                Case 128
                    Binaryz = Binaryz & "01000011101"
                Case 129
                    Binaryz = Binaryz & "00001010111"
                Case 130
                    Binaryz = Binaryz & "00001011101"
                Case 131
                    Binaryz = Binaryz & "01000100001"
                Case 132
                    Binaryz = Binaryz & "01000010001"
                Case 133
                    Binaryz = Binaryz & "00010100001"
                Case 134
                    Binaryz = Binaryz & "00001010001"
                Case 135
                    Binaryz = Binaryz & "00101111011"
                Case 136
                    Binaryz = Binaryz & "00101101111"
                Case 137
                    Binaryz = Binaryz & "00101100011"
                Case 138
                    Binaryz = Binaryz & "0011100010100"
            End Select
        Next
        NumCode = NumCode Mod 103
        ' Following code to see the character you want to add text to complete
        Select Case NumCode
            Case 0
                Binaryz = Binaryz & "00100110011"
            Case 1
                Binaryz = Binaryz & "00110010011"
            Case 2
                Binaryz = Binaryz & "00110011001"
            Case 3
                Binaryz = Binaryz & "01101100111"
            Case 4
                Binaryz = Binaryz & "01101110011"
            Case 5
                Binaryz = Binaryz & "01110110011"
            Case 6
                Binaryz = Binaryz & "01100110111"
            Case 7
                Binaryz = Binaryz & "01100111011"
            Case 8
                Binaryz = Binaryz & "01110011011"
            Case 9
                Binaryz = Binaryz & "00110110111"
            Case 10
                Binaryz = Binaryz & "00110111011"
            Case 11
                Binaryz = Binaryz & "00111011011"
            Case 12
                Binaryz = Binaryz & "01001100011"
            Case 13
                Binaryz = Binaryz & "01100100011"
            Case 14
                Binaryz = Binaryz & "01100110001"
            Case 15
                Binaryz = Binaryz & "01000110011"
            Case 16
                Binaryz = Binaryz & "01100010011"
            Case 17
                Binaryz = Binaryz & "01100011001"
            Case 18
                Binaryz = Binaryz & "00110001101"
            Case 19
                Binaryz = Binaryz & "00110100011"
            Case 20
                Binaryz = Binaryz & "00110110001"
            Case 21
                Binaryz = Binaryz & "00100011011"
            Case 22
                Binaryz = Binaryz & "00110001011"
            Case 23
                Binaryz = Binaryz & "00010010001"
            Case 24
                Binaryz = Binaryz & "00010110011"
            Case 25
                Binaryz = Binaryz & "00011010011"
            Case 26
                Binaryz = Binaryz & "00011011001"
            Case 27
                Binaryz = Binaryz & "00010011011"
            Case 28
                Binaryz = Binaryz & "00011001011"
            Case 29
                Binaryz = Binaryz & "00011001101"
            Case 30
                Binaryz = Binaryz & "00100100111"
            Case 31
                Binaryz = Binaryz & "00100111001"
            Case 32
                Binaryz = Binaryz & "00111001001"
            Case 33
                Binaryz = Binaryz & "01011100111"
            Case 34
                Binaryz = Binaryz & "01110100111"
            Case 35
                Binaryz = Binaryz & "01110111001"
            Case 36
                Binaryz = Binaryz & "01001110111"
            Case 37
                Binaryz = Binaryz & "01110010111"
            Case 38
                Binaryz = Binaryz & "01110011101"
            Case 39
                Binaryz = Binaryz & "00101110111"
            Case 40
                Binaryz = Binaryz & "00111010111"
            Case 41
                Binaryz = Binaryz & "00111011101"
            Case 42
                Binaryz = Binaryz & "01001000111"
            Case 43
                Binaryz = Binaryz & "01001110001"
            Case 44
                Binaryz = Binaryz & "01110010001"
            Case 45
                Binaryz = Binaryz & "01000100111"
            Case 46
                Binaryz = Binaryz & "01000111001"
            Case 47
                Binaryz = Binaryz & "01110001001"
            Case 48
                Binaryz = Binaryz & "00010001001"
            Case 49
                Binaryz = Binaryz & "00101110001"
            Case 50
                Binaryz = Binaryz & "00111010001"
            Case 51
                Binaryz = Binaryz & "00100010111"
            Case 52
                Binaryz = Binaryz & "00100011101"
            Case 53
                Binaryz = Binaryz & "00100010001"
            Case 54
                Binaryz = Binaryz & "00010100111"
            Case 55
                Binaryz = Binaryz & "00010111001"
            Case 56
                Binaryz = Binaryz & "00011101001"
            Case 57
                Binaryz = Binaryz & "00010010111"
            Case 58
                Binaryz = Binaryz & "00010011101"
            Case 59
                Binaryz = Binaryz & "00011100101"
            Case 60
                Binaryz = Binaryz & "00010000101"
            Case 61
                Binaryz = Binaryz & "00110111101"
            Case 62
                Binaryz = Binaryz & "00001110101"
            Case 63
                Binaryz = Binaryz & "01011001111"
            Case 64
                Binaryz = Binaryz & "01011110011"
            Case 65
                Binaryz = Binaryz & "01101001111"
            Case 66
                Binaryz = Binaryz & "01101111001"
            Case 67
                Binaryz = Binaryz & "01111010011"
            Case 68
                Binaryz = Binaryz & "01111011001"
            Case 69
                Binaryz = Binaryz & "01001101111"
            Case 70
                Binaryz = Binaryz & "01001111011"
            Case 71
                Binaryz = Binaryz & "01100101111"
            Case 72
                Binaryz = Binaryz & "01100111101"
            Case 73
                Binaryz = Binaryz & "01111001011"
            Case 74
                Binaryz = Binaryz & "01111001101"
            Case 75
                Binaryz = Binaryz & "00111101101"
            Case 76
                Binaryz = Binaryz & "00110101111"
            Case 77
                Binaryz = Binaryz & "00001000101"
            Case 78
                Binaryz = Binaryz & "00111101011"
            Case 79
                Binaryz = Binaryz & "01110000101"
            Case 80
                Binaryz = Binaryz & "01011000011"
            Case 81
                Binaryz = Binaryz & "01101000011"
            Case 82
                Binaryz = Binaryz & "01101100001"
            Case 83
                Binaryz = Binaryz & "01000011011"
            Case 84
                Binaryz = Binaryz & "01100001011"
            Case 85
                Binaryz = Binaryz & "01100001101"
            Case 86
                Binaryz = Binaryz & "00001011011"
            Case 87
                Binaryz = Binaryz & "00001101011"
            Case 88
                Binaryz = Binaryz & "00001101101"
            Case 89
                Binaryz = Binaryz & "00100100001"
            Case 90
                Binaryz = Binaryz & "00100001001"
            Case 91
                Binaryz = Binaryz & "00001001001"
            Case 92
                Binaryz = Binaryz & "01010000111"
            Case 93
                Binaryz = Binaryz & "01011100001"
            Case 94
                Binaryz = Binaryz & "01110100001"
            Case 95
                Binaryz = Binaryz & "01000010111"
            Case 96
                Binaryz = Binaryz & "01000011101"
            Case 97
                Binaryz = Binaryz & "00001010111"
            Case 98
                Binaryz = Binaryz & "00001011101"
            Case 99
                Binaryz = Binaryz & "01000100001"
            Case 100
                Binaryz = Binaryz & "01000010001"
            Case 101
                Binaryz = Binaryz & "00010100001"
            Case 102
                Binaryz = Binaryz & "00001010001"
        End Select
        Binaryz = Binaryz & "0011100010100" ' End code by adding your Albainery stop all codes

        ' Image Generation displayed character Albainery the user
        Dim bmp As Bitmap = New Bitmap(Len(Binaryz), 60, System.Drawing.Imaging.PixelFormat.Format24bppRgb)
        Dim z As String ' Variable to see the font color 
        Dim GraphZ As Graphics = Graphics.FromImage(bmp)
        Dim RectZ As Rectangle = New Rectangle(0, 0, bmp.Width, bmp.Height) ' A rectangle the size of the picture to give the background in white
        ' Brush to paint the former White painted rectangle
        Dim myBrush As Brush = New Drawing.Drawing2D.LinearGradientBrush(RectZ, Color.White, Color.White, Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal)
        ' Paint the previous rectangle painted white
        GraphZ.FillRectangle(myBrush, RectZ)

        '  Draw lines Barcode
        Dim PenZ As Pen
        Dim point1 As Point ' The starting point of the line
        Dim point2 As Point ' End point of the line
        For I = 1 To Len(Binaryz)
            z = Mid(Binaryz, I, 1)
            If z = "0" Then
                PenZ = New Pen(Color.Black, 1)
                point1 = New Point(I, 0)
                point2 = New Point(I, 40)
                GraphZ.DrawLine(PenZ, point1, point2)
            Else
                PenZ = New Pen(Color.White, 1)
                point1 = New Point(I, 0)
                point2 = New Point(I, 40)
                GraphZ.DrawLine(PenZ, point1, point2)
            End If
        Next
        ' Drawing text to be encoded down code

        'GraphZ.DrawString(TheText, New Font("calibri", 12, FontStyle.Regular), New SolidBrush(Color.Black), 20, 40)



        ' The return of the final image of the function
        Code128 = bmp
    End Function
    Function Toc(ByVal Text2CStr As String) As String
        ' Function to compensate for the text you want to encrypt the ROI of the class 
        ' (C)
        Dim X As Integer = 1
        Dim NewText As String = ""
        Dim Z As String = ""
        Do
            Z = Mid(Text2CStr, X, 2)

            ' Add No. 32 to the value of ASCII character and restore output after added
            NewText = NewText & Chr(Val(Z) + 32)
            X += 2
            Z = Mid(Text2CStr, X, 1)
            If X >= Len(Text2CStr) Then Exit Do
            If Z = "" Then Exit Do
        Loop
        Toc = NewText
    End Function
End Module
