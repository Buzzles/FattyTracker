namespace FattyTracker

open System

type RunDetails() =
    member val Distance : double = 0.0 with get, set
    member val Time : DateTime = new DateTime() with get, set