PROJETO CALCULADORA 
Mentoring, 2024 

Necessidade 
Criar uma calculadora com as 4 operações básicas, adição, subtração, multiplicação e divisão. 

Requisitos 
Entrada com 2 números 
Saída com cada operação conforme o ex.: x+y=z 
Salvar os resultados 
Possibilidade de consultar os resultados 
Programa não deve ser finalizado até que o usuário confirme a finalização 

Linguagem: C#
Front: Console do VS


Solução 
Classe: Operacoes  

Variáveis  
X double 
Y double 

Método: 
Adição - public double 
x+y 

Subtração - public double 
x-y 

Multiplicação - public doublre 
x*y 

Divisão - public double 
x*y 

 
Classe: Program 

Variáveis  
Operacoes: Resultado 
Arraylist: MemoResult 
Do While: MemoResult < 5 

Entrada:  
Informar a variável X 
Informar a variável Y 
Informar a operação (Adição, Subtração, Multiplicação, Divisão) 

Saída: 
X + Y = Z (Sinal conforme a operação) 
MemoResult [0] = Adição (aplicar para todas as operações) 
