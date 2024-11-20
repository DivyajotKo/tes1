// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from DJ"

// Define the list of salaries
let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

// Tax calculation based on salary
let calculateTax salary =
    match salary with
    | s when s <= 49020.0 -> s * 0.15
    | s when s <= 98040.0 -> s * 0.205
    | s when s <= 151978.0 -> s * 0.26
    | s when s <= 216511.0 -> s * 0.29
    | s -> s * 0.33  // Default case for salaries above $216,511

// 1. Filter high-income salaries (> $100,000)
let highIncomeSalaries = salaries |> List.filter (fun s -> s > 100000.0)

// 2. Calculate taxes for all salaries
let taxes = salaries |> List.map calculateTax

// 3. Filter and update salaries less than $49,020 by adding $20,000
let updatedSalaries = salaries |> List.filter (fun s -> s < 49020.0) |> List.map (fun s -> s + 20000.0)

// 4. Sum salaries between $50,000 and $100,000 using fold
let sumMidRangeSalaries = salaries |> List.filter (fun s -> s >= 50000.0 && s <= 100000.0) |> List.fold (+) 0.0

// Print the results
printfn "High-Income Salaries: %A" highIncomeSalaries
printfn "Taxes for All Salaries: %A" taxes
printfn "Updated Salaries (less than $49,020, +$20,000): %A" updatedSalaries
printfn "Sum of Salaries between $50,000 and $100,000: %f" sumMidRangeSalaries



// Tail-recursive function to sum multiples of 3 up to a given number
let sumMultiplesOf3 n =
    // Helper function to perform the tail-recursive summation
    let rec sumHelper current total =
        if current > n then
            total  // Base case: return the total sum when current exceeds n
        else
            sumHelper (current + 3) (total + current)  // Recursively add multiples of 3

    sumHelper 3 0  // Start from 3 with an initial total of 0

// Example usage
let result = sumMultiplesOf3 27
printfn "Sum of multiples of 3 up to 27: %d" result

