$(document).ready(function() {

    L.mapbox.accessToken = 'pk.eyJ1Ijoic21hZzIzMCIsImEiOiJjaWd5azJiczEwdmxkd2NtNWhwZWhyNDh0In0.toAU2T3KTEZIEDfvfC9ONA';
    L.mapbox.map('map', 'mapbox.streets')
        .addControl(L.mapbox.geocoderControl('mapbox.places', {
            keepOpen: true,
            autocomplete: true
        }));
});