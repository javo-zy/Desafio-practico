# 🧮 Calculadora de Descuentos - Primer Desafío Práctico

**Materia:** Programación Estructurada  
**Universidad:** Universidad Don Bosco  

---

## 📌 Descripción del Proyecto

Este programa es una aplicación de escritorio creada con **Windows Forms en C#**.

Su función principal es **calcular el precio final de un producto aplicando un porcentaje de descuento**.

El descuento depende de dos factores:

- 🏷️ **La categoría del producto**:
  - Electrónica  
  - Ropa  
  - Alimentos  
  - Hogar  

- 💰 **El monto total de la compra**, siempre que supere un mínimo establecido para cada categoría.

---

## 🚀 ¿Cómo usar el programa?

1. Clonar el repositorio.
2. Abrir el proyecto en **Visual Studio**.
3. Presionar el botón **"Iniciar" (Start)** en la parte superior para ejecutar la aplicación.
4. En la ventana del programa:
   - Ingresar el **Precio original** del producto en la primera caja de texto (solo números).
   - Ingresar el **Monto total de la compra** en la segunda caja de texto.
   - Seleccionar la **Categoría del producto** en la lista desplegable.
5. Hacer clic en el botón **Calcular**.
6. El programa mostrará:
   - ✅ El **precio final a pagar**
   - 📢 Un mensaje indicando cuánto fue el descuento aplicado (o si no se aplicó ninguno)

---

## 🧠 Explicación del Código y Estructuras Utilizadas

Para que el código sea seguro y cumpla con los requisitos, se utilizaron las siguientes estructuras:

### 🔐 Manejo de Errores (`try-catch`)

Todo el código del botón está dentro de un bloque `try-catch`.  

Si el usuario ingresa texto en lugar de números, el programa no se cierra inesperadamente. En su lugar, ejecuta el bloque `catch` y muestra un mensaje de advertencia amigable.
