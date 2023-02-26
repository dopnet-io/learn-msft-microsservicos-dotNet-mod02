#! /bin/bash

# Caso seu linux não tenha instalado o WGET:
sudo apt install wget && \
wget https://dot.net/v1/dotnet-install.sh && \
chmod +x dotnet-install.sh && \

# Adicione o repositório (ubuntu 22.04):
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
&& \
# Instala o apk:
sudo dpkg -i packages-microsoft-prod.deb
&& \
# Remove o apk:
rm packages-microsoft-prod.deb
&& \
# Execute a atualização e também instale a ferramenta para suporte a HTTPS
sudo apt update && \
sudo apt install -y apt-transport-https
