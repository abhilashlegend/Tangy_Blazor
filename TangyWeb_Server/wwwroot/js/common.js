window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Operation Successful', { timeOut: 5000 })
    }
    if (type === "error") {
        toastr.error(message, "Operation Failed", { timeOut: 5000 } )
    }
    if (type === "info") {
        toastr.info(message, "Info:", { timeOut: 10000 })
    }
}

window.SweetAlert = (type, message) => {
    if (type === "success") {
        Swal.fire({
            icon: 'success',
            title: 'Success',
            text: message
        })
    }

    if (type === "error") {
        Swal.fire({
            icon: 'error',
            title: 'Error',
            text: message
        })
    }


}