# Proyecto: Calculadora de Figuras y Generador de Web en C#

Este es un proyecto desarrollado en C# que incluye varias funcionalidades relacionadas con geometría y generación de tablas, además de un generador de páginas web que consume una API externa para crear usuarios de prueba. Fue creado el **miércoles, ‎15‎ de ‎junio‎ de ‎2022**. Puedes consultar el repositorio en el siguiente enlace:  
[Repositorio del Proyecto](https://github.com/codestiven/Calculadora_trigonometrica)

## Descripción

Este proyecto permite al usuario realizar las siguientes acciones:

1. **Identificación de triángulos según sus lados**: Indica si un triángulo es equilátero, isósceles o escaleno, con base en las longitudes de sus lados.
2. **Identificación de triángulos según sus ángulos**: Indica si un triángulo es rectángulo, acutángulo u obtusángulo, con base en sus ángulos.
3. **Verificador de cuadrados**: Determina si una figura es un cuadrado según las longitudes de sus lados.
4. **Generador de tabla de multiplicar**: Genera y muestra la tabla de multiplicar para un número ingresado.
5. **Generador web con usuarios de prueba**: Genera una página HTML consumiendo una API externa que genera datos de usuarios de prueba.
6. **Salir**: Opción para salir de la aplicación.

## Funcionalidades

### 1. Triángulo según sus lados
- **Equilátero**: Los tres lados son iguales.
- **Isósceles**: Dos lados son iguales.
- **Escaleno**: Todos los lados son diferentes.

### 2. Triángulo según sus ángulos
- **Rectángulo**: Uno de sus ángulos es de 90 grados.
- **Acutángulo**: Todos sus ángulos son menores a 90 grados.
- **Obtusángulo**: Uno de sus ángulos es mayor a 90 grados.

### 3. Verificador de cuadrados
El usuario ingresa las longitudes de los lados de un cuadrilátero y la aplicación verifica si es un cuadrado.

### 4. Generador de tabla de multiplicar
El usuario ingresa un número, y la aplicación genera la tabla de multiplicar para ese número.

### 5. Generador web con usuarios de prueba
Esta funcionalidad consume la API de [Random User](https://randomuser.me/api/?results=) para generar una página HTML con una cantidad determinada de usuarios de prueba.

- La aplicación realiza una petición HTTP a la API `https://randomuser.me/api/?results={cantidad}`, donde `{cantidad}` es el número de usuarios que el usuario desea generar.
- Luego, construye una página web dinámica que presenta estos usuarios, mostrando detalles como el nombre, la foto, el correo electrónico, la ubicación, entre otros.
- La página HTML se genera con un diseño básico y muestra los datos obtenidos de manera organizada.
  
#### Ejemplo de uso del API
El usuario ingresa cuántos usuarios de prueba desea generar (por ejemplo, 10). La aplicación llama a la API `https://randomuser.me/api/?results=10` y genera un archivo HTML con los detalles de los 10 usuarios en la página.

El archivo generado incluirá información como:
- Nombre completo del usuario
- Fotografía
- Dirección de correo
- Ubicación

#### API de usuarios aleatorios
- **URL del API**: `https://randomuser.me/api/?results={cantidad}`
- **Formato de respuesta**: JSON
- **Datos devueltos por el API**: nombre, género, email, imagen, dirección, teléfono, etc.

#### Ejemplo de página generada
```html
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Usuarios de Prueba</title>
</head>
<body>
    <h1>Usuarios de Prueba</h1>
    <div class="user-list">
        <!-- Detalles de los usuarios generados dinámicamente -->
    </div>
</body>
</html>
