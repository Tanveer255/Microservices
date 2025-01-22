README: Running .NET Core 8.0 Microservices with Kubernetes and Docker

Overview

This guide provides instructions to set up, run, and monitor a microservices architecture based on .NET Core 8.0. The solution includes the following services:

AuthService: Handles authentication and authorization.

ProductService: Manages product-related data.

DocsService: Manages documentation-related operations.

CRMService: Handles customer relationship management functionalities.

Each service is containerized using Docker and deployed with Kubernetes with linux operating system. Health status checks and secure communication between services are included.

Prerequisites

Tools and Dependencies
and change the connection string in the appsettings.json file in each service to point to the database server.
set your server-name,username and password for each service 
and run command in console manager update-database to create the database in the service.

.NET Core 8.0 SDK

Docker

install docker desktop and enable kubernetes in docker desktop
and create network in docker desktop with name microservice_default
if you are using visualstudio you can use docker-compose to run the services.
got to tools select comanline and run the command 
```
docker-compose up
```
to run the services.

each service is based on .net core 8.0 with three tire architecher data acess layer,business logic layer,and interface .


Folder Structure

root
|-- AuthService
|-- ProductService
|-- DocsService
|-- CRMService
|-- docker-compose.yml
|-- k8s
    |-- auth-deployment.yaml
    |-- product-deployment.yaml
    |-- docs-deployment.yaml
    |-- crm-deployment.yaml
    |-- gateway-deployment.yaml
|-- README.md

Step-by-Step Guide

1. Build Docker Images

Each microservice contains a Dockerfile to build its respective image.

Run the following command in each microservice directory:

docker build -t <your-dockerhub-username>/<service-name>:latest .

Push the images to Docker Hub:

docker push <your-dockerhub-username>/<service-name>:latest

2. Run Locally with Docker Compose

Use docker-compose.yml to run all services locally:

here is the docker-compose.yml file
```
services:
  # ocelot-gateway:
  ocelot-gateway:
    build:
      context: .
      dockerfile: OcelotGateWay/Dockerfile
    container_name: ocelot-gateway
    ports:
      - "8081:8080"
    networks:
      - microservice_default
    environment:
      - ASPNETCORE_URLS=http://0.0.0.0:8081/
      - ASPNETCORE_ENVIRONMENT=Development

  # auth-server:
  auth-server:
    build:
      context: .
      dockerfile: AuthServer/Dockerfile
    container_name: auth-server
    ports:
      - "8082:8080"
    networks:
      - microservice_default
    environment:
      - ASPNETCORE_URLS=http://0.0.0.0:8082/
      - ASPNETCORE_ENVIRONMENT=Development
     # - ConnectionStrings__DefaultConnection=Server=127.0.0.1;Port=3306;Database=microservice_AuthServer_dev_db;User=microservice;Password=ko7Mar^e8cAQc;
     
      # Use root/example as user/password credentials
  auth-server-db:
    image: mysql:latest
    restart: always
    container_name: auth-server-db
    environment:
      MYSQL_ROOT_PASSWORD: Letmein123$
      MYSQL_DATABASE: microservice_AuthServer_dev_db
      MYSQL_USER: microservice
      MYSQL_PASSWORD: ko7Mar^e8cAQc
    ports:
      - "3306:3306"
    volumes:
      - db_data:/var/lib/mysql
 # service-interface:
  service-interface:
    build:
      context: .
      dockerfile: CRM/Dockerfile
    container_name: service-interface
    ports:
      - "8083:8080"
    networks:
      - microservice_default
    environment:
      - ASPNETCORE_URLS=http://0.0.0.0:8083/
      - ASPNETCORE_ENVIRONMENT=Development
  #     - ConnectionStrings__DefaultConnection=Server=service-interface-db;Database=microservice_CRM_db_dev;User Id=microservice;Password=123456789;MultipleActiveResultSets=True;TrustServerCertificate=True;


  # docs-server:
  docs-server:
    build:
      context: .
      dockerfile: DocsServer/Dockerfile
    container_name: docs-server
    ports:
      - "8084:8080"
    networks:
      - microservice_default
    environment:
      - ASPNETCORE_URLS=http://0.0.0.0:8084/
      - ASPNETCORE_ENVIRONMENT=Development
  #     - ConnectionStrings__DefaultConnection=Server=docsServer-db;Database=microservice_DocsServer_db_dev;User Id=microservice;Password=123456789;MultipleActiveResultSets=True;TrustServerCertificate=True;

  product-server:
    build:
      context: .
      dockerfile: ProductServer/Dockerfile
    container_name: product-server
    ports:
      - "8085:8080"
    networks:
      - microservice_default
    environment:
      - ASPNETCORE_URLS=http://0.0.0.0:8085/
      - ASPNETCORE_ENVIRONMENT=Development
      - ConnectionStrings__DefaultConnection=Server=productServer-db;Database=microservice_ProductServer_db_dev;User Id=microservice;Password=123456789;MultipleActiveResultSets=True;TrustServerCertificate=True;

  # Use a Linux-based SQL Server image:
  productServer-db:
    image: mcr.microsoft.com/mssql/server:2022-latest
    container_name: productServer-db
    ports:
      - "1437:1433"
    networks:
      - microservice_default
    environment:
      - ACCEPT_EULA=Y
      - SA_PASSWORD=StrongPassword!123
      - MSSQL_PID=Developer
  microservice-app:
    build:
      context: ./microservice-app 
      dockerfile: Dockerfile
    container_name: microservice-app
    ports:
      - "64125:64125"
    volumes:
      - ./microservice-app:/app  # Map only the 'microservice-app' folder to '/app'
      - /app/node_modules  # Prevent overwriting node_modules
    environment:
      NODE_ENV: development
    command: ["npm", "run", "dev", "--", "--host"]
#network
networks:
  microservice_default:
    external: true
#volumes
volumes:
  db_data:
```

4. Set Up API Gateway

Use Ocelot as the API Gateway. Configure routes for each microservice.

use common path for all services and use the same path in the gateway.
which define as global configuration in the ocelot.json file.
```
https://localhost:7121/your-api-path
```
ocelot.json:

```
{
  "Routes": [
    // ==========================
    // Auth Service Routes
    // ==========================
    {
      "DownstreamPathTemplate": "/api/users/login",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5228
        }
      ],
      "UpstreamPathTemplate": "/users/login",
      "UpstreamHttpMethod": [ "POST" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    {
      "DownstreamPathTemplate": "/api/users",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5228
        }
      ],
      "UpstreamPathTemplate": "/users",
      "UpstreamHttpMethod": [ "GET" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    // ==========================
    // CRM Service Routes
    // ==========================
    {
      "DownstreamPathTemplate": "/api/contacts/{everything}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5295
        }
      ],
      "UpstreamPathTemplate": "/contacts/{everything}",
      "UpstreamHttpMethod": [ "GET", "POST", "PUT", "DELETE" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    // ==========================
    // Document Service Routes
    // ==========================
    {
      "DownstreamPathTemplate": "/api/saleOrders/{everything}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5280
        }
      ],
      "UpstreamPathTemplate": "/saleOrders/{everything}",
      "UpstreamHttpMethod": [ "GET", "POST", "PUT", "DELETE" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    {
      "DownstreamPathTemplate": "/api/customsDeclarations/{everything}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5280
        }
      ],
      "UpstreamPathTemplate": "/customsDeclarations/{everything}",
      "UpstreamHttpMethod": [ "GET", "POST", "PUT", "DELETE" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    {
      "DownstreamPathTemplate": "/api/instalationOrders/{everything}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5280
        }
      ],
      "UpstreamPathTemplate": "/instalationOrders/{everything}",
      "UpstreamHttpMethod": [ "GET", "POST", "PUT", "DELETE" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    {
      "DownstreamPathTemplate": "/api/Orders/{everything}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5280
        }
      ],
      "UpstreamPathTemplate": "/Orders/{everything}",
      "UpstreamHttpMethod": [ "GET", "POST", "PUT", "DELETE" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    {
      "DownstreamPathTemplate": "/api/PackingLists/{everything}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5280
        }
      ],
      "UpstreamPathTemplate": "/PackingLists/{everything}",
      "UpstreamHttpMethod": [ "GET", "POST", "PUT", "DELETE" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    // ==========================
    // Product Service Routes
    // ==========================
    {
      "DownstreamPathTemplate": "/api/products/{everything}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5000
        }
      ],
      "UpstreamPathTemplate": "/products/{everything}",
      "UpstreamHttpMethod": [ "GET", "POST", "PUT", "DELETE" ],
      "RetryOptions": {
        "Attempts": 3,
        "Interval": 1000
      }
    },
    // ==========================
    // SWAN Service Routes
    // ==========================
    {
      "DownstreamPathTemplate": "/api/company/{everything}",
      "DownstreamScheme": "http",
      "DownstreamHostAndPorts": [
        {
          "Host": "localhost",
          "Port": 5058
        }
      ],
      "UpstreamPathTemplate": "/company/{everything}",
      "UpstreamHttpMethod": [ "GET", "POST", "PUT", "DELETE" ]
    }


  ],

  "GlobalConfiguration": {
    "BaseUrl": "https://localhost:7121",
    "Cors": {
      "AllowAnyOrigin": false,
      "AllowedOrigins": [ "http://localhost:58763" ],
      "AllowAnyMethod": true,
      "AllowAnyHeader": true
    }
  }

}
```

Deploy the gateway:

kubectl apply -f k8s/gateway-deployment.yaml

5. Health Checks

Add health checks to each service in the Program.cs file:

builder.Services.AddHealthChecks();

app.MapHealthChecks("/health");

Check the health of a service:
authservice :curl http://localhost:5228/health
CRMService: curl http://http://localhost:5295/health
DocsService:curl http://http://localhost:5280/health
ProductService:curl http://http://localhost:5000/health

Authentication and Authorization

AuthService is responsible for issuing JWT tokens.
its a good practice to and used as shared tocken and health check service for all services.
if you want to use it as a shared service you can use it as a shared service and use it as a shared service for all services. just add the JwtAuthentication liberary in your services and add the following code in your program.cs.
```
builder.Services.AddScoped<IJwtAuthenticationService, JwtAuthenticationService>();
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
// and also addthe following pipeline in your program.cs
// Configure the HTTP request pipeline.
app.UseAuthentication(); // Ensure authentication middleware is before authorization
app.UseAuthorization();  // Authorization middleware
```

Protect routes in other services by validating JWT tokens.

Example Middleware for JWT Validation:

```// Add JWT Authentication using IOptions<JwtSettings>
builder.Services.AddAuthentication(auth =>
{
    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    // Use IOptions<JwtSettings> to get the settings
    var jwtSettings = builder.Services.BuildServiceProvider().GetRequiredService<IOptions<JwtSettings>>().Value;

    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = jwtSettings.Audience,
        ValidIssuer = jwtSettings.Issuer,
        RequireExpirationTime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey)),
        ValidateIssuerSigningKey = true
    };
});
app.UseAuthentication(); // Ensure authentication middleware is before authorization
app.UseAuthorization();  // Authorization middleware

```

Cleanup

To remove all Kubernetes resources:

kubectl delete -f k8s/

Notes

Ensure proper logging and monitoring (e.g., with Prometheus and Grafana).

Use a CI/CD pipeline for automated builds and deployments.

Configure secrets securely using Kubernetes Secrets or an external secret manager.

Contact

For any issues or contributions, contact the development team.

