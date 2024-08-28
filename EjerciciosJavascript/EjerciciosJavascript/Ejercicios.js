const readline = require('readline');

// Configurar readline para leer entrada del usuario
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

function contrasenaValida(password) {
    // Definir las contrase�as v�lidas
    const validPasswords = ["2Fj(jjbFsuj", "eoZiugBf&g9"];
    // Comprobar si la contrase�a proporcionada est� en la lista de contrase�as v�lidas
    return validPasswords.includes(password);
}

// Pedir al usuario que ingrese una contrase�a
rl.question('Por favor, ingresa la contrase�a: ', (input) => {
    // Comprobar la validez de la contrase�a y mostrar el resultado
    if (contrasenaValida(input)) {
        console.log('La contrase�a es v�lida.');
    } else {
        console.log('La contrase�a es inv�lida.');
    }
    // Cerrar la interfaz readline
    rl.close();
});
