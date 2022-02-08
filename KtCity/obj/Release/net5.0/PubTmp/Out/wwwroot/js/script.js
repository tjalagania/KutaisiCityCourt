let structLink = document.getElementById("structLink");
let closeBtn = document.getElementById("closeBtn");
let structPanel = document.getElementById("structPanel");
let pdf = document.getElementById("pdfs");
let pdfLinks = document.getElementById("pdfLinks");
let closeLink = document.getElementById("closeLink");

let pagelnk = document.querySelectorAll(".page-link");
console.log("test");
pagelnk.forEach(el => {
    el.parentElement.classList.remove("active");

    if (el.href == location.href) {
        el.parentElement.classList.add("active");
    }
    
})

pdfLinks.addEventListener("click",e=>{
    e.preventDefault();
  if(structPanel.className.lastIndexOf("views")){
      structPanel.classList.remove("views")
  }
  pdf.classList.toggle("views")
  
})

closeLink.addEventListener("click",e=>{
    e.preventDefault();
    pdf.classList.remove("views")
})
closeBtn.addEventListener("click",e=>{
    e.preventDefault();
    structPanel.classList.remove("views")
})
structLink.addEventListener("click",e=>{
    e.preventDefault();
    
    if(pdf.className.lastIndexOf("views")){
        pdf.classList.remove("views")
    }
    structPanel.classList.toggle("views")
})

