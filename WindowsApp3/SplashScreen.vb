Public NotInheritable Class SplashScreen

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.ApplicationTitle.Text = "Splash Screen"
        Me.Version.Text = "The one"
        Me.Copyright.Text = "The Copyright"

    End Sub

    'Private Sub SplashScreen1_Shown(sender As Object, e As EventArgs) Handles Me.Shown '
    '    ' I had to add a 'Shown' Event. The following code will allow seconds to pass 
    '    ' before continuing 

    '    Application.DoEvents()
    '    Dim sw As New Stopwatch
    '    Dim myTime As Integer = 2000 ' value in milliseconds

    '    sw.Start()
    '    Do : Loop While sw.ElapsedMilliseconds < myTime

    'End Sub

End Class
