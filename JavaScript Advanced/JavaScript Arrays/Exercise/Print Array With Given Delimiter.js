function solve(arr){
    let lastItem = arr.pop();
    return arr.join(lastItem, arr);
}

console.log(
    solve(
    ['One', 
    'Two', 
    'Three', 
    'Four', 
    'Five', 
    '-']
    )
)