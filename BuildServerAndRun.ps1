##Copiar ficheros de la base de datos
$source = "src/Database"
$destino = "Tools/ServerSQL"


Copy-Item -Path $source -Filter "*.sql" -Recurse -Destination $destino -Container -force

##Borrar la imagen vieja
docker rm $(docker stop $(docker ps -a -q --filter ancestor='server-sql' --format="{{.ID}}"))


##NETWORK 2 Containers
docker network create APINET

##construir la imagen
docker build -t server-sql Tools\ServerSQL\.

##iniciar el contenedor ##Terminos y Password
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Passw0rd" -d -p 1433:1433 --net APINET -v C:/Users/a842225/source/repos/CodeFirst-APIRest/APIAsync/APIRestAsync/database/data:/var/opt/mssql/data -v C:/Users/a842225/source/repos/CodeFirst-APIRest/APIAsync/APIRestAsync/database/log:/var/opt/mssql/log -v C:/Users/a842225/source/repos/CodeFirst-APIRest/APIAsync/APIRestAsync/database/secrets:/var/opt/mssql/secrets server-sql 



##Borrar la imagen vieja
docker rm $(docker stop $(docker ps -a -q --filter ancestor='api-async' --format="{{.ID}}"))

##Dockerizar API
docker build -t api-async -f DockerfileCode .

##Iniciar contenedor API
docker run -d -p 5000:5000 -p 5001:5001 -p 8000:80 --net APINET api-async



#DOCKER COMPOSE
##docker-compose up -d