function initVM(arg) {
    var vm = kendo.observable({
        firstname: '',
        lastname: '',
        mobile: '',

        onSearch:
            function myfunction(e) {
                vm.searchDS.page(0);
            },

        searchDS:
            new kendo.DataSource(
                {
                    transaport:
                    {
                        read:
                        {
                            dataType: "json",
                            type: 'POST',
                            url: arg.searchUrl,
                            data:
                            {
                                firstname:
                                    function () { return vm.firstname; },
                                lastname:
                                    function () { return vm.lastname; },
                                nationalCode:
                                    function () { return vm.nationalCode; }
                            }
                        }
                    },
                    schema:
                    {
                        total: "Total",
                        data: "Data",
                        parse:
                            function (result) {
                                console.log("Data Has Been Recived!");
                                console.log(result);
                                return result;
                            }
                    },
                    pageSize: 10,
                    serverPaging: true
                })
    });
    return vm;
}