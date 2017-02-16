namespace CalculatorInternals

module CreationOperations =
    open CalculatorInternals.ResourceTypes

    let makeBricks (operationTime : Time) (clayIn : Clay) (timeIn : Time) =
        let clayPerOp = 3   // Each factory operation needs 3 clay
        let bricksPerOp = 2     // Each factory operation produces 2 bricks
        let pricePerOp = 10

        // First calculate number of cycles
        let numCycles = rClay clayIn
                        |> amount
                        |> aUnits ((/) clayPerOp)

        // Cough up the total cost
        let totalCost = rClay clayIn
                        |> price
                        |> aCurr ((+) 10)
                        |> (*) numCycles

        let totalBricks = numCycles * bricksPerOp
                        
        let timeSpent = numCycles * (uTime operationTime)
                        |> (+) (uTime timeIn)

        timeSpent, (Bricks {Price = (Currency totalCost) ; Amount = (Units totalBricks) })

        