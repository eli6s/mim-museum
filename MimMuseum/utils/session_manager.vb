Friend NotInheritable Class session_manager
    Public Shared Property employee_id As Integer = 0
    Public Shared Property user_name As String = String.Empty
    Public Shared Property position As UserPosition = UserPosition.Cashier

    Public Shared ReadOnly Property is_logged_in As Boolean
        Get
            Return employee_id > 0
        End Get
    End Property

    'password reset session (temporary)
    Public Shared Property reset_employee_id As Integer = 0
    Public Shared Property reset_user_name As String = String.Empty


    'open a new session for the given user
    Public Shared Sub login(
                        _employee_id As Integer,
                        _user_name As String,
                        _position As UserPosition
                        )
        session_manager.employee_id = _employee_id
        session_manager.user_name = _user_name
        session_manager.position = _position
    End Sub


    'clear all session data
    Public Shared Sub logout()
        employee_id = 0
        user_name = String.Empty
        position = UserPosition.Cashier
    End Sub


    'start a temporary password reset session
    'this is NOT a full login, it just stores the user being reset
    Public Shared Sub start_password_reset(_employee_id As Integer, _user_name As String)
        reset_employee_id = _employee_id
        reset_user_name = _user_name
    End Sub


    'clear the password reset session after the reset is complete
    Public Shared Sub end_password_reset()
        reset_employee_id = 0
        reset_user_name = String.Empty
    End Sub


    'return True if the current user has FULL access to the module
    Public Shared Function has_full_access([module] As SystemModule) As Boolean
        Return permission_manager.has_full_access(position, [module])
    End Function


    'return True if the current user can only VIEW the module
    Public Shared Function is_read_only([module] As SystemModule) As Boolean
        Return permission_manager.is_read_only(position, [module])
    End Function


    'return True if the current user can access the module at all
    Public Shared Function has_access([module] As SystemModule) As Boolean
        Return permission_manager.has_access(position, [module])
    End Function


    'return all the modules accessible to the currently logged-in user
    Public Shared Function get_my_modules() As List(Of SystemModule)
        Return permission_manager.get_accessible_modules(position)
    End Function


    ' prevent instantiation
    Private Sub New()
    End Sub

End Class