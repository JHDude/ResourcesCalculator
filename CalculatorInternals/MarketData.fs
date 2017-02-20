namespace CalculatorInternals

module MarketData =
    open Option
    open FSharp.Data
    type R = CsvProvider<"http://www.resources-game.ch/exchange/kurseliste.csv", AssumeMissingValues = true, Separators=";", CacheRows = false, Schema = "int, string, string, int, int, int", HasHeaders = false, SkipRows = 1>
    
    // Type for representing a row of the csv
    type RContainer = {IDNum : int;
                        Item : string;
                        ItemEN : string;
                        MarketPrice : int;
                        HighestBid : int}

    type MarketData = MarketData of List<RContainer>
    
    type Timestamp = Timestamp of System.DateTime

    type MarketDataAndTimestamp = MDAT of (Timestamp * MarketData) option
    
    let getCurrDateTime = Timestamp System.DateTime.UtcNow

    let queryMarket =
        let rData = R.Load("http://www.resources-game.ch/exchange/kurseliste.csv")
                            
        // Creates a list of RContainers from the loaded data
        let dataList = [for row in rData.Rows do
                            yield {IDNum = row.Column1;
                                    Item = row.Column2;
                                    ItemEN = row.Column3;
                                    MarketPrice = row.Column4;
                                    HighestBid = row.Column5}]
                        |> MarketData
                                                        
        (getCurrDateTime, dataList)
        |> Some
        |> MDAT
        
