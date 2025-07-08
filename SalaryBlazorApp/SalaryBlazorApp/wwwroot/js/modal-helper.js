export function mostrarModal(selector) {
    const modalElement = document.querySelector(selector);
    if (modalElement) {
        const modal = new bootstrap.Modal(modalElement);
        modal.show();
    }
}