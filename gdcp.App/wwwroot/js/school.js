
var dataTable;
$(document).ready(function () {
    loadDataTable();

});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        ajax: { url: '/school/getall/', dataSrc: 'data' },
        //data: data,
        dataType: 'json',
        contentType: 'application/json; charset=utf-8',
        type: "GET",
        columns: [

            { data: 'schoolName', "width": "20%" },
            { data: 'countryCode', "width": "5%" },
            { data: 'address', "width": "10%" },
            { data: 'latitude', "width": "7%" },
            { data: 'longitude', "width": "7%" },
            { data: 'user.userName', "width": "10%" },
            {
                "data": "Id", "width": "50px", "render": function (data) {

                    return `<div class="text-center">
                                <a onclick="showInPopup('/IncidentCategory/Form?id=${data}','Update Incident Category')" class="btn btn-sm btn-info text-white"><i class="fa fa-pencil"></i> Detail</a>
 <a onclick="showInPopup('/IncidentCategory/Form?id=${data}','Update Incident Category')" class="btn btn-sm btn-info text-white"><i class="fa fa-pencil"></i> Contact Reporter</a>
                                <a onclick="showInPopup('/IncidentCategory/Form?id=${data}','Update Incident Category')" class="btn btn-sm btn-primary text-white"><i class="fa fa-pencil"></i> Edit</a>
                                
                               
                               <a onclick="showInPopup('/IncidentCategory/Form?id=${data}','Update Incident Category')" class="btn btn-sm btn-success text-white"><i class="fa fa-pencil"></i> Approve</a>
                                <a onclick=Delete('/IncidentCategory/Delete?id=${data}') class="text-white btn btn-danger btn-sm text-white" style="cursor:pointer;"><i class="fa fa-trash"></i> Delete</a>
                            `
                }
            },

        ]
    });
}