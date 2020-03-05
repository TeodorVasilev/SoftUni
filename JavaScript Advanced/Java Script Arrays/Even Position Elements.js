function solve(arr){
    let result = "";

    for (let i = 0; i < arr.length; i++){
        if(i % 2 === 0) {
            result += arr[i] + " ";
        }
    }

    return result.trim();
}

console.log(
    solve(['20', '30', '40'])
)