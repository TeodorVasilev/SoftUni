function solve() {
  let input = document.getElementById("input");
  let output = document.getElementById("output");
  if(input === null || output === null) {
    throw new Error("...");
  }

  let senteces = input.innerHTML.split(".")
  .filter(x => x !== "");

  for (let i = 0; i < senteces.length; i+= 3) {
    let p = document.createElement("p");
    let str = "";
    for (let j = 0; j < 3; j++){
      if(i + j < senteces.length){

        str += senteces[i + j] + ".";
      }
    }
    p.innerHTML = str;
    output.appendChild(p);
  }
}