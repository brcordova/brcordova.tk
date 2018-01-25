﻿$(document).ready(function () {



    $.ajax({
        type: 'GET',
        url: '/Abono/ObtenerEstadisticas',
        contentType: "application/json; charset=utf-8",
        dataType: 'JSON',
        success: function (data) {
            var Registrado; // 10
            var Activo;     // 20
            var Inactivo;   // 30
            var Rechazado;  // 40
            var Cancelado;  // 50
            var NoDefinido; // 60

            $.each(data, function (index, value) {
                if (value.intCveTipoEstatus == 10) { Registrado = value.decPcteRegistro.toFixed(2); }
                if (value.intCveTipoEstatus == 20) { Activo = value.decPcteRegistro.toFixed(2); }
                if (value.intCveTipoEstatus == 30) { Inactivo = value.decPcteRegistro.toFixed(2); }
                if (value.intCveTipoEstatus == 40) { Rechazado = value.decPcteRegistro.toFixed(2); }
                if (value.intCveTipoEstatus == 50) { Cancelado = value.decPcteRegistro.toFixed(2); }
                if (value.intCveTipoEstatus == 60) { NoDefinido = value.decPcteRegistro.toFixed(2); }
            });
            //$("#divActivo").width(Activo);
            $("#divRegistrado").innerWidth(Registrado.toString() + '%');
            $("#divRegistrado").text('Registrado ' + Registrado.toString() + '%');

            $("#divActivo").innerWidth(Activo.toString() + '%');
            $("#divActivo").text('Activo ' + Activo.toString() + '%');

            $("#divInactivo").innerWidth(Inactivo.toString() + '%');
            $("#divInactivo").text('Inactivo' + Inactivo.toString() + '%');

            $("#divRechazado").innerWidth(Rechazado.toString() + '%');
            $("#divRechazado").text('Rechazado: ' + Rechazado.toString() + '%');

            $("#divCancelado").innerWidth(Cancelado.toString() + '%');
            $("#divCancelado").text('Cancelado: ' + Cancelado.toString() + '%');

            $("#divNoDefinido").innerWidth(NoDefinido.toString() + '%');
            $("#divNoDefinido").text('ND: ' + NoDefinido.toString() + '%');

            //$("#test-circle").circliful({
            //    animation: 1,
            //    animationStep: 5,
            //    foregroundBorderWidth: 7,
            //    backgroundBorderWidth: 7,
            //    percent: 99,
            //    textSize: 28,
            //    textStyle: 'font-size: 12px;',
            //    textColor: '#666',
            //    multiPercentage: 1,
            //    percentages: [
            //        { 'percent': Activo, 'color': '#00ff00', 'title': 'Activos' },
            //        { 'percent': Inactivo, 'color': '#3366ff', 'title': 'Inactivos' },
            //        { 'percent': Rechazado, 'color': '#ff0000', 'title': 'Rechazados' },
            //        { 'percent': Cancelado, 'color': '#737373', 'title': 'Cancelados' }
            //    ],
            //    multiPercentageLegend: 1,
            //    replacePercentageByText: '',
            //    backgroundColor: '#eee',
            //    icon: 'f080',
            //    iconPosition: 'middle',
            //    iconColor: '#273B4E',

            //});



        },
        failure: function (response) {
            alert(response.responseText);
        },
        error: function (ex) {
            alert('Error');
            var r = jQuery.parseJSON(ex.responseText);
            alert("Message: " + r.Message);
            alert("StackTrace: " + r.StackTrace);
            alert("ExceptionType: " + r.ExceptionType);

        }
    });

    function addCommas(nStr) {
        nStr += '';
        x = nStr.split('.');
        x1 = x[0];
        x2 = x.length > 1 ? '.' + x[1] : '';
        var rgx = /(\d+)(\d{3})/;
        while (rgx.test(x1)) {
            x1 = x1.replace(rgx, '$1' + ',' + '$2');
        }
        return x1 + x2;
    }

    function formatDate(date) {
        var year = date.getFullYear();

        var month = (1 + date.getMonth()).toString();
        month = month.length > 1 ? month : '0' + month;

        var day = date.getDate().toString();
        day = day.length > 1 ? day : '0' + day;

        return day + '/' + month + '/' + year;
    }

    $('#btnFiltrar').click(function (e) {
        //e.preventDefault();

        var dtmInicio = $('#dtpFecInicio').val();
        var dtmFinal = $('#dtpFecFinal').val();

        if ($.isEmptyObject(dtmInicio) && $.isEmptyObject(dtmFinal)) {
            alert('No paso');
        }
        else {

            var urlDestino = "Abono?dtpFecInicio=" + dtmInicio + "&dtpFecFinal=" + dtmFinal;
            alert(urlDestino);
            window.location.href = urlDestino;
        }
    });

    $('#divRegistrado').click(function (e) {
        window.location.href = "Abono?status=10";
        $('#h3Filtro').text("Abonos registrados");
    });

    $('#divActivo').click(function (e) {
        window.location.href = "Abono?status=20";
        $('#h3Filtro').text("Abonos activos");
    });

    $('#divInactivo').click(function (e) {
        window.location.href = "Abono?status=30";
        $('#h3Filtro').text("Abonos inactivos");
    });

    $('#divRechazado').click(function (e) {
        window.location.href = "Abono?status=40";
        $('#h3Filtro').text("Abonos rechazados");
    });

    $('#divCancelado').click(function (e) {
        window.location.href = "Abono?status=50";
        $('#h3Filtro').text("Abonos cancelados");
    });

    //var grid = $("#list").anexGrid(data);

    $("#datepicker").datepicker({
        showWeek: true,
        firstDay: 1
    });

    var dateFormat = "dd/mm/yy";
    from = $("#dtpFecInicio")
      .datepicker({
          showWeek: true,
          firstDay: 1,
          defaultDate: "+1w",
          changeMonth: true,
          numberOfMonths: 2
      })
      .on("change", function () {
          to.datepicker("option", "minDate", getDate(this));
      }),
    to = $("#dtpFecFinal").datepicker({
        showWeek: true,
        firstDay: 1,
        defaultDate: "+1w",
        changeMonth: true,
        numberOfMonths: 2
    })
    .on("change", function () {
        from.datepicker("option", "maxDate", getDate(this));
    });

    function getDate(element) {
        var date;
        try {
            date = $.datepicker.parseDate(dateFormat, element.value);
        } catch (error) {
            date = null;
        }

        return date;
    }


    $.datepicker.regional['es'] = {
        closeText: 'Cerrar',
        prevText: '< Ant',
        nextText: 'Sig >',
        currentText: 'Hoy',
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
        dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
        dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
        weekHeader: 'Sm',
        dateFormat: 'dd/mm/yy',
        firstDay: 1,
        isRTL: false,
        showMonthAfterYear: false,
        yearSuffix: ''
    };

    $.datepicker.setDefaults($.datepicker.regional['es']);

    //'@Url.Action("Details", "Abono",new { id = '+ obj.Id +' })'
    $("#list").anexGrid({
        class: 'table-striped table-bordered table-condensed',
        columnas: [
            { leyenda: 'Consultar', style: { width: '40px' }, class: 'text-center' },
            { leyenda: 'Cliente', class: '', ordenable: true, filtro: true, columna: 'Cuenta_Abono_nombreOrdenante' },
            { leyenda: 'Cuenta', class: '', columna: 'Cuenta_Abono_cuentaOrdenante' },
            { leyenda: 'F. Ope.', class: '', ordenable: true, columna: 'Cuenta_Abono_fechaOperacion' },
            { leyenda: 'Monto', class: '', columna: 'Cuenta_Abono_monto' },
            { leyenda: 'F.  Registro', class: '', ordenable: true, columna: 'Cuenta_Abono_fechaRegistro' },
            { leyenda: 'Concepto', class: '', columna: 'Cuenta_Abono_conceptoPago' },
        ],
        modelo: [
            //{ formato: function(tr, obj, celda){
            //    var fila_id = tr.data('fila');
            //    return '<button value="' + obj.Id + '" type="button" class="btn btn-primary btn-editar">Editar</button>';
            //}
            //},
            {
                formato: function (tr, obj, celda) {
                    return anexGrid_link({
                        contenido: '<a class="btn btn-primary glyphicon glyphicon-eye-open" href="Abono/Details/'+ obj.Id +'"> </a>',
                        href: '' ,
                        target: '_self'
                    });
                }
            },
            { propiedad: 'Cuenta_Abono_nombreOrdenante' },
            { propiedad: 'Cuenta_Abono_cuentaOrdenante' },
            { formato: function (tr, obj, valor) { return fecConvCompleta(obj.Cuenta_Abono_fechaOperacion.toString(),0) } },
            { formato: function(tr,obj,valor) { return addCommas(obj.Cuenta_Abono_monto.toFixed(2))} },
            { formato: function (tr, obj, valor) { return fecConvCompleta(obj.Cuenta_Abono_fechaRegistro.toString(),1) } },
            { propiedad: 'Cuenta_Abono_conceptoPago' },
        ],
        url: '/Abono/Listar',
        limite: [10, 25, 50, 75],
        paginable: true,
        filtrable: true,
        columna: 'Id',
        columna_orden: 'DESC'
    });

    //anexGrid.tabla().on('click', '.btn-editar', function () {
    //    var obj = anexGrid.obtener($(this).val());
    //    alert('Se hizo hizo click al empleado ' + obj.Id );
    //})


    function fecConvCompleta(fecha , completa )
    {
        var res;
        var fecLimpia = new Date(parseInt(fecha.toString().substring(6, 19)))

        var anio = fecLimpia.getFullYear();

        var mes = (1 + fecLimpia.getMonth()).toString();
        mes = mes.length > 1 ? mes : '0' + mes;

        var dia = fecLimpia.getDate().toString();
        dia = dia.length > 1 ? dia : '0' + dia;

        var hora = fecLimpia.getHours().toString();
        hora = hora.length > 1 ? hora : '0' + hora;

        var minuto = fecLimpia.getMinutes().toString();
        minuto = minuto.length > 1 ? minuto : '0' + minuto;

        if (completa == 1)
        { res = dia + '/' + mes + '/' + anio + ' ' + hora + ':' + minuto; }

        if (completa == 0)
        { res = dia + '/' + mes + '/' + anio ; }

        return res;

    };

});