using UnityEngine;
using UnityEngine.UI;

public class CollectingCoins : MonoBehaviour
{
	public Text scoreText;
	private byte _collectedCoins;

	private void OnTriggerEnter(Collider other)
	{
		bool isCollidingWithCoin = other.CompareTag("Coins");

		if (isCollidingWithCoin)
		{
			Destroy(other.gameObject);
			_collectedCoins++;

			if (_collectedCoins != 3)
				scoreText.text = $"Coins: {_collectedCoins}";
			else
				scoreText.text = "Level Completed!";
		}
	}
}