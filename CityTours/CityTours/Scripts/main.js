$(document).ready(function () {

    /* =========================================================
     Initialize
    =========================================================== */
    var g = {};
    var resultNum = [];

    /* ==========================================================================
       Paginate Map items 
    ========================================================================= */

    var getQueryVariable = function (variable) {
        var query = window.location.search.substring(1);
        var t = query.match(/\w+\W./i);
        var newx = new String(t);
        //alert(newx);
        var vars = newx.split("&");
        for (var i = 0; i < vars.length; i++) {
            var pair = vars[i].split("=");

            var a = pair[0];
            var b = variable;

            var c = a.match(/\w+/i);
            var cc = c.ignoreCase;

            var d = b.match(/\w+/i);
            var dd = d.ignoreCase;

            if (cc == dd) { return pair[1]; }
        }
        // alert(pair[0] + "  " +  variable);
        return (false);
    }

    g.paginationNum = getQueryVariable("sho");


    /* =========================================================
      Map
    =========================================================== */
    //alert(g.paginationNum);

    function initialize() {

        //Call JSON 
        $.getJSON("/Tours/myResults/", function (results) {

            //reference t as the JSON list
            var t = results;

            //loop through JSON items
            $.each(t, function (index, location) {
                //console.log(t[index].shownum + " , " + location.first + location.last);

                //   if (t[index].shownum == g.paginationNum) {

                // var resultNumValue = resultNum[index];
                var latLng = new google.maps.LatLng(t[index].Latitude, t[index].Longitude);

                console.log(t[index].Marker);

                //set the marker if there is a match
                marker = new google.maps.Marker({
                    position: latLng,
                    map: map,
                    title: t[index].TourName,
                    icon: t[index].Marker,
                });

                var message = '<div class="showFacility">' + marker.title + '</div>';
                var infowindow = new google.maps.InfoWindow({
                    content: message
                });

                //click event for the map marker for address
                //google.maps.event.addListener(marker, 'click', function (event) {
                //    infowindow.open(marker.get('map'), marker); //                  
                //});

                google.maps.event.addListener(marker, 'click', (function (marker, infowindow) {
                    return function () {
                        infowindow.open(map, marker);
                    };
                })(marker, infowindow));

                //if (marker.custominfo == g.paginationNum) {
                //alert(location.first + marker.custominfo);
                marker.setMap(map);
                // }
                // }
            });

        });



        var mapProp = {
            //center: new google.maps.LatLng(40.478165, -88.954401),
            center: new google.maps.LatLng(48.857914, 2.352222),
            zoom: 16,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };

        var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
    }

    google.maps.event.addDomListener(window, 'load', initialize);



    $('.header-wrapper header nav  li  + a ').wrapAll('<li/>');



});