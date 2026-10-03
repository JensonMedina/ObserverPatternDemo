# ObserverPatternDemo

Aplicación educativa en **C# y Windows Forms** que demuestra el patrón de diseño **Observer** mediante una estación meteorológica. Un servicio publica temperaturas y distintos paneles reaccionan mientras están suscriptos.

Trabajo práctico para la materia **Desarrollo y Arquitectura de Software**.

## Objetivo

Entender qué problema resuelve Observer, reconocer sus roles en el código y observar cómo las suscripciones permiten agregar o quitar destinatarios sin modificar la lógica de notificación.

La temperatura se ingresa manualmente para controlar la demostración. La aplicación no requiere sensores, una API meteorológica ni una base de datos.

## Qué es Observer

Observer es un **patrón de diseño de comportamiento** que establece una relación **uno a muchos** entre un sujeto y sus observadores. Cuando ocurre un cambio o evento de interés, el sujeto notifica a los objetos suscriptos mediante un contrato común.

Cada observador decide cómo reaccionar. El sujeto conoce el contrato para notificar, pero no necesita conocer las clases concretas ni las reglas particulares de sus destinatarios.

Es un patrón de comportamiento porque organiza la comunicación y la distribución de responsabilidades entre objetos.

### Qué problema resuelve

Una misma temperatura puede necesitar varias representaciones: Celsius, Fahrenheit, una alerta y un historial. Si el emisor contiene una llamada específica para cada panel, agregar otro destinatario obliga a modificar esa parte del emisor.

Observer permite registrar los interesados en una colección y notificarlos a través de una interfaz. Para incorporar otro comportamiento, se crea un observador y se suscribe su instancia.

El acoplamiento **se reduce, no desaparece**: el servicio depende de la interfaz y mantiene referencias a los objetos suscriptos.

## Funcionalidades

- Publicar una temperatura ingresada desde el formulario.
- Mostrar el valor en Celsius y su conversión a Fahrenheit.
- Activar una alerta cuando la temperatura supera los **35 °C**.
- Conservar un historial visual con la hora de recepción de cada temperatura.
- Suscribir y desuscribir cada panel mediante casillas.
- Registrar las excepciones de un observador e intentar continuar con los demás.

## Roles y responsabilidades

| Rol | Implementación | Responsabilidad |
| --- | --- | --- |
| Sujeto observable | `TemperaturaService` | Mantiene la colección de observadores y publica temperaturas. |
| Contrato del observador | `IObservadorTemperatura` | Define `ActualizarTemperatura(decimal temperaturaCelsius)`. |
| Observador concreto | `PanelCelsius` | Muestra la temperatura en Celsius. |
| Observador concreto | `PanelFahrenheit` | Convierte el dato recibido y lo muestra en Fahrenheit. |
| Observador concreto | `PanelAlerta` | Evalúa el umbral y actualiza el mensaje y su color. |
| Observador concreto | `PanelHistorial` | Agrega una entrada con la hora de recepción y la temperatura. |
| Código que conecta los objetos | `EstacionMeteorologicaForm` | Suscribe los paneles y publica el valor ingresado por el usuario. |

`TemperaturaService` cumple el rol de sujeto sin necesitar una interfaz adicional para ese rol en este ejemplo.

Los paneles heredan de `UserControl` e implementan `IObservadorTemperatura`. Se suscriben las **instancias visuales existentes**, no las clases en general.

## Organización del código

Las rutas de esta tabla son relativas a la carpeta del proyecto:

| Archivo o carpeta | Contenido |
| --- | --- |
| `Observadores/IObservadorTemperatura.cs` | Contrato común para recibir las temperaturas. |
| `Servicios/TemperaturaService.cs` | Suscripción, desuscripción, publicación y notificación. |
| `Controles/PanelCelsius.cs` | Reacción del panel Celsius. |
| `Controles/PanelFahrenheit.cs` | Reacción del panel Fahrenheit. |
| `Controles/PanelAlerta.cs` | Regla de alerta. |
| `Controles/PanelHistorial.cs` | Historial en memoria. |
| `EstacionMeteorologicaForm.cs` | Coordinación del formulario y eventos de sus controles. |
| `*.Designer.cs` | Creación de controles y propiedades visuales estáticas. |
| `*.resx` | Recursos asociados al formulario y a los controles, cuando corresponda. |

Los cambios visuales dinámicos, como el texto de una temperatura o el color de una alerta, forman parte de la reacción del observador y permanecen en su clase de comportamiento.

## Requisitos y ejecución

- Windows para ejecutar la interfaz WinForms.
- Visual Studio con la carga de trabajo **Desarrollo de escritorio de .NET**.
- El SDK o paquete de destino correspondiente a la versión de .NET declarada en el archivo `.csproj`.

La versión requerida se puede consultar en las propiedades del proyecto o en `TargetFramework` / `TargetFrameworkVersion` del `.csproj`, según el tipo de proyecto.

1. Clonar o descargar el repositorio.
2. Abrir su solución en Visual Studio. Si no hay un archivo de solución, abrir el `.csproj`.
3. Establecer la aplicación WinForms como proyecto de inicio si es necesario.
4. Compilar la solución.
5. Ejecutar con **F5** o **Ctrl + F5**.

## Uso de la aplicación

1. Ingresar una temperatura en el control numérico.
2. Elegir qué observadores estarán suscriptos mediante las casillas.
3. Presionar **Publicar temperatura**.
4. Observar cómo reacciona cada panel suscripto.

Las casillas comienzan marcadas y el formulario realiza las suscripciones iniciales. Desmarcar una casilla quita ese observador de futuras publicaciones.

**Desuscribir no borra el panel ni su último valor.** Volver a suscribirlo tampoco lo actualiza inmediatamente: en esta implementación, recibirá la próxima publicación.

## Recorrido de una notificación

1. El evento del botón lee `nudTemperatura.Value`.
2. El formulario llama a `PublicarTemperatura` en el servicio.
3. El servicio ejecuta `Notificar` y obtiene una copia de la colección mediante `ToArray()`.
4. Recorre los observadores e invoca `ActualizarTemperatura` en cada uno.
5. Cada panel ejecuta su implementación del método.

El contrato común es:

```csharp
public interface IObservadorTemperatura
{
    void ActualizarTemperatura(decimal temperaturaCelsius);
}
```

El formulario conecta al sujeto con sus observadores:

```csharp
_temperaturaService.Suscribir(panelCelsius);
_temperaturaService.Suscribir(panelFahrenheit);
_temperaturaService.Suscribir(panelAlerta);
_temperaturaService.Suscribir(panelHistorial);
```

La publicación no contiene llamadas específicas a los paneles:

```csharp
_temperaturaService.PublicarTemperatura(nudTemperatura.Value);
```

## Decisiones de esta implementación

Estas decisiones describen la aplicación y **no son garantías universales del patrón Observer**.

| Decisión | Consecuencia |
| --- | --- |
| Cada llamada publica el valor recibido. | Repetir una temperatura también produce una notificación. |
| La suscripción no envía valores anteriores. | El observador espera la próxima publicación. |
| `Contains` evita agregar otra vez el mismo observador. | En estos controles, sin una redefinición de igualdad, suscribir la misma instancia dos veces no duplica los avisos. |
| El recorrido usa `ToArray()`. | Las modificaciones de la lista durante una notificación no alteran los integrantes de esa copia. |
| El recorrido es síncrono y secuencial. | Un observador debe terminar para que se invoque el siguiente. |
| La publicación parte del hilo de la interfaz. | Un observador lento puede demorar los demás y bloquear temporalmente la ventana. |
| Cada invocación tiene su propio `try/catch`. | Si falla un observador, se registra el error y se intenta continuar. |
| El historial se guarda en el control visual. | No persiste al cerrar la aplicación. |

La copia realizada con `ToArray()` **no hace que el servicio sea seguro para accesos concurrentes**. Si se publicara desde otros hilos, habría que resolver tanto la sincronización del servicio como el acceso a los controles de WinForms.

### Manejo de errores

El `try/catch` está dentro del `foreach` para aislar el error de cada invocación. El registro mediante `Trace.TraceError` incluye el tipo del observador, la temperatura y la excepción.

Esto no reintenta la notificación fallida, no revierte las reacciones anteriores y no garantiza que todos los paneles terminen actualizados.

Los mensajes pueden verse durante la depuración en la ventana **Salida**, según la configuración de `TRACE` y los listeners. `Trace.TraceError` por sí solo no configura un archivo de logs.

## Guion de demostración

### Suscripción y desuscripción

Comenzar con todos los observadores suscriptos:

| Paso | Acción | Celsius | Fahrenheit |
| --- | --- | --- | --- |
| 1 | Publicar `25`. | 25 °C | 77 °F |
| 2 | Desuscribir Fahrenheit y publicar `30`. | 30 °C | Conserva 77 °F |
| 3 | Volver a suscribir Fahrenheit. | Conserva 30 °C | Conserva 77 °F |
| 4 | Publicar `30` nuevamente. | 30 °C | 86 °F |

La cantidad de decimales y el separador decimal dependen del formato del control y de la configuración regional.

### Regla de alerta

Con el panel de alertas suscripto, publicar `35`, `36` y `25`:

- `35`: dentro del umbral.
- `36`: alerta de temperatura alta.
- `25`: vuelve al estado dentro del umbral.

La condición es `temperaturaCelsius > 35m`. El panel recibe todas las publicaciones mientras está suscripto, aunque la temperatura no active una alerta.

### Independencia de los observadores

Desuscribir todos los paneles excepto el historial y publicar varias temperaturas. Solo el historial debe agregar entradas. No depende del panel Celsius para recibir el dato.

### Fallo controlado, opcional

Para demostrar el `try/catch`, se puede agregar temporalmente este bloque al principio de `PanelCelsius.ActualizarTemperatura`, antes de actualizar la etiqueta:

```csharp
if (temperaturaCelsius == 99m)
{
    throw new System.InvalidOperationException(
        "Fallo simulado en el observador Celsius.");
}
```

Con todos los observadores suscriptos, publicar primero `25` y después `99`:

- Celsius conserva 25 °C porque falla antes de modificar su etiqueta.
- Fahrenheit muestra 210,2 °F.
- Alertas indica temperatura alta.
- El historial agrega una entrada con 99 °C.
- El error se registra mediante `Trace`.

Si el depurador se detiene en el `throw`, continuar la ejecución para que se alcance el `catch`. **Retirar el fallo simulado al terminar la prueba.** No representa una validación real de temperatura.

## Cómo agregar otro observador

1. Crear una clase o un nuevo `UserControl`.
2. Implementar `IObservadorTemperatura`.
3. Definir su reacción en `ActualizarTemperatura`.
4. Suscribir la instancia desde el código que conecta los objetos.
5. Desuscribirla cuando ya no deba recibir notificaciones.

No es necesario modificar el bucle de notificación de `TemperaturaService` ni el evento del botón para incorporar al nuevo destinatario. Si el observador es visual, también hay que agregarlo al formulario.

## Ventajas y límites

**Ventajas:** el emisor utiliza un contrato común, las reacciones quedan separadas y los interesados pueden cambiar durante la ejecución.

**Límites:** hay que gestionar las suscripciones, el flujo resulta menos explícito que una secuencia de llamadas directas y un observador puede consumir tiempo o fallar. Si un sujeto vive más que sus observadores, mantener referencias a objetos que ya no se necesitan puede impedir que el recolector los libere.

Los observadores deberían funcionar sin depender de que otro reciba la notificación antes. Aunque esta implementación recorre una lista en orden, no conviene utilizarlo para establecer dependencias de negocio entre paneles.

Observer es útil cuando varios componentes deben reaccionar a un mismo cambio y sus destinatarios pueden variar. Una interacción única y fija puede resolverse con una llamada directa. Para operaciones que exigen confirmación, reintentos, persistencia o una transacción conjunta, esta demo necesita mecanismos adicionales.

## Relación con C# y .NET

Usamos una interfaz propia para hacer visibles los roles y la colección de observadores. .NET también ofrece otras formas de expresar notificaciones:

- **`event` y delegados:** permiten registrar manejadores de eventos. Los eventos del botón y las casillas pertenecen a la interfaz WinForms.
- **`IObservable<T>` e `IObserver<T>`:** proporcionan contratos estándar para flujos de notificaciones, con `OnNext`, `OnError` y `OnCompleted`.

No es obligatorio usar esas interfaces estándar para implementar el patrón. Tampoco el uso de eventos implica automáticamente ejecución en segundo plano.

## Preguntas para preparar la exposición

| Pregunta | Respuesta breve |
| --- | --- |
| ¿Alcanza con implementar la interfaz? | No. La instancia también debe estar suscripta. |
| ¿Qué pasa si no hay observadores? | El recorrido no ejecuta ninguna iteración. |
| ¿Quién conoce los paneles concretos? | El formulario que los conecta. El servicio trabaja con la interfaz. |
| ¿Desuscribir borra el último valor? | No. En esta demo solo quita al panel de futuras publicaciones. |
| ¿Volver a suscribir recupera lo anterior? | No en nuestra implementación. |
| ¿El sujeto sabe qué hace cada observador? | No. Solo conoce el método del contrato. |
| ¿Las notificaciones son asíncronas? | No. Nuestro `foreach` es síncrono y secuencial. |
| ¿Qué sucede si un observador falla? | El `catch` registra el error y permite intentar notificar a los siguientes. |
| ¿`ToArray()` resuelve la concurrencia? | No. Obtiene una copia para el recorrido, pero no sincroniza accesos entre hilos. |
| ¿El historial persiste entre ejecuciones? | No. Se mantiene únicamente en memoria. |

## Referencias

- [Microsoft Learn: Observer design pattern](https://learn.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern)
- [Microsoft Learn: Observer design pattern best practices](https://learn.microsoft.com/en-us/dotnet/standard/events/observer-design-pattern-best-practices)
- [Microsoft Learn: Events in C#](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/events/)

Las fuentes describen conceptos y contratos de .NET. El manejo de excepciones, el umbral, el historial y las reglas de suscripción de esta aplicación son decisiones del ejemplo educativo.
