(function($) {
    "use strict"; // Start of use strict

    $.fn.activateLinks = function(options, cb) {
        var settings = $.extend({
                // class to add to the selector
                "class": "active",
                // how many segments to remove from url in order to find active link in menu
                traverse: 0
            },
            options);
        var segments = window.location.href.split("?")[0] // no query string
            .replace(window.location.protocol + '//' + window.location.host, '').split("/");
        var level = segments.length;
        var minLevel = settings.traverse <= 0 ? level : level >= settings.traverse ? level - settings.traverse : level;

        while (level >= minLevel) {
            var currentUrl = segments.join('/');
            var items = $(this).find('a[href$="' + currentUrl + '"],a[href^="' + currentUrl + '?"]');

            if (items.length > 0) {
                items.addClass(settings["class"]);

                if (cb) {
                    cb(items);
                }

                return this;
            }

            level -= 1;
            segments = segments.slice(0, level);
        }

        return this;
    };

})(jQuery); // End of use strict