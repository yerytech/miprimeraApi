# MiPrimeraApi

Una API REST construida con **ASP.NET Core 9.0** y **Entity Framework Core** para la gestión de usuarios. Esta aplicación implementa operaciones CRUD completas utilizando SQLite como base de datos.

## 🚀 Características

- **ASP.NET Core 9.0**: Framework web moderno y de alto rendimiento
- **Entity Framework Core**: ORM para acceso a datos con SQLite
- **Swagger/OpenAPI**: Documentación interactiva de la API
- **Operaciones CRUD**: Crear, leer, actualizar y eliminar usuarios
- **Arquitectura RESTful**: Endpoints siguiendo las mejores prácticas REST

## 📋 Estructura del Proyecto

```
MiPrimeraApi/
├── Controllers/
│   └── UsuariosController.cs    # Controlador principal para usuarios
├── Data/
│   └── AppDbContext.cs          # Contexto de Entity Framework
├── Models/
│   └── Usuario.cs               # Modelo de datos de usuario
├── Migrations/                  # Migraciones de base de datos
└── usuarios.db                  # Base de datos SQLite
```

## 🛠️ Tecnologías Utilizadas

- **.NET 9.0**
- **ASP.NET Core**
- **Entity Framework Core**
- **SQLite**
- **Swagger/OpenAPI**

## 📊 Modelo de Datos

### Usuario

```csharp
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
}
```

## 🔗 Endpoints de la API

| Método   | Endpoint         | Descripción                    |
| -------- | ---------------- | ------------------------------ |
| `GET`    | `/Usuarios`      | Obtiene todos los usuarios     |
| `GET`    | `/Usuarios/{id}` | Obtiene un usuario por ID      |
| `POST`   | `/Usuarios`      | Crea un nuevo usuario          |
| `PUT`    | `/Usuarios/{id}` | Actualiza un usuario existente |
| `DELETE` | `/Usuarios/{id}` | Elimina un usuario             |

## 🚀 Cómo ejecutar

1. **Clonar el repositorio**

   ```bash
   git clone <url-del-repositorio>
   cd MiPrimeraApi
   ```

2. **Restaurar dependencias**

   ```bash
   dotnet restore
   ```

3. **Ejecutar la aplicación**

   ```bash
   dotnet run
   ```

4. **Acceder a Swagger UI**
   - Abrir navegador en: `https://localhost:5001/swagger` o `http://localhost:5000/swagger`

## 📝 Ejemplos de Uso

### Crear un nuevo usuario

```json
POST /Usuarios
Content-Type: application/json

{
    "nombre": "Juan Pérez",
    "email": "juan.perez@email.com"
}
```

### Obtener todos los usuarios

```json
GET /Usuarios
```

### Actualizar un usuario

```json
PUT /Usuarios/1
Content-Type: application/json

{
    "nombre": "Juan Carlos Pérez",
    "email": "juan.carlos@email.com"
}
```

## 🗄️ Base de Datos

La aplicación utiliza **SQLite** como base de datos, con Entity Framework Core para el mapeo objeto-relacional. La base de datos se crea automáticamente al ejecutar la aplicación por primera vez.

## 📋 Requisitos

- **.NET 9.0 SDK**
- **SQLite** (incluido automáticamente)

## 🔧 Configuración

Las configuraciones de la aplicación se encuentran en:

- `appsettings.json`: Configuración general
- `appsettings.Development.json`: Configuración específica para desarrollo

## 🤝 Contribuir

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request
