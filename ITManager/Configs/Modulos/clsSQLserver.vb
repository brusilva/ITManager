Imports Microsoft.SqlServer.Management
Imports Microsoft.SqlServer.Management.Smo

' De acordo com:
' http://kellychronicles.spaces.live.com/blog/cns!A0D71E1614E8DBF8!204.entry
Public Class clsSqlServer
    ''' <summary>
    ''' The form of EnumerateServers for all machines in the network.
    ''' </summary>
    Public Overloads Shared Function EnumerateServers() As ServerInstance()
        Return EnumerateServers("")
    End Function
    ''' <summary>
    ''' Return a collection of server instance descriptors for all SQL Servers within a network
    ''' </summary>
    ''' <param name="computerName">Specify a computer name to target a particular machine</param>
    ''' <returns>An array of ServerInstance descriptor objects</returns>
    ''' <remarks>This method translates the DataTable to a list of objects with Intellisense.</remarks>
    Public Overloads Shared Function EnumerateServers(ByVal computerName As String) As ServerInstance()
        Dim tableServers As DataTable = Nothing
        If computerName.Length = 0 Then
            tableServers = SmoApplication.EnumAvailableSqlServers
        Else
            tableServers = SmoApplication.EnumAvailableSqlServers(computerName)
        End If
        ' Create enough space for all the SQL Server instances.
        Dim list(tableServers.Rows.Count - 1) As ServerInstance
        ' Build the list of servers.
        For index As Integer = 0 To tableServers.Rows.Count - 1
            Dim row As DataRow = tableServers.Rows(index)
            Dim name As String = row("Name").ToString()
            Dim server As String = row("Server").ToString()
            Dim instance As String = row("Instance").ToString()
            Dim clustered As Boolean = row("IsClustered").ToString()
            Dim local As Boolean = row("IsLocal").ToString()
            Dim entry As New ServerInstance(name, server, instance, clustered, local)
            list(index) = entry
        Next index
        Return list
    End Function
    Public Class ServerInstance
        Public Sub New(ByVal name As String, ByVal server As String, ByVal instance As String, ByVal clustered As Boolean, ByVal local As Boolean)
            m_name = name
            m_server = server
            m_instance = instance
            m_clustered = clustered
            m_local = local
        End Sub
        Private m_name As String = ""
        Public Property Name() As String
            Get
                Return m_name
            End Get
            Set(ByVal value As String)
                m_name = value
            End Set
        End Property
        Private m_server As String = ""
        Public Property Server() As String
            Get
                Return m_server
            End Get
            Set(ByVal value As String)
                m_server = value
            End Set
        End Property
        Private m_instance As String = ""
        Public Property Instance() As String
            Get
                Return m_instance
            End Get
            Set(ByVal value As String)
                m_instance = value
            End Set
        End Property
        Private m_clustered As Boolean
        Public Property IsClustered() As Boolean
            Get
                Return m_clustered
            End Get
            Set(ByVal value As Boolean)
                m_clustered = value
            End Set
        End Property
        Private m_local As Boolean
        Public Property IsLocal() As Boolean
            Get
                Return m_local
            End Get
            Set(ByVal value As Boolean)
                m_local = value
            End Set
        End Property
    End Class
End Class
