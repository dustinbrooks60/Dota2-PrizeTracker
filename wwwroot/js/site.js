// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.


$(document).ready(function() {
    $("input#autocomplete").autocomplete({
        source: [
             { value: "The International 2019", url: "/Index" }, 
             { value: "The International 2018", url: "/ti8" },
             { value: "The International 2017", url: '/ti7' },
             { value: "The International 2016", url: '/ti6' },
             { value: "The International 2015", url: '/ti5' },
             { value: "The International 2014", url: '/ti4' }

        ],
        select: function (event, ui) {
            window.location = ui.item.url;
        }
    });
});


