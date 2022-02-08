let editbtns = document.querySelectorAll(".fa-edit");
let editForm = document.querySelector(".edit_form");
let editInput = document.getElementById("editInput");
let posid = document.getElementById("posid");
let editCloseBtn = document.getElementById("edit_close_btn")
let deleteFormCloseBtn = document.getElementById("delete_form_btn");


let deleteForm = document.querySelector(".delete_form");
let tresh = document.querySelectorAll(".fa-trash-alt");
let posDelId = document.getElementById("posdelid");
let postName = document.getElementById("posName");
let deleteClose = document.getElementById("delete_form_btn");
let no = document.getElementById("no");
editbtns.forEach(btn=>{
    btn.addEventListener("click", e=>{
        editForm.classList.add("visibiliti")
        let el = e.target.parentNode.parentNode
        posid.value = e.target.dataset.id
        editInput.value = el.textContent.trim();
        
    })
})
tresh.forEach(btn=>{
    btn.addEventListener("click",e=>{
        deleteForm.classList.add("visibiliti");
        let el = e.target.parentNode.parentNode;
        posDelId.value = e.target.dataset.id;
        postName.textContent = el.textContent.trim();
        console.log(deleteForm)
    })
})
editCloseBtn.addEventListener("click",e=>{
    if(editForm.classList.contains("visibiliti")){
        editForm.classList.remove("visibiliti")
    }
});

deleteClose.addEventListener("click",e=>{
    if(deleteForm.classList.contains("visibiliti")){
        deleteForm.classList.remove("visibiliti")
    }
})
no.addEventListener("click",e=>{
    e.preventDefault();
    if(deleteForm.classList.contains("visibiliti")){
        deleteForm.classList.remove("visibiliti")
    }
})