window.dial = function(number, name) {
	cordova.exec(function(){
		console.log("Success dialing");
	}, function(err) {
        console.log("Error: " + err);
    }, "Dialer", "dial", [number, name]);
};
