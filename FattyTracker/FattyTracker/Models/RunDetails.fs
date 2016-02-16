namespace FattyTracker

open System

type RunDetails() =
    member this.Distance : double = 0.0 
    member this.Time : DateTime = new DateTime()