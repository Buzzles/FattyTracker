namespace FattyTracker.DataAccess

open FattyTracker

type MongoConnector() = 
    interface IDataStoreProvider with
        member this.Save() = printfn "MongoConnection"
        member this.Save(x: WeightDetails) = printfn "SavingWeightDetails"
        member this.Save(x : RunDetails) = printfn "SavingRunDetails"