module MongoTest

open MongoDB.Driver
open MongoDB.Driver.Core
open MongoDB.Bson


let mongoSettings = 
    let connt = new MongoClientSettings()
    connt.Server <- new MongoServerAddress("contString")
    connt

let _client = new MongoClient(mongoSettings);
let _database = _client.GetDatabase("test");