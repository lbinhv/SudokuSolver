var solutionresults = [];

$(function () {
    GetSolutionResult();
});


function GetSolutionResult() {
    fetch("http://localhost:5058/GetListSolutionResult")
        .then(function (response) {
            if (response.ok) {
                return response.json();
            }
            else {
                throw new Error("Error retrieving data from API.");
            }
        })
        .then(function (data) {
            solutionresults = data;

            $("#dataGrid").dxDataGrid({
                dataSource: solutionresults,
                keyExpr: "solutionResultId",
                columns: [
                    {
                        dataField: "solutionStatusDisplay",
                        caption: "Solution Status",
                        width: "200px",
                        sortOrder: "des",
                    }, {
                        dataField: "resultDate",
                        caption: "Result Date",
                        width: "300px",
                        dataType: "date",
                        format: "dd MMM yyyy hh:mm:ss",
                        sortOrder: "des",
                    }
                ],
                allowColumnReordering: true,
                allowColumnResizing: true,
                paging: {
                    pageSize: 10,
                    pageIndex: 0    // Shows the second page
                },
                pager: {
                    showPageSizeSelector: true,
                    showNavigationButtons: true,
                    showInfo: true,
                    infoText: "Page #{0}. Total: {1} ({2} items)" 
                }
            });

            
        })
        .catch(function (error) {
            // Handle any errors
            console.error("Error retrieving data from API: " + error);
        });
}