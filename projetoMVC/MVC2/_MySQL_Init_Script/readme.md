Nessa pasta foi criado um script para inserir/popular o banco de dados. Esse método é melhor que o Migrate()/EnsureCreated(), pois é mais segura e pode ser revisado pelo DBA.

Incluir o mapeamento do arquivo de Script Mysql.

- .MySQL_Init_Script:/docker-entrypoint-initdb.d

Documentação MySQL:

https://hub.docker.com/_/mysql

remover ou comentar no Programan.cs a linha

```c#

PopulaDb.CreateDBIfNotExists(app);
```