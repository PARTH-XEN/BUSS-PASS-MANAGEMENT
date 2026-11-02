Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms

''' <summary>
''' Database connection helper module for Bus Pass Management System
''' Service-Based Database (.mdf) connection handler
''' </summary>
Public Module DBConnection

    ' Session Info
    Public LoggedInAdminId As Integer = 0
    Public LoggedInAdminUsername As String = "admin"
    Public LoggedInAdminFullName As String = "Administrator"

    Private _connectionString As String = String.Empty

    Public Function GetConnectionString() As String
        If Not String.IsNullOrEmpty(_connectionString) Then
            Return _connectionString
        End If

        Dim appDir As String = AppDomain.CurrentDomain.BaseDirectory
        Dim mdfPath As String = Path.Combine(appDir, "BusPassDB.mdf")

        ' If running in bin\Debug, look for the MDF in the output directory first
        If Not File.Exists(mdfPath) Then
            ' Check project directory
            Dim projMdf As String = Path.GetFullPath(Path.Combine(appDir, "..\..\BusPassDB.mdf"))
            If File.Exists(projMdf) Then
                mdfPath = projMdf
            ElseIf File.Exists("c:\Users\dell\OneDrive\Documents\Visual Studio 2010\Projects\BusPASS\BusPASS\BusPassDB.mdf") Then
                mdfPath = "c:\Users\dell\OneDrive\Documents\Visual Studio 2010\Projects\BusPASS\BusPASS\BusPassDB.mdf"
            End If
        End If

        ' Test Service-Based Database connection with User Instance (Standard for VS2010 Express)
        Dim testStrings As New List(Of String)()
        testStrings.Add("Data Source=.\SQLEXPRESS;AttachDbFilename=" & mdfPath & ";Integrated Security=True;User Instance=True;Connect Timeout=15;")
        testStrings.Add("Data Source=.\SQLEXPRESS;AttachDbFilename=" & mdfPath & ";Integrated Security=True;Connect Timeout=15;")
        testStrings.Add("Data Source=.\SQLEXPRESS;Initial Catalog=BusPassDB;Integrated Security=True;Connect Timeout=15;")

        For Each cs As String In testStrings
            Try
                Using conn As New SqlConnection(cs)
                    conn.Open()
                    _connectionString = cs
                    Return _connectionString
                End Using
            Catch ex As Exception
                ' Try next connection
            End Try
        Next

        ' Default fallback
        _connectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=" & mdfPath & ";Integrated Security=True;User Instance=True;"
        Return _connectionString
    End Function

    Public Function OpenConnection() As SqlConnection
        Dim conn As New SqlConnection(GetConnectionString())
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        Return conn
    End Function

    Public Function ExecuteQuery(ByVal sql As String, Optional ByVal parameters As SqlParameter() = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As SqlConnection = OpenConnection()
            Using cmd As New SqlCommand(sql, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ExecuteNonQuery(ByVal sql As String, Optional ByVal parameters As SqlParameter() = Nothing) As Integer
        Using conn As SqlConnection = OpenConnection()
            Using cmd As New SqlCommand(sql, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ExecuteScalar(ByVal sql As String, Optional ByVal parameters As SqlParameter() = Nothing) As Object
        Using conn As SqlConnection = OpenConnection()
            Using cmd As New SqlCommand(sql, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Function TestConnection(ByRef outMessage As String) As Boolean
        Try
            Using conn As SqlConnection = OpenConnection()
                outMessage = "Database connected successfully to Service-based .mdf file!"
                Return True
            End Using
        Catch ex As Exception
            outMessage = "Connection Error: " & ex.Message
            Return False
        End Try
    End Function

End Module
