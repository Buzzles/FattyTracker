namespace FattyTracker.DataAccess

type IDataAccess =
    abstract member Save : unit -> unit


type LocalFileStore() =
    interface IDataAccess with
        member this.Save() = printfn "LocalSave fo'sure"