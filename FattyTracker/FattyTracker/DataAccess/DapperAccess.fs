namespace FattyTracker.DataAccess

type DapperHandler() =
    let x = 0
    interface IDataAccess with
        member this.Save() = printfn "Dapper handler for DB"
