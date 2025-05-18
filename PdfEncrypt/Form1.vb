Imports iTextSharp.text.pdf
Imports System.IO

Public Class Form1

    Private Sub btnFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrom.Click
        fldFrom.ShowDialog()
        txtFrom.Text = fldFrom.SelectedPath
    End Sub

    Private Sub btnTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTo.Click
        fldTo.ShowDialog()
        txtTo.Text = fldTo.SelectedPath
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        If Trim(txtPassword.Text) = "" Then
            MsgBox("Password is missing.")
            Exit Sub
        End If

        Dim sFromPath As String = txtFrom.Text
        Dim sToPath As String = txtTo.Text

        If Not Directory.Exists(sFromPath) Then
            MsgBox("From folder does not exist")
            Exit Sub
        End If

        ProccessFolder(sFromPath, sToPath)

        MsgBox("Done!")
    End Sub


    Sub ProccessFolder(ByVal sFromPath As String, ByVal sToPath As String)

        If Not Directory.Exists(sToPath) Then
            Try
                Directory.CreateDirectory(sToPath)
            Catch ex As Exception
                MsgBox("To folder does not exist and could not be created.")
                Exit Sub
            End Try
        End If

        Dim oFiles As String() = Directory.GetFiles(sFromPath)
        ProgressBar1.Maximum = oFiles.Length

        btnProcess.Enabled = False
        For i As Integer = 0 To oFiles.Length - 1
            Dim sFromFilePath As String = oFiles(i)
            Dim oFileInfo As New FileInfo(sFromFilePath)
            Dim sToFileName As String = sToPath & "\" & oFileInfo.Name

            If UCase(oFileInfo.Extension) = ".PDF" Then
                Try
                    EncryptPdf(sFromFilePath, sToFileName, txtPassword.Text)
                Catch ex As Exception
                    Dim oStreamWriter As New StreamWriter(txtFrom.Text & "\Log.txt", True)
                    oStreamWriter.WriteLine(sFromFilePath & " " & ex.Message)
                    oStreamWriter.Close()
                End Try
            End If

            ProgressBar1.Value = i
        Next

        btnProcess.Enabled = True
        ProgressBar1.Value = 0

        Dim oFolders As String() = Directory.GetDirectories(sFromPath)
        For i As Integer = 0 To oFolders.Length - 1
            Dim sChildFolder As String = oFolders(i)
            Dim iPos As Integer = sChildFolder.LastIndexOf("\")
            Dim sFolderName As String = sChildFolder.Substring(iPos + 1)
            ProccessFolder(sChildFolder, sToPath & "\" & sFolderName)
        Next

    End Sub

    Sub EncryptPdf(ByVal sInFilePath As String, ByVal sOutFilePath As String, ByVal sPassword As String)

        Dim oPdfReader As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(sInFilePath)
        Dim oPdfDoc As New iTextSharp.text.Document()
        Dim oPdfWriter As PdfWriter = PdfWriter.GetInstance(oPdfDoc, New FileStream(sOutFilePath, FileMode.Create))
        oPdfWriter.SetEncryption(PdfWriter.STRENGTH40BITS, sPassword, sPassword, PdfWriter.AllowCopy)
        oPdfDoc.Open()

        oPdfDoc.SetPageSize(iTextSharp.text.PageSize.LEDGER.Rotate())

        Dim oDirectContent As iTextSharp.text.pdf.PdfContentByte = oPdfWriter.DirectContent
        Dim iNumberOfPages As Integer = oPdfReader.NumberOfPages
        Dim iPage As Integer = 0

        Do While (iPage < iNumberOfPages)
            iPage += 1
            oPdfDoc.SetPageSize(oPdfReader.GetPageSizeWithRotation(iPage))
            oPdfDoc.NewPage()

            Dim oPdfImportedPage As iTextSharp.text.pdf.PdfImportedPage = oPdfWriter.GetImportedPage(oPdfReader, iPage)
            Dim iRotation As Integer = oPdfReader.GetPageRotation(iPage)
            If (iRotation = 90) Or (iRotation = 270) Then
                oDirectContent.AddTemplate(oPdfImportedPage, 0, -1.0F, 1.0F, 0, 0, oPdfReader.GetPageSizeWithRotation(iPage).Height)
            Else
                oDirectContent.AddTemplate(oPdfImportedPage, 1.0F, 0, 0, 1.0F, 0, 0)
            End If
        Loop

        oPdfDoc.Close()


    End Sub

End Class
