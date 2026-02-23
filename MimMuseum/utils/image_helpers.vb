' =============================================================================
' Module  : ImageHelper
' Project : Museum & Boutique Management System
' Purpose : Handles all image I/O for boutique items and user profile pictures.
'           - Boutique item images  → Resources/boutique_items/
'           - User profile pictures → Resources/user_pfps/
'           - Only the UUID filename (boutique) or file extension (pfp) is
'             persisted in the database; full paths are always built at runtime.
' =============================================================================
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

    Private ReadOnly Property pfps_dir As String
        Get
            Return Path.Combine(assets_dir, "user-pfps")
        End Get
    End Property

    Private ReadOnly allowed_exts As String() = {".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp"}

    ' =========================================================================
    ' 1. save_item_image
    '    Copies the image at <source_image_path> into the boutique storage
    '    folder under a freshly generated UUID filename, then returns that
    '    filename so the caller can persist it to the database.
    '
    '    Returns : UUID filename string  (e.g. "a1b2c3d4-e5f6-...jpg")
    '    Throws  : ArgumentException     – unsupported file extension
    '              FileNotFoundException – source file missing
    '              IOException           – copy failed
    ' =========================================================================
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

    ' =========================================================================
    ' 2. get_item_image_path
    '    Returns the full absolute path for a stored boutique image filename,
    '    or Nothing when the file does not exist on disk.
    '
    '    Returns : Full path string, or Nothing
    ' =========================================================================
    Public Function get_item_image_path(filename As String) As String
        If String.IsNullOrWhiteSpace(filename) Then
            Return Nothing
        End If

        Dim full_path As String = Path.Combine(imgs_dir, filename)
        Return If(File.Exists(full_path), full_path, Nothing)
    End Function

    ' =========================================================================
    ' 3. delete_item_image
    '    Removes a boutique image file from disk. Silently ignores the call
    '    when <filename> is Nothing/empty or the file no longer exists.
    '
    '    Throws : IOException / UnauthorizedAccessException on actual I/O error
    ' =========================================================================
    Public Sub delete_item_image(filename As String)
        If String.IsNullOrWhiteSpace(filename) Then Return

        Dim full_path As String = Path.Combine(imgs_dir, filename)
        If File.Exists(full_path) Then
            File.Delete(full_path)
        End If
    End Sub

    ' =========================================================================
    ' 4. get_placeholder_image
    '    Returns the boutique item placeholder bitmap. Falls back to a plain
    '    light-gray 200×200 bitmap if the file is missing.
    ' =========================================================================
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

    ' =========================================================================
    ' 5. save_pfp
    '    Copies the image at <source_image_path> into the pfp folder, naming
    '    the file after the user ("pfp_<user_id><ext>") so that uploading a
    '    new photo automatically replaces the old one.
    '
    '    Persist only the extension (e.g. ".png") in the database — or nothing
    '    at all if you standardise on a single format.
    '
    '    Returns : The saved extension string (e.g. ".png")
    '    Throws  : ArgumentException     – unsupported extension or bad user_id
    '              FileNotFoundException – source file missing
    '              IOException           – copy failed
    ' =========================================================================
    Public Function save_pfp(source_image_path As String, user_id As Integer) As String
        If String.IsNullOrWhiteSpace(source_image_path) Then
            Throw New ArgumentNullException(NameOf(source_image_path), "Source image path must not be empty.")
        End If

        If user_id <= 0 Then
            Throw New ArgumentException("user_id must be a positive integer.", NameOf(user_id))
        End If

        If Not File.Exists(source_image_path) Then
            Throw New FileNotFoundException("Source image file not found.", source_image_path)
        End If

        Dim ext As String = Path.GetExtension(source_image_path).ToLowerInvariant()
        If Not allowed_exts.Contains(ext) Then
            Throw New ArgumentException(
                $"Unsupported image format '{ext}'. Allowed: {String.Join(", ", allowed_exts)}")
        End If

        ensure_dir_exists(pfps_dir)

        ' Delete any existing pfp for this user (could be a different extension)
        delete_pfp(user_id)

        Dim pfp_filename As String = $"pfp_{user_id}{ext}"
        Dim destination As String = Path.Combine(pfps_dir, pfp_filename)

        File.Copy(source_image_path, destination, overwrite:=True)

        Return ext
    End Function

    ' =========================================================================
    ' 6. get_pfp_path
    '    Searches the pfp folder for a file named "pfp_<user_id>.*" and returns
    '    its full path, or Nothing if the user has no pfp on disk.
    '
    '    Returns : Full path string, or Nothing
    ' =========================================================================
    Public Function get_pfp_path(user_id As Integer) As String
        If user_id <= 0 Then Return Nothing

        ensure_dir_exists(pfps_dir)

        For Each ext As String In allowed_exts
            Dim candidate As String = Path.Combine(pfps_dir, $"pfp_{user_id}{ext}")
            If File.Exists(candidate) Then
                Return candidate
            End If
        Next

        Return Nothing
    End Function

    ' =========================================================================
    ' 7. get_pfp_or_placeholder
    '    Convenience wrapper for UI use: returns the user's pfp bitmap if one
    '    exists, otherwise falls back to get_pfp_placeholder().
    '    Call this directly from your settings page to populate the pfp control.
    '
    '    Returns : Bitmap (never Nothing)
    ' =========================================================================
    Public Function get_pfp_or_placeholder(user_id As Integer) As Bitmap
        Dim pfp_path As String = get_pfp_path(user_id)

        If pfp_path IsNot Nothing Then
            Return New Bitmap(pfp_path)
        End If

        Return get_pfp_placeholder()
    End Function

    ' =========================================================================
    ' 8. delete_pfp
    '    Removes the pfp file for <user_id> from disk (all extensions checked).
    '    Silently ignores the call if no pfp exists. Call this when the user
    '    resets to the default placeholder from the settings page.
    '
    '    Throws : IOException / UnauthorizedAccessException on actual I/O error
    ' =========================================================================
    Public Sub delete_pfp(user_id As Integer)
        If user_id <= 0 Then Return

        For Each ext As String In allowed_exts
            Dim candidate As String = Path.Combine(pfps_dir, $"pfp_{user_id}{ext}")
            If File.Exists(candidate) Then
                File.Delete(candidate)
            End If
        Next
    End Sub

    ' =========================================================================
    ' 9. get_pfp_placeholder
    '    Returns the user pfp placeholder bitmap (Resources/user_pfps/placeholder.png).
    '    Falls back to a simple gray circle on a light-gray 200×200 canvas if
    '    the file is missing.
    ' =========================================================================
    Public Function get_pfp_placeholder() As Bitmap
        Dim placeholder_path As String = Path.Combine(pfps_dir, "placeholder.png")

        If File.Exists(placeholder_path) Then
            Return New Bitmap(placeholder_path)
        End If

        ' Fallback: gray circle on light-gray background
        Dim bmp As New Bitmap(200, 200)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(Color.LightGray)
            g.FillEllipse(Brushes.Gray, 40, 40, 120, 120)
        End Using
        Return bmp
    End Function


    ' ── Helpers ───────────────────────────────────────────────────────────────

    ' Creates the given directory tree if it does not yet exist.
    Private Sub ensure_dir_exists(dir_path As String)
        If Not Directory.Exists(dir_path) Then
            Directory.CreateDirectory(dir_path)
        End If
    End Sub

End Module