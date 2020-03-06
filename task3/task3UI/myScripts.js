$(document).ready(function(){
    $('#load_data').click(function(){
     $.ajax({
      url:"employeeTable.csv",
      dataType:"text",
        success:function(data)
        {
            var employee_Table = data.split(/\r?\n|\r/);
            var table_data = '<table class="table table-bordered table-striped">';
            for(var i = 0; i<employee_Table.length; i++)
            {
                    var cell_data = employee_Table[i].split(",");
                    table_data += '<tr>';
                    for(var cell_count=0; cell_count<cell_data.length; cell_count++)
                    {
                        if(i === 0)
                        {
                            table_data += '<th>'+cell_data[cell_count]+'</th>';
                        }
                        else
                        {
                            table_data += '<td>'+cell_data[cell_count]+'</td>';
                        }
                    }
                    if(i == 0)
					{
						table_data += '<th>'+'<p>Edit</p>'+ '</th>';
						table_data += '<th>'+'<p>Delete</p>'+ '</th>';
					}
                    if(i >= 1 &&  i < employee_Table.length-1  )
					{
						table_data += '<td>'+'<button type="button" onclick="editCurrentRow(event)"  class="btn btn-primary">Edit</button>'+ '</td>';
						table_data += '<td>'+'<button type="button" id="delete" onclick="deleteData(event)" class="btn btn-primary" align="center">Delete</button>'+ '</td>';
					}
                    table_data += '</tr>';
                }
                table_data += '</table>';
                $('#employee_table').html(table_data);
            }
        });
    });
    
});

// Deleting a row from a table.
function deleteData(event){

    var par = event.target.parentNode.parentElement; 
    par.remove();
}

function editCurrentRow(event){
    
}

$(document).ready(function(){
    $('#Comp1').click(function(){
     $.ajax({
      url:"Company_Data1.csv",
      dataType:"text",
        success:function(data)
        {
            var employee_Table = data.split(/\r?\n|\r/);
            var table_data = '<table class="table table-bordered table-striped">';
            for(var i = 0; i<employee_Table.length; i++)
            {
                    var cell_data = employee_Table[i].split(",");
                    table_data += '<tr>';
                    for(var cell_count=0; cell_count<cell_data.length; cell_count++)
                    {
                        if(i === 0)
                        {
                            table_data += '<th>'+cell_data[cell_count]+'</th>';
                        }
                        else
                        {
                            table_data += '<td>'+cell_data[cell_count]+'</td>';
                        }
                    }
                    if(i == 0)
					{
						table_data += '<th>'+'<p>Edit</p>'+ '</th>';
						table_data += '<th>'+'<p>Delete</p>'+ '</th>';
					}
                    if(i >= 1 &&  i < employee_Table.length-1  )
					{
						table_data += '<td>'+'<button type="button" onclick="editCurrentRow(event)"  class="btn btn-primary">Edit</button>'+ '</td>';
						table_data += '<td>'+'<button type="button" id="delete" onclick="deleteData(event)" class="btn btn-primary" align="center">Delete</button>'+ '</td>';
					}
                    table_data += '</tr>';
                }
                table_data += '</table>';
                $('#employee_table').html(table_data);
            }
        });
    });
    
});

$(document).ready(function(){
    $('#Comp2').click(function(){
     $.ajax({
      url:"Company_Data2.csv",
      dataType:"text",
        success:function(data)
        {
            var employee_Table = data.split(/\r?\n|\r/);
            var table_data = '<table class="table table-bordered table-striped">';
            for(var i = 0; i<employee_Table.length; i++)
            {
                    var cell_data = employee_Table[i].split(",");
                    table_data += '<tr>';
                    for(var cell_count=0; cell_count<cell_data.length; cell_count++)
                    {
                        if(i === 0)
                        {
                            table_data += '<th>'+cell_data[cell_count]+'</th>';
                        }
                        else
                        {
                            table_data += '<td>'+cell_data[cell_count]+'</td>';
                        }
                    }
                    if(i == 0)
					{
						table_data += '<th>'+'<p>Edit</p>'+ '</th>';
						table_data += '<th>'+'<p>Delete</p>'+ '</th>';
					}
                    if(i >= 1 &&  i < employee_Table.length-1  )
					{
						table_data += '<td>'+'<button type="button" onclick="editCurrentRow(event)"  class="btn btn-primary">Edit</button>'+ '</td>';
						table_data += '<td>'+'<button type="button" id="delete" onclick="deleteData(event)" class="btn btn-primary" align="center">Delete</button>'+ '</td>';
					}
                    table_data += '</tr>';
                }
                table_data += '</table>';
                $('#employee_table').html(table_data);
            }
        });
    });
    
});

$(document).ready(function(){
    $('#Comp3').click(function(){
     $.ajax({
      url:"Company_Data3.csv",
      dataType:"text",
        success:function(data)
        {
            var employee_Table = data.split(/\r?\n|\r/);
            var table_data = '<table class="table table-bordered table-striped">';
            for(var i = 0; i<employee_Table.length; i++)
            {
                    var cell_data = employee_Table[i].split(",");
                    table_data += '<tr>';
                    for(var cell_count=0; cell_count<cell_data.length; cell_count++)
                    {
                        if(i === 0)
                        {
                            table_data += '<th>'+cell_data[cell_count]+'</th>';
                        }
                        else
                        {
                            table_data += '<td>'+cell_data[cell_count]+'</td>';
                        }
                    }
                    if(i == 0)
					{
						table_data += '<th>'+'<p>Edit</p>'+ '</th>';
						table_data += '<th>'+'<p>Delete</p>'+ '</th>';
					}
                    if(i >= 1 &&  i < employee_Table.length-1  )
					{
						table_data += '<td>'+'<button type="button" onclick="editCurrentRow(event)"  class="btn btn-primary">Edit</button>'+ '</td>';
						table_data += '<td>'+'<button type="button" id="delete" onclick="deleteData(event)" class="btn btn-primary" align="center">Delete</button>'+ '</td>';
					}
                    table_data += '</tr>';
                }
                table_data += '</table>';
                $('#employee_table').html(table_data);
            }
        });
    });
    
});

$(document).ready(function(){
    $('#Comp4').click(function(){
     $.ajax({
      url:"Company_Data4.csv",
      dataType:"text",
        success:function(data)
        {
            var employee_Table = data.split(/\r?\n|\r/);
            var table_data = '<table class="table table-bordered table-striped">';
            for(var i = 0; i<employee_Table.length; i++)
            {
                    var cell_data = employee_Table[i].split(",");
                    table_data += '<tr>';
                    for(var cell_count=0; cell_count<cell_data.length; cell_count++)
                    {
                        if(i === 0)
                        {
                            table_data += '<th>'+cell_data[cell_count]+'</th>';
                        }
                        else
                        {
                            table_data += '<td>'+cell_data[cell_count]+'</td>';
                        }
                    }
                    if(i == 0)
					{
						table_data += '<th>'+'<p>Edit</p>'+ '</th>';
						table_data += '<th>'+'<p>Delete</p>'+ '</th>';
					}
                    if(i >= 1 &&  i < employee_Table.length-1  )
					{
						table_data += '<td>'+'<button type="button" onclick="editCurrentRow(event)"  class="btn btn-primary">Edit</button>'+ '</td>';
						table_data += '<td>'+'<button type="button" id="delete" onclick="deleteData(event)" class="btn btn-primary" align="center">Delete</button>'+ '</td>';
					}
                    table_data += '</tr>';
                }
                table_data += '</table>';
                $('#employee_table').html(table_data);
            }
        });
    });
    
});

$(document).ready(function(){
    $('#Comp5').click(function(){       
     $.ajax({
      url:"Company_Data5.csv",
      dataType:"text",
        success:function(data)
        {
            var employee_Table = data.split(/\r?\n|\r/);
            var table_data = '<table class="table table-bordered table-striped">';
            for(var i = 0; i<employee_Table.length; i++)
            {
                    var cell_data = employee_Table[i].split(",");
                    table_data += '<tr>';
                    for(var cell_count=0; cell_count<cell_data.length; cell_count++)
                    {
                        if(i === 0)
                        {
                            table_data += '<th>'+cell_data[cell_count]+'</th>';
                        }
                        else
                        {
                            table_data += '<td>'+cell_data[cell_count]+'</td>';
                        }
                    }
                    if(i == 0)
					{
						table_data += '<th>'+'<p>Edit</p>'+ '</th>';
						table_data += '<th>'+'<p>Delete</p>'+ '</th>';
					}
                    if(i >= 1 &&  i < employee_Table.length-1  )
					{
						table_data += '<td>'+'<button type="button" onclick="editCurrentRow(event)"  class="btn btn-primary">Edit</button>'+ '</td>';
						table_data += '<td>'+'<button type="button" id="delete" onclick="deleteData(event)" class="btn btn-primary" align="center">Delete</button>'+ '</td>';
					}
                    table_data += '</tr>';
                }
                table_data += '</table>';
                $('#employee_table').html(table_data);
            }
        });
    });
    
});



