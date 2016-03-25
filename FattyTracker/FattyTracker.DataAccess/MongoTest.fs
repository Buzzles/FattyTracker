module MongoTest

open MongoDB.Driver
open MongoDB.Driver.Core
open MongoDB.Bson

let dockerIp = "192.168.99.100"
let dockerPort = 32768

let _client = new MongoClient();

let settings = 
    let x = new MongoServerAddress(dockerIp, dockerPort) 
            |> _client.Settings.Server
    _client.Settings.Server

let _database = _client.GetDatabase("test");