Feature: Crear un usuario
Como cliente 
quiero registrarme en la página web 
para poder acceder a las sesiones de rehabilitación y/o programas de entrenamiento.

Scenario: Ingresa a la vista Registro

Given que el usuario ha ingresado a la aplicación y se encuentra en la vista inicio
When selecciona la opción Nuevo Usuario
Then se muestra la vista de registo

Scenario: Completa sus datos

Given que el usuario se encuentra en la vista nuevo Usuario
When ingresa sus datos y da clic en guardar
Then se crea la cuenta del usuario