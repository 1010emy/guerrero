INICIO PROGRAMA

    DEFINE vida COMO ENTERO
    DEFINE resistencia COMO ENTERO
    DEFINE fuerza COMO ENTERO
    DEFINE accion COMO ENTERO
    DEFINE energia COMO FLOAT = 100
    DEFINE reproducirSonido COMO FLOAT
    DEFINE nombre COMO CADENA DE TEXTO
    DEFINE ubicacion COMO CADENA DE TEXTO

    nombre = "Orfeo"
    MOSTRAR nombre
    ubicacion = "Bar de Hermes"
    MOSTRAR ubicacion
    DEFINE vidaOrfeo COMO ENTERO = 100
    resistencia = 50
    LEER resistencia

    
    DEFINE fuerza COMO ENTERO    
    DEFINE energia COMO FLOAT = 100
    DEFINE accion COMO ENTERO

FIN PROGRAMA

//Menú principal
MOSTRAR "Elige cuantas horas quieres practicar"
MOSTRAR "1. UNA HORA"
MOSTRAR "2. DOS HORAS"
MOSTRAR "3. TRES HORAS"
MOSTRAR "4. CUATRO HORAS"
MOSTRAR "5. CINCO HORAS"
LEER num 
REPETIR

MOSTAR "Orfeo se sienta en una esquina y empieza a practicar..."

/-- MÉTODOS --/

METODO CrearCanción()
   DEFINIR ComponerLetra COMO FLOAT = -1.5 energia 
                                    = +5 fuerza 
                       
METODO AtaqueOrfeo()
    DEFINIR Cantar COMO CADENA DE TEXTO
    MOSTRAR "King of silver... King of bricks... And everything shivering under the ground."
    DEFINIR reproducirSonido COMO FLOAT
    - 1.5 = energia
    = +10 Fuerza 

METODO TocarLira()
   reproducirSonido = archivo.mp3
    +10 = fuerza

METODO HorasEntrenadas()
   DEFINIR horas COMO ENTERO = 6 horas 
   - 6.5 = energia
   + 30 = fuerza 
//Mostrar el progreso relizado en texto, tomando en cuenta las horas entrenadas

//Menu alterno al finalizar la practica
MOSTRAR "La canción esta casi terminada"
MOSTRAR "¿Seguir practicando?
MOSTRAR "A. No"
MOSTRAR "B. Si"
LEER letra 
    SEGUN num HACER
  A:  MOSTRAR "Orfeo deja de practicar y va a recoger madera junto con Euridice"
      MOSTRAR "Ambos van a descansar"
      //Orfeo recarga energia
  B: //Regresar al menu principal
HASTA QUE letra = B 

    
