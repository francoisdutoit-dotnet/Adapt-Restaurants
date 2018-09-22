$(document).ready(function () {
    $('#btnUseCurrentLocation').prop('disabled', true).addClass("disabledButton");
});

function GetMap() {

    var map = new Microsoft.Maps.Map('#restaurantMap', {
        credentials: 'AidJ7KoD8MUgXdPr4bs8em809h6TIP4o1TnfOgCo35BgBgEuSRXQUbVaHYt2X1HV'
    });

    navigator.geolocation.getCurrentPosition(function (position) {

        Microsoft.Maps.loadModule('Microsoft.Maps.Search', function () {
            var searchManager = new Microsoft.Maps.Search.SearchManager(map);

            var reverseGeocodeRequestOptions = {
                location: new Microsoft.Maps.Location(position.coords.latitude, position.coords.longitude),
                callback: function (answer, userData) {
                    map.setView({ bounds: answer.bestView });
                    map.entities.push(new Microsoft.Maps.Pushpin(reverseGeocodeRequestOptions.location));
                    $("input[name=currentPostalCode]").val(answer.address.postalCode);
                    $(':input[type="submit"]').prop('disabled', false).removeClass("disabledButton");
                }
            };
            searchManager.reverseGeocode(reverseGeocodeRequestOptions);
        })
    });
}




