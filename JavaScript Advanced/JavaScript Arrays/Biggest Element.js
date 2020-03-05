function solve(arr){
    return Math.max(...arr.flat(1))
}

console.log(
    solve([
        [3, 5, 7, 12],
        [-1, 4, 33, 2],
        [8, 3, 0, 4]
    ])
)