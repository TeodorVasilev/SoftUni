function solve(input) {
    let result = [];
    input.sort(twoCriteraSort);
    input.forEach(el => console.log(el));

    function twoCriteraSort(a, b){
        if(a.length > b.length) {
            return 1;
        } else if (a.length < b.length) {
            return - 1;
        } else {
            return a > b;
        }
    }

    return result.join("\n");
}

console.log(
    solve(    
    ['alpha', 
    'beta', 
    'gamma']
    )
)