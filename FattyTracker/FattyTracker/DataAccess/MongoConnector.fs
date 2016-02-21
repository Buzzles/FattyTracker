namespace FattyTracker.DataAccess

type MongoConnector() = 
    interface IDataAccess with
        member this.Save() = printfn "MongoConnection"