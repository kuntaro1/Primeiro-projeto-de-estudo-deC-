// See https://aka.ms/new-console-template for more information

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice.roll: {roll1} + {roll2} + {roll3} + {total}");

if  ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)){
Console.WriteLine("Você teve dois resultados iguais, acaba de dobrar as suas chances!");
total += 2;

}
if ((roll1 == roll2) && (roll2 == roll3)){
    Console.WriteLine("Você triplicou suas chances cara +6 no bonus total!");
    total += 6; 
}
if(total >= 16){

Console.WriteLine("Você acaba de ganhar um carro novo! Meus parabéns!");
}
 else if (total >= 10){
Console.WriteLine("Você acaba de ganhar um notebook novo! Parabéns");
}  
else if (total == 7){
    Console.WriteLine("Você acaba de ganhar uma viagem com tudo pago! Parabéns");
}
else {
Console.WriteLine("Você ganhou um gatinho! Mais que fofo!");
} 