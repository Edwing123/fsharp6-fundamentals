(*

Composing functions to create new functions.

Right composition operator `>>`

to achieve g(f(x)) use f >> g

Left composition operator `<<`

to achieve f(g(x)) use f << g

*)

module Cart =

    type Product =
        { Id: string
          Name: string
          Price: decimal
          Quantity: int
          Discount: decimal }


    let private calculateTotal product =
        (decimal product.Quantity) * product.Price

    let private applyDiscount porcentage price = price - (price * porcentage)

    let calculateProductTotal product =
        product |> calculateTotal |> (applyDiscount product.Discount)


    let createProduct name price quantity discount =
        { Id = System.Guid.NewGuid().ToString()
          Name = name
          Price = price
          Quantity = quantity
          Discount = discount }

    let createProductOutput product =
        $"
    Id: {product.Id}
    Name: {product.Name}
    Unit price: {product.Price}
    Quantity: {product.Quantity}
    Discount: {product.Discount}
    "

let products =
    [ Cart.createProduct "Fanta" 32m 1 0.05m
      Cart.createProduct "Zambo chile" 65m 1 0m ]

let productsWithPrices =
    products |> List.map (fun p -> (p, Cart.calculateProductTotal (p)))

productsWithPrices
|> List.iter (fun (p, totalPrice) ->
    System.Console.WriteLine(Cart.createProductOutput p)
    System.Console.WriteLine $"Total: {totalPrice}")

let cartTotal =
    productsWithPrices
    |> List.map (fun (_, total) -> total)
    |> List.fold (fun acc total -> acc + total) 0m

System.Console.WriteLine $"Cart total: {cartTotal}"
