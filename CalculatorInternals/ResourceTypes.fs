namespace CalculatorInternals

module Currency =
    type Currency = 
        | Currency of int
    
    let uCurr (Currency c) = c // Unwrapper
    let aCurr f (Currency c) = Currency(f c) // Applicator
    let addCurr (Currency a) (Currency b) = Currency(a + b)

module Units =
    type Units = 
        | Units of int
    
    let uUnits (Units u) = u // Unwrapper
    let aUnits f (Units u) = Units(f u) // Applicator
    let addUnits (Units a) (Units b) = Units(a + b)

module Time =
    type Time = 
        | Time of int
    
    let uTime (Time t) = t // Unwrapper
    let aTime f (Time t) = Time(f t) // Applicator
    let addTime (Time a) (Time b) = Time(a + b)

module ResourceTypes = 
    open Currency
    open Time
    open Units

    type TotalCost = 
        { MoneyCost : Currency
          TimeCost : Time }
    
    type Resource = 
        { Price : Currency
          Amount : Units }
    
    let amount r = r.Amount
    let price r = r.Price
    
    type Bauxite = 
        | Bauxite of Resource
    
    let rBauxite (Bauxite b) = b // Unwrapper
    
    type Chalcopyrite = 
        | Chalcopyrite of Resource
    
    let rChalc (Chalcopyrite c) = c // Unwrapper
    
    type Clay = 
        | Clay of Resource
    
    let rClay (Clay cl) = cl // Unwrapper
    let aClay f (Clay cl) = f cl // Applicator
    
    type Coal = 
        | Coal of Resource
    
    let rCoal (Coal c) = c // Unwrapper
    
    type CrudeOil = 
        | CrudeOil of Resource
    
    let rOil (CrudeOil oil) = oil // Unwrapper
    
    type GoldOre = 
        | GoldOre of Resource
    
    let rGOre (GoldOre g) = g // Unwrapper
    
    type Gravel = 
        | Gravel of Resource
    
    let rGravel (Gravel g) = g //Unwrapper
    
    type Ilmenite = 
        | Ilmenite of Resource
    
    let rIlmenite (Ilmenite ilmn) = ilmn // Unwrapper
    
    type IronOre = 
        | IronOre of Resource
    
    type Limestone = 
        | Limestone of Resource
    
    let rLimestone (Limestone lime) = lime // Unwrapper
    
    type LithiumOre = 
        | LithiumOre of Resource
    
    type QuartzSand = 
        | QuartzSand of Resource
    
    type RoughDiamonds = 
        | RoughDiamonds of Resource
    
    type SilverOre = 
        | SilverOre of Resource
    
    type Aluminum = 
        | Aluminum of Resource
    
    type Batteries = 
        | Batteries of Resource
    
    type Bricks = 
        | Bricks of Resource
    
    type Concrete = 
        | Concrete of Resource
    
    type Copper = 
        | Copper of Resource
    
    type Electronics = 
        | Electronics of Resource
    
    type Fertilizer = 
        | Fertilizer of Resource
    
    type FossilFuel = 
        | FossilFuel of Resource
    
    type Glass = 
        | Glass of Resource
    
    type Gold = 
        | Gold of Resource
    
    type Insecticides = 
        | Insecticides of Resource
    
    type Jewellery = 
        | Jewellery of Resource
    
    type Lithium = 
        | Lithium of Resource
    
    type MedicalTechnology = 
        | MedicalTechnology of Resource
    
    type Plastics = 
        | Plastics of Resource
    
    type ScanDrones = 
        | ScanDrones of Resource
    
    type Silicon = 
        | Silicon of Resource
    
    type Silver = 
        | Silver of Resource
    
    type Steel = 
        | Steel of Resource
    
    type Titanium = 
        | Titanium of Resource
    
    type Trucks = 
        | Trucks of Resource
    
    type Weapons = 
        | Weapons of Resource
