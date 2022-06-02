"use strict";
let mountains = [
    { name: "Kilimanjaro", height: 19341 },
    { name: "Everest", height: 29029 },
    { name: "Denali", height: 20310 }
];
mountains.reduce((a, b) => a + b.height, 0) / mountains.length;
function findNameOfTallestMountain(mountainArray) {
    let maxHeight = 0;
    let maxName = "";
    for (let i = 0; i < mountainArray.length; i++) {
        if (mountainArray[i].height > maxHeight) {
            maxHeight = mountainArray[i].height;
            maxName = mountainArray[i].name;
        }
    }
    return maxName;
}
console.log(findNameOfTallestMountain(mountains));
let products = [
    { name: "Mouse", price: 31 },
    { name: "Tshirt", price: 60 },
    { name: "Drill", price: 15 }
];
function calcAverageProductPrice(productArray) {
    let sum = 0;
    let averagePrice;
    for (let i = 0; i < productArray.length; i++) {
        sum += productArray[i].price;
    }
    averagePrice = sum / productArray.length;
    return averagePrice;
}
console.log(calcAverageProductPrice(products));
let inventory = [
    { quantity: 10, product: products[0] },
    { quantity: 4, product: products[1] },
    { quantity: 20, product: products[2] },
];
function calcInventoryValue(inventoryArray) {
    let sum = 0;
    for (let i = 0; i < inventory.length; i++) {
        sum += inventoryArray[i].product.price * inventoryArray[i].quantity;
    }
    return sum;
}
console.log(calcInventoryValue(inventory));
