
--# 🛡️ Hoja de Observación - Prueba cruzada de guerreros

**Nombre del equipo que prueba:** FerRC-Axl
**Nombre del equipo dueño del código:** Equipo Dinamita
**Fecha:** 16q/08/2025

---

## 1. Datos generales del guerrero evaluado

| Atributo            | Valor       |
| ------------------- | ----------- |
| Nombre del guerrero | No definido |
| Vida base           | No definida |
| Ataque base         | No definido |
| Defensa base        | No definida |
| Velocidad           | No definida |

**Observación:**
Este código no implementa atributos de un guerrero, sino una mecánica narrativa sobre practicar música o recolectar madera.

---

## 2. Pruebas de práctica y horas disponibles

> El código permite elegir entre practicar o no, y luego cuántas horas dedicar (1 a 6).

| Caso de prueba | Entrada            | Salida esperada                            | Resultado ✅ / ❌ | Observaciones                                                   |
| -------------- | ------------------ | ------------------------------------------ | --------------- | --------------------------------------------------------------- |
| 1              | "Si" + "1 hora"    | "Tomas tu lira..." + "Cantas por una hora" | ✅               | Funciona correctamente.                                         |
| 2              | "No"               | "Buscas madera para la fogata"             | ✅               | Funciona correctamente.                                         |
| 3              | "Si" + "6 horas"   | "Tomas tu lira..." + "Cantas por 6 horas"  | ✅               | Funciona correctamente.                                         |
| 4              | "Si" + "7 horas"   | "Excedes el maximo de horas"               | ✅               | Control de error bien aplicado.                                 |
| 5              | "Si" + "dos horas" | "Excedes el maximo de horas"               | ❌               | No reconoce entradas numéricas escritas con letras (ej. "dos"). |

---

## 3. Evaluación del sistema de práctica

### A. Decisión inicial

* ¿Permite elegir practicar o no? ✅
* ¿Ambas opciones muestran mensajes distintos? ✅
* **Observaciones:** Bien implementado con `switch`, pero solo tiene dos respuestas fijas.

### B. Horas de práctica

* ¿Se limita a un máximo de 6 horas? ✅
* ¿Se acepta más de una forma de entrada (ej. "1 hora" y "una hora")? ✅
* ¿Se reconocen todas las variantes posibles ("dos horas", "tres horas")? ❌
* **Observaciones:** Falta estandarizar las entradas para que el jugador no tenga que escribir exactamente la frase esperada.

### C. Consecuencias de practicar

* ¿Aumenta alguna estadística por practicar? ❌
* ¿Consumir horas afecta energía o vida? ❌
* **Observaciones:** Solo muestra texto narrativo, no hay impacto real en atributos.

---

## 4. Progresión y balance

* ¿Hay un sistema de progreso (niveles, experiencia, energía)? ❌
* ¿Existen consecuencias diferentes según la práctica? ❌
* **Observaciones:** Actualmente el código funciona como un **simulador narrativo simple** sin progresión ni atributos que se modifiquen.

---

## 5. Revisión de requisitos técnicos del código

| Requisito                                                      | Cumple ✅ / ❌ | Comentarios                                              |
| -------------------------------------------------------------- | ------------ | -------------------------------------------------------- |
| Menú interactivo con `switch`                                  | ✅            | Usa `switch` tanto en la decisión inicial como en horas. |
| Al menos una función por actividad (Ej: `EntrenarFuerza()`)    | ❌            | Todo está dentro del `Main`, no hay funciones separadas. |
| Uso de operadores aritméticos, lógicos y de comparación        | ❌            | Solo se usan comparaciones directas con `switch`.        |
| Condiciones para subir de nivel, agotarse o perder una batalla | ❌            | No implementado.                                         |
| Validaciones de energía y límites                              | ✅ / parcial  | Solo valida horas máximas, no energía.                   |
| Decisión del usuario sobre cuántas horas invertir por acción   | ✅            | Se puede decidir entre 1 y 6 horas.                      |
| Uso de estructuras de control (`if`, `for`, `do-while`, etc.)  | ✅            | Se usa `switch` y `default` correctamente.               |

---

## 6. Retroalimentación general

* El código cumple con la lógica básica de **entrada del usuario y validación con `switch`**.
* Es un buen inicio para un sistema de práctica, pero aún carece de **estadísticas** y **efectos reales** sobre un guerrero o personaje.
