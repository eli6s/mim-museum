Module enums
    Public Enum FormMode As Integer
        Add = 0
        Edit = 1
    End Enum

    Public Enum EventStatus As Integer
        Upcoming = 0
        Ongoing = 1
        Completed = 2
        Cancelled = 3
    End Enum


    Public Enum ItemStatus As Integer
        Active = 1
        InRepair = 2
        Inactive = 3
    End Enum


    Public Enum ServiceType As Integer
        Internal = 1
        External = 2
    End Enum


    Public Enum DonationType As Integer
        Standard = 1
        _Event = 2
    End Enum


    Public Enum PaymentMethod As Integer
        Cash = 1
        Card = 2
    End Enum


    Public Enum BuildingType As Integer
        Museum = 1
        Boutique = 2
    End Enum


    Public Enum SessionStatus As Integer
        Active = 1
        Ended = 2
    End Enum


    Public Enum ActionType As Integer
        Create = 1
        Delete = 2
        Update = 3
    End Enum


    Public Enum UserPosition As Integer
        Manager = 1
        Assistant = 2
        Cashier = 3
    End Enum


    Public Enum SystemModule As Integer
        ' museum modules
        MuseumDashboard = 100
        Minerals = 101
        Classifications = 102
        Sections = 103
        Countries = 104
        MuseumEquipment = 105
        MuseumMaintenance = 106
        MuseumEmployees = 107
        Donations = 108
        Events = 109
        Guests = 110

        ' boutique modules
        BoutiqueDashboard = 200
        POS = 201
        Inventory = 202
        Transactions = 203
        Customers = 204
        BoutiqueEmployees = 205
        BoutiqueEquipment = 206
        BoutiqueMaintenance = 207

        Categories = 300
        Positions = 301
        Users = 302
        Reports = 303
        Settings = 304
    End Enum

End Module
