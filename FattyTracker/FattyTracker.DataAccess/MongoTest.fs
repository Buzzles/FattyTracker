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

let testCall = 
    let coll = _database.GetCollection<string>("teststrings")
    let col2 = _database.GetCollection<BsonDocument>("wobble")
    let fu = Builders<BsonDocument>.Filter
    let ee = fu.Eq("test", "val")
    let filter = new BsonDocument()
    let cursor = coll.Find(fu)
    let res = cursor.ToBsonDocument()
    res.