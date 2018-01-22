$(document).ready(function () {
    //alert('Cargo');

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
                if (value.intCveTipoEstatus == 10) { Registrado = value.decPcteRegistro.toFixed(2) }
                if (value.intCveTipoEstatus == 20) { Activo = value.decPcteRegistro.toFixed(2) }
                if (value.intCveTipoEstatus == 30) { Inactivo = value.decPcteRegistro.toFixed(2) }
                if (value.intCveTipoEstatus == 40) { Rechazado = value.decPcteRegistro.toFixed(2) }
                if (value.intCveTipoEstatus == 50) { Cancelado = value.decPcteRegistro.toFixed(2) }
                if (value.intCveTipoEstatus == 60) { NoDefinido = value.decPcteRegistro.toFixed(2) }
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

            $("#divNoDefinido").innerWidth(Cancelado.toString() + '%');
            $("#divNoDefinido").text('No definido: ' + Cancelado.toString() + '%');

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

    $('#btnFiltrar').click(function (e) {
        //e.preventDefault();
        
        var dtmInicio = $('#dtpFecInicio').val();
        var dtmFinal = $('#dtpFecFinal').val();
        if (dtmInicio === undefined) {
            alert('F. Inicio: ' + dtmInicio + ' F. Final: ' + dtmFinal);
           // window.location.href = "Abono?dtpFecInicio=" + dtmInicio + "&dtpFecFinal=" + dtmFinal;
        }
        

        //var data = [{ "status": "0", "fIni": dtmInicio, "fFin" : dtmFinal }];

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






});


//$(document).ready(function () {
//    alert('Si entra');
//});

/////////////////////////////////
// https://jsfiddle.net/0c8qaqaj/41/
//

//// HTML 
//<section class="container">

//    <h3>Circliful</h3>

//    <div class="row">
//        <div class="col-lg-4">
//            <div id="test-circle"></div>
//        </div>    </div>
//</section>




//// Javascript
//$(document).ready(function () { // 6,32 5,38 2,34

//});
