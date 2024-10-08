## Objetivo do Projeto

Nosso projeto visa desenvolver um **Sistema de Recomendação para Tratamentos Preventivos** no setor odontológico, ajudando a reduzir custos e fraudes, além de melhorar a qualidade no atendimento aos pacientes. O sistema será responsável por gerenciar dados de pacientes, tratamentos realizados e sinistros. A partir dessas informações, ele vai sugerir tratamentos preventivos personalizados, ajudando os profissionais de saúde a serem mais proativos e a evitar possíveis complicações futuras para os pacientes.

## Escopo

O projeto contempla o desenvolvimento de um sistema completo com as seguintes funcionalidades principais:

- **Cadastro de Pacientes**: O sistema permitirá o gerenciamento de dados como nome, e-mail, telefone, endereço, entre outras informações pessoais.
- **Gerenciamento de Tratamentos**: Serão registrados e administrados os tratamentos odontológicos oferecidos, incluindo descrições detalhadas, tipos de tratamento e custos associados.
- **Controle de Sinistros**: O sistema fará o acompanhamento de sinistros relacionados a tratamentos, registrando valores reembolsados, status e outras informações relevantes.
- **Recomendações Preventivas**: O sistema fornecerá recomendações de tratamentos preventivos com base no histórico do paciente e nos sinistros que ele já enfrentou, ajudando a evitar futuros problemas.
- **Painel de Controle**: Haverá uma interface web responsiva, desenvolvida em **MVC** com **Bootstrap**, para facilitar o uso e a gestão de todas as funcionalidades mencionadas.
- **API Documentada**: A aplicação integrará a **Swagger** para facilitar a documentação e o uso das APIs pelos desenvolvedores.

## Requisitos Funcionais e Não Funcionais

### Requisitos Funcionais:

1. O sistema deve permitir o cadastro, edição e exclusão de pacientes, com dados detalhados como nome, e-mail, telefone e endereço.
2. Deve ser possível gerenciar tratamentos odontológicos, incluindo informações sobre o tipo de tratamento e seu custo.
3. O sistema deve registrar e acompanhar os sinistros ocorridos, com controle sobre valores reembolsados e o status de cada caso.
4. A aplicação deve gerar recomendações automáticas de tratamentos preventivos baseados nos dados históricos dos pacientes e nos sinistros registrados.
5. A interface web deve ser fácil de usar, acessível e responsiva, para garantir uma boa experiência de uso em diferentes dispositivos.
6. O banco de dados será o **MySQL**, integrando-se à aplicação via **Entity Framework Core**, garantindo que todas as operações de persistência e consulta de dados sejam eficientes.
7. Todas as operações relacionadas a dados devem ser assíncronas, para otimizar o desempenho da aplicação e evitar bloqueios.

### Requisitos Não Funcionais:

1. O sistema será desenvolvido com **.NET Core**, utilizando uma arquitetura limpa, que garante a separação adequada das responsabilidades e facilita a manutenção futura.
2. **MySQL** será o banco de dados escolhido, com o **Entity Framework Core** atuando como ORM (Object-Relational Mapping).
3. A interface seguirá o padrão **MVC** e será construída com **Bootstrap** para garantir que o sistema seja visualmente agradável e funcione bem em qualquer dispositivo.
4. A segurança será tratada com seriedade, utilizando **HTTPS** para proteger a comunicação, além de implementar autenticação e autorização para controlar o acesso aos dados sensíveis.
5. O sistema precisa ser escalável e de fácil manutenção, com suporte a **migrações de banco de dados** para permitir futuras expansões ou modificações no esquema dos dados.
6. Todo o código será adequadamente documentado e testado. Para a documentação da API, utilizaremos **Swagger**, que facilitará o uso e a integração com outros sistemas.
