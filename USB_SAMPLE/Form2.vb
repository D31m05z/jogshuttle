Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "http://haizin.serveblog.net/"
        LinkLabel1.Links.Add(0, _
            LinkLabel1.Text.Length, _
            "http://haizin.serveblog.net/")
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object,ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Links(0).LinkData.ToString())
    End Sub
End Class