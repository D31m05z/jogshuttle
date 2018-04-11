Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LinkLabel1.Text = "https://wheelcontroller.wordpress.com"
        LinkLabel1.Links.Add(0, LinkLabel1.Text.Length, "https://wheelcontroller.wordpress.com")
        LinkLabel1.TextAlign = ContentAlignment.TopLeft

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Links(0).LinkData.ToString())
    End Sub
End Class