function initVM() {
    var vm = kendo.observable({
        firstname: '',
        lastname: '',
        mobile: ''
    });
    return vm;
}