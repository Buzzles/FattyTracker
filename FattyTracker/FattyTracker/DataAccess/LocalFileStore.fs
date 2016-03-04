namespace FattyTracker.DataAccess

open FattyTracker

type LocalFilestore() =
    interface IDataStoreProvider with
        member this.Save() = printfn "localsave fo'sure"
        member this.Save(x: WeightDetails) = printfn "SavingWeightDetails"
        member this.Save(x : RunDetails) = printfn "SavingRunDetails"
