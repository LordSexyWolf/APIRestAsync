##Copiar ficheros de la base de datos
$source = "src/Database"
$destino = "Tools/ServerSQL"

Copy-Item -Path $source -Filter "*.sql" -Recurse -Destination $destino -Container -force

##Borrar la imagen vieja
docker rm $(docker stop $(docker ps -a -q --filter ancestor='server-sql' --format="{{.ID}}"))


##construir la imagen
docker build -t server-sql Tools\ServerSQL\.

##iniciar el contenedor
docker run -d -p 1433:1433 server-sql