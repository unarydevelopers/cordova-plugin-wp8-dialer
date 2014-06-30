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
                    [options]);
	},
};

var plugin = new Dialer();

module.exports = plugin;
