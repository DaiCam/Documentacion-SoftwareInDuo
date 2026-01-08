# Documentacion-SoftwareInDuo

##  Herramientas Software empleadas
### backEnd NodeJS
### FrontEnd ReactJS  -React Native 
### Base de Datos : SL

# 1. Objetivo del sistema  y Objetivos generales
Desarrollar una aplicacion informatica para la gestion integral de un restaurante, que permita administrar reservas, recursos operativos y reportes de forma eficiente, segura y sin dependencia de conexion a internet,
optimizando los procesos internos y mejorando la experiencia del personal.

# 1.2 Objetivos particulares
Permitir la gestion de reservas de mesas, incluyendo altas, modificaciones y cancelaciones.
Facilitar la organización de mesas y horarios para evitar superposiciones.
Optimizar la gestion de recursos del restaurante (mesas, personal, disponibilidad).
Proveer un panel de control (dashboard) con informacion clara y actualizada.
Generar reportes operativos para la toma de decisiones.
Garantizar el funcionamiento del sistema en modo offline.
Permitir el uso del sistema en tablets y telefonos moviles.
Asegurar una interfaz intuitiva y facil de usar para el personal del restaurante.


# 3. Alcance del sistema 
Sistema con uso exclusivo al uso interno del restaurante, siendo utilizado por el personal autorizado (administradores, encargadors y empleados)
Ademas de contar con la posibilida de usarse en tablets y celulares sin conexion a internet.

# 3.1 Modulo de reservas
Registrar nuevas reservas indicando fecha, horario y cantidad de personas.
Asignar mesas disponibles segun capacidad y horario.
Modificar reservas existentes.
Cancelar reservas.
Visualizar el estado de las reservas por dia y franja horaria.

# 3.2 Modulo de operaciones
Este modulo estara orientado a la operacion diaria del restaurante y permitira:
Consultar reservas activas del dia.
Liberar mesas una vez finalizado el servicio.
Detectar conflictos de horarios o disponibilidad.
Visualizar el estado de ocupacion del restaurante en tiempo real.


# Gestion de recursos
# 4. Modulo de control
Gestionar las mesas del restaurante (cantidad, capacidad, estado).
Administrar la disponibilidad del personal.
Controlar la asignación de recursos segun turnos y horarios.
Mantener actualizada la información operativa del restaurante.

# 5.Personas involucradas
   Administrador de sistemas: configuracion general, reportes e informes.
   Encargado del restaurante: Procesa facturacion, registra pagos, realiza cierres, consulta reportes.
   Mozos: consulta de reservas y gestión de mesas, Informa estados de atencion.
   Personal de cocina: consulta de pedidos y estados.
 
# Casos de uso / Diagramas de flujo

## Listar reservas:
en esta sección se podra visualizar la lista de todas las reservas, ya sean
finalizadas, iniciadas o pendientes.

## Realizar reserva:
Actor: Encargado / Administrador
Flujo:
El usuario accede al modulo o ventana de reservas.
Ingresa fecha, horario y cantidad de personas.
El sistema verifica disponibilidad de mesas.
El usuario confirma la reserva.
El sistema registra la informacion en la base de datos.

 
## 6 Clases
 ### Clase Usuario
   idUsuario : int
   nombre : string
   apellido : string
   email : string
   contraseña : string
   activo : boolean

   ### roles
- id_rol (PK)
- nombre
- descripcion

  ### mesas
- id_mesa (PK)
- numero
- capacidad
- estado

  ### reservas
- id_reserva (PK)
- fecha
- hora
- cantidad_personas
- estado
- id_mesa (FK)
- id_usuario (FK)

Metodos???
login()
logout()Usuario — Rol

relaciones???
Usuario — Reserva
Reserva — Mesa
Mesa — Factura
Factura — DetalleFactura
DetalleFactura — Articulo(seria el menu del restoran)
Usuario — Informe


