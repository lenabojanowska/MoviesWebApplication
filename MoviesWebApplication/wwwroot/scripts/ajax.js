function startGETRequest(url, onComplete)
{
  var ajax;
    if (window.XMLHttpRequest){
         ajax=new XMLHttpRequest();
     }else if (window.ActiveXObject){
         ajax=newActiveXObject("Microsoft.XMLHTTP");
      }else{
          alert ("nie utworzono obiektu");
      }
	 
    ajax.onreadystatechange=function(){
         if(ajax.readyState==4){
		   var responseText = ajax.responseText; 
		   onComplete(responseText);
		   delete ajax;
          }
    }
   ajax.open("GET",url,true);
   ajax.send(null);
}


function show(){
   var city = document.getElementById('city').value;
   
   if (city==""){
      alert("Wprowadz kryterium!");
	  return;
	}
	url="http://localhost:8081/Ajax_PHP/Skrypty/dane.php?city="+city;
	url=encodeURI(url);
	startGETRequest(url,onComplete);
}

function onComplete(text){
   var data = document.getElementById('data');
   if(text.substr(0, 5) != "error"){;
      data.innerHTML = text;
   }else{
      data.innerHTML = "Gucio z danymi";
   }
}

