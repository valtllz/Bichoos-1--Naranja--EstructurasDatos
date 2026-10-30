# Bichoos-1--Naranja--EstructurasDatos
# Integrantes y estructuras asignadas

## Valeria Téllez Carmona (Rama: Abeja)

Implementó las siguientes estructuras de datos para el proyecto **BICHOOS**:

### Lista Enlazada Simple
- Agregar insecto.
- Buscar insecto.
- Mostrar insectos.
- Eliminar insecto.

### Matriz Bidimensional (2D)
- Mostrar mapa del bosque.
- Consultar casilla.
- Modificar casilla.

### Pila (Stack)
- Recolectar recurso (Push).
- Ver último recurso recolectado (Peek).
- Retirar último recurso (Pop).

Estas estructuras fueron aplicadas al juego **BICHOOS** para representar la exploración de ecosistemas, el registro de insectos encontrados y la recolección de recursos necesarios para la elaboración de la cura.

---

# Cómo ejecutar el proyecto

## Requisitos

Antes de ejecutar el programa, asegúrate de tener instalado:

- .NET SDK
- Visual Studio 2022 o Visual Studio Code

## Pasos para ejecutar

### 1. Clonar el repositorio

```bash
git clone https://github.com/valtllz/Bichoos-1--Naranja--EstructurasDatos.git
```

### 2. Acceder a la carpeta del proyecto

```bash
cd Bichoos-1--Naranja--EstructurasDatos
```

### 3. Compilar el proyecto

```bash
dotnet build
```

### 4. Ejecutar el programa

```bash
dotnet run
```

## Uso del programa

Al iniciar la aplicación se mostrará un menú interactivo que permite:

- Agregar insectos a la lista enlazada.
- Mostrar los insectos registrados.
- Buscar un insecto específico.
- Eliminar insectos del registro.
- Visualizar el mapa del bosque mediante una matriz bidimensional.
- Recolectar recursos utilizando una pila.
- Consultar o retirar el último recurso recolectado.

Estas estructuras forman parte del sistema de exploración y recolección del juego **BICHOOS**, donde Bumi debe encontrar insectos y recursos para desarrollar una cura que salve a su pueblo.

---

# Tabla comparativa de estructuras

| Estructura | Aplicación en BICHOOS | Operaciones Implementadas |
|------------|----------------------|---------------------------|
| Lista Enlazada Simple | Registro de insectos encontrados por Bumi | Agregar, Buscar, Mostrar, Eliminar |
| Matriz 2D | Representación del mapa del bosque | Mostrar mapa, Consultar casilla, Modificar casilla |
| Pila (Stack) | Administración de recursos para la cura | Push, Peek, Pop |

---

# Descripción del proyecto

**BICHOOS** es un videojuego en el que Bumi debe explorar distintos ecosistemas para recolectar insectos y recursos necesarios para crear una cura que salve a su pueblo de una misteriosa enfermedad.

Durante la aventura, el jugador deberá:

- Recolectar especies específicas de insectos.
- Encontrar insectos especiales de nivel poco común.
- Completar el registro de especies descubiertas.
- Llevar los recursos recolectados a la casa de Balu para contribuir al desarrollo de la cura.