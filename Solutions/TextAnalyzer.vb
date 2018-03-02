Imports System.Text

Public Class TextAnalyzer
    Implements ITextAnalyzer

    Private text As String

    Public Sub New(ByVal theText As String)
        text = theText
    End Sub

    Public ReadOnly Property CharacterCount() As Integer Implements ITextAnalyzer.CharacterCount
        Get
            Return text.Length
        End Get
    End Property

    Public ReadOnly Property VowelCount() As Integer Implements ITextAnalyzer.VowelCount
        Get
            Dim count, i As Integer

            count = 0
            For i = 0 To text.Length - 1
                If IsVowel(text(i)) Then
                    count = count + 1
                End If
            Next
            Return count
        End Get
    End Property

    Public ReadOnly Property ConsonantCount() As Integer Implements ITextAnalyzer.ConsonantCount
        Get
            Dim count, i As Integer

            count = 0
            For i = 0 To text.Length - 1
                If IsConsonant(text(i)) Then
                    count = count + 1
                End If
            Next
            Return count
        End Get
    End Property

    Public ReadOnly Property FrequencyOfThe() As Integer Implements ITextAnalyzer.FrequencyOfThe
        Get
            Dim count, idxCur, idxNext As Integer
            count = 0
            idxCur = 0

            While (True)
                idxNext = text.IndexOf("the", idxCur, StringComparison.OrdinalIgnoreCase)
                If idxNext = -1 Then
                    Return count
                End If
                idxCur = idxNext + 1
                count = count + 1
            End While
        End Get
    End Property

    Public Function FilterNonVowels() As String Implements ITextAnalyzer.FilterNonVowels
        Dim sb As New StringBuilder(CInt(text.Length / 2))

        Dim i As Integer
        For i = 0 To text.Length - 1
            If IsVowel(text(i)) Then
                sb.Append(text(i))
            End If
        Next
        Return sb.ToString()
    End Function

    Private Shared Function IsVowel(ByVal c As Char) As Boolean
        c = Char.ToLower(c)
        Return (c = "a") Or (c = "e") Or (c = "i") Or (c = "o") Or (c = "u")
    End Function

    Private Shared Function IsConsonant(ByVal c As Char) As Boolean
        Return Char.IsLetter(c) And Not IsVowel(c)
    End Function

End Class
