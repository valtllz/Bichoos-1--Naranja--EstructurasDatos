# BICHOOS - Paquete 3

## Integrante
Fernanda

## Estructuras implementadas

### 1. Lista Circular (implementada con nodos propios)

La lista circular se utilizó para representar el ciclo de tiempo del videojuego BICHOOS.

```text
Mañana → Tarde → Noche → Madrugada → Mañana
```

Cada nodo almacena un momento del día y el último nodo apunta nuevamente al primero, permitiendo un recorrido continuo.

#### Operaciones implementadas
- Agregar momento.
- Mostrar ciclo completo.
- Buscar momento.
- Avanzar al siguiente momento.

#### Aplicación en el juego
Permite controlar el ciclo día/noche del bosque. Dependiendo del momento actual pueden aparecer distintos insectos o eventos.

---

### 2. Diccionario (Dictionary<TKey,TValue>)

Se utilizó un diccionario para almacenar los insectos del juego y su habilidad principal.

#### Ejemplo

```text
Vitalis -> Cura
Espectral -> Invisibilidad
Melífera -> Velocidad
```

#### Operaciones implementadas

- Agregar insectos.
- Mostrar insectos registrados.
- Buscar insecto por nombre.

#### Aplicación en el juego

Permite acceder rápidamente a la información de cada insecto mediante su nombre, facilitando la gestión de habilidades y características.

---

### 3. Grafo con lista de adyacencia

Se utilizó un grafo para representar las conexiones entre diferentes zonas del bosque.

#### Ejemplo

```text
Bosque Central
│
├── Pantano
├── Campo de Flores
└── Cueva
```

#### Operaciones implementadas

- Agregar zonas.
- Conectar zonas.
- Mostrar conexiones.
- Buscar una zona.

#### Aplicación en el juego

Permite representar caminos y rutas entre áreas explorables del mapa, ayudando a la navegación y diseño del mundo del juego.

---

# Tabla comparativa

| Estructura | Memoria | Tipo | Ventajas | Desventajas |
|------------|---------|-------|-----------|-------------|
| Lista Circular | Dinámica | Nodos | Permite recorridos infinitos y ciclos continuos | Recorrido secuencial |
| Diccionario | Dinámica | Colección C# | Búsqueda rápida por clave | Mayor consumo de memoria |
| Grafo | Dinámica | Colección C# | Modela conexiones complejas | Implementación más compleja |

---

# Cuándo conviene usar cada estructura

## Lista Circular

Cuando se necesitan ciclos repetitivos.

Ejemplos:
- Turnos.
- Ciclo día/noche.
- Rotación de eventos.

## Diccionario

Cuando se requiere localizar datos mediante una clave.

Ejemplos:
- Inventario.
- Habilidades.
- Enemigos.

## Grafo

Cuando existen conexiones entre múltiples elementos.

Ejemplos:
- Mapas.
- Niveles conectados.
- Rutas del jugador.

---

# Cómo ejecutar el proyecto

1. Abrir la solución en Visual Studio.
2. Compilar el proyecto.
3. Ejecutar el programa.
4. Seleccionar una opción del menú principal.
5. Probar las operaciones de cada estructura.

---

# Uso futuro en Unity

## Lista Circular

Se usaría para controlar:

- Ciclo día/noche.
- Eventos periódicos.
- Sistema de turnos.

## Diccionario

Se usaría para almacenar:

- Insectos.
- Objetos.
- Inventario.
- Habilidades.

## Grafo

Se usaría para representar:

- Conexiones entre zonas.
- Rutas de exploración.
- Navegación dentro del mapa.

---

# Conclusión

Las estructuras de datos implementadas permiten resolver diferentes necesidades del videojuego BICHOOS. La lista circular facilita los ciclos continuos del tiempo, el diccionario gestiona eficientemente la información de los insectos y el grafo modela las conexiones entre las distintas áreas del bosque.
