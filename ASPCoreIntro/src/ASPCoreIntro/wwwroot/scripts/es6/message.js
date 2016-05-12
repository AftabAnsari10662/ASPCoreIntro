(function (undefined) {

    let message = "Hello from AspNet Core Application";

    let clickHandler = () => {

        let newMessage = `${message} developed by Aftab`;
        alert(message);
    };
  
    $("div").click(clickHandler);

    
}())