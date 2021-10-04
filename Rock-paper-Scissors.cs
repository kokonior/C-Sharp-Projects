// a Simple Rock Paper Scissors game.

using System;

class MainClass {
 
	static int batu = 0;
	static int kertas = 1;
	static int gunting = 2;
	
	static int playerScore = 0;
	static int enemyScore = 0;
	
	static int playerSign = 0;
	static int enemySign = 0;
	
	static void Main() {
        
        Console.WriteLine("Selamat Datang di permainan Batu Kertas Gunting");
        Console.WriteLine("Masukkan angka pada bagian input dan pisahkan dengan Enter. Keterangannya di bawah ini:");
        Console.WriteLine(" 0 = batu,\n 1 = kertas,\n 2 = gunting.\n");
        Console.WriteLine("Selamat bermain\n");
        
		int round = 1;
		while(round < 6){
			Console.WriteLine("Ronde " + round);
			playerSign = Int32.Parse(Console.ReadLine());	
       
        Random r = new Random();
		enemySign = r.Next(0,3);
		
		CompareSigns();

		TranslatePlayerSign();
		TranslateEnemySign();
          
		round++;
		
		ShowScore();
      
		Console.WriteLine();
		}
		Console.WriteLine("Game Selesai");
		CheckFinalScore();
    }
    
    public static void CompareSigns(){
		if(playerSign == kertas && enemySign == batu){
			playerScore++;
			Console.WriteLine("Anda menang");
		}

		else if(playerSign == batu && enemySign == gunting){
			playerScore++;
			Console.WriteLine("Anda menang");
		}

		else if(playerSign == gunting && enemySign == kertas){
			playerScore++;
			Console.WriteLine("Anda menang");
		}

		else if(playerSign == enemySign){
			Console.WriteLine("Draw");
		}
		
		else{
			enemyScore++;
			Console.WriteLine("Anda kalah");
		}	
    }
    
    public static void TranslatePlayerSign(){
      if (playerSign == 0){
		  Console.WriteLine("Pilihan Anda adalah batu");
		} 
	  
	  else if(playerSign == 1){
		  Console.WriteLine("Pilihan Anda adalah kertas");
		}
	  
	  else if(playerSign == 2){
		  Console.WriteLine("Pilihan Anda adalah gunting");
		}
	  
	  else{
		  Console.WriteLine("Pilihan Anda tidak sesuai");
		}
    }
    
    public static void TranslateEnemySign(){
		if (enemySign == 0){
			Console.WriteLine("Pilihan musuh adalah batu");
		}
		
		else if(enemySign == 1){
			Console.WriteLine("Pilihan musuh adalah kertas");
		}
		
		else if(enemySign == 2){
			Console.WriteLine("Pilihan musuh adalah gunting");
		}
		
		else{
			Console.WriteLine("Pilihan musuh tidak sesuai");
		}
    }
    
    public static void ShowScore(){
       Console.WriteLine("Skor sementara Player: " + playerScore + " vs" + " Enemy: " + enemyScore);
    }
  
    public static void CheckFinalScore(){
        if(playerScore > enemyScore){
			Console.WriteLine("Selamat Anda Memenangkan Pertandingan!");
			Console.WriteLine("Hasil akhir Player: " + playerScore + " vs" + " Enemy: " +enemyScore);			
		}
	
		else if(playerScore == enemyScore){
			Console.WriteLine("Draw nih");
			Console.WriteLine("Hasil akhir Player: " + playerScore + " vs" + " Enemy: " +enemyScore);		
		}
		
		else{
			Console.WriteLine("Yah, Anda kalah. Coba lagi yaa");
			Console.WriteLine("Skor akhir Player: " + playerScore + " vs" + " Enemy: " +enemyScore);			
		}
	}
}

