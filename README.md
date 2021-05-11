# CoronaDB

el proyecto tiene dos carpetas principales **CoronaTest** que es el banked del proyecto desarrollado en .net core 5 utilizando una conexion a una base de datos local sql server. Y la carpteta **coronaObs** que es el frontend del proyecto desarrollado con angular 11.

## Backend
Para iniciar el proyecto debemos tener sql server microsoft. la cadena de conexcion se encuentra en el archivo appSettings.JSON, debemos especificar el usaurio (sa) y la contraña de la base de datos (123456).

Despues de abrir el proyecto debemos de ejecutar el comando:
`Update-database`
Nos creara las base de datos y la tabla utilizada en el proyecto

Al correr el proyecto nos abrirá una pagina swagger donde podremos probar los endPoints de nuestro proyecto
