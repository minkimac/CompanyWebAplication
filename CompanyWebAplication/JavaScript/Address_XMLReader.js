var countriesLoaded = false;
function getCountryList()
{
    if (countriesLoaded == false)
    {
        var xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = function () {
            parseCountryXML(this);
            countriesLoaded = true;
        };
       
        //alert("executed myFunction");
        xmlhttp.open("GET", "assets/globalxmls/countries.xml", true);
        //alert("opened xml file" );
        xmlhttp.send();
    }
}

function parseCountryXML(xml)
{
    var i;
    var xmlDoc = xml.responseXML;
    var country;
    var ddlCountry = document.getElementById("ddlCountry");
    var x = xmlDoc.getElementsByTagName("country");
    for (i = 0; i < x.length; i++) {
        country = "<option>" + x[i].childNodes[0].nodeValue + "</option>";
        ddlCountry.innerHTML += country;
    }
}
