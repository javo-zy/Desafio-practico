#Calculadora de Descuentos - Primer Desafío Práctico
Materia: Programación Estructurada
Universidad: Universidad Don Bosco

#Descripción del Proyecto
Este programa es una aplicación de escritorio creada con Windows Forms en C#. Su función principal es calcular el precio final de un producto aplicando un porcentaje de descuento. El descuento depende de dos cosas:
La categoría del producto (Electrónica, Ropa, Alimentos u Hogar).
El monto total de la compra (si supera un mínimo establecido para cada categoría).

#¿Cómo usar el programa?
Clonal el repocitorio
Abra el proyecto en Visual Studio.
Presione el botón "Iniciar" (Start) en la parte superior para ejecutar la aplicación.
En la ventana del programa, ingrese el Precio original del producto en la primera caja de texto (solo números).
Ingrese el Monto total de la compra en la segunda caja de texto.
Seleccione la Categoría del producto en la lista desplegable.
Haga clic en el botón Calcular.
El programa mostrará el precio final a pagar y un mensaje indicando de cuánto fue el descuento aplicado (o si no se aplicó ninguno).

#Explicación del Código y Estructuras Utilizadas
Para que el código sea seguro y cumpla con los requisitos, se utilizaron las siguientes estructuras:
Manejo de Errores (try-catch): Todo el código del botón está dentro de un bloque try-catch. Si el usuario ingresa texto en lugar de números, el programa no se cierra de golpe, sino que salta al catch y muestra un mensaje de advertencia amigable.
Conversión de Datos: Se utilizó Convert.ToDouble() para transformar el texto que el usuario escribe en las cajas (TextBox) a números decimales con los que se puede hacer matemáticas.
Estructura switch-case: Se usó para evaluar la categoría seleccionada en el ComboBox. Dependiendo de si es Electrónica, Ropa, Alimentos u Hogar, el programa entra a un "caso" diferente.
Estructura if-else: Dentro de cada case, se usó un if para verificar si el monto total de la compra supera el mínimo necesario para dar el descuento. También se usó un if-else al final para decidir qué mensaje mostrar al usuario (si hubo descuento o no).
