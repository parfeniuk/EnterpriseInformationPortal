function myMap() {
    var myCenter = new google.maps.LatLng(50.503266, 30.436805);
    var mapProp = { center: myCenter, zoom: 13, scrollwheel: true, draggable: false, mapTypeId: google.maps.MapTypeId.ROADMAP };
    var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
    var marker = new google.maps.Marker({ position: myCenter });
    marker.setMap(map);
}