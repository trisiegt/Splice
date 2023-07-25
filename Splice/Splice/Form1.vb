Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Message, Title, UsernamePrompt
        Message = "What is your Steam username?"    ' Set prompt.
        Title = "Splice for CSGO"    ' Set title.

        ' Display message, title, and default value.
        UsernamePrompt = InputBox(Message, Title, )

        Label3.Text = UsernamePrompt
        If Label3.Text = "" Then Close()

        Dim SteamPath = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam", "InstallPath", Nothing)
        Label6.Text = "Steam Install Path (required for patching): " & SteamPath

    End Sub


End Class
