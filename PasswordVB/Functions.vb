Imports System.Text
Imports PasswordVB.Password

Public Class Functions

    Private Shared _Random As Random = New Random()
    Private Shared _UppercaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Private Shared _LowercaseCharacters = "abcdefghijklmnopqrstuvwxyz"
    Private Shared _Numerals As String = "1234567890"
    Private Shared _NonAlphaNumericCharacters As String = "`-=[]\;',./~!@#$%^&*()_+{}:<>? " + """"
    Private Shared _StrongPassword As Boolean = True
    Private Shared _PasswordLength As Integer = 8

    Public Shared Function RandomValue(Maximum As Integer) As Integer
        Dim Value As Integer = 1

        Value = _Random.Next(1, Maximum + 1);

        Return Value
    End Function

    Public Shared Function StringToWord(Character As String) As String
        Dim Result As String = ""

        Select Case Character
            Case "1"
                Result = "one"
                Exit Select
            Case "2"
                Result = "two"
                Exit Select
            Case "3"
                Result = "three"
                Exit Select
            Case "4"
                Result = "four"
                Exit Select
            Case "5"
                Result = "five"
                Exit Select
            Case "6"
                Result = "six"
                Exit Select
            Case "7"
                Result = "seven"
                Exit Select
            Case "8"
                Result = "eight"
                Exit Select
            Case "9"
                Result = "nine"
                Exit Select
            Case "0"
                Result = "zero"
                Exit Select
            Case "a"
                Result = "alpha"
                Exit Select
            Case "b"
                Result = "bravo"
                Exit Select
            Case "c"
                Result = "charlie"
                Exit Select
            Case "d"
                Result = "delta"
                Exit Select
            Case "e"
                Result = "echo"
                Exit Select
            Case "f"
                Result = "foxtrot"
                Exit Select
            Case "g"
                Result = "golf"
                Exit Select
            Case "h"
                Result = "hotel"
                Exit Select
            Case "i"
                Result = "india"
                Exit Select
            Case "j"
                Result = "juliet"
                Exit Select
            Case "k"
                Result = "kilo"
                Exit Select
            Case "l"
                Result = "lima"
                Exit Select
            Case "m"
                Result = "mike"
                Exit Select
            Case "n"
                Result = "november"
                Exit Select
            Case "o"
                Result = "oscar"
                Exit Select
            Case "p"
                Result = "papa"
                Exit Select
            Case "q"
                Result = "quebec"
                Exit Select
            Case "r"
                Result = "romeo"
                Exit Select
            Case "s"
                Result = "sierra"
                Exit Select
            Case "t"
                Result = "tango"
                Exit Select
            Case "u"
                Result = "uniform"
                Exit Select
            Case "v"
                Result = "victor"
                Exit Select
            Case "w"
                Result = "whiskey"
                Exit Select
            Case "x"
                Result = "xray"
                Exit Select
            Case "y"
                Result = "yankee"
                Exit Select
            Case "z"
                Result = "zulu"
                Exit Select
            Case "A"
                Result = "APLHA"
                Exit Select
            Case "B"
                Result = "BRAVO"
                Exit Select
            Case "C"
                Result = "CHARLIE"
                Exit Select
            Case "D"
                Result = "DELTA"
                Exit Select
            Case "E"
                Result = "ECHO"
                Exit Select
            Case "F"
                Result = "FOXTROT"
                Exit Select
            Case "G"
                Result = "GOLF"
                Exit Select
            Case "H"
                Result = "HOTEL"
                Exit Select
            Case "I"
                Result = "INDIA"
                Exit Select
            Case "J"
                Result = "JULIET"
                Exit Select
            Case "K"
                Result = "KILO"
                Exit Select
            Case "L"
                Result = "LIMA"
                Exit Select
            Case "M"
                Result = "MIKE"
                Exit Select
            Case "N"
                Result = "NOVEMBER"
                Exit Select
            Case "O"
                Result = "OSCAR"
                Exit Select
            Case "P"
                Result = "PAPA"
                Exit Select
            Case "Q"
                Result = "QUEBEC"
                Exit Select
            Case "R"
                Result = "ROMEO"
                Exit Select
            Case "S"
                Result = "SIERRA"
                Exit Select
            Case "T"
                Result = "TANGO"
                Exit Select
            Case "U"
                Result = "UNIFORM"
                Exit Select
            Case "V"
                Result = "VICTOR"
                Exit Select
            Case "W"
                Result = "WHISKEY"
                Exit Select
            Case "X"
                Result = "XRAY"
                Exit Select
            Case "Y"
                Result = "YANKEE"
                Exit Select
            Case "Z"
                Result = "ZULU"
                Exit Select
            Case "!"
                Result = "exclamation"
                Exit Select
            Case "@"
                Result = "at"
                Exit Select
            Case "#"
                Result = "hash"
                Exit Select
            Case "$"
                Result = "dollar"
                Exit Select
            Case " "
                Result = "space"
                Exit Select
            Case "%"
                Result = "percent"
                Exit Select
            Case "^"
                Result = "caret"
                Exit Select
            Case "&"
                Result = "ampersand"
                Exit Select
            Case "*"
                Result = "asterisk"
                Exit Select
            Case "("
                Result = "left-bracket"
                Exit Select
            Case ")"
                Result = "right-bracket"
                Exit Select
            Case "_"
                Result = "underscore"
                Exit Select
            Case "+"
                Result = "plus"
                Exit Select
            Case "-"
                Result = "hyphen"
                Exit Select
            Case "="
                Result = "equals"
                Exit Select
            Case "["
                Result = "left-square-bracket"
                Exit Select
            Case "]"
                Result = "right-square-bracket"
                Exit Select
            Case "{"
                Result = "left-brace"
                Exit Select
            Case "}"
                Result = "right-brace"
                Exit Select
            Case "|"
                Result = "pipe"
                Exit Select
            Case ";"
                Result = "semi-colon"
                Exit Select
            Case "'"
                Result = "apostrophe"
                Exit Select
            Case ":"
                Result = "colon"
                Exit Select
            Case ","
                Result = "comma"
                Exit Select
            Case "."
                Result = "fullstop"
                Exit Select
            Case "<"
                Result = "less-than"
                Exit Select
            Case ">"
                Result = "greater-than"
                Exit Select
            Case "?"
                Result = "question"
                Exit Select
            Case "~"
                Result = "tilde"
                Exit Select
            Case "`"
                Result = "backtick"
                Exit Select
            Case "/"
                Result = "forward-slash"
                Exit Select
            Case "\"
                Result = "back-slash"
                Exit Select
            Case """"
                Result = "double-quote"
                Exit Select
            Case Else
                Result = Character
                Exit Select
        End Select

        Return Result


    End Function

    Public Shared Function GeneratePassword() As String
        Dim PasswordSpeltOut As String = ""

        Return GeneratePassword(_PasswordLength, PasswordSpeltOut, _StrongPassword)
    End Function

    Public Shared Function GeneratePassword(Length As Integer) As String
        Dim PasswordSpeltOut As String = ""

        Return GeneratePassword(Length, PasswordSpeltOut, _StrongPassword)
    End Function

    Public Shared Function GeneratePassword(ByRef PasswordSpeltOut As String) As String
        Return GeneratePassword(_PasswordLength, PasswordSpeltOut, _StrongPassword)
    End Function

    Public Shared Function GeneratePassword(StrongPassword As Boolean) As String
        Dim PasswordSpeltOut As String = ""

        Return GeneratePassword(_PasswordLength, PasswordSpeltOut, StrongPassword)
    End Function

    Public Shared Function GeneratePassword(Length As Integer, StrongPassword As Boolean) As String
        Dim PasswordSpeltOut As String = ""

        Return GeneratePassword(Length, PasswordSpeltOut, StrongPassword)
    End Function

    Public Shared Function GeneratePassword(ByRef PasswordSpeltOut As String, StrongPassword As Boolean) As String
        Return GeneratePassword(_PasswordLength, PasswordSpeltOut, StrongPassword)
    End Function

    Public Shared Function GeneratePassword(Length As Integer, ByRef PasswordSpeltOut As String, StrongPassword As Boolean) As String
        Dim Password As New StringBuilder()
        Dim CharacterType As Integer = 0
        Dim Queue As FixedSizeQueue(Of Integer) = Nothing
        Dim PasswordCharacterTypeMax As Integer = 4
        ' Assume strong passwords
        Dim Value As Integer = 0
        Queue = New FixedSizeQueue(Of Integer)(3)

        If Not StrongPassword Then
            PasswordCharacterTypeMax = 3
            Queue = New FixedSizeQueue(Of Integer)(1)
        End If

        ' A strong password cannot be less than 3 characters long
        If Length < 3 Then
            Length = 3
        End If

        For i As Integer = 0 To Length - 1
            CharacterType = RandomValue(PasswordCharacterTypeMax)

            If StrongPassword Then
                While Queue.Contains(CharacterType)
                    CharacterType = RandomValue(PasswordCharacterTypeMax)
                End While
                Queue.Enqueue(CharacterType)
            End If

            Select Case CharacterType
                Case 1
                    Value = RandomValue(_UppercaseCharacters.Length - 1)
                    Password.Append(_UppercaseCharacters.Substring(Value, 1))
                    Exit Select
                Case 2
                    Value = RandomValue(_LowercaseCharacters.Length - 1)
                    Password.Append(_LowercaseCharacters.Substring(Value, 1))
                    Exit Select
                Case 3
                    Value = RandomValue(_Numerals.Length - 1)
                    Password.Append(_Numerals.Substring(Value, 1))
                    Exit Select
                Case 4
                    Value = RandomValue(_NonAlphaNumericCharacters.Length - 1)
                    Password.Append(_NonAlphaNumericCharacters.Substring(Value, 1))
                    Exit Select
            End Select
        Next

        PasswordSpeltOut = SpeltOutPassword(Password.ToString())

        Return Password.ToString()
    End Function

    Public Shared Function SpeltOutPassword(Password As String) As String
        Dim Counter As Integer = 0
        Dim Result As String = ""

        For Counter = 0 To Password.Length - 1
            Result += StringToWord(Password.Substring(Counter, 1)) + " "
        Next

        If Result.EndsWith(" ") Then
            Result = Result.Substring(0, Result.Length - 1)
        End If

        Return Result
    End Function

End Class
