function solve(input) {
    let rotations = Number(input[input.length - 1]);
    input.pop();
    for (let i = 0; i < rotations % input.length; i++) {
        input.unshift(input.pop());
    }
    return input.join(' ');
}

console.log(
    solve(
    ['1', 
    '2', 
    '3', 
    '4', 
    '2']
    )
)