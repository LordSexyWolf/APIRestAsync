from mcr.microsoft.com/mssql/server:2019-latest
COPY . /
USER root
RUN /opt/mssql/bin/mssql-conf set hadr.hadrenabled 1
RUN /opt/mssql/bin/mssql-conf set memory.memorylimitmb 2048