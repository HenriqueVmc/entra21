function apagarElemento(id) {
    if (document.contains(document.getElementById(id))) {
        document.getElementById(id).remove();
    }
}

function validarFrm() {

    if (!validarNome() && !validarCodM() && !validarFrequencia()) {
        event.preventDefault();
    }
}

function validarNome() {

    var nome = document.getElementById("nome").value;

    document.getElementById("nome").classList.remove("border-success");

    apagarElemento("span-nome-menor-5");
    apagarElemento("span-nome-maior-100");

    if (nome.length < 5) {

        var spanNome = document.createElement("span");
        var texto = document.createTextNode("Nome deve possuir mais de 5 caracteres");

        spanNome.id = "span-nome-menor-5";
        spanNome.appendChild(texto);
        spanNome.classList.add("text-danger");

        document.getElementById("div-nome").appendChild(spanNome);
        document.getElementById("nome").classList("border-danger");

        return false;
    }

    if (nome.length > 100) {
        var spanNome = document.createElement("span");
        var texto = document.createTextNode("Nome deve possuir no máximo 100 caracteres");

        spanNome.id = "span-nome-maior-100";
        spanNome.classList.add("text-danger");

        document.getElementById("div-nome").appendChild(spanNome);
        document.getElementById("nome").classList.add("border-danger");

        return false;
    }

    if (nome.length >= 7 && nome.length <= 100) {
        document.getElementById("nome").classList.remove("border-danger");
        document.getElementById("nome").classList.add("border-success");

        return true;
    }
}

function validarCodM() {
    var codM = document.getElementById("codM").value;

    document.getElementById("codM").classList.remove("border-success");

    apagarElemento("span-codM");

    if (codM.length == 10) {
        document.getElementById("codM").classList.remove("border-danger");
        document.getElementById("codM").classList.add("border-success");

        return true;

    } else {

        var spanCodM = document.createElement("span");
        var texto = document.createTextNode("Matricula de conter 10 caracteres");

        spanCodM.id = "span-codM";
        spanCodM.appendChild(texto);
        spanCodM.classList.add("text-danger");

        document.getElementById("div-codM").appendChild(spanCodM);
        document.getElementById("codM").classList("border-danger");

        return false;
    }
}

function validarFrequencia() {
    var frequencia = document.getElementById("frequencia").value;

    document.getElementById("frequencia").classList.remove("border-success");

    apagarElemento("span-frequencia");

    if (frequencia > 0 && frequencia <= 100) {
        document.getElementById("frequencia").classList.remove("border-danger");
        document.getElementById("frequencia").classList.add("border-success");

        return true;

    } else {

        var spanFrequencia = document.createElement("span");
        var texto = document.createTextNode("Frequencia deve estar entre 1% ~ 100%");

        spanFrequencia .id = "span-frequencia";
        spanFrequencia.appendChild(texto);
        spanFrequencia.classList.add("text-danger");

        document.getElementById("div-frequencia").appendChild(spanFrequencia);
        document.getElementById("frequencia").classList("border-danger");

        return false;
    }
}

/*
function validarNota1() {
    var nota1 = document.getElementById("nota1").value;

    document.getElementById("nota1").classList.remove("border-success");

    apagarElemento("span-notas");

    if (nota1 >= 0 && nota1 <= 10) {
        document.getElementById("nota1").classList.remove("border-danger");
        document.getElementById("nota1").classList.add("border-success");

        return true;

    } else {

        var spanNotas = document.createElement("span");
        var texto = document.createTextNode("Nota deve estar entre 0 ~ 10");

        spanNotas.id = "span-notas";
        spanNotas.appendChild(texto);
        spanNotas.classList.add("text-danger");

        document.getElementById("div-notas").appendChild(spanNotas);
        document.getElementById("nota1").classList.remove("border-danger");

        return false;
    }
}

function validarNota2() {
    var nota2 = document.getElementById("nota2").value;

    document.getElementById("nota2").classList.remove("border-success");

    apagarElemento("span-notas");

    if (nota2 >= 0 && nota2 <= 10) {
        document.getElementById("nota2").classList.remove("border-danger");
        document.getElementById("nota2").classList.add("border-success");

        return true;

    } else {

        var spanNotas = document.createElement("span");
        var texto = document.createTextNode("Nota deve estar entre 0 ~ 10");

        spanNotas.id = "span-notas";
        spanNotas.appendChild(texto);
        spanNotas.classList.add("text-danger");

        document.getElementById("div-notas").appendChild(spanNotas);
        document.getElementById("nota2").classList.remove("border-danger");

        return false;
    }
}

function validarNota3() {
    var nota3 = document.getElementById("nota3").value;

    document.getElementById("nota3").classList.remove("border-success");

    apagarElemento("span-notas");

    if (nota3 >= 0 && nota3 <= 10) {

        document.getElementById("nota3").classList.remove("border-danger");
        document.getElementById("nota3").classList.add("border-success");

        return true;

    } else {

        var spanNotas = document.createElement("span");
        var texto = document.createTextNode("Nota deve estar entre 0 ~ 10");

        spanNotas.id = "span-notas";
        spanNotas.appendChild(texto);
        spanNotas.classList.add("text-danger");

        document.getElementById("div-notas").appendChild(spanNotas);
        document.getElementById("nota3").classList.remove("border-danger");

        return false;
    }
}*/