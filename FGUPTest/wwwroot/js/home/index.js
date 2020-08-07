var app = new Vue({
    el: '#vueapp',
    data: {
        errorTxt: "123",
        tableData: [],
        disctrictColumns: [
            {
                title: '1.2.1. Пол: мужской', width: "220px", columns: [
                    { field: 'menKid', title: '1.2.1.1. 0-18 лет' },
                    { field: 'menAdult', title: '1.2.1.2. 18-60 лет' },
                    { field: 'menSenior', title: '1.2.1.3. старше 60 лет' }
                ]
            },
            {
                title: '1.2.2.Пол: женский', width: "220px", columns: [
                    { field: 'womenKid', title: '1.2.2.1. 0-18 лет' },
                    { field: 'womenAdult', title: '1.2.2.2 18-60 лет' },
                    { field: 'womenSenior', title: '1.2.2.3. старше 60 лет' }
                ]
            },
            { field: 'sumTotal', title: '1.2.3. Итого', width: "100px" }
        ],
        subjectColumns: [
            {
                title: '2.2.1. Пол: мужской', width: "220px", columns: [
                    { field: 'menKid', title: '2.2.1.1. 0-18 лет' },
                    { field: 'menAdult', title: '2.2.1.2. 18-60 лет' },
                    { field: 'menSenior', title: '2.2.1.3. старше 60 лет' }
                ]
            },
            {
                title: '2.2.2.Пол: женский', width: "220px", columns: [
                    { field: 'womenKid', title: '2.2.2.1. 0-18 лет' },
                    { field: 'womenAdult', title: '2.2.2.2 18-60 лет' },
                    { field: 'womenSenior', title: '2.2.2.3. старше 60 лет' }
                ]
            },
            { field: 'sumTotal', title: '2.2.3. Итого', width: "100px" }
        ],
        regionRoutesColumns: [
            { field: 'cityFrom', title: '3.1.1. Пункт отпр' },
            { field: 'cityTo', title: '3.1.2. Пункт приб.' }
        ],
        regionValuesColumns: [
            {
                title: '3.2.1. Пол: мужской', width: "220px", columns: [
                    { field: 'menKid', title: '3.2.1.1. 0-18 лет' },
                    { field: 'menAdult', title: '3.2.1.2. 18-60 лет' },
                    { field: 'menSenior', title: '3.2.1.3. старше 60 лет' }
                ]
            },
            {
                title: '3.2.2.Пол: женский', width: "220px", columns: [
                    { field: 'womenKid', title: '3.2.2.1. 0-18 лет' },
                    { field: 'womenAdult', title: '3.2.2.2 18-60 лет' },
                    { field: 'womenSenior', title: '3.2.2.3. старше 60 лет' }
                ]
            },
            { field: 'sumTotal', title: '3.2.3. Итого', width: "100px" }
        ]
    },
    created() {
        this.getTableData();
    },
    methods: {
        getTableData: function () {
            var vue = this;
            axios.get(tableDataUrl)
                .then(response => {
                    console.log(response);
                    if (response.data.isSuccess)
                        vue.tableData = response.data.federalDistrictData;                    
                    else
                        vue.showModal(response.data.ErrorMessage);
                })
                .catch(error => {
                    console.error(error);
                    vue.errorTxt = "error occurred";
                    vue.showModal();
                });
        },
        showModal: function () {
            $("#indexModal").modal("show");
        },
        closeModal: function () {
            $("#indexModal").modal("hide");
            this.errorTxt = "";
        }
    }
})