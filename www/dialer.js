var Dialer = function () {

};

Dialer.prototype = {
	options = options || {};
	dial: function (options) {
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
