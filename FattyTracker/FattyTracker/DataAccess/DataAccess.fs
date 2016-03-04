namespace FattyTracker.DataAccess

open FattyTracker

type DataAccessProvider (dataProvider: IDataStoreProvider ) =
    let provider : IDataStoreProvider = dataProvider
    member this.SaveWeight(x :obj) = // type constraint ensures it's an object
        match x with
        | :? WeightDetails as wd -> provider.Save(wd)
        | :? RunDetails as rd -> provider.Save(rd)
        | _ -> printfn "couldn't match type to save"


type DataAccessProviderBoxing (dataProvider: IDataStoreProvider ) =
    let provider : IDataStoreProvider = dataProvider
    member this.SaveWeight(x) =
        match box x with // Box is magic and forces it to be a ref type
        | :? WeightDetails as wd -> provider.Save(wd)
        | :? RunDetails as rd -> provider.Save(rd)
        | _ -> printfn "couldn't match type to save"
