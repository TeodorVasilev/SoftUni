function createArticle() {
	let article = document.createElement("article");
	let h3 = document.createElement("h3");
	let p = document.createElement("p");

	let input = document.getElementById("createTitle");
	let textarea = document.getElementById("createContent");
	let articles = document.getElementById("articles");

	h3.innerHTML = input.value;
	p.innerHTML = textarea.value;

	article.appendChild(h3);
	article.appendChild(p);

	articles.appendChild(article);
}

document.addEventListener("DOMContentLoaded", x => {
	document.getElementById("createArticleButton").addEventListener("click", createArticle);
	document.addEventListener("keypress", function(evt) {
		console.log(evt);
	})
})

