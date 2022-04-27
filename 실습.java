package ch04;
import java.util.Scanner;

class Player{
	Scanner sc;
	private String name;
	private String word;
	
	public Player(String name) {
		this.name=name;
		sc=new Scanner(System.in);
	}
	
	public String getName() { return name; }
	
	public String getWordFromUser() {
		System.out.print(name+">>");
	    word=sc.next();
	    return word;
	}
	
	public boolean checkSuccess(String lastWord) {
		int lastIdx=lastWord.length()-1;
		
		if(lastWord.charAt(lastIdx)==word.charAt(0))
			return true;
		else
			return false;
	}
}

public class WordGameApp {
	private Scanner sc;
	private String startWord="아버지"; //시작단어
	private Player[] players; //게임 참가자 이름
	
	public WordGameApp() {
		sc=new Scanner(System.in);
	}
	
	public void createPlayers() {
		System.out.print("게임에 참가하는 인원은 몇명입니까 >>");
		int nPlayers = sc.nextInt();
		players=new Player[nPlayers];
		for(int i=0; i<nPlayers; i++) {
			System.out.print("참가자의 이름을 입력하세요 >>");
			String name = sc.next();
			players[i]=new Player(name);
		}
	}
	
	public void run() {
		createPlayers();
		String lastWord = startWord;
		System.out.println("시작하는 단어는 "+lastWord+"입니다");
		int next=0;
		
		while(true) {
			String newWord = players[next].getWordFromUser();
			if(!players[next].checkSuccess(lastWord)) {
				System.out.print(players[next].getName()+"이 졌습니다.");
				break;
			}
			next++;
			next %=players.length;
			lastWord = newWord;
		}
	}
	
	public static void main(String[] args) {
		WordGameApp game = new WordGameApp();
		game.run();
	}
}
