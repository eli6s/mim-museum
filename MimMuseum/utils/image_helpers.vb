Imports System.IO

Module image_helpers
    Private ReadOnly Property assets_dir As String
        Get
            Return Path.Combine(Directory.GetParent(Application.StartupPath).Parent.FullName, "assets")
        End Get
    End Property

    Private ReadOnly Property imgs_dir As String
        Get
            Return Path.Combine(assets_dir, "boutique-items")
        End Get
    End Property

    Private ReadOnly allowed_exts As String() = {".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp"}


    ' copies the image at <source_image_path> into the boutique storage folder
    ' under a freshly generated UUID filename, then returns that filename so the caller can persist it to the database.
    Public Function save_item_image(source_image_path As String) As String
        If String.IsNullOrWhiteSpace(source_image_path) Then
            Throw New ArgumentNullException(NameOf(source_image_path), "Source image path must not be empty.")
        End If

        If Not File.Exists(source_image_path) Then
            Throw New FileNotFoundException("Source image file not found.", source_image_path)
        End If

        Dim ext As String = Path.GetExtension(source_image_path).ToLowerInvariant()
        If Not allowed_exts.Contains(ext) Then
            Throw New ArgumentException(
                $"Unsupported image format '{ext}'. Allowed: {String.Join(", ", allowed_exts)}")
        End If

        ensure_dir_exists(imgs_dir)

        Dim uuid_filename As String = $"{Guid.NewGuid().ToString()}{ext}"
        Dim destination As String = Path.Combine(imgs_dir, uuid_filename)

        File.Copy(source_image_path, destination, overwrite:=False)

        Return uuid_filename
    End Function


    ' returns the full absolute path for a stored boutique image filename,
    ' or Nothing when the file does not exist on disk.
    Public Function get_item_image_path(filename As String) As String
        If String.IsNullOrWhiteSpace(filename) Then
            Return Nothing
        End If

        Dim full_path As String = Path.Combine(imgs_dir, filename)
        Return If(File.Exists(full_path), full_path, Nothing)
    End Function


    ' removes a boutique image file from disk.
    ' silently ignores the call when <filename> is Nothing/empty or the file no longer exists.
    Public Sub delete_item_image(filename As String)
        If String.IsNullOrWhiteSpace(filename) Then Return

        Dim full_path As String = Path.Combine(imgs_dir, filename)
        If File.Exists(full_path) Then
            File.Delete(full_path)
        End If
    End Sub


    ' returns the boutique item placeholder bitmap.
    ' falls back to a plain light-grey 200×200 bitmap if the file is missing.
    Public Function get_placeholder_image() As Bitmap
        Dim placeholder_path As String = Path.Combine(imgs_dir, "placeholder.png")

        If File.Exists(placeholder_path) Then
            Return New Bitmap(placeholder_path)
        End If

        Dim bmp As New Bitmap(200, 200)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.LightGray)
        End Using
        Return bmp
    End Function


    ' creates the given directory tree if it does not yet exist.
    Private Sub ensure_dir_exists(dir_path As String)
        If Not Directory.Exists(dir_path) Then
            Directory.CreateDirectory(dir_path)
        End If
    End Sub

End Module