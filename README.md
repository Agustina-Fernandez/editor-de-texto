# Wordcito - Editor de texto en VB .NET

Un editor de texto de escritorio desarrollado en **Visual Basic .NET** utilizando la herramienta **Visual Studio 2022**.El proyecto simula ser una aplicación del tipo Word que cuenta con las funciones esenciales de uno,permitiendo la personalización del texto por selección y la persistencia de esa selección en los archivos.

## 🚀 Características Principales

* **Formato de texto avanzado:** Permite cambiar el tipo de letra (fuente) y el tamaño de manera independiente por cada palabra o fragmento seleccionado.
* **Persistencia en formato estándar (.rtf):** Los archivos se guardan y leen manteniendo el formato original de estilos, tamaños y colores mediante el uso del control `RichTextBox`.
* **Temas Visuales Dinámicos:** El proyecto cuenta con tres modos de interfaz interactivos:
     * Modo Claro
     * Modo Oscuro
     * Modo Sistema (Personalizado)
* **Flujo seguro de cierre:** Incluye un control lógico en el botón de salida para prevenir la pérdida accidental de datos antes de cerrar la aplicación.

## 🛠️ Tecnologías Utilizadas

* **Lenguaje de Programación:** Visual Basic .NET (VB .NET)
* **Entorno de Desarrollo:** Visual Studio 2022
* **Framework:** .NET Windows Forms

## 📂 Estructura del Código

El proyecto implementa buenas prácticas de programación:
* **Validación de Estados:** Control de referencias nulas (`IsNot Nothing`) en el formato de selección para evitar excepciones de sistema si el usuario selecciona múltiples fuentes al mismo tiempo.
* **Documentación Interna:** Código comentado, facilitando el entendimiento de las variables globales de estado y los controladores de eventos de los componentes del formulario.
