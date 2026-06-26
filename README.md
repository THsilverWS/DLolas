# 🥐 Panadería y Pastelería D'Lola - Sistema de Gestión Realtime

¡Bienvenido al repositorio oficial de **D'Lola**! Este es un sistema de escritorio robusto desarrollado en **C# (Windows Forms)** diseñado para automatizar y controlar el flujo de inventario, la gestión de personal y el procesamiento de ventas en tiempo real, utilizando **Firebase Realtime Database** como núcleo en la nube.

---

## 🚀 Características Principales

El sistema está dividido en módulos estratégicos pensados para la eficiencia del negocio:

### 📊 Dashboard Administrativo

* Panel de control con métricas en tiempo real.
* Alertas automáticas de stock crítico y stock bajo.
* Visualización rápida del estado general del negocio.

### 🛒 Control de Pedidos y Ventas

* Sincronización inmediata con Firebase Realtime Database.
* Gestión de pedidos en tiempo real.
* Actualización de estados de venta.
* Registro y monitoreo de ventas diarias.

### 👤 Módulo de Perfil Seguro

* Actualización optimizada mediante operaciones parciales (`PatchAsync`).
* Validaciones estrictas para nombres, direcciones y teléfonos.
* Gestión segura de la información del usuario.

### 🔐 Seguridad y Roles

* Control de acceso basado en roles.
* Diferenciación de permisos entre Administradores y Vendedores.
* Reglas de seguridad implementadas en Firebase.

---

# 👥 Colaboradores

<a href="https://github.com/THsilverWS" title="THsilverWS (Desarrollador Principal)">
  <img src="https://github.com/THsilverWS.png" width="80px;" style="border-radius:50%;" alt="THsilverWS"/>
</a>
<a href="https://github.com/JuarezDKNN" title="JuarezDKNN (QA & Bug Fixing)">
  <img src="https://github.com/JuarezDKNN.png" width="80px;" style="border-radius:50%;" alt="JuarezDKNN"/>
</a>
<a href="https://github.com/alialii07" title="alialii07 (Testing)">
  <img src="https://github.com/alialii07.png" width="80px;" style="border-radius:50%;" alt="alialii07"/>
</a>

### 🛠️ Roles y Responsabilidades

* **THsilverWS** - Desarrollador Principal  
    *Responsable de la arquitectura base del sistema, diseño asíncrono y la integración completa con Firebase.*
* **JuarezDKNN** - Colaborador / Bug Fixing  
    *Encargado de la detección de excepciones, depuración de código en tiempo real y resolución de conflictos de stock.*
* **alialii07** - Colaborador en Pruebas  
    *Responsable de la fase de pruebas de caja negra, validación de formularios y simulación de concurrencia de ventas.*

---

> 📌 **Nota sobre el Trabajo en el Repositorio:**
> El desarrollo de este ecosistema se gestionó de forma híbrida para agilizar las entregas académicas antes de centralizarlo en GitHub. Parte del equipo trabajó de manera local descomprimiendo y editando módulos específicos del archivo de solución `.sln`. Posteriormente, estos cambios externos fueron integrados, validados y fusionados manualmente por los desarrolladores principales directamente en este repositorio remoto para asegurar una única versión estable.

---

## 🔧 Configuración e Instalación (Paso a Paso)

Para descargar, compilar y probar el proyecto de manera local, sigue detalladamente estas instrucciones.

### 1. Clonar el repositorio

Abre tu terminal (Git Bash, CMD o PowerShell) en la carpeta donde desees guardar el proyecto y ejecuta:

```bash
git clone https://github.com/THsilverWS/DLolas.git
cd DLolas
```

---

## 2. Requisitos de Entorno e IDE

Antes de ejecutar el proyecto, asegúrate de contar con los siguientes requisitos:

### IDE Recomendado

* Visual Studio 2026.

### Plataforma de desarrollo

* .NET 10.

> **Nota de compatibilidad:**
> No se garantiza el correcto funcionamiento ni ha sido probado en Visual Studio 2022, dado que este último carece del soporte nativo para los componentes actualizados de .NET 10 requeridos por las librerías utilizadas en el sistema.

---

## 3. Cómo abrir y ejecutar el proyecto en Visual Studio

### Paso 1: Abrir Visual Studio

Inicia Visual Studio 2026 en tu computadora.

### Paso 2: Abrir la solución

En la ventana principal selecciona:

**"Abrir un proyecto o una solución"** (*Open a project or solution*).

### Paso 3: Buscar el proyecto

Navega hasta la carpeta donde clonaste el repositorio:

```text
DLolas
```

Selecciona el archivo con extensión **.sln** y haz clic en **Abrir**.

### Paso 4: Restaurar dependencias

Espera a que Visual Studio cargue completamente la estructura del proyecto.

Si el IDE lo solicita, acepta la restauración automática de paquetes NuGet necesarios para el funcionamiento de Firebase y demás dependencias.

### Paso 5: Ejecutar la aplicación

Haz clic en:

```text
▶ Iniciar
```

o presiona:

```text
F5
```

Visual Studio compilará automáticamente la solución y ejecutará la aplicación.

---

## 🏗️ Arquitectura del Sistema

El sistema está construido bajo una arquitectura orientada a servicios y sincronización en tiempo real utilizando Firebase como backend principal.

### Componentes principales

* Aplicación de escritorio Windows Forms.
* Firebase Realtime Database.
* Firebase Authentication.
* Gestión de inventario.
* Gestión de usuarios.
* Gestión de pedidos.
* Gestión de ventas.
* Sistema de alertas de stock.

---

## 📦 Dependencias Utilizadas

El proyecto utiliza las siguientes tecnologías y bibliotecas:

* C#
* Windows Forms
* Firebase Realtime Database
* Firebase Authentication
* .NET 10

Las dependencias se restaurarán automáticamente mediante NuGet al abrir la solución.


---

## 🔥 Integración con Firebase

El sistema utiliza Firebase Realtime Database para:

* Almacenamiento centralizado de información.
* Actualización de datos en tiempo real.
* Sincronización de ventas y pedidos.
* Gestión de inventario.
* Gestión de usuarios y roles.

Además, se implementan reglas de seguridad para garantizar que cada usuario acceda únicamente a las funciones autorizadas según su rol.

---

## ✅ Verificación de Ejecución

Si la instalación fue correcta:

1. La aplicación iniciará sin errores de compilación.
2. Se mostrará la pantalla de inicio de sesión.
3. El sistema establecerá conexión con Firebase Realtime Database.
4. Los datos se sincronizarán automáticamente en tiempo real.

---

## 📝 Licencia

Este proyecto es de uso académico y educativo.

Todos los derechos reservados © D'Lola.

---

## 💡 Soporte

Si encuentras errores, deseas reportar un problema o proponer mejoras:

1. Abre un Issue en GitHub.
2. Describe detalladamente el problema.
3. Adjunta capturas de pantalla si es necesario.
4. Indica la versión del sistema utilizada.

---

### 🥐 D'Lola — Sistema Inteligente de Gestión para Panadería y Pastelería

Desarrollado con C#, Windows Forms y Firebase Realtime Database.
