var dataTable;

$(document).ready(function () {
    loadDataTable();
    var id = document.getElementById("pacienteId");
    if (id.value > 0) {
        $('#myModal').modal('show');
    }
});

function limpar() {
    var pacienteId = document.getElementById("pacienteId");
    var pacienteNomeClinica = document.getElementById("pacienteNomeClinica");
    var pacienteNomePaciente = document.getElementById("pacienteNomePaciente");
    var pacienteSobrenomePaciente = document.getElementById("pacienteSobrenomePaciente");
    var pacientDescricao = document.getElementById("pacientDescricao");
    var pacienteDataRecebido = document.getElementById("pacienteDataRecebido");
    var PacienteDataEntregue = document.getElementById("PacienteDataEntregue");
    var pacienteEstado = document.getElementById("pacienteEstado");

    pacienteId.value = 0;
    pacienteNomeClinica.value = "";
    pacienteNomePaciente.value = "";
    pacienteSobrenomePaciente.value = "";
    pacientDescricao.value = "";
    pacienteDataRecebido.value = true;
    PacienteDataEntregue.value = true;
    pacienteEstado.value = true;
}

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Paciente/ObterTodos"
        },
        "columns": [
            { "data": "nomeClinica", "width": "10%" },
            { "data": "nomePaciente", "width": "10%" },
            { "data": "sobrenomePaciente", "width": "10%" },
            { "data": "descricao", "width": "10%" },
            { "data": "dataRecebido", "width": "20%" },
            { "data": "dataEntregue", "width": "20%" },
            {
                "data": "estado",
                "render": function (data) {
                    if (data == true) {
                        return "Ativo";
                    }
                    else {
                        return "Inativo";
                    }
                }, "width": "10%",
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div>
                            <a href="/Paciente/Create/${data}" class="btn btn-success text-white" style="cursor:pointer;">
                             Edit
                            </a>
                        </div>
                            `;
                }, "width": "10%"
            }
        ]
    });
}