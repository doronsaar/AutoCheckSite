Module AutoCheckSiteModule

    Sub Main()
        Dim Crawler As New CrawlerLib.Crawler()
        Dim CookieContainer As New Net.CookieContainer()
        Dim HTML As String = Crawler.Request("http://www.internet-p.com", "", Nothing)
        If HTML = "" Then
            'פתח תקלה
            Crawler.Request("http://wiplsupport.com/portal/index.php", "s_fullname=Doron Saar&s_email=doronsaar@yahoo.com", CookieContainer)
        End If

    End Sub


End Module
