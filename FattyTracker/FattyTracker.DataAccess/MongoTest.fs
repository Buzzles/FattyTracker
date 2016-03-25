﻿module MongoTest

open MongoDB.Driver
open MongoDB.Driver.Core
open MongoDB.Bson

let dockerIp = "192.168.99.100"
let dockerPort = 32768

let mongoSettings = 
    let connt = new MongoClientSettings()
    connt.Server <- new MongoServerAddress("contString")
    connt

let _client = new MongoClient(mongoSettings);

let settings = 
    let x = new MongoServerAddress(dockerIp, dockerPort) 
            |> _client.Settings.Server
    _client.Settings.Server

let _database = _client.GetDatabase("test");