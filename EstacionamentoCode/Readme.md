# Readme.md
## Sistema de Controle de Estacionamento

### Curso Code Now! de desenvolvimento C# e .net

#### Definição
Permitir controlar as vagas e gerenciar os veículos estacionados


#### Etapas
##### 1. Criação da Solução 'EstacionamentoCode'
	1.1. Criação de um Projeto Console 'EstacionamentoCode.Console' que conterá o projeto principal nessa etapa
	1.2. Criação de um Projeto Class Library 'EstacionamentoCode.Dominio' que conterá as Classes do Modelo
	1.3. Criação de um Projeto Class Library 'EstacionamentoCode.Infra' que conterá o Contexto e Repositórios
	1.4. Adicionar Referências entre os projetos
		1.4.1. Console deverá acessar Dominio e Infra
		1.4.2. Infra deverá acessar Domínio

##### 2. Criação dos Modelos
	2.1. Criar uma pasta Models no projeto Dominio
	2.2. Criar as Classes na pasta Models
	2.2.1. Classe Veiculo
		2.2.1.1 Propriedades
			2.2.1.1.01 Id - inteiro
			2.2.1.1.02 Placa - texto
			2.2.1.1.03 Tipo de Veículo - inteiro
		2.2.1.1 Métodos
			2.2.1.1.1 ValidarPlaca(placa) : Validará se a placa informada tem 3 caracteres

	2.2.2. Classe Estacionamento
		2.2.2.1 Propriedades
			2.2.2.1.01  Id - inteiro
			2.2.2.1.02  Nome - texto
			2.2.2.1.03  PrecoInicial - decimal
			2.2.2.1.04  PrecoHora - decimal
			2.2.2.1.05  Tolerancia - inteiro
			2.2.2.1.06  QtdeVagasTotais - inteiro
			2.2.2.1.07  Veiculos - Lista de Veículos
		2.2.2.2 Métodos
			2.2.2.2.01  Estacionar(veiculo) - Deve adicionar um veículo na lista de Veículos. Não pode ter mais de um veículo com a mesma placa
			2.2.2.2.02  ObterVagasOcupadas() - Deve retornar a quantidade de vagas ocupadas
			2.2.2.2.03  ObterVagasDisponiveis() - Deve retornar a quantidade de vagas disponíveis
			2.2.2.2.04  Obter(placa) - Deve retornar um veículo estacionado a partir da Placa. Retornar null se não encontrar o veículo
			2.2.2.2.05  Obter() - Deve retornar a lista com todos os veículos estacionados
			2.2.2.2.06  CalcularValor(placa, tempo) - Deve calcular o valor do estacionamento, com base no tempo do veículo estacionado
			2.2.2.2.07  Pagar(placa) - Deve identificar que o pagamento do estacionamento foi realizado
			2.2.2.2.08  Retirar(placa) - Deve remover o veículo do Estacionamento, desde que ele esteja pago
