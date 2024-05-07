# Requisitos para rodar o projeto

## Banco de dados:

- Ter instalado o Postgres 15
- Criar um usuario com nome fiapDbUser utilizando a senha fiapAlura
- Criar um Database com o nome tech_challenge_fase_1 pela própria interface do Postgres

## Bibliotecas
Se necessário instalar algum pacote atraves do Nuget. Na imagem abaixo os nomes de todos que foram instalados

![image](https://github.com/rafaxzx/techchallengefase1/assets/39475113/165f357b-8251-45c3-b552-b015e5ffac1c)

## Migrations
Para serem criadas as tabelas de modo a funcionar corretamente, é necessário rodar uma migration, abaixo os comandos necessários de serem usados no **Package Manager Console**

`Add-Migration` e `Update-Database`

Obtendo sucesso nessas etapas o projeto irá funcionar e será possível utilizar o Swagger e até a página HTML criada para listar os contatos de acordo com DDD selecionado
Abaixo o caminho para encontrar o arquivo HTML

![image](https://github.com/rafaxzx/techchallengefase1/assets/39475113/5f754d99-dc87-4933-ac0a-33b9a5e02505)

## Demonstração da página estática consumindo a api

![image](https://github.com/rafaxzx/techchallengefase1/assets/39475113/fe5517e6-d6f1-481a-88e8-8e0d9c13c596)

![image](https://github.com/rafaxzx/techchallengefase1/assets/39475113/10784168-4731-45a8-9053-45bbcfbd3fb5)
