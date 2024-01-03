var dataTable;

$(document).ready(function () {
    const urlParams = new URLSearchParams(window.location.search);
    const status = urlParams.get('status');

    loadDataTable(status);
});


function loadDataTable(status) {
    dataTable = $('#tblBookings').DataTable({
        "ajax": {
            "url": "/booking/GetAll?status=" + status
        },
        "columns": [
            { data: 'id', width: '5%' },
            { data: 'name', width: '5%' },
            { data: 'phone', width: '5%' },
            { data: 'email', width: '5%' },
            { data: 'status', width: '5%' },
            { data: 'checkIndate', width: '5%' },
            { data: 'nights', width: '5%' },
            { data: 'totalCost', render: $.fn.dataTable.number(',', '.', 2), width: '5%' },
            {
                data: 'id', render: function (data) { 
                return `<div class="w-75 btn-group" >
                        <a href="booking/bookingDetails?bookingId=${data}"
                            class="btn btn-outline-warning mx-2">
                            <i class="bi bi-pencil-square"></i>
                            Details</a></div >`
            }, width: '5%' },
        ]
    })

}