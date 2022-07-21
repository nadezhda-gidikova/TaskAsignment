
let element='ul#bottomMenu';
const arr=[];
function ExtractElements(ev){
    ev.preventDefault();
   
    const divElement=document.createElement('div');
    let element=document.querySelector('.tagElement');
    let elValue=element.value;
   
    let arrEl=findChilds(elValue);
    
    let arrElLower=arrEl.map(x=>x.tagName.toLowerCase());
   divElement.textContent=arrElLower.join(",");
   document.body.prepend(divElement);
    
}

function findChilds(element){
    
    let first=document.querySelector(element);
    console.log(first.tagName);

    arr.push(element);
    let elems=Array.from(first.querySelectorAll("*"));
    
        return elems;
   }
function modifyDom(){
    const button=document.createElement('button');
    const inputField=document.createElement('input');
    inputField.className='tagElement';
   
    inputField.setAttribute('type', 'text');
    inputField.setAttribute('name', 'tag');
    
    button.textContent="Search";
    button.type="button";
    button.addEventListener('click',ExtractElements);
    document.body.prepend(button);
    document.body.prepend(inputField);
}
window.onload = function() {
    modifyDom();
}