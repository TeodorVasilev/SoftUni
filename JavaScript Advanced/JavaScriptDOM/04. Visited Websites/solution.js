const template = x => `visited ${x} times`;
const linksState = {
  "Google": 2,
  "YouTube": 4,
  "Gmail": 7,
  "Wikipedia": 4,
  "SoftUni": 1,
  "stackoverflow": 6,
}

function solve() {

  document.addEventListener("click", (e) => {
    if(e.target.classList.contains("linkCta")){
      e.target.parentNode.querySelector(".linkOut")
      .innerHTML = template(
        linksState[
          e.target.textContent.trim()
        ]++
      )
    }
  })

}

