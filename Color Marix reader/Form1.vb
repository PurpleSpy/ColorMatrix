Public Class Form1
    Dim pim As Drawing.Image = Nothing
    Dim pim2 As Drawing.Image = Nothing
    Dim cm As New Drawing.Imaging.ColorMatrix
    Dim loaded As Boolean = False
    Dim backimg As New Bitmap(40, 40)
    Dim csaves As New ArrayList
    Dim tempzipaddress As String = ""
    Dim crollzip As IO.Compression.ZipArchive = Nothing
    Dim zipsream As IO.Stream = Nothing
    Dim crollnum As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        Select Case sender.text.tolower
            Case "new camera roll"
                sender.text = "Add Image"
                Try


                    If crollzip IsNot Nothing Then
                        crollnum = 0
                        zipsream.Close()
                        crollzip.Dispose()
                        IO.File.Delete(tempzipaddress)
                        cameralabel1.Text = crollnum
                        Button2.Enabled = False
                    End If
                Catch ex As Exception

                End Try

                tempzipaddress = My.Computer.FileSystem.GetTempFileName
                zipsream = IO.File.Open(tempzipaddress, IO.FileMode.OpenOrCreate)
                crollzip = New IO.Compression.ZipArchive(zipsream, IO.Compression.ZipArchiveMode.Create)
                crollnum += 1
                cameralabel1.Text = crollnum
                writeEntryInZip(crollzip, pim, "base.png")
            Case "add image"
                crollnum += 1
                Button2.Enabled = True
                cameralabel1.Text = crollnum
                writeEntryInZip(crollzip, pim2, "colorized" & crollnum & ".png")
            Case "save camera roll"
                Button1.Text = "New Camera Roll"
                Try
                    Using cp As New SaveFileDialog
                        cp.Filter = "camera roll zip file|*.zip"
                        zipsream.Flush()
                        crollzip.Dispose()

                        If cp.ShowDialog = DialogResult.OK Then

                            IO.File.Move(tempzipaddress, cp.FileName)
                        End If
                        Button2.Enabled = False
                    End Using
                Catch ex As Exception

                End Try

        End Select


    End Sub

    Public Sub writeEntryInZip(zip As IO.Compression.ZipArchive, img As Drawing.Image, fname As String)
        Dim ne As IO.Compression.ZipArchiveEntry = zip.CreateEntry(fname)

        Dim encoderingo As Imaging.ImageCodecInfo = grabencoder("png")
        Dim enc As New Imaging.Encoder(encoderingo.Clsid)
        Dim encoderparam As New Imaging.EncoderParameters(1)
        Dim qualparm As New Imaging.EncoderParameter(enc, 5L)
        encoderparam.Param(0) = qualparm
        Dim be As IO.Stream = ne.Open
        img.Save(be, encoderingo, encoderparam)
        be.Flush()
        be.Close()

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim icount As Integer = 0
        Dim y = 0
        For Each itm As Reflection.PropertyInfo In cm.GetType.GetProperties
            If icount > 1 And icount Mod 5 = 0 Then

                y += 1

            End If
            If itm.Name.ToLower.IndexOf("matrix") = 0 Then

                Dim cnum As New NumericUpDown

                cnum.DecimalPlaces = 3
                cnum.Increment = 0.01
                cnum.Minimum = -5
                cnum.Maximum = 5



                cnum.Top = y * cnum.Height
                cnum.Left = (icount Mod 5) * cnum.Width
                cnum.Name = itm.Name
                cnum.Value = itm.GetValue(cm)
                Panel1.HorizontalScroll.Enabled = True
                Panel1.VerticalScroll.Enabled = True

                Panel1.Controls.Add(cnum)
                AddHandler cnum.ValueChanged, AddressOf matrixchange
                icount += 1
            End If
        Next

        Using drg As Drawing.Graphics = Drawing.Graphics.FromImage(backimg)
            Dim ccolor As Drawing.Color = Drawing.Color.Azure
            Dim bbrush As New Drawing.SolidBrush(ccolor)

            drg.FillRectangle(bbrush, New Rectangle(0, 0, 20, 20))
            drg.FillRectangle(bbrush, New Rectangle(20, 20, 20, 20))
        End Using

        PictureBox1.BackgroundImage = backimg
        PictureBox1.BackgroundImageLayout = ImageLayout.Tile
        picturebox2.BackgroundImage = backimg
        picturebox2.BackgroundImageLayout = ImageLayout.Tile
        PictureBox1.Cursor = Cursors.Hand
        picturebox2.Cursor = Cursors.Hand

        csaves.Add(New ColorMatrixSave)
        csaves(0).name = "Default"

        ComboBox1.Items.Add(csaves(0).name)
        Panel1.Enabled = False
        Panel2.Enabled = False
    End Sub

    Public Sub matrixchange(sender As Object, e As EventArgs)
        updateImages()
    End Sub


    Function createMatrix() As Drawing.Imaging.ColorMatrix
        Dim cmat As New Drawing.Imaging.ColorMatrix
        For Each itm As NumericUpDown In Panel1.Controls
            If itm.Name.ToLower.IndexOf("matrix") = 0 Then
                cmat.GetType.GetProperty(itm.Name).SetValue(cmat, Single.Parse(itm.Value))

            End If

        Next
        Return cmat
    End Function

    Public Function appyMatrix(img As Drawing.Image, matrix As Imaging.ColorMatrix) As Image
        Dim sp As New Bitmap(img.Width, img.Height)
        Dim xrc As New Imaging.ImageAttributes

        xrc.SetColorMatrix(matrix)
        sp.MakeTransparent()

        Using gdi As Drawing.Graphics = Drawing.Graphics.FromImage(sp)

            gdi.DrawImage(img, New Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, xrc)
        End Using

        Return sp
    End Function
    Private Sub OpenImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenImageToolStripMenuItem.Click
        Try
            Using srp As New OpenFileDialog
                srp.Filter = "Images|*.*"
                srp.FilterIndex = 1

                If srp.ShowDialog = DialogResult.OK Then
                    Try
                        Dim bim As Image = Image.FromFile(srp.FileName)
                        cm = createMatrix()
                        pim = bim
                        updateImages()
                        Panel1.Enabled = True
                        Panel2.Enabled = True
                        CloseImageToolStripMenuItem.Enabled = True
                    Catch ex As Exception
                        MessageBox.Show("File not accepted")
                    End Try
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub


    Sub updateImages()
        Try
            cm = createMatrix()
            pim2 = appyMatrix(pim, cm)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            picturebox2.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Image = pim
            picturebox2.Image = pim2
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SaveColorizedImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveColorizedImageToolStripMenuItem.Click
        Using dc As New SaveFileDialog
            dc.DefaultExt = "png"
            dc.Filter = "Png file|*.png"
            dc.FilterIndex = 1

            Try
                If dc.ShowDialog = DialogResult.OK Then
                    Try
                        Using ffname As IO.FileStream = IO.File.Open(dc.FileName, IO.FileMode.Create)
                            Dim encoderingo As Imaging.ImageCodecInfo = grabencoder("png")
                            Dim enc As New Imaging.Encoder(encoderingo.Clsid)
                            Dim encoderparam As New Imaging.EncoderParameters(1)
                            Dim qualparm As New Imaging.EncoderParameter(enc, 5L)
                            encoderparam.Param(0) = qualparm
                            pim2.Save(ffname, encoderingo, encoderparam)
                        End Using
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try

        End Using
    End Sub

    Public Function grabencoder(mime As String) As Imaging.ImageCodecInfo
        For Each itm As Imaging.ImageCodecInfo In Imaging.ImageCodecInfo.GetImageEncoders
            If itm.MimeType.ToLower.IndexOf(mime.ToLower) > 1 Then
                Return itm
            End If
        Next
        Return Nothing
    End Function

    Public Sub viewImage(img As Image, backimg As Image)
        Dim fform As New Form
        Dim cpan As New Panel
        Dim pbox As New PictureBox

        cpan.Controls.Add(pbox)
        fform.Controls.Add(cpan)
        cpan.Dock = DockStyle.Fill
        cpan.AutoScroll = True
        cpan.BackgroundImage = backimg
        cpan.BackgroundImageLayout = ImageLayout.Tile
        pbox.SizeMode = PictureBoxSizeMode.AutoSize

        pbox.Image = img

        pbox.Location = New Point(0, 0)
        cpan.Location = New Point(0, 0)

        fform.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, picturebox2.Click
        Select Case sender.name.tolower
            Case "picturebox1"
                If pim IsNot Nothing Then
                    viewImage(pim, backimg)
                End If

            Case "picturebox2"
                If pim IsNot Nothing Then
                    viewImage(pim2, backimg)
                End If
        End Select

    End Sub

    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub CloseImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseImageToolStripMenuItem.Click
        pim2 = Nothing
        pim = Nothing
        sender.enabled = False
        Panel1.Enabled = False
        Panel2.Enabled = False
        PictureBox1.Image = Nothing
        picturebox2.Image = Nothing
        crollnum = 0
        Button1.Text = "New Camera Roll"
    End Sub


End Class

Public Class ColorMatrixSave
    Public Property ColorMatrix As New Drawing.Imaging.ColorMatrix
    Public Property Name As String = ""
    Public Property MatrixDetails As New Collections.SortedList
    Sub New()

    End Sub

    Public Function createMatrix() As Drawing.Imaging.ColorMatrix
        ColorMatrix = New Drawing.Imaging.ColorMatrix
        For Each itm As Reflection.PropertyInfo In MatrixDetails.GetType.GetProperties
            If MatrixDetails.ContainsKey(itm.Name) Then
                ColorMatrix.GetType.GetProperty(itm.Name).SetValue(ColorMatrix, MatrixDetails(itm.Name))
            End If
        Next

        Return ColorMatrix
    End Function

    Public Sub saveMatrix(path As String)
        MatrixDetails.Clear()
        MatrixDetails("Name") = Name
        For Each itm As Reflection.PropertyInfo In ColorMatrix.GetType.GetProperties

            If itm.Name.ToLower.IndexOf("matrix") = 0 Then
                MatrixDetails(itm.Name) = ColorMatrix.GetType.GetProperty(itm.Name).GetValue(ColorMatrix)
            End If
        Next



        Dim jeer As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
        Using xmr As IO.Stream = IO.File.OpenWrite(path)
            Using strre As New IO.StreamWriter(xmr)
                Dim jsout As String = System.Text.Json.JsonSerializer.Serialize(MatrixDetails)
                strre.Write(jsout)
                strre.Flush()
                strre.Close()
            End Using


        End Using


    End Sub

    Public Sub loadMatrix(path As String)
        If IO.File.Exists(path) Then
            Try

                Using stre As IO.Stream = IO.File.Open(path, IO.FileMode.Open)

                    Dim testval As New SortedList
                    testval = System.Text.Json.JsonSerializer.Deserialize(stre, testval.GetType)
                    If testval.ContainsKey("Name") Then
                        Name = testval(Name)
                    End If

                    MatrixDetails = testval
                    stre.Close()
                    Me.ColorMatrix = createMatrix()
                End Using
            Catch ex As Exception

            End Try




        End If
    End Sub

End Class