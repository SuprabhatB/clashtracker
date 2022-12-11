(function () {
    window.JSInteropService = {
        iconInit: () => {
            feather.replace();
        },
        logger: (l) => {
            console.log(l);
        },
        toggleSidebar: () => {
            // Menu toggle
            if ($("#nav-toggle").length) {
                $("#nav-toggle").on("click", function (e) {
                    e.preventDefault();
                    $("#db-wrapper").toggleClass("toggled");
                });
            }
        },
        setAutoHeight: () => {
            $('.js-fullheight').css('height', $(window).height());
            $(window).resize(function () {
                $('.js-fullheight').css('height', $(window).height());
            });
        },
        setTableEmptyRowWidth: (tableRef) => {
            if (tableRef) {
                const table = document.getElementById(tableRef);
                if (table) {
                    const headerLength = table.rows.item(0).cells.length;
                    table.rows.item(1).cells.item(0).setAttribute('colspan', headerLength);
                }
            }
        }
    }
})(jQuery);
