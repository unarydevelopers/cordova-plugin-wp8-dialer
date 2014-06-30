var Dialer = function () {

};

Dialer.prototype = {
	dial: function (options) {
		cordova.exec(
                    alert('success'),
                    function (e) {
                        alert("Error occurred: " + e);
                    },
                    "Dialer", "dial",
                    [options]);
	},
};

var plugin = new Dialer();

module.exports = plugin;
