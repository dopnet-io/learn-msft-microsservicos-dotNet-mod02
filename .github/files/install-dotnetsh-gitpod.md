# Baixe o script de instalação do Dotnet

Bem, uma das maneiras mais fáceis de começar com o Dotnet é instalá-lo com o script fornecido oficialmente pela Microsoft. O usuário pode usá-lo para instalar .Net SDK ou Core e .Net Runtime.

$ sudo apt install wget

## Obtenha o roteiro:

$ wget https://dot.net/v1/dotnet-install.sh

## Torne-o executável:

$ chmod +x dotnet-install.sh

# Instação via Package

Adicione o repositório:

$ wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb

$ sudo dpkg -i packages-microsoft-prod.deb

$ rm packages-microsoft-prod.deb

$ sudo apt update
$ sudo apt install -y apt-transport-https

Finalmente, terminamos com o repositório, agora é hora de simplesmente usar o comando do gerenciador de pacotes APT para a instalação do Microsoft dot net.

$ sudo apt install dotnet-sdk-6.0

Considerando que, apenas para o tempo de execução do Asp .Net Core, use:

$ sudo apt-get install aspnetcore-runtime-6.0

E para Only .Net Runtime, este:

$ sudo apt-get install dotnet-runtime-6.0

> OBS : caso prefira baixa o arquivo sh : [script-sh](/workspace/learn-msft-microsservicos-dotNet-mod02/.github/files/install-apk-msf-prod.sh)

### Remova ou desinstale o SDK (opcional)

Para remover o SDK usando a execução do APT:

$ sudo apt remove dotnet-sdk-6.0

# Instale o SDK do .Net Core

O comando fornecido executará o script baixado para instalar a versão mais recente do Dotnet

$ ./dotnet-install.sh -c Current

Considerando que o usuário que está procurando por alguma versão específica pode substituir o 'Current' no comando por isso. Por exemplo, se você deseja instalar a versão .Net versão 5, o comando acima será como:

$ ./dotnet-install.sh -c 5.0

### Nota: 

O caminho de instalação será “/home/$USER/.dotnet“. O $USER é aquele que você usou para executar o script acima. Além disso, você pode adicionar esse caminho à variável do sistema para acessar globalmente a linha de comando dotnet.

> Nota: Substitua $USER pelo seu atual:

$ echo 'export PATH="$PATH:/home/$USER/.dotnet/"' >> ~/.bashrc

Se você não tiver a pasta em seu caminho, receberá “comando dotnet não encontrado no seu ubuntu”. Portanto, para resolver esse usuário, é necessário alternar sua pasta ou precisar mencionar o caminho da pasta toda vez para executá-lo.

Recarregar sessão:

$ newgrp $User