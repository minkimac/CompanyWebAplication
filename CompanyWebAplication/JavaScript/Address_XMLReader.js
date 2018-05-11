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
            parseCities_LocalitiesXML(this);
            var i;
            for (i = 0; i < citiesNode.length; i++)
            {
                citiesOption = "<option>" + citiesNode[i].childNodes[0].nodeValue + "</option>";
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
function parseCities_LocalitiesXML(xml)
{
    citiesXMLDoc = xml.responseXML;
    ddlCities = document.getElementById("ddlCities");
    citiesNode = citiesXMLDoc.getElementsByTagName("City");
}

//load Localities
function getStreet_LocalityList()
{
    if (street_LocalityLoaded == false)
    {
        var xmlhttp = new XMLHttpRequest();
        xmlhttp.onreadystatechange = function ()
        {
            alert("ready state changed");
            parseCities_LocalitiesXML(this);
            var i;
            var prevCityNode = "NULL";
            for (i = 0; i < citiesNode.length; i++)
            {
                if (citiesNode[i].childNodes[0].nodeValue != prevCityNode)
                {
                    citiesOption = "<option>" + citiesNode[i].childNodes[0].nodeValue + "</option>";
                    ddlCities.innerHTML += citiesOption;
                }
                prevCityNode = citiesNode[i].childNodes[0].nodeValue;
            }
            citiesLoaded = true;
        };

        //alert("executed myFunction");
        xmlhttp.open("GET", "assets/globalxmls/Cities_Localities.xml", true);
        //alert("opened xml file" );
        xmlhttp.send();
    }
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
    var ddlCountry = document.getElementById("ddlCountry");
    countryNode = countryXMLDoc.getElementsByTagName("country");
}
