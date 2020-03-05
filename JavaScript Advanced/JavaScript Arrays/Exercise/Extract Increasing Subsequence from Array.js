function solve(lines) {
    lines=lines.map(Number);
    let result=[];
    let biggest = lines[0];
    for (let i = 0; i < lines.length; i++) {
        if(lines[i]>=biggest){
            result.push(lines[i]);
            biggest=lines[i];
        }
    }
    return result.join('\n');
}

console.log(
    solve(
        [1, 
        3, 
        8, 
        4, 
        10, 
        12, 
        3, 
        2, 
        24]
        )
)