const form = document.querySelector('form');
const alerta = document.getElementById('alerta')

form.addEventListener('submit', (event) => {
    event.preventDefault();

    const correo = document.getElementById('correo');
    const clave = document.getElementById('clave');


    const correoValor = correo.value.trim();
    const claveValor = clave.value.trim();

    if (correoValor === '' || claveValor === '') {
        alerta.innerText = '';
        alerta.innerText = 'Complete los campos';
        return;
    }

    form.submit();

   
});
