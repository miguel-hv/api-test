# pokelab-back

Backend para el proyecto Angular pokelab. Estoy probando .net con ayuda de [este tutorial](https://www.youtube.com/watch?v=Gua0O0Q7I58)
usando el paquete Entity Framework Core como ORM

## Autenticación
Para el sistema de autenticación uso Identity con token (en vez de cookies) según [este tutorial](https://www.youtube.com/watch?v=V-S5JZJUvvU) 
y para modificar la clase User me guié por [este otro tutorial](https://www.youtube.com/watch?v=S0RSsHKiD6Y).


## Notas
- DbContext es una clase parte del Entity Framework. Representa una sesión de trabajo con la db para hacer CRUD mediante operaciones de dominio
- Se instala el paquete Entity Framework Core SQL Server
- Entity Framework Tools es el paquete para ejecutar las migraciones a la db
- Para ejecutar las migraciones se hace desde la consola de paquetes Nuget