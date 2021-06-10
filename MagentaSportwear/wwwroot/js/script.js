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
    var precio = document.getElementById("PrecioInput").value;

    var data = "nombre="+nombre+"&precio=" + precio;

    xhr.send(data);

    document.getElementById("NombreInput").value = "";
    document.getElementById("PrecioInput").value = "";

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

function addArtRow(id, nombre, precio) {

    var actions = '<div><button class="btn btn-sm" onclick="openModalDelete('+id+')"><img src="https://img.icons8.com/small/16/000000/trash--v1.png" /></button><button class="btn btn-sm"> <img src="https://img.icons8.com/small/16/000000/edit.png" /></button><div class="btn-group" role="group"><button id="btnGroupDrop1" type="button" class="btn btn-sm dropdown-toggle" data-bs-toggle="dropdown" aria-expanded="false"><img src="https://img.icons8.com/small/16/000000/more.png" /></button><ul class="dropdown-menu"><li><a class="dropdown-item" href="#"><img src="https://img.icons8.com/small/16/000000/zoom-in.png" /> Ver Imagen </a></li></ul></div></div >';

    var tableBody = document.getElementById('ArtTableBody');
    var newRow = tableBody.insertRow(tableBody.rows.length);
    var ArtId = newRow.insertCell(0);
    var ArtName = newRow.insertCell(1);
    var ArtPrice = newRow.insertCell(2);
    var ArtActions = newRow.insertCell(3);

    var Id = document.createTextNode(id);
    var Name = document.createTextNode(nombre);
    var Price = document.createTextNode("$" + precio);
    ArtActions.innerHTML = actions;

    ArtId.appendChild(Id);
    ArtName.appendChild(Name);
    ArtPrice.appendChild(Price);
}

function myFunction(items) {
    var item = Object.values(items);

    var id = item[0];
    var nombre = item[1];
    var precio = item[2];

    addArtRow(id, nombre, precio);
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