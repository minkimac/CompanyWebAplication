function loadXMLDoc()
{
    //alert("entered loadXMLDoc");
    var xmlhttp = new XMLHttpRequest();
    xmlhttp.onreadystatechange = function () {
            myFunction(this);
    };

    //alert("executed myFunction");
    xmlhttp.open("GET", "Assets\XML\countries.xml", true);
    //alert("opened xml file");
    xmlhttp.send();
}

function myFunction(xml)
{
    //alert("vsv");
    var x, i, xmlDoc, drop;
    xmlDoc = xml.responseXML;
    txt = "";
    x = xmlDoc.getElementsByTagName("countries");
    //alert("node value :"+x[0].nodeValue);
    for (i = 0; i < x.length; i++) {
        txt += x[i].childNodes[0].nodeValue + "<br>";
    }
    //alert(txt);
}

function getCountryList()
{
    
}