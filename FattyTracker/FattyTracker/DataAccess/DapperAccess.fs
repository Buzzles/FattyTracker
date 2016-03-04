namespace FattyTracker.DataAccess

open FattyTracker

type DapperHandler() =
    let x = 0
    interface IDataStoreProvider with
        member this.Save() = printfn "Dapper handler for DB"
        member this.Save(x: WeightDetails) = printfn "SavingWeightDetails"
        member this.Save(x: RunDetails) = printfn "SavingRunDetails"
