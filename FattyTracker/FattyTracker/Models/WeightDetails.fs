namespace FattyTracker

open System

type Weight() =
    member this.Stones : int = 0
    member this.Pounds : int = 0
    member this.Ounces : int = 0
    
type WeightDetails() =
    member this.Date : DateTime = new DateTime()
    member this.Weight : Weight = new Weight()