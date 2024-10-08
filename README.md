## Objetivo do Projeto

Nosso projeto visa desenvolver um **Sistema de Recomenda��o para Tratamentos Preventivos** no setor odontol�gico, ajudando a reduzir custos e fraudes, al�m de melhorar a qualidade no atendimento aos pacientes. O sistema ser� respons�vel por gerenciar dados de pacientes, tratamentos realizados e sinistros. A partir dessas informa��es, ele vai sugerir tratamentos preventivos personalizados, ajudando os profissionais de sa�de a serem mais proativos e a evitar poss�veis complica��es futuras para os pacientes.

## Escopo

O projeto contempla o desenvolvimento de um sistema completo com as seguintes funcionalidades principais:

- **Cadastro de Pacientes**: O sistema permitir� o gerenciamento de dados como nome, e-mail, telefone, endere�o, entre outras informa��es pessoais.
- **Gerenciamento de Tratamentos**: Ser�o registrados e administrados os tratamentos odontol�gicos oferecidos, incluindo descri��es detalhadas, tipos de tratamento e custos associados.
- **Controle de Sinistros**: O sistema far� o acompanhamento de sinistros relacionados a tratamentos, registrando valores reembolsados, status e outras informa��es relevantes.
- **Recomenda��es Preventivas**: O sistema fornecer� recomenda��es de tratamentos preventivos com base no hist�rico do paciente e nos sinistros que ele j� enfrentou, ajudando a evitar futuros problemas.
- **Painel de Controle**: Haver� uma interface web responsiva, desenvolvida em **MVC** com **Bootstrap**, para facilitar o uso e a gest�o de todas as funcionalidades mencionadas.
- **API Documentada**: A aplica��o integrar� a **Swagger** para facilitar a documenta��o e o uso das APIs pelos desenvolvedores.

## Requisitos Funcionais e N�o Funcionais

### Requisitos Funcionais:

1. O sistema deve permitir o cadastro, edi��o e exclus�o de pacientes, com dados detalhados como nome, e-mail, telefone e endere�o.
2. Deve ser poss�vel gerenciar tratamentos odontol�gicos, incluindo informa��es sobre o tipo de tratamento e seu custo.
3. O sistema deve registrar e acompanhar os sinistros ocorridos, com controle sobre valores reembolsados e o status de cada caso.
4. A aplica��o deve gerar recomenda��es autom�ticas de tratamentos preventivos baseados nos dados hist�ricos dos pacientes e nos sinistros registrados.
5. A interface web deve ser f�cil de usar, acess�vel e responsiva, para garantir uma boa experi�ncia de uso em diferentes dispositivos.
6. O banco de dados ser� o **MySQL**, integrando-se � aplica��o via **Entity Framework Core**, garantindo que todas as opera��es de persist�ncia e consulta de dados sejam eficientes.
7. Todas as opera��es relacionadas a dados devem ser ass�ncronas, para otimizar o desempenho da aplica��o e evitar bloqueios.

### Requisitos N�o Funcionais:

1. O sistema ser� desenvolvido com **.NET Core**, utilizando uma arquitetura limpa, que garante a separa��o adequada das responsabilidades e facilita a manuten��o futura.
2. **MySQL** ser� o banco de dados escolhido, com o **Entity Framework Core** atuando como ORM (Object-Relational Mapping).
3. A interface seguir� o padr�o **MVC** e ser� constru�da com **Bootstrap** para garantir que o sistema seja visualmente agrad�vel e funcione bem em qualquer dispositivo.
4. A seguran�a ser� tratada com seriedade, utilizando **HTTPS** para proteger a comunica��o, al�m de implementar autentica��o e autoriza��o para controlar o acesso aos dados sens�veis.
5. O sistema precisa ser escal�vel e de f�cil manuten��o, com suporte a **migra��es de banco de dados** para permitir futuras expans�es ou modifica��es no esquema dos dados.
6. Todo o c�digo ser� adequadamente documentado e testado. Para a documenta��o da API, utilizaremos **Swagger**, que facilitar� o uso e a integra��o com outros sistemas.
