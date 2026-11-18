# delgado-riveras-feliciano-clase-objetos

# Integrantes del Grupo:

* Jesica Delgado (2024-3909)
* Yokairy Feliciano (2025-0626)
* Yosemi Riveras Rincón (2024-1104)

# Descripción del programa:

Este programa es una aplicación desarrollada en C#, basada en el paradigma de programación orientada a objetos, destinada a la gestión del inventario de la tienda «TecnoPunto».

Permite registrar productos, administrar sus datos esenciales, validar la información ingresada y calcular automáticamente el valor total en existencia de cada producto, garantizando así un manejo adecuado y confiable de los registros.


# Datos de entrada: 

Código del producto, nombre, precio unitario y cantidad en existencia ingresados por el usuario mediante la consola.

# Datos que procesa: 
  
Validación de reglas de negocio (nombre no vacío, precio > 0, cantidad > 0 y cálculo automático del valor total (⁠Precio × Cantidad⁠).
  

 # Datos de salida:
 
Información detallada de los productos registrados, mensajes de error controlados ante datos inválidos y el valor total calculado.


# Capturas de Ejecución del Programa

# 1. Registro Exitoso de los Productos:

En esta captura se evidencia el ingreso correcto de los datos por teclado (nombre, precio y cantidad) para cada uno de los 3 productos solicitados, demostrando que las propiedades encapsuladas aceptan valores válidos sin interrupciones.

<img width="677" height="680" alt="image" src="https://github.com/user-attachments/assets/583d7df4-65bc-48b5-a27a-8e35837f325e" />


# 2. Reporte de Inventario y Cálculo de Totales

Muestra la salida final en consola una vez completado el registro.

<img width="872" height="692" alt="image" src="https://github.com/user-attachments/assets/2a93e5b7-5706-45e5-b124-a3570091b5bd" />


# 3. Manejo de Errores y Validaciones

Evidencia el funcionamiento de las validaciones internas y los bloques `try-catch ante entradas incorrectas (como dejar el nombre en blanco, ingresar letras en campos numéricos o colocar precios negativos). El sistema muestra una alerta clara al usuario y vuelve a solicitar el dato sin que el programa se cierre inesperadamente.

<img width="1137" height="651" alt="image" src="https://github.com/user-attachments/assets/5aa3d5dc-3f9f-4764-9f68-8499674c38e3" />

# Sistema que se utilizó:

Visual Studio (C# - Aplicación de consola)



