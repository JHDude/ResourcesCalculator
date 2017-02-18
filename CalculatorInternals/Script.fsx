// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "ResourceTypes.fs"
#load "ResourceOperations.fs"
#r @"../packages/FSharp.Data/lib/net40/FSharp.Data.dll"
open CalculatorInternals
open FSharp.Data

//"ItemID;Item;ItemEN;Kurs;SMKurs"

// Define your library scripting code here

// Defines a CSV provider, and loads the csv from the website
type R = CsvProvider<"http://www.resources-game.ch/exchange/kurseliste.csv", AssumeMissingValues = true, Separators=";", CacheRows = false, Schema = "int, string, string, int, int, int", HasHeaders = false, SkipRows = 1>
let RData = R.Load("http://www.resources-game.ch/exchange/kurseliste.csv")

// Type for representing a row of the csv
type RContainer = {IDNum : int;
                    Item : string;
                    ItemEN : string;
                    MarketPrice : int;
                    HighestBid : int}
                    
// Creates a list of RContainers from the loaded data
let DataList = [for row in RData.Rows do
                    yield {IDNum = row.Column1;
                            Item = row.Column2;
                            ItemEN = row.Column3;
                            MarketPrice = row.Column4;
                            HighestBid = row.Column5}]
    
// Print out the contents of each row of the list
List.iter (fun x -> printfn "IDNum = %i, Item = %s, Item(english) = %s, Market Price = $%i, Highest Bid = $%i" x.IDNum x.Item x.ItemEN x.MarketPrice x.HighestBid) DataList