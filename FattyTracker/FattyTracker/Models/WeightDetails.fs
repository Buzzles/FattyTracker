namespace FattyTracker

open System

type Weight() =
    member val Stones : int = 0 with get, set
    member val Pounds : int = 0 with get, set
    member val Ounces : int = 0 with get, set
    
type WeightDetails() =
    member val Date : DateTime = new DateTime() with get, set
    member val Weight : Weight = new Weight() with get, set