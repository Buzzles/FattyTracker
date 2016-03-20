module MongoTest

open MongoDB.Driver
open MongoDB.Driver.Core
open MongoDB.Bson

let _client = new MongoClient();
let _database = _client.GetDatabase("test");