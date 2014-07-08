window.dial = function(number, name) {
	cordova.exec(function(){
		console.log("Success dialling");
	}, function(err) {
        console.log("Error: " + err);
    }, "Dialer", "dial", [number]);
};
