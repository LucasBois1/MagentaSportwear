function addArticulo() {
    var url = "https://localhost:44392/Registros/AddArticulo";

    var xhr = new XMLHttpRequest();
    xhr.open("POST", url);

    xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            console.log(xhr.status);
            console.log(xhr.responseText);
        }
    };

    var nombre = document.getElementById("NombreInput").value;

    var precioxs = document.getElementById("PrecioXS").value;
    var precios = document.getElementById("PrecioS").value;
    var preciom = document.getElementById("PrecioM").value;
    var preciol = document.getElementById("PrecioL").value;
    var precioxl = document.getElementById("PrecioXL").value;

    var stockxs = document.getElementById("StockXS").value;
    var stocks = document.getElementById("StockS").value;
    var stockm = document.getElementById("StockM").value;
    var stockl = document.getElementById("StockL").value;
    var stockxl = document.getElementById("StockXL").value;

    var data = "nombre=" + nombre + "&precioxs=" + precioxs + "&precios=" + precios + "&preciom=" + preciom + "&preciol=" + preciol + "&precioxl=" + precioxl
        + "&stockxs=" + stockxs + "&stocks=" + stocks + "&stockm=" + stockm + "&stockl=" + stockl + "&stockxl=" + stockxl;

    xhr.send(data);

    document.getElementById("nombre").value = "";

    document.getElementById("PrecioXS").value = "";
    document.getElementById("PrecioS").value = "";
    document.getElementById("PrecioM").value = "";
    document.getElementById("PrecioL").value = "";
    document.getElementById("PrecioXL").value = "";

    document.getElementById("StockXS").value = "";
    document.getElementById("StockS").value = "";
    document.getElementById("StockM").value = "";
    document.getElementById("StockL").value = "";
    document.getElementById("StockXL").value = "";

    document.getElementById("CloseButton").click();

    if (xhr.status === 200) {
        var toastElList = [].slice.call(document.querySelectorAll('.toast'))
        var toastList = toastElList.map(function (toastEl) {
            return new bootstrap.Toast(toastEl)
        });
        toastList.forEach(toast => toast.show());
    }

}

function openModalDelete(id) {

    

}

function DeleteArt(id) {

    var url = "https://localhost:44392/Registros/DeleteArticulo";

    var xhr = new XMLHttpRequest();
    xhr.open("POST", url);

    xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            //console.log(xhr.status);
            //console.log(xhr.responseText);
        }
    };

    var data = "id=" + id;

    xhr.send(data);

}

function addArtRow(id, nombre, precioxs, precios, preciom, preciol, precioxl, stockxs, stocks, stockm, stockl, stockxl) {

    var actions = '<div><button class="btn btn-sm" onclick="openModalDelete('+id+')"><img src="https://img.icons8.com/small/16/000000/trash--v1.png" /></button><button class="btn btn-sm"> <img src="https://img.icons8.com/small/16/000000/edit.png" /></button><div class="btn-group" role="group"><button id="btnGroupDrop1" type="button" class="btn btn-sm dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false"><img src="https://img.icons8.com/small/16/000000/more.png" /></button><ul class="dropdown-menu"><li><a class="dropdown-item" href="#"><img src="https://img.icons8.com/small/16/000000/zoom-in.png" /> Ver Imagen </a></li></ul></div></div >';

    var tableBody = document.getElementById('ArtTableBody');
    var newRow = tableBody.insertRow(tableBody.rows.length);
    var ArtId = newRow.insertCell(0);
    var ArtName = newRow.insertCell(1);
    var ArtPriceXS = newRow.insertCell(2);
    var ArtStockXS = newRow.insertCell(3);
    var ArtPriceS = newRow.insertCell(4);
    var ArtStockS = newRow.insertCell(5);
    var ArtPriceM = newRow.insertCell(6);
    var ArtStockM = newRow.insertCell(7);
    var ArtPriceL = newRow.insertCell(8);
    var ArtStockL = newRow.insertCell(9);
    var ArtPriceXL = newRow.insertCell(10);
    var ArtStockXL = newRow.insertCell(11);
    var ArtActions = newRow.insertCell(12);

    ArtActions.innerHTML = actions;

    ArtId.appendChild(document.createTextNode(id));
    ArtName.appendChild(document.createTextNode(nombre));
    ArtPriceXS.appendChild(document.createTextNode("$" + precioxs));
    ArtStockXS.appendChild(document.createTextNode(stockxs));
    ArtPriceS.appendChild(document.createTextNode("$" + precios));
    ArtStockS.appendChild(document.createTextNode(stocks));
    ArtPriceM.appendChild(document.createTextNode("$" + preciom));
    ArtStockM.appendChild(document.createTextNode(stockm));
    ArtPriceL.appendChild(document.createTextNode("$" + preciol));
    ArtStockL.appendChild(document.createTextNode(stockl));
    ArtPriceXL.appendChild(document.createTextNode("$" + precioxl));
    ArtStockXL.appendChild(document.createTextNode(stockxl));

}

function myFunction(items) {
    var item = Object.values(items);

    var id = item[0];
    var nombre = item[1];

    var precioxs = item[7];
    var precios = item[8];
    var preciom = item[9];
    var preciol = item[10];
    var precioxl = item[11];

    var stockxs = item[2];
    var stocks = item[3];
    var stockm = item[4];
    var stockl = item[5];
    var stockxl = item[6];

    addArtRow(id, nombre, precioxs, precios, preciom, preciol, precioxl, stockxs, stocks, stockm, stockl, stockxl);
}

function fillArtTable() {
    var url = "https://localhost:44392/Registros/GetArticulos";

    var xhr = new XMLHttpRequest();
    xhr.open("POST", url);

    xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");

    xhr.responseType = "json";

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            var items = xhr.response;
            console.log(items)
            items.forEach(myFunction);
        }
    };

    xhr.send();

}

function fillCatTable() {
    var url = "https://localhost:44392/Registros/GetCategorias";

    var xhr = new XMLHttpRequest();
    xhr.open("POST", url);

    xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            console.log(xhr.status);
            console.log(xhr.responseText);
        }
    };
}

window.onload = function () {
    fillArtTable();
    //fillCatTable();
};