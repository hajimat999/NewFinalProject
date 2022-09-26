document.querySelectorAll('.product-img-item').forEach(e => {
    e.addEventListener('click', () => {
        let img = e.querySelector('img').getAttribute('src')
        document.querySelector('#product-img > img').setAttribute('src', img)
    })
})
const allStars=document.querySelectorAll('.star')
allStars.forEach((star,i)=>{
    star.addEventListener('click', function(e){
        e.preventDefault()
        var currentStarLevel = i + 1;
        allStars.forEach((star, j)=>{
            if(currentStarLevel >= j + 1){
                star.innerHTML ='&#9733';
            }
            else{
                star.innerHTML ='&#9734'
            }
        })
    })
})

var minus = document.getElementsByClassName("bx bx-minus")[0]
var plyus = document.getElementsByClassName("bx bx-plus")[0]
var quantity = document.getElementsByClassName("product-quantity")[0]
var count = 1;
minus.addEventListener("click", function(){
    if(count>1){
        count--;
    }
    else{
        count;
    }
    quantity.innerHTML=count;
})
plyus.addEventListener("click", function(){
    count++;
    quantity.innerHTML = count;
})
var a1 = document.getElementsByClassName("a1")[0];
var a2 = document.getElementsByClassName("a1")[1];
var a3 = document.getElementsByClassName("a1")[2];
document.getElementsByClassName("content-section")[0].style.display="block"
a1.style.color="yellow"
a1.addEventListener("click", function(e){
    e.preventDefault();
    if( document.getElementsByClassName("content-section")[0].style.display=="block"){
        document.getElementsByClassName("content-section")[0].style.display="none";
        document.getElementsByClassName("content-section")[1].style.display="none";
        document.getElementsByClassName("content-section")[2].style.display="none";
        a1.style.color="white"
        a2.style.color="white"
        a3.style.color="white"
    }
    else{
        document.getElementsByClassName("content-section")[0].style.display="block";
        document.getElementsByClassName("content-section")[1].style.display="none";
        document.getElementsByClassName("content-section")[2].style.display="none";
        a1.style.color="yellow"
        a2.style.color="white"
        a3.style.color="white"
    }
        
});
a2.addEventListener("click", function(e){
    e.preventDefault();
    if(document.getElementsByClassName("content-section")[1].style.display=="none"){
        document.getElementsByClassName("content-section")[0].style.display="none";
        document.getElementsByClassName("content-section")[1].style.display="block";
        document.getElementsByClassName("content-section")[2].style.display="none";
        a2.style.color="yellow"
        a1.style.color="white"
        a3.style.color="white"
    }
    else{
        document.getElementsByClassName("content-section")[0].style.display="none";
        document.getElementsByClassName("content-section")[1].style.display="none";
        document.getElementsByClassName("content-section")[2].style.display="none";
        a2.style.color="white"
    } 
});
a3.addEventListener("click", function(e){
    e.preventDefault();
    if(document.getElementsByClassName("content-section")[2].style.display=="none"){
        document.getElementsByClassName("content-section")[0].style.display="none";
        document.getElementsByClassName("content-section")[1].style.display="none";
        document.getElementsByClassName("content-section")[2].style.display="block";
        a3.style.color="yellow"
        a2.style.color="white"
        a1.style.color="white"
    }
    else{
        document.getElementsByClassName("content-section")[0].style.display="none";
        document.getElementsByClassName("content-section")[1].style.display="none";
        document.getElementsByClassName("content-section")[2].style.display="none";
        a3.style.color="white"
    }
    
    
});