FROM ubuntu
WORKDIR /schuldatenbank
COPY . .
CMD "apt-get update"
