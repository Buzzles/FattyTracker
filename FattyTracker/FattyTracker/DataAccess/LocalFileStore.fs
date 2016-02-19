namespace FattyTracker.DataAccess

type LocalFileStore() =
    interface IDataAccess with
        member this.Save() = printfn "LocalSave fo'sure"