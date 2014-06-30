var Dialer = function () {

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
