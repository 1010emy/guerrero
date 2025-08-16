# 🛡️ Hoja de Observación - Prueba cruzada de guerreros

**Nombre del equipo que prueba:** _Emily Macias Balderas_______  
**Nombre del equipo dueño del código:** _Equipo Dinamita_____  
**Fecha:** _15/08/2025____

---

## 1. Datos generales del guerrero evaluado

| Atributo        | Valor |
|-----------------|-------|
| Nombre del guerrero | --- |
| Vida base       | --- |
| Ataque base     | --- |
| Defensa base    | --- |
| Velocidad       | --- |

---

## 2. Pruebas de combate con enemigos personalizados

Prueba el guerrero con enemigos que tengan distintos niveles de fuerza, vida y velocidad.

| Enemigo # | Vida | Ataque | Velocidad | ¿Ganó el guerrero? | Observaciones |
|-----------|------|--------|-----------|---------------------|----------------|
| 1         |      |        |           |                     |                |
| 2         |      |        |           |                     |                |
| 3         |      |        |           |                     |                |
| 4         |      |        |           |                     |                |
| 5         |      |        |           |                     |                |

---

## 3. Evaluación del sistema de entrenamiento

### A. Entrenar fuerza

- ¿Aumenta la fuerza después de entrenar?  ❌  
- ¿Consume energía de forma proporcional a las horas? ❌  
- ¿El entrenamiento respeta el límite de 6 horas? ❌  
- Observaciones:  
  No establece cuanto es el maximo de horas para entrenar, supongo que el limite es mayo de 2 horas, porque al sellecionar 3 horas aparece el mensaje "Excedes el maximo de horas". 

### B. Entrenar resistencia

- ¿Aumenta la resistencia? ❌  
- ¿Afecta otras estadísticas? (por ejemplo, menos energía) ❌  
- ¿Tiene sentido el impacto por hora entrenada? ❌  
- Observaciones:  
  No cuenta con dicho entrenamiento.

### C. Dormir / Descansar

- ¿Recupera energía al descansar? ❌  
- ¿Se evita sobrecargar la energía (por ejemplo, pasar de 100)? ❌  
- Observaciones:  
  Si cuenta con la opcion de no entrenar, sin embargo, no establece la nueva energia o sobrecarga. 

---

## 4. Progresión y balance

- ¿El personaje sube de nivel correctamente con la experiencia acumulada? ❌  
- ¿Se siente balanceado el avance del personaje? ❌  
- ¿Hay consecuencias claras si no tiene energía (por ejemplo, no puede entrenar)? ❌  
- Observaciones:  
  No cuenta con ello. 

---

## 5. Revisión de requisitos técnicos del código

| Requisito                                                        | Cumple ✅ / ❌ | Comentarios |
|------------------------------------------------------------------|---------------|-------------|
| Menú interactivo con `switch` que se repite                     |      ✅        | Solo cuenta con dos posibles opciones a elegir. |
| Al menos una función por actividad (Ej: `EntrenarFuerza()`)     |      ✅        | Si entrena, pero no muestra el dato solicitado. |
| Uso de operadores aritméticos, lógicos y de comparación         |      ❌        | No cuenta con ello mas que solo con el signo de =. |
| Condiciones para subir de nivel, agotarse o perder una batalla |       ❌        | No cuenta con ello. |
| Validaciones de energía y límites                               |      ❌        | No cuenta con ello. |
| Decisión del usuario sobre cuántas horas invertir por acción   |       ✅        | Da la libertad de escoger la accion. |
| Uso de estructuras de control (`if`, `for`, `do-while`, etc.)   |      ❌        | No cuenta con ninguno. |

---

## 6. Retroalimentación general  
- Falto agregar los bucles de control. 
- Falto agregar al heroe y al enemigo, junto con sus variables.
- El codigo no cuenta con la mayoria de lo solicitado, se requiere revision de ello. 
