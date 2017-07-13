using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {


	public class Boss{
		private int hp =100;
		public int mp =53;
		private int power =25;

		public void Attack(){
			Debug.Log (this.power + "のダメージを与えた");
		}

		public void Defence(int damage){
			Debug.Log (damage + "のダメージを受けた");
			this.hp -= damage;
		}

		public void Magic(){
			mp -= 5;
			if (mp < 3) {
				Debug.Log ("MPが足りないため魔法が使えない。" );
			} else {
				Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
			}
		}


	}



	// Use this for initialization
	void Start () {
		
		int[] array = new int[5];

		array [0] = 10;
		array [1] = 20;
		array [2] = 30;
		array [3] = 40;
		array [4] = 50;

		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

		for (int i = 4; i > -1; i--) {
			Debug.Log (array [i]);
		}
	  

		Boss lastboss = new Boss ();

		lastboss.Attack ();
		lastboss.Defence (3);

		for (int i = 0; i < 11; i++) {
			lastboss.Magic ();
		}

			



	}



	// Update is called once per frame
	void Update () {
	
	}
}
