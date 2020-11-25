function openTab(tabname, element, color)
{
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tab-link");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].Style.backgroundColor = "";
    }

    document.getElementById(tabname).Style.display = "block";
    element.Style.backgroundColor = color;
}
document.getElementById("DefultOpen").click();
