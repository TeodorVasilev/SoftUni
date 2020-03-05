function solve(matrix) {
    let rowSum = matrix.map(r => r.reduce((a,b) => a + b));
    let colSum = matrix.reduce((a, b) => a.map((x, i) => x + b[i]));

    let firstSum = rowSum[0];

    for (let i = 0; i < rowSum.length; i++) {
        if(rowSum[i] !== firstSum || colSum[i] !== firstSum) {
            return "false";
        }
    }

    return "true";
}

console.log(
    solve([
        [1, 0, 0],
        [0, 0, 0],
        [0, 0, 0]
    ])
)