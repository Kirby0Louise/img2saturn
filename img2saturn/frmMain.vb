Imports System.IO
Public Class frmMain

    Public filesToProcess As Integer = 0
    Private Sub tsbLoad_Click(sender As Object, e As EventArgs) Handles tsbLoad.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*"
            ofd.Multiselect = True
            If ofd.ShowDialog() = DialogResult.OK Then
                populateListView(ofd.FileNames)
            End If
        End Using
    End Sub

    Private Sub populateListView(fileNames() As String)
        For Each targetPath As String In fileNames
            Dim lvi As New ListViewItem(targetPath)
            Dim outStr As String = targetPath.Substring(targetPath.LastIndexOf("\") + 1)
            outStr = outStr.Substring(0, outStr.LastIndexOf(".")) + ".GFX"
            lvi.SubItems.Add(outStr)
            lvi.SubItems.Add("Unprocessed")
            lvi.ImageKey = "image.png"
            lvImages.Items.Add(lvi)
        Next
    End Sub

    Private Sub tsbAbout_Click(sender As Object, e As EventArgs) Handles tsbAbout.Click
        MsgBox("img2saturn v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + " by Kirby0Louise", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "About")
    End Sub

    Private Sub tsbConvert_Click(sender As Object, e As EventArgs) Handles tsbConvert.Click
        filesToProcess = 0
        For Each lvi As ListViewItem In lvImages.Items
            If lvi.SubItems(2).Text = "Unprocessed" Then
                filesToProcess += 1
            End If
        Next

        If Not filesToProcess > 0 Then
            Exit Sub
        End If
        setupOutputFolder()
        setupProgressBar()
        convertAllFilesToSaturn()
    End Sub

    Private Sub setupOutputFolder()
        If Not My.Computer.FileSystem.DirectoryExists(Environment.CurrentDirectory + "\output") Then
            Try
                Directory.CreateDirectory(Environment.CurrentDirectory + "\output")
            Catch ex As Exception
                MsgBox("Exception occured when creating output directory." + vbNewLine + vbNewLine + "You most likely lack permission to create it, but the full error details are below:" + vbNewLine + vbNewLine + ex.Message + vbNewLine + vbNewLine + ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!!")
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub setupProgressBar()
        tspbProcessing.Value = 0
        tspbProcessing.Maximum = filesToProcess
    End Sub

    Private Sub convertAllFilesToSaturn()
        For Each lvi As ListViewItem In lvImages.Items
            If lvi.SubItems(2).Text = "Unprocessed" Or lvi.SubItems(2).Text = "Errored Out" Then
                'read image
                Dim targetPath As String = lvi.Text
                Dim image As New Bitmap(targetPath)

                'Output array
                Dim outputArray(image.Width * image.Height - 1) As UShort

                'Zero fill
                For i As Integer = 0 To image.Height - 1
                    For j As Integer = 0 To image.Width - 1
                        outputArray(i * image.Width + j) = 0
                    Next
                Next

                '8888 RGBA to 1555 ABGR
                For y As Integer = 0 To image.Height - 1
                    For x As Integer = 0 To image.Width - 1

                        'Alpha
                        If Not image.GetPixel(x, y).A = 0 Then
                            'Alpha bit set to 1
                            outputArray(x + y * image.Width) = outputArray(x + y * image.Width) Or &H8000
                        End If

                        'Blue
                        Dim blueSaturn As UShort = CUShort(image.GetPixel(x, y).B >> 3)
                        blueSaturn <<= 10
                        outputArray(x + y * image.Width) = outputArray(x + y * image.Width) Or blueSaturn

                        'Green
                        Dim debyte2 As Byte = image.GetPixel(x, y).G
                        Dim greenSaturn As UShort = CUShort(image.GetPixel(x, y).G >> 3)
                        greenSaturn <<= 5
                        outputArray(x + y * image.Width) = outputArray(x + y * image.Width) Or greenSaturn

                        'Red
                        Dim debyte3 As Byte = image.GetPixel(x, y).R
                        Dim redSaturn As UShort = CUShort(image.GetPixel(x, y).R >> 3)
                        outputArray(x + y * image.Width) = outputArray(x + y * image.Width) Or redSaturn

                        'switch endian because conversion to bytes forces LE
                        outputArray(x + y * image.Width) = swapEndian(outputArray(x + y * image.Width))
                    Next
                Next

                'UShort to bytes
                Dim finalBytes(outputArray.Length * 2 - 1) As Byte
                Buffer.BlockCopy(outputArray, 0, finalBytes, 0, outputArray.Length * 2)

                'try writing output file
                Try
                    File.WriteAllBytes(Environment.CurrentDirectory + "\output\" + lvi.SubItems(1).Text, finalBytes)
                    lvi.ImageKey = "tick-circle.png"
                    lvi.SubItems(2).Text = "Completed"
                Catch ex As Exception
                    MsgBox("Exception occured when writing output file " + lvi.SubItems(1).Text + "." + vbNewLine + vbNewLine + "You most likely lack permission to create/write it, but the full error details are below:" + vbNewLine + vbNewLine + ex.Message + vbNewLine + vbNewLine + ex.StackTrace, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!!")
                    lvi.ImageKey = "cross-circle.png"
                    lvi.SubItems(2).Text = "Errored Out"
                End Try

                'update progress bar
                tspbProcessing.Value += 1
                Application.DoEvents()
            End If
        Next
    End Sub


    'For various things
    Private Function swapEndian(ByVal value As UShort) As UShort
        Dim result As UShort = (value And &HFF) << 8 Or (value And &HFF00) >> 8
        Return result
    End Function

End Class
