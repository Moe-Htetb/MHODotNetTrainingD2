

using MHODotNetTrainingD4;

BeforeSystem:
InventoryService inventoryService = new InventoryService();
//inventoryService.CreateProduct();

Console.WriteLine("Enter 1 to add a product, 2 to view products, 3 to update Products,4 to delete Products, or 0 to exit:");
Console.Write("Input:");
string input = Console.ReadLine()!;
switch (input)
{
    case "1":
        inventoryService.CreateProduct();
        break;

    case "2":
        inventoryService.ViewProduct();
        break;
    case "3":
        inventoryService.UpdateProduct();
        break;
    case "4":
        inventoryService.DeleteProduct();
        break;
    case "0":
        Console.WriteLine("Exiting the program.");
        goto Exit;

    default: goto Exit;
}

goto BeforeSystem;

Exit:
Console.ReadKey();


