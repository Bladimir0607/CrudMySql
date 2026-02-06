# 🚀 CRUD API con C# y MySQL

📘 **Proyecto académico** que implementa un CRUD (Create, Read, Update, Delete) utilizando  
**ASP.NET Core Web API**, **Entity Framework Core** y **MySQL**, aplicando buenas prácticas de desarrollo backend.

---

## 🧠 Objetivo del proyecto
Desarrollar una **API REST funcional** para la gestión de tareas, reforzando conocimientos en:
- Arquitectura backend
- Persistencia de datos con MySQL
- Entity Framework Core (Code First)
- Uso de Swagger para documentación y pruebas

---

## 🛠️ Tecnologías utilizadas

### 🔹 Lenguaje & Framework
- 💻 **C#**
- 🌐 **ASP.NET Core Web API**

### 🔹 Base de datos
- 🐬 **MySQL**
- 🔄 **Entity Framework Core**

### 🔹 Herramientas
- 📘 **Swagger (OpenAPI)**
- 🧰 **Visual Studio 2022**
- 🔧 **Git & GitHub**

---

## 🔄 Proceso de desarrollo del CRUD API

El siguiente diagrama muestra el flujo general del sistema, desde la solicitud del cliente hasta la base de datos:

<img width="1024" height="1536" alt="Diagrama de flujo del CRUD API" src="https://github.com/user-attachments/assets/cffc4b3f-574b-413f-aa7d-d25dce62f033" />

---

## 📡 Endpoints disponibles

📌 **Base URL:** `https://localhost:7085`

| Método | Endpoint | Descripción |
|------|---------|------------|
| 🟢 POST | `/api/Tareas` | Crear una nueva tarea |
| 🔵 GET | `/api/Tareas` | Obtener todas las tareas |
| 🟡 PUT | `/api/Tareas/{id}` | Actualizar una tarea |
| 🔴 DELETE | `/api/Tareas/{id}` | Eliminar una tarea |

---

## 📦 Modelo de datos (Tarea)

```json
{
  "id": 1,
  "titulo": "Aprender ASP.NET",
  "estado": "Completada"
}
```

--- 

## ▶️ Ejecución del proyecto:

- ## 1️⃣ Clonar el repositorio:
  - git clone https://github.com/TU_USUARIO/CrudMySql.git
  
- ## 2️⃣ Configurar la base de datos:
  🔹 Editar la cadena de conexión en el archivo:
   - appsettings.json

- ## 3️⃣ Ejecutar migraciones:
  - dotnet ef database update

- ## 4️⃣ Ejecutar el proyecto:
  - Ejecutar el proyecto desde Visual Studio 2022 (Run ▶️).

- ## 5️⃣ Probar la API:
  - Acceder a Swagger desde el navegador para probar los endpoints 🚀
  
---

## 👨‍💻 Desarrollado por
## ✨ Bladimir Antonio Ventura Paniagua
## 🎓 Estudiante de Ingeniería de Software

## 📌 Proyecto académico desarrollado como práctica de
## ASP.NET Core Web API + MySQL + Entity Framework Core

---
## ⭐ Si este proyecto te resulta útil, no olvides dejar una estrella en el repositorio 😉
