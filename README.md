# Descripción
  Es una API para una ONG ficticia, la misma cuenta con los siguientes endpoint:
  - Activities
  - Auth
  - Categories
  - Members
  - News
  - Organizations
  - Slides
  - Testimonials
  - UserDetails
  - Comments
  - Contacts

# Tecnologías
  Se realizo el proyecto con:
  - Version de SDK: [.NET6](https://dotnet.microsoft.com/en-us/download)
  - IDE: [Visual Studio 2022](https://visualstudio.microsoft.com/es/downloads/)
  - Envio de Email: [SendGrid](https://sendgrid.com/)

# Arquitectura
  Se realizo el proyecto aplicando la arquitectura limpia (Clean Aqchitecture) de Robert Martin, que se basa en la premisa de estructurar el código en capas contiguas, es decir,   que solo tienen comunicación con las capas que están inmediatamente a sus lados, cada nivel debe realizar sus propias tareas y se comunica únicamente con sus niveles           inmediatamente contiguos.
  
# Cuentas de administradores y usuarios  para loguear a la API

## Admins: tienen autorización para realizar cualquier operación.
admin0@localhost
admin1@localhost
admin2@localhost
admin3@localhost
admin4@localhost
admin5@localhost
admin6@localhost
admin7@localhost
admin8@localhost
admin9@localhost

password: Abc123.

## Users: solo pueden realizar operaciones limitadas.
user0@localhost
user1@localhost
user2@localhost
user3@localhost
user4@localhost
user5@localhost
user6@localhost
user7@localhost
user8@localhost
user9@localhost

password: 123Abc.
