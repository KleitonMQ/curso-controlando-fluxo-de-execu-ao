using static System.Console;

WriteLine("Digita a sua idade");
int idade = int.Parse(ReadLine());

//sintaxe IF
if (idade >= 18){
    WriteLine("Você já pode ser preso.");
}else{
    WriteLine("Vai caçá o que fazê.");
}


//Sintaxe SWITCH
switch (idade){
    case 1:
    //TODO Alguma coisa se tiver 1 ano.
    break;
    case 2:
        //TODO Alguma coisa se tiver 2 anos.
    break;
default:
    WriteLine("Mensagem padrão caso não caia em nenhuma opção acima.");

break;
}


//sintaxe DO
do
{
    //Repete esta ação enquando a condição for verdadeira.
    //Detalhe da repetição "do" é que ela sempre vai executar pelo menos uma vez.
    idade++;2
    
} while (idade < 10);

//Sintaxe FOR
for (int i = 0; i < idade; i++)
{
    //TODO algum calculo envolvendo a idade. 
}

//foreach é mais usado para tratar com arrays (eu acho)
int[] lista = new int[]{1 ,2, 3 ,4};
foreach (var item in lista)
{
    WriteLine(item);
}