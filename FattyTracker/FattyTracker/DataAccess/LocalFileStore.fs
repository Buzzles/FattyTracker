﻿namespace FattyTracker.DataAccess

type LocalFilestore() =
    interface IDataAccess with
        member this.Save() = printfn "localsave fo'sure"