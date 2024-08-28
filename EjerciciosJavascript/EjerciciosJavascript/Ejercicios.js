const readline = require('readline');

// Configurar readline para leer entrada del usuario
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

function contrasenaValida(password) {
    // Definir las contraseñas válidas
    const validPasswords = ["2Fj(jjbFsuj", "eoZiugBf&g9"];
    // Comprobar si la contraseña proporcionada está en la lista de contraseñas válidas
    return validPasswords.includes(password);
}

// Pedir al usuario que ingrese una contraseña
rl.question('Por favor, ingresa la contraseña: ', (input) => {
    // Comprobar la validez de la contraseña y mostrar el resultado
    if (contrasenaValida(input)) {
        console.log('La contraseña es válida.');
    } else {
        console.log('La contraseña es inválida.');
    }
    // Cerrar la interfaz readline
    rl.close();
});
