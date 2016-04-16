module MongoTest

open MongoDB.Driver
open MongoDB.Driver.Core
open MongoDB.Bson

// 192.168.99.100:32768 - Docker Port 27017/tcp
let dockerIp = "192.168.99.100"
let dockerPort = 32768

let mongoSettings = 
    let clientSettings = new MongoClientSettings()
    clientSettings.Server <- new MongoServerAddress(dockerIp, dockerPort)
    clientSettings

let _client = new MongoClient(mongoSettings);

let _database = _client.GetDatabase("test");