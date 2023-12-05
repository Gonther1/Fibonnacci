# Sequence Fibonnacci

Este repositorio es una guia para la correcta realizacion del famoso
ejercicio "Fibbonacci" 

## 1- Step One

Como primer paso tenemos la declaracion de 3 variables:

```c#
int ZeroToShow=0; // ZeroToShow mostrara los numeros de la secuencia Fibonnacci esta se inicializa en 0 
int ZeroDontSee=0; // ZeroDontSee se usara para igualar el valor de ZeroToShow esto para reemplazar el valor que posee ZeroToShow
int NumberOne=1; // NumberOne es una variable que contiene el numero uno, esto para indicar que esta variable va a estar por delante de las anteriores dos
```

## 2- Step Two

Finalmente en el ciclo imprimimos una de las variables que se declaro con 0

```c#
Console.Write($"{ZeroToShow}, "); // En este caso ZeroToShow 
```

Luego declaramos las variables de la siguiente manera:

```c#
ZeroDontSee = ZeroToShow;
ZeroToShow = NumberOne;
NumberOne = ZeroDontSee + NumberOne;
```

El resultado final es el siguiente:

```c#
for (int i = 0; i < 20; i++) // 20 es la cantidad de numeros que se mostraran en la secuencia
{
    Console.Write($"{ZeroToShow}, ");
    ZeroDontSee = ZeroToShow;
    ZeroToShow = NumberOne;
    NumberOne = ZeroDontSee + NumberOne;
}
```