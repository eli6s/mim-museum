Imports System.Data.SqlClient

Public Class db_controller
    Private ReadOnly conn_str As String = "Data Source=localhost;Initial Catalog=mim_museum;Integrated Security=True"


    Private Function get_conn() As SqlConnection
        Return New SqlConnection(conn_str)
    End Function


    ' Build SqlParameter list from a dictionary
    Private Function build_params(dict As Dictionary(Of String, Object)) As List(Of SqlParameter)
        Dim list As New List(Of SqlParameter)

        If dict Is Nothing Then Return list

        For Each kvp In dict
            Dim name = "@" & kvp.Key
            Dim value = If(kvp.Value, DBNull.Value)
            list.Add(New SqlParameter(name, value))
        Next

        Return list
    End Function


    Public Function fetch(
                sql As String,
                Optional params As Dictionary(Of String, Object) = Nothing
                ) As List(Of Dictionary(Of String, Object))

        Dim result As New List(Of Dictionary(Of String, Object))

        Using con = get_conn()
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddRange(build_params(params).ToArray())
                con.Open()

                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim row As New Dictionary(Of String, Object)

                        For i = 0 To reader.FieldCount - 1
                            row(reader.GetName(i)) = reader.GetValue(i)
                        Next

                        result.Add(row)
                    End While
                End Using
            End Using
        End Using

        Return result
    End Function


    Public Function fetch_one(
                sql As String,
                Optional params As Dictionary(Of String, Object) = Nothing
                ) As Dictionary(Of String, Object)

        Using con = get_conn()
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddRange(build_params(params).ToArray())
                con.Open()

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim row As New Dictionary(Of String, Object)

                        For i = 0 To reader.FieldCount - 1
                            row(reader.GetName(i)) = reader.GetValue(i)
                        Next

                        Return row
                    End If
                End Using
            End Using
        End Using

        Return Nothing
    End Function


    Public Function fetch_val(
                sql As String,
                Optional params As Dictionary(Of String, Object) = Nothing
                ) As Object

        Using con = get_conn()
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddRange(build_params(params).ToArray())
                con.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function


    Public Function execute(
                sql As String,
                Optional params As Dictionary(Of String, Object) = Nothing
                ) As Integer

        Using con = get_conn()
            Using cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddRange(build_params(params).ToArray())
                con.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

End Class
