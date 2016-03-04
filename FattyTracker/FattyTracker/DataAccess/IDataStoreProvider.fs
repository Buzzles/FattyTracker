namespace FattyTracker.DataAccess

open FattyTracker

    type IDataStoreProvider =
        abstract member Save : unit -> unit
        abstract member Save : WeightDetails -> unit
        abstract member Save : RunDetails -> unit
        // Add a generic save method for implementers to consume