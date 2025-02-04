// Function expressions.

type Product =
    { Id: uint64
      Name: string
      Count: uint8
      Price: decimal
      Discount: float }

let createProduct id name count (price: decimal) discount =
    { Id = uint64 id
      Name = name
      Count = uint8 count
      Price = price
      Discount = discount }

let products =
    [ createProduct 1 "Fanta Naranja" 1 32m 0
      createProduct 2 "Zambo picante" 1 56m 0.05
      createProduct 3 "Pollo Asado" 1 156.67m 0
      createProduct 4 "Dos Pinos Nieve Alaska Fresa" 1 90m 0.10 ]

// Get products that have a discount percentage > 0
let productsWithDiscount = products |> List.filter (fun p -> p.Discount > 0)

let calculateDiscount p = p.Price * (decimal p.Discount)

let calculateProductTotal p =
    let discount = calculateDiscount (p)
    let total = (decimal p.Count) * (p.Price - discount)
    total

let totalPrice =
    products |> List.fold (fun acc p -> acc + calculateProductTotal (p)) 0m
