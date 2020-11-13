## Interfaces Inteligentes
### Práctica 3: Delegados, eventos

1. Agregar dos objetos en la escena: A y B. Cuando el jugador colisiona con un objeto de tipo B, el objeto A volcará en consola un mensaje. Cuando toca el objeto A se incrementará un contador en el objeto B:
	
	Para el primer enunciado "Cuando el jugador colisiona con un objeto de tipo B, el objeto A volcará en consola un mensaje" scripts usados: *objectA, delegateHandler*
	[![Image from Gyazo](https://i.gyazo.com/43331d996bd059535a2d5c59964c94b7.gif)](https://gyazo.com/43331d996bd059535a2d5c59964c94b7)

> 	(Se imprime 4 veces ya que existes cuatro instancias del objecto A en  el momento de ejecución)

 Cuando toca el objeto A se incrementará un contador en el objeto B:
 [![Image from Gyazo](https://i.gyazo.com/2289d39f12ab1e80d04cd296493e3aba.gif)](https://gyazo.com/2289d39f12ab1e80d04cd296493e3aba)
> Un pequeño fail en el primer intento de chocar jeje
----
2. Implementar un controlador de escena usando el patrón delegado que gestione las siguientes acciones: 

○ Si el jugador dispara, los objetos de tipo A que estén a una distancia media serán desplazados y los que estén a una distancia pequeña serán destruidos. Los umbrales que marcan los límites se deben configurar en el inspector:
[![Image from Gyazo](https://i.gyazo.com/2bf1da290cff3a5326f5e07b416cdfa0.gif)](https://gyazo.com/2bf1da290cff3a5326f5e07b416cdfa0)

○ Si el jugador choca con objetos de tipo B, todos los de ese tipo sufrirán alguna transformación o algún cambio en su apariencia y decrementarán el poder del jugador:
[![Image from Gyazo](https://i.gyazo.com/0728494bdd8b042225e072fd8ca929bc.gif)](https://gyazo.com/0728494bdd8b042225e072fd8ca929bc)

---
3. En la escena habrá ubicados un tipo de objetos que al ser recolectados por el jugador harán que ciertos obstáculos se desplacen desbloqueando algún espacio:
[![Image from Gyazo](https://i.gyazo.com/879c964810e5844d90cbaa9949826a79.gif)](https://gyazo.com/879c964810e5844d90cbaa9949826a79)

----
4. Incorporar un elemento que sirva para encender o apagar un foco utilizando el teclado:
[![Image from Gyazo](https://i.gyazo.com/10cca6ef65dfd9d80b3101fd7b1d2505.gif)](https://gyazo.com/10cca6ef65dfd9d80b3101fd7b1d2505)
