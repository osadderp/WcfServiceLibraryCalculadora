# WcfServiceLibraryCalculadora
Taller de Docker

Este repositorio es un taller de la Materia Modelado y Validación de Arquitectura de la Universidad Javeriana
Presentado al profesor German Alonso Suárez Guerrero.

Indicaciones del taller:

Crear un servicio que retorne la suma de 2 números (El servicio puede ser implementado en cualquier lenguaje de programación. Debe ser SOAP o REST). El servicio debe ser desplegado en una imagen Docker para su consumo.
Publicar el código en GitHub/GitLab
Agregar como parte del código la imagen docker (Dockerfile)
Publicar la imagen Docker en Docker Hub
Agregar como parte del código los scripts que permitan crear/destruir la imagen docker de manera local. Estos archivos deben ser llamados start.sh y stop.sh
Agregar la documentación para consuimir el servicio en GitHub (README)
Utilizar las etiquetas (tags) UJaveriana, AES, ModVal en las descripciones de GitHub/GitLab y DockerHub

Dentro de la carpeta que contiene los fuentes se encuentra el archivo Dockerfile.

Ejecutar el archivo start.sh para poder bajar la imagen a utilizar de Docker Hub y que esta se inicialice.

Utilizar la siguiente sentencia para identificar cual es la IP generada para la ejecucion del servicio de calculadora.
docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" my-running-site
Ya identificada la IP reemplazarla en la siguiente sentencia donde estan las xxx
http://xxx.xxx.xxx.xxx:83/WcfServiceLibraryCalculadora.ServiceCalculadora.svc?wsdl

Por ejemplo
docker inspect -f "{{ .NetworkSettings.Networks.nat.IPAddress }}" my-running-site
172.23.214.9 
La ip indicada se reemplaza en la sentencia quedando de la siguiente manera
http://172.23.214.9:83/WcfServiceLibraryCalculadora.ServiceCalculadora.svc?wsdl

Esta ruta del servicio se puede consumir con SoapUI para su porsterior verificacion o cualquier otro de su preferencia.

Ejecutar el archivo stop.sh para detener la ejecucion y posterior eliminacion de esta.

El servico de calculadora suma dos numeros enteros.
