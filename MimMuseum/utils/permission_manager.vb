'`permission_manager` is essentially the "engine" under the hood. `session_manager.vb` just calls these functions.
'we do NOT call them directly. `session_manager` is always called instead because it already knows who's logged in.

Friend NotInheritable Class permission_manager
    Public Shared Function has_full_access(position As UserPosition, [module] As SystemModule) As Boolean
        If position = UserPosition.Manager Then
            Return True
        End If

        If position = UserPosition.Assistant Then
            Select Case [module]
                Case SystemModule.MuseumDashboard,
                     SystemModule.Minerals,
                     SystemModule.Classifications,
                     SystemModule.Sections,
                     SystemModule.Countries,
                     SystemModule.MuseumEquipment,
                     SystemModule.MuseumMaintenance,
                     SystemModule.MuseumEmployees,
                     SystemModule.Donations,
                     SystemModule.Events,
                     SystemModule.Guests,
                     SystemModule.Settings
                    Return True

                Case Else
                    Return False
            End Select
        End If

        If position = UserPosition.Cashier Then
            Select Case [module]
                Case SystemModule.BoutiqueDashboard,
                     SystemModule.POS,
                     SystemModule.Inventory,
                     SystemModule.Settings
                    Return True

                Case Else
                    Return False
            End Select
        End If

        'default: no access
        Return False
    End Function


    'return True if the position can only VIEW the module (no editing)
    Public Shared Function is_read_only(position As UserPosition, [module] As SystemModule) As Boolean
        'only cashier has read-only access to transactions
        If position = UserPosition.Cashier And [module] = SystemModule.Transactions Then
            Return True
        End If

        'everyone else: either full access or no access, therefore it's not just read-only
        Return False
    End Function


    'return True if the position can access the module at all (either full access OR read-only).
    Public Shared Function has_access(position As UserPosition, [module] As SystemModule) As Boolean
        Return has_full_access(position, [module]) OrElse is_read_only(position, [module])
    End Function


    'get all the modules accessible to a position
    Public Shared Function get_accessible_modules(position As UserPosition) As List(Of SystemModule)
        Dim result As New List(Of SystemModule)

        For Each m As SystemModule In [Enum].GetValues(GetType(SystemModule))
            If has_access(position, m) Then
                result.Add(m)
            End If
        Next

        Return result
    End Function


    ' Prevent instantiation
    Private Sub New()
    End Sub

End Class