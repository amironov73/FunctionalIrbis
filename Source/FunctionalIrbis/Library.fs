namespace FunctionalIrbis

/// <summary>
/// ������� � ����.
/// </summary>
type SubField = {
    Code: char;
    Value: string
}

/// <summary>
/// ���� ������.
/// </summary>
type RecordField = {
    Tag: int
    Value: string
    SubFields: SubField list
}

/// <summary>
/// ������ ������.
/// </summary>
type RecordStatus =
    None = 0
    | LogicallyDeleted = 1
    | PhysicallyDeleted = 2
    | Absent = 4
    | NonActualized = 8
    | Last = 32
    | Locked = 64

/// <summary>
/// ������.
/// </summary>
type MarcRecord = {
    Mfn: int
    Status: RecordStatus
    Fields: RecordField list
}

/// <summary>
/// ���������� � �������, ������������ � ������� �����.
/// </summary>
type ClientInfo = {
    Number: string
    IPAddress: string
    Port: string
    Name: string
    ID: string
    Workstation: string
    Registered: string
    Acknowledged: string
    LastCommand: string
    CommandNumber: string
}

/// <summary>
/// �������� ���� ������.
/// </summary>
type DatabaseDescription = {
    Name: string
    Description: string
    ReadOnly: bool
}

/// <summary>
/// ���������� � ���� ������ �����.
/// </summary>
type DatabaseInfo = {
    MaxMfn: int
    LogicallyDeletedRecords: int[]
    PhysicallyDeletedRecords: int[]
    NonActualizedRecords: int[]
    LockedRecords: int[]
    DatabaseLocked: bool
}

/// <summary>
/// ���������� � ������������������ ������������ �������
/// (�� ������ client_m.mnu).
/// </summary>
type UserInfo = {
    Number: string option
    Name: string
    Password: string
    Cataloger: string option
    Reader: string option
    Circulation: string option
    Acquisitions: string option
    Provision: string option
    Administrator: string option
}

/// <summary>
/// ���������� � ������ �����-�������.
/// </summary>
type IrbisVersion = {
    Organization: string
    Version: string
    MaxClients: int
    ConnectedClients: int
}

/// <summary>
/// ���� � ������ �����.
/// </summary>
type IrbisPath =
    | System = 0
    | Data = 1
    | MasterFile = 2
    | InvertedFile = 3
    | ParameterFile = 10
    | FullText = 11
    | InternalResource = 12


/// <summary>
/// ������������ ����� �� �����-�������.
/// </summary>
type FileSpecification = {
    Path: IrbisPath
    Database: string
    Name: string
}

/// <summary>
/// ���������� � ��������, ������������� �� �����-�������.
/// </summary>
type ProcessInfo = {
    Number: string
    IPAddress: string
    Name: string
    ClientID: string
    Workstation: string
    Started: string
    LastCommand: string
    CommandNumber: string
    ProcessId: string
    State: string
}

/// <summary>
/// ����������� � ������� �����.
/// </summary>
type IrbisConnection = class

    member this.ActualizeRecord(mfn: int): unit =
        failwith "Not implemented"

    member this.Connect(): unit =
        failwith "Not implemented"

    member this.CreateDatabase(name: string) (description: string): unit =
        failwith "Not implemented"

    member this.CreateDictionary(database: string): unit =
        failwith "Not implemented"

    member this.DeleteDatabase(database: string): unit =
        failwith "Not implemented"

    member this.Disconnect(): unit =
        failwith "Not implemented"

    member this.FormatMfn(format: string) (mfn: int): string =
        failwith "Not implemented"

    member this.FormatRecord(format: string) (record: MarcRecord): string =
        failwith "Not implemented"

    member this.GetDatabaseInfo(database: string): DatabaseInfo =
        failwith "Not implemented"

    member this.GetMaxMfn(): int =
        failwith "Not implemented"

    member this.GetServerVersion(): IrbisVersion =
        failwith "Not implemented"

    member this.ListFiles(): string list =
        failwith "Not implemented"

    member this.ListProcesses(): ProcessInfo[] =
        failwith "Not implemented"

    member this.NoOp(): unit =
        failwith "Not implemented"

    member this.ReadRecord(mfn: int): MarcRecord =
        failwith "Not implemented"

    member this.ReadTextFile(specification: FileSpecification): string option =
        failwith "Not implemented"

    member this.ReloadDictionary(database: string): unit =
        failwith "Not implemented"

    member this.ReloadMasterFile(database: string): unit =
        failwith "Not implemented"

    member this.RestartServer(): unit =
        failwith "Not implemented"

    member this.Search(expression: string): int[] =
        failwith "Not implemented"

    member this.TruncateDatabase(database: string): unit =
        failwith "Not implemented"

    member this.UnlockDatabase(database: string): unit =
        failwith "Not implemented"

    member this.UnlockRecords(database: string) (mfns: int[]): unit =
        failwith "Not implemented"

    member this.UpdateIniFile(lines: string[]): unit =
        failwith "Not implemented"

    member this.UpdateUserList(users: UserInfo[]): unit =
        failwith "Not implemented"

    member this.WriteRecord(record: MarcRecord): MarcRecord =
        failwith "Not implemented"

end
