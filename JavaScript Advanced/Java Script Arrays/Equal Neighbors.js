function main(arr){

    function intersect(a,b) {
        return a.filter((element, index) => b[index] === element).length;
    }

    function solve(arr) {
        let result = 0;

        for(let i = 0; i < arr.length - 1; i++) {
            result += intersect(arr[i], arr[i + 1])
        }   

        return result;
    }

    return solve(arr);
}

console.log(
    solve(
        [
            ['test', 'yes', 'yo', 'ho'],
            ['well', 'done', 'yo', '6'],
            ['not', 'done', 'yet', '5']
        ]
    )
)