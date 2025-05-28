Option Strict Off
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Windows.Forms
Imports System.Threading.Tasks
Imports IWshRuntimeLibrary
Imports System.Data.Common
Imports SevenZipExtractor
Imports SevenZip
Public Class Form1

    Private Sub LinkL(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = "https://github.com/TrollboxDevelopersUnited/WinTrollbox"
            psi.UseShellExecute = True ' This ensures the system uses the default browser
            Process.Start(psi)
        Catch ex As System.ComponentModel.Win32Exception
            MessageBox.Show($"Error: {ex.Message}",
"Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LinkG(sender As Object, e As EventArgs) Handles LinkLabel2.Click
        Try
            Dim psi As New ProcessStartInfo()
            psi.FileName = "https://github.com/TrollboxDevelopersUnited/wintrollboxsetup"
            psi.UseShellExecute = True ' This ensures the system uses the default browser
            Process.Start(psi)
        Catch ex As System.ComponentModel.Win32Exception
            MessageBox.Show($"Error: {ex.Message}",
"Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub install(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = True
        LinkLabel1.Visible = False
        LinkLabel2.Visible = False
        Button1.Visible = False
        CheckBox1.Visible = False


        Try
            ' URL of the file to download
            Dim fileUrl As String = "https://github.com/TrollboxDevelopersUnited/WinTrollbox/releases/download/v5.5/wowa7zfile.7z"

            Dim iconUrl As String = "https://www.windows93.net/favicon.ico?v=2.4.9"

            Dim IcosavePath As String = Path.Combine(Path.GetTempPath(), "Trollbox\") & "ico.ico"
            ' Path to save the downloaded file
            Dim savePath As String = Path.Combine(Path.GetTempPath(), "Trollbox\") & "wowa7zfile.7z"
            SevenZip.SevenZipExtractor.SetLibraryPath("C:\Program Files\7-Zip\7z.dll")
            Dim sevenZup As New ProcessStartInfo()
            sevenZup.FileName = "C:\Program Files\7-Zip\7z.exe"
            sevenZup.Arguments = $"x ""{Path.Combine(Path.GetTempPath, "Trollbox\") & "wowa7zfile.7z"}"" -o""{Path.Combine(Path.GetTempPath(), "Trollbox")}"" -y"
            sevenZup.WindowStyle = ProcessWindowStyle.Hidden
            sevenZup.UseShellExecute = False


            Dim extractor As New SevenZip.SevenZipExtractor(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads\") & "wowa7zfile.7z")
            ' Specify the path of the folder to be created
            Dim folderPath As String = Path.Combine(Path.GetTempPath(), "Trollbox")
            If IO.File.Exists(folderPath) Then
                Dim result1 As DialogResult = MessageBox.Show("Do you want to update the app?",
                                                              "Update Confirmation",
MessageBoxButtons.YesNo,
MessageBoxIcon.Question
                )
                If result1 = DialogResult.No Then
                    Environment.Exit(0)

                End If
            End If
            Try
                ' Check if the folder already exists
                If Not Directory.Exists(folderPath) Then
                    ' Create the folder
                    Directory.CreateDirectory(folderPath)
                    Console.WriteLine("Folder created.")


                End If
            Catch ex As Exception
                ' Handle any errors
                MessageBox.Show(
                    $"Error creating folder: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
            End Try
            ' Download the file
            Try
                Using client As New HttpClient()

                    Dim bytes1 As Byte() = Await client.GetByteArrayAsync(fileUrl)
                    Await System.IO.File.WriteAllBytesAsync(savePath, bytes1)



                    Try
                        Dim proc As Process = Process.Start(sevenZup)
                        proc.WaitForExit()
                    Catch ex As Exception
                        MessageBox.Show(
                            $"Error: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                    End Try
                    Dim bytes2 As Byte() = Await client.GetByteArrayAsync(iconUrl)
                    Await System.IO.File.WriteAllBytesAsync(IcosavePath, bytes2)
                End Using
            Catch ex As Exception
                MessageBox.Show(
                    $"Error downloading file: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)
            End Try


            If Not IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "Trollbox.lnk") Then
                Try

                    Dim shortcutPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Trollbox.lnk") ' Where the shortcut will be saved
                    Dim targetPath As String = Path.Combine(Path.GetTempPath(), "Trollbox\") & "net9.0-windows\testapp9.exe" ' Path to the application or file
                    Dim description As String = "Trollbox Native App"

                    ' Create the shortcut
                    Dim shell As New WshShell()
                    Dim shortcut As IWshShortcut = CType(shell.CreateShortcut(shortcutPath), IWshShortcut)
                    shortcut.TargetPath = targetPath
                    shortcut.IconLocation = IcosavePath
                    shortcut.Description = description
                    shortcut.Save()

                    Console.WriteLine("System shortcut created successfully!")
                Catch ex As Exception
                    MessageBox.Show($"Error creating shortcut: {ex.Message}",
                                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
)
                End Try
            Else
                MessageBox.Show(
                        "Shortcut already exists.",
                        "Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning)
            End If

            Dim result As DialogResult = MessageBox.Show("Setup Installed! You can now close the setup.",
"Installed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            )
            If result = DialogResult.OK Then
                Environment.Exit(0)
            End If

        Catch ex As Exception
            MessageBox.Show(
                $"Error downloading file: {ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                )
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
