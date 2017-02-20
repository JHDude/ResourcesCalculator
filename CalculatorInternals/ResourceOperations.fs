namespace CalculatorInternals

module CreationOperations =


    //let Factory opTime 

    let makeBricks operationTime clayIn (timeIn: Time) =
        let clayPerOp = 3   // Each factory operation needs 3 clay
        let bricksPerOp = 2     // Each factory operation produces 2 bricks
        let pricePerOp = Currency(10)

        // First calculate number of cycles
        let numCycles = clayIn
                        |> (amount >> uUnits)
                        |> (/) clayPerOp

        // Cough up the total cost
        let totalCost = clayIn
                        |> price
                        |> addCurr pricePerOp
                        |> aCurr ((*) numCycles)

        let totalBricks = numCycles * bricksPerOp
                        
        let timeSpent = operationTime 
                        |> aTime ((*) numCycles)
                        |> addTime timeIn

        timeSpent, Bricks {Price = totalCost ; Amount = (Units totalBricks) }

    let makeConcrete operationTime gravelIn limeIn timeIn =
        let gravelPerOp = 3 // Each factory operation needs 3 gravel
        let limePerOp = 2   // Each factory operation needs 2 limestone
        let concretePerOp = 14  // Each factory operation creates 14 concrete
        let pricePerOp = 20

        // First calculate the number of cycles
        let numCycles = 
            // Maximum number of cycles we can have based on the gravel input
            let maxGravelCycles =
                gravelIn
                |> (amount >> uUnits)
                |> ((/) gravelPerOp)

            // Maximum number of cycles we can have based on the limestone input
            let maxLimeCycles =
                limeIn
                |> (amount >> uUnits)
                |> ((/) limePerOp) 

            min maxGravelCycles maxLimeCycles

        // The total amount of money that this would cost 
        let totalCost =
            let gravelCost = 
                gravelIn
                |> price
                |> aCurr ((*) numCycles)

            let limeCost =
                limeIn
                |> price
                |> aCurr ((*) numCycles)

            gravelCost
            |> addCurr limeCost
            |> addCurr (Currency(numCycles * pricePerOp))

        let totalCrete = numCycles * concretePerOp

        let timeSpent = operationTime
                        |> aTime ((*) numCycles)
                        |> addTime timeIn

        timeSpent, Concrete {Price = totalCost ; Amount = (Units totalCrete)}