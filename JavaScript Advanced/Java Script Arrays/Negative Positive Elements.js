function main(arr){
    const actionsMap = {
       true: "unshift",
       false: "push"
    }

    function solve(arr){
        let result = [];
        for (let i = 0; i < arr.length; i++){
            result[actionsMap[arr[i] < 0]](arr[i]);
        }
        return result;
    }
    
    return solve(arr);
}
console.log(
    main([3, -2, 0, -1])
)