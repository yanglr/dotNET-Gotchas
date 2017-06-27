Module Test

    '...
    'You will see the effect of this attribute
    <MTAThread()> _
    Sub Main()
        '...
        Dim theMyComp As MyCOMCompLib.IMyComp _
    = New MyCOMCompLib.MyCompClass

        theMyComp.Method1()
    End Sub

End Module
