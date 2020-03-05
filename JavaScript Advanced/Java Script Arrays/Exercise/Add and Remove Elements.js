function solve(arr){
    let number = 1;
    let result = [];
        for (let i = 0; i < arr.length; i++){
            if(arr[i] == "add") {
                result.push(number);
            } else if(arr[i] == "remove"){
                result.pop();
            }

            number++;
        }
        if(result.length == 0)
        return "Empty";
        else
        return result.join("\n");
}

console.log(
    solve(
    ['add', 
    'add', 
    'add', 
    'add']
    )
)