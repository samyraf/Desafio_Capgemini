function inserir() {
    $.ajax({
        url: '/Anuncio/insert',
        method: 'POST',
        data: {
            id: 0,
            investimentoPorDia: $('#investimentoPorDia').val(),
            nomeAnuncio: $('#nomeAnuncio').val(),
            cliente: $('#cliente').val(),
            dataInicio: $('#dataInicio').val(),
            dataTermino: $('#dataTermino').val()
        },
        success: () => {
            console.log('teste')
        },
        error: (xmlhr) => {
            console.log(xmlhr.responseText);
        }
    });
}