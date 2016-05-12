(function (undefined) {

    let message = "Hello from AspNet Core Application";

    let clickHandler =  () => alert(message);
  
    $("div").click(clickHandler);

    
}())