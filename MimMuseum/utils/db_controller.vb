Imports System.Data.SqlClient

Public Class db_controller
    Private ReadOnly conn_str As String = "Data Source=localhost;Initial Catalog=mim_museum;Integrated Security=True"

    ' no need for a function to close connections since we're using a context manager

    ' return a new SqlConnection
    Private Function get_conn() As SqlConnection
        Return New SqlConnection(conn_str)
    End Function


    ' build the SqlParameter list from a dictionary
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

        Using conn = get_conn()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddRange(build_params(params).ToArray())
                conn.Open()

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


    Public Function fetch_row(
            sql As String,
            Optional params As Dictionary(Of String, Object) = Nothing
            ) As Dictionary(Of String, Object)

        Using conn = get_conn()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddRange(build_params(params).ToArray())
                conn.Open()

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

    ' fetch a value
    Public Function fetch_val(
            sql As String,
            Optional params As Dictionary(Of String, Object) = Nothing
            ) As Object

        Using conn = get_conn()
            Using cmd As New SqlCommand(sql, conn)

                If params IsNot Nothing Then
                    cmd.Parameters.AddRange(build_params(params).ToArray())
                End If

                conn.Open()

                Dim result = cmd.ExecuteScalar()

                If result Is Nothing OrElse IsDBNull(result) Then
                    Return 0
                End If

                Return result
            End Using
        End Using
    End Function


    ' fetch data as a DataTable
    Public Function fetch_datatable(
            sql As String,
            Optional params As Dictionary(Of String, Object) = Nothing
            ) As DataTable

        Dim dt As New DataTable()

        Using conn = get_conn()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddRange(build_params(params).ToArray())
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function


    Public Function execute(
            sql As String,
            Optional params As Dictionary(Of String, Object) = Nothing
            ) As Integer

        Using conn = get_conn()
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddRange(build_params(params).ToArray())
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

End Class
