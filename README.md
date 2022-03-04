# HospitalProjeto
Sistema quando for inicializado a primeira vez vai pedir a quantidade de leitos que a unidade possui, essa e a unica configuracao que
e necessaria fazer antes de comecar utilizar o sistema.
No Menu inicial tera as seguintes opcoes.
[1]Entrada de paciente: o usuario do sistema ira dar inicio aos atendimentos passando uma senha para o paciente que chega na unidade,
essa senha sera zerada todo dia que o sistema for aberto. Pode ser entregue quantas senhas forem necessarias antes de comecar atender
na recepcao.
[2]Recepcao: o sistema chama o proximo referente a senha atual, o sistema exclui automaticamente as senha apos serem chamadas, nessa parte
os dados inicias do paciente sao necessarios. Com os dados inicias sao geradas duas filas, uma preferencial outra nao.
[3]Triagem: o sistema chama o proximo paciente referente a ordem de preferencia seguindo a proporcao solicitada 2 para 1, automaticamente.
[4]Lista Arquivados: E possivel ver todos pacientes arquivados e buscar um em especifico com o padrao CPF, todos sao salvos em um arquivo texto
automaticamente.
[5]Acompanhar Casos: Possivel acompanhar casos que nao estao arquivados ou na internacao/fila de internacao, possui buscar um especifico 
passando cpf, tambem sao salvos em um arquivo texto.
[6]Fila internacao: pacientes que nao estao na internacao estao aguardando uma vaga, eles sao ordenados com prioridades de comorbidades
e sao chamados automaticamente para a internacao quando é liberado um leito.
[7]Internacao: [7].[1]:Possivel adicionar um paciente direto a internacao, caso nao tenha vaga ele vai direto para fila de internacao.
[7].[2]: Buscar Paciente: busca um paciente especifico na internacao.
[7].[3]: Buscar um Paciente para dar alta, a automaticamente ele vai ser arquivado e liberando a vaga e chamado o proximo na fila de internacao
caso tenha.
[7].[4]:Imprimir lista Internacao: Imprimi todos pacientes na internacao.
[7].[5]:Quantidade de leitos disponiveis: Mostra todos leitos disponiveis na unidade caso tenha.
[7].[6]:Alterar quantidade de leitos: Possivel alterar a quantidade de leitos da unidade, exemplo caso na configuracao inicial tenha colocado
20leitos e possivel alterar essa quantidade por esse campo.

