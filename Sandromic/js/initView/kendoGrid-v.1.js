function initView(vm) {

    $('#grid').kendoGrid(
        {
            selectable: "multiple cell",
            autobind: false,
            scrollable: true,
            resizable: true,
            allowCopy: true,
            navigatable: true,
            pageable:
            {
                pageSize: 10,
                message: {
                    display: "{2} از {1}-{0} نمایش",
                    empty: "اطلاعاتی موجود نیست"
                }
            },
            columns:
                [
                    { field: "Name", title: "نام" },
                    { field: "LastName", template: "نام خانوادگی" },
                    { field: "NationalCode", tile: "کد ملی", width: "100px" },
                    { field: "IsActive", tile: "وضعیت", width: "60px" },
                ],
            dataSource: vm.SearchDS
        });
}