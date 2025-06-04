# TdPlusDbContextGestion
Repositorio dedicado para centralizar las clases de mapeo a las tablas de la BD

1.- Crear proyecto de libreria del DbContext:
		dotnet new classlib -n TdPlusDbContextGestion
2.- Se agregan la carpeta Domain e Infraestructure
3.- Configurar dependencias:
		dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
		dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 8.0.0
		dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.0
4.- Publicar la libreria:
		dotnet pack -c Release
		Nota: esta libreria se encuentra en TdPlusDbContext.Gestion\bin\Release\TdPlusDbContextGestion.1.0.0.nupkg
