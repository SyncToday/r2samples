module SyncToday2015R2.Samples.Tests

open SyncToday2015R2.Samples
open NUnit.Framework

[<Test>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)
