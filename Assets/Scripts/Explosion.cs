using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
	public AnimatedSpriteRender start;
	public AnimatedSpriteRender middle;
	public AnimatedSpriteRender end;

	public void SetActiveRender(AnimatedSpriteRender render) {
		start.enabled = render == start;
		middle.enabled = render == middle;
		end.enabled = render == end;
	}

	public void SetDirection(Vector2 direction) {
		float angle = Mathf.Atan2(direction.y, direction.x);
		transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
	}

	public void DestroyAfter(float seconds) {
		Destroy(gameObject, seconds);
	}
}
