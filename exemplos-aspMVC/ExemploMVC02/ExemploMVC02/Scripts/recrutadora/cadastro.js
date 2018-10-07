
function apagarElemento(id) {
    if (document.contains(document.getElementById(id))) {
        document.getElementById(id).remove();
    }
}

function validarFrm() {
    var cpf = document.getElementById("cpf").value;
    var tempoEmpresa = document.getElementById("tempoEmpresa").value;
    var salario = document.getElementById("salario").value;

    if(!validarNome()){
        event.preventDefault();
    }
}

function validarNome(){

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


/*

console.log("Texto: " + nome);
console.log("Caracteres:" + qtdCararteresNome);//Apresenta no console
var qtdCararteresCpf = cpf.length;

if (qtdCararteresCpf < 14) {
    alert("CPF deve possuir 14 caracteres");
}

var salario = parseFloat(salario);

if (salario < 1200) {
    alert("Salário deve ser maior que R$1.200,00");
} else if (salario > 100000) {
    alert("Salário deve ser menor que R$100.000,00");
}

function validarCPF(cpf) {
    cpf = cpf.replace(/[^\d]+/g, '');
    if (cpf == '') return false;
    // Elimina CPFs invalidos conhecidos	
    if (cpf.length != 11 ||
		cpf == "00000000000" ||
		cpf == "11111111111" ||
		cpf == "22222222222" ||
		cpf == "33333333333" ||
		cpf == "44444444444" ||
		cpf == "55555555555" ||
		cpf == "66666666666" ||
		cpf == "77777777777" ||
		cpf == "88888888888" ||
		cpf == "99999999999")
        return false;
    // Valida 1o digito	
    add = 0;
    for (i = 0; i < 9; i++)
        add += parseInt(cpf.charAt(i)) * (10 - i);
    rev = 11 - (add % 11);
    if (rev == 10 || rev == 11)
        rev = 0;
    if (rev != parseInt(cpf.charAt(9)))
        return false;
    // Valida 2o digito	
    add = 0;
    for (i = 0; i < 10; i++)
        add += parseInt(cpf.charAt(i)) * (11 - i);
    rev = 11 - (add % 11);
    if (rev == 10 || rev == 11)
        rev = 0;
    if (rev != parseInt(cpf.charAt(10)))
        return false;
    return true;
}

*/