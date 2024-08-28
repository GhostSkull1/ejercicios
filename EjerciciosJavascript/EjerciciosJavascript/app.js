'use strict';

//1.	Contrase�a v�lida
//Escribir una funci�n llamada contrasenaValida que reciba un string y retorne true si el string es igual a "2Fj(jjbFsuj" o "eoZiugBf&g9".De lo contrario debe retornar false.


//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function contrasenaValida(password) {

//    const validPasswords = ["1234", "eoZiugBf&g9"];

//    return validPasswords.includes(password);
//}

//rl.question('Por favor, ingresa la contrasena: ', (input) => {

//    if (contrasenaValida(input)) {
//        console.log('La contrasena es valida.');
//    } else {
//        console.log('La contrasena es invalida.');
//    }

//    rl.close();
//});






//2.	Calcular impuestos
//Escribir una funci�n llamada calcularImpuestos que reciba dos argumentos num�ricos: edad e ingresos.Si edad es igual o mayor a 18 y los ingresos son iguales o mayores a 1000 debe retornar ingresos * 40 %.De lo contrario retornar 0.

//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function calcularImpuestos(edad, ingresos) {
//    if (edad >= 18 && ingresos >= 1000) {
//        return ingresos * 0.40;
//    } else {
//        return 0;
//    }
//}

//rl.question('Por favor, ingresa tu edad: ', (edadInput) => {
//    const edad = parseFloat(edadInput);

//    rl.question('Por favor, ingresa tus ingresos: ', (ingresosInput) => {
//        const ingresos = parseFloat(ingresosInput);

//        const impuestos = calcularImpuestos(edad, ingresos);

//        console.log(`El impuesto calculado es: ${impuestos}`);

//        rl.close();
//    });
//});




//3.	IMC(�ndice de masa corporal)
//El �ndice de masa corporal(IMC), o BMI por sus siglas en ingl�s, es un valor que determina la cantidad de grasa de una persona.
//El BMI se calcula con la siguiente formula: peso / altura ^ 2
//Escribir una funci�n llamada bmi que reciba dos argumentos: peso y altura, y retorne un string con las siguientes posibilidades:

//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function bmi(peso, altura) {
//    const imc = peso / (altura * altura);

//    if (imc < 18.5) {
//        return 'Bajo peso';
//    } else if (imc < 24.9) {
//        return 'Peso normal';
//    } else if (imc < 29.9) {
//        return 'Sobrepeso';
//    } else {
//        return 'Obesidad';
//    }
//}

//rl.question('Por favor, ingresa tu peso en kilogramos: ', (pesoInput) => {
//    const peso = parseFloat(pesoInput);

//    rl.question('Por favor, ingresa tu altura en metros: ', (alturaInput) => {
//        const altura = parseFloat(alturaInput);

//        const categoria = bmi(peso, altura);
//        console.log(`Tu categoria de IMC es: ${categoria}`);

//        rl.close();
//    });
//});




//4.	Imprimir un arreglo
//Escribir una funci�n llamada imprimirArreglo que reciba un arreglo e imprima cada elemento en una l�nea a parte:

//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function preguntar(query) {
//    return new Promise(resolve => rl.question(query, resolve));
//}

//async function main() {
//    try {
//        const cantidadInput = await preguntar(' Cuantos numeros deseas ingresar? ');
//        const cantidad = parseInt(cantidadInput, 10);

//        if (isNaN(cantidad) || cantidad <= 0) {
//            console.log('Entrada no valida. Debes ingresar un numero positivo.');
//            rl.close();
//            return;
//        }

//        const numeros = [];

//        for (let i = 0; i < cantidad; i++) {
//            const numeroInput = await preguntar(`Ingrese el numero ${i + 1}: `);
//            const numero = parseInt(numeroInput, 10);
//            if (!isNaN(numero)) {
//                numeros.push(numero);
//            } else {
//                console.log('Entrada no valida. Se omitira este numero.');
//            }
//        }

//        // Imprimir los n�meros
//        imprimirArreglo(numeros);

//    } catch (error) {
//        console.error('Error:', error);
//    } finally {
//        rl.close();
//    }
//}

//function imprimirArreglo(arreglo) {
//    arreglo.forEach(elemento => {
//        console.log(elemento);
//    });
//}

//main();






//5.	N�mero de Likes
//Escribe una funci�n llamada likes que reciba un n�mero y retorne un string utilizando el formato de K para miles y M para millones.
//Por ejemplo:
//�	1400 se convierte en 1K
//�	34, 567 se convierte en 34K
//�	7�456, 345 se convierte en 7M.
//Si el n�mero es menor a 1000 se debe devolver el mismo n�mero como un string.

//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function likes(num) {
//    if (num < 1000) {
//        return num.toString();
//    } else if (num < 1000000) {
//        return Math.floor(num / 1000) + 'K';
//    } else {
//        return Math.floor(num / 1000000) + 'M';
//    }
//}

//function obtenerDatos() {
//    rl.question('Introduce un valor de 1 a un millon: ', (respuesta) => {
//        const num = parseFloat(respuesta);
//        if (!isNaN(num)) {
//            console.log(likes(num));
//        } else {
//            console.log("Entrada no v�lida. Por favor, introduce un n�mero.");
//        }
//        rl.close();
//    });
//}

//obtenerDatos();





//6.	FizzBuzz
//Escribir una funci�n llamada fizzBuzz que reciba un n�mero y retorne un string de acuerdo con lo siguiente:
//�	"fizz" si el n�mero es m�ltiplo de 3.
//�	"buzz" si el n�mero es m�ltiplo de 5.
//�	"fizzbuzz" si el n�mero es m�ltiplo tanto de 3 como de 5.
//�	Si no cumple ninguna de las condiciones anteriores debe retornar el mismo n�mero.


//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function fizzBuzz(num) {
//    if (num % 3 === 0 && num % 5 === 0) {
//        return 'fizzbuzz';
//    } else if (num % 3 === 0) {
//        return 'fizz';
//    } else if (num % 5 === 0) {
//        return 'buzz';
//    } else {
//        return num.toString();
//    }
//}

//function obtenerDatos() {
//    rl.question('Introduce un numero para aplicar fizzBuzz: ', (respuesta) => {
//        const num = parseInt(respuesta, 10);
//        if (!isNaN(num)) {
//            console.log(fizzBuzz(num));
//        } else {
//            console.log("Entrada no valida. Por favor, introduce un numero.");
//        }
//        rl.close();
//    });
//}

//obtenerDatos();







//7.	Contar rango de n�meros
//Escribir una funci�n llamada contarRango que reciba dos n�meros y retorne cu�ntos n�meros que hay entre ellos(excluy�ndolos):
//Nota: Utiliza un ciclo en tu soluci�n.Puedes asumir que el primer n�mero va a ser menor que el segundo.

//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function contarRango(num1, num2) {

//    if (num1 >= num2) {
//        throw new Error("El primer numero debe ser menor que el segundo.");
//    }

//    let contador = 0;
//    for (let i = num1 + 1; i < num2; i++) {
//        contador++;
//    }

//    return contador;
//}

//function obtenerDatos() {
//    rl.question('Introduce el primer numero: ', (respuesta1) => {
//        const num1 = parseInt(respuesta1, 10);

//        rl.question('Introduce el segundo numero: ', (respuesta2) => {
//            const num2 = parseInt(respuesta2, 10);

//            if (!isNaN(num1) && !isNaN(num2)) {
//                try {
//                    const resultado = contarRango(num1, num2);
//                    console.log(`Hay ${resultado} numeros entre ${num1} y ${num2}.`);
//                } catch (error) {
//                    console.log(error.message);
//                }
//            } else {
//                console.log("Por favor, introduce numeros validos.");
//            }

//            rl.close();
//        });
//    });
//}

//obtenerDatos();







//8.	Sumar rango de n�meros
//Escribir una funci�n llamada sumarRango que reciba dos argumentos: n�mero inicial y n�mero final.La funci�n debe retornar la suma de los n�meros en ese rango(incluy�ndolos).
//    Nota: puedes asumir que el n�mero inicial va a ser menor o igual que el n�mero final.

//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function sumarRango(inicio, fin) {
//    if (inicio > fin) {
//        throw new Error("El numero inicial debe ser menor o igual al numero final.");
//    }

//    let suma = 0;
//    for (let i = inicio; i <= fin; i++) {
//        suma += i;
//    }

//    return suma;
//}

//function obtenerDatos() {
//    rl.question('Introduce el numero inicial: ', (respuesta1) => {
//        const inicio = parseInt(respuesta1, 10);

//        rl.question('Introduce el numero final: ', (respuesta2) => {
//            const fin = parseInt(respuesta2, 10);

//            if (!isNaN(inicio) && !isNaN(fin)) {
//                try {
//                    const resultado = sumarRango(inicio, fin);
//                    console.log(`La suma de los numeros del ${inicio} al ${fin} es ${resultado}.`);
//                } catch (error) {
//                    console.log(error.message);
//                }
//            } else {
//                console.log("Por favor, introduce numeros validos.");
//            }

//            rl.close();
//        });
//    });
//}

//obtenerDatos();





//9.	N�mero de aes(letra "a")
//Escribir una funci�n llamada numeroDeAes que reciba un string y retorne el n�mero de veces que aparece la letra "a":

//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function numeroDeAes(cadena) {
//    const cadenaMinuscula = cadena.toLowerCase();
//    return cadenaMinuscula.split('a').length - 1;
//}

//function obtenerDatos() {
//    rl.question('Introduce un texto: ', (texto) => {
//        const resultado = numeroDeAes(texto);
//        console.log(`El numero de veces que aparece la letra "a" es: ${resultado}`);
//        rl.close();
//    });
//}

//obtenerDatos();





//10.	N�mero de caracteres
//Escribir una funci�n llamada numeroDeCaracteres que reciba un string y un caracter(un string de un caracter).La funci�n debe retornar el n�mero de veces que aparece el caracter en el string.

//const readline = require('readline');

//const rl = readline.createInterface({
//    input: process.stdin,
//    output: process.stdout
//});

//function numeroDeCaracteres(cadena, caracter) {
//    if (caracter.length !== 1) {
//        throw new Error("El segundo argumento debe ser un solo caracter.");
//    }

//    let contador = 0;
//    for (let i = 0; i < cadena.length; i++) {
//        if (cadena[i] === caracter) {
//            contador++;
//        }
//    }

//    return contador;
//}

//function obtenerDatos() {
//    rl.question('Introduce un texto: ', (texto) => {
//        rl.question('Introduce el caracter a buscar: ', (caracter) => {
//            if (caracter.length !== 1) {
//                console.log("Por favor, introduce un solo caracter.");
//            } else {
//                try {
//                    const resultado = numeroDeCaracteres(texto, caracter);
//                    console.log(`El caracter "${caracter}" aparece ${resultado} veces en el texto.`);
//                } catch (error) {
//                    console.log(error.message);
//                }
//            }
//            rl.close();
//        });
//    });
//}

//obtenerDatos();

