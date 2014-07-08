/*var Dialer = function () {

};

Dialer.prototype = {
	dial: function (options) {
		alert('plugin dial called');
		cordova.exec(
                    alert('success'),
                    function (e) {
                        alert("Error occurred: " + e);
                    },
                    'Dialer', 'dial',
                    {"123"});
	},
};

var plugin = new Dialer();

module.exports = plugin;
*/
window.dial = function(str) {
	alert('plugin dial called');
    cordova.exec(function(){
		alert("Success dialing");
	}, function(err) {
        alert("Error dialing" + err);
    }, "Dialer", "dial", str);
};
