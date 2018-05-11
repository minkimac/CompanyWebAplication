var countriesLoaded = false;
var street_LocalityLoaded = false;
var citiesLoaded = false;

function loadRegistrationModalData()
{
    getCitiesList();
    getCountryList();
}

//load cities
var citiesNode;
var citiesOption;
var ddlCities;
function getCitiesList()
{
    if (citiesLoaded == false)
    {
        var xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = function ()
        {
            //alert("ready state changed");
            parseCitiesXML(this);
            var i;
            ddlCities = document.getElementById("ddlCities");
            for (i = 0; i < citiesNode.length; i++)
            {
                citiesOption = "<option value=\"" + citiesNode[i].getAttribute("CityId") + "\">" + citiesNode[i].childNodes[0].nodeValue + "</option>";
                ddlCities.innerHTML += citiesOption;
            }
            citiesLoaded = true;
        };

        //alert("executed myFunction");
        xmlhttp.open("GET", "assets/globalxmls/Cities.xml", true);
        //alert("opened xml file" );
        xmlhttp.send();
    }
}

var citiesXMLDoc;
function parseCitiesXML(xml)
{
    citiesXMLDoc = xml.responseXML;
    citiesNode = citiesXMLDoc.getElementsByTagName("City");
}

//load Localities
var street_LocalityNode;
var street_LocalityOption;
var ddlStreet_Locality;
var xmlhttpStreet_Locality;
function getStreet_LocalityList(cityId)
{
    street_LocalityLoaded = false;
    if (street_LocalityLoaded == false)
    {
        if (xmlhttpStreet_Locality == null)
            xmlhttpStreet_Locality = new XMLHttpRequest();

        xmlhttpStreet_Locality.onreadystatechange = function ()
        {
            //alert("ready state changed");
            parseCities_LocalityXML(this, cityId);
            var i;
            ddlStreet_Locality = document.getElementById("ddlStreet_Locality");
            for (i = 0; i < street_LocalityNode.length; i++)
            {
                if (cityId == street_LocalityNode[i].getElementsByTagName("CityId")[0].childNodes[0].nodeValue)
                {
                    street_LocalityOption = "<option>" + street_LocalityNode[i].getElementsByTagName("LocalityName")[0].childNodes[0].nodeValue + "</option>";
                    ddlStreet_Locality.innerHTML += street_LocalityOption;
                }
            }
            street_LocalityLoaded = true;
        };

        //alert("executed myFunction");
        xmlhttpStreet_Locality.open("GET", "assets/globalxmls/Cities_Localities.xml", true);
        //alert("opened xml file" );
        xmlhttpStreet_Locality.send();
    }
}

var street_LocalitiesXMLDoc;
function parseCities_LocalityXML(xml,cityId)
{
    street_LocalitiesXMLDoc = xml.responseXML;
    street_LocalityNode = street_LocalitiesXMLDoc.getElementsByTagName("Locality");
    //alert(cityIdNode[3].childNodes[0].parentNode.nodeValue);
}

//load country list
var countryNode;
var countriesOption;
function getCountryList()
{
    if (countriesLoaded == false)
    {
        var xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = function ()
        {
            parseCountryXML(this);
            var i;
            var ddlCountry = document.getElementById("ddlCountry");
            for (i = 0; i < countryNode.length; i++)
            {
                countriesOption = "<option>" + countryNode[i].childNodes[0].nodeValue + "</option>";
                ddlCountry.innerHTML += countriesOption;
            }
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
    var countryXMLDoc = xml.responseXML;
    countryNode = countryXMLDoc.getElementsByTagName("country");
}
