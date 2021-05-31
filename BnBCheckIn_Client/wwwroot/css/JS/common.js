Window.ShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire({
            icon: 'success',
            title: 'Perfect...',
            text: message,
            showClass: {
                popup: 'animate__animated animate__fadeInDown'
            },
            hideClass: {
                popup: 'animate__animated animate__fadeOutUp'
            }
        })
    }
    if (type === "error") {
        Swal.fire({
            icon: 'error',
            title: 'Sorry...',
            text: message,
            showClass: {
                popup: 'animate__animated animate__fadeInDown'
            },
            hideClass: {
                popup: 'animate__animated animate__fadeOutUp'
            }
        })
    }
}