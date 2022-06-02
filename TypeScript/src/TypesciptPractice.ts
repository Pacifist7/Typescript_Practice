interface Mountain{
    name:string;
    height:number;
}

let mountains:Array<Mountain> = [
    {name:"Kilimanjaro", height: 19341},
    {name:"Everest", height:29029},
    {name:"Denali", height:20310}
];

mountains.reduce((a,b) => a + b.height, 0) / mountains.length;

function findNameOfTallestMountain(mountainArray:Array<Mountain>):string{

    let maxHeight:number = 0;
    let maxName:string = "";

    for (let i=0; i<mountainArray.length; i++){
        if(mountainArray[i].height >maxHeight){
            maxHeight = mountainArray[i].height;
            maxName = mountainArray[i].name;
        }
    }

    return maxName;
}

console.log(findNameOfTallestMountain(mountains));


//Products

interface Product{
    name:string;
    price:number;
}

let products:Array<Product> = [
   {name:"Mouse", price:31},  
   {name:"Tshirt", price:60}, 
   {name:"Drill", price:15} 
]

function calcAverageProductPrice(productArray : Array<Product>): number {

    let sum:number = 0;
    let averagePrice:number;

    for(let i=0; i<productArray.length; i++){
        sum += productArray[i].price
    }
    averagePrice = sum/productArray.length

    return averagePrice;
}

console.log(calcAverageProductPrice(products));


//INVENTORY

interface InventoryItem{
    product:Product;
    quantity:number;
}

let inventory:Array<InventoryItem> = [
    {quantity:10, product:products[0]},
    {quantity:4, product:products[1]},
    {quantity:20, product:products[2]}, 
]

function calcInventoryValue(inventoryArray : Array<InventoryItem>) : number {
    let sum:number = 0;

    for(let i=0; i<inventory.length; i++){
        sum += inventoryArray[i].product.price * inventoryArray[i].quantity
    }

    return sum
}

console.log(calcInventoryValue(inventory));

