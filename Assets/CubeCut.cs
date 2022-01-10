using UnityEngine;

public class CubeCut : MonoBehaviour {
	public static bool Cut(Transform victim,Vector3 _pos)
	{
        Debug.LogError("work");
		Vector3 pos = new Vector3(_pos.x, victim.position.y, victim.position.z);
		Vector3 victimScale = victim.localScale;
		float distance = Vector3.Distance(victim.position, pos);
		//if (distance-15f >= victimScale.x/2) return false;
		
		Vector3 leftPoint = victim.position - Vector3.right * victimScale.x/2;
		Vector3 rightPoint = victim.position + Vector3.right * victimScale.x/2;
		Material mat = victim.GetComponent<MeshRenderer>().material;
		Destroy(victim.gameObject);
        Debug.LogError("workzzz");
        GameObject rightSideObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
		rightSideObj.transform.position = (rightPoint + pos) /2;
		float rightWidth = Vector3.Distance(pos,rightPoint);
		rightSideObj.transform.localScale = new Vector3( rightWidth-3f ,victimScale.y+5f ,victimScale.z + 9f);
		rightSideObj.AddComponent<Rigidbody>().mass = 10000f;
        rightSideObj.GetComponent<MeshRenderer>().material = mat;
        Destroy(rightSideObj.GetComponent<BoxCollider>(),0.1f);
		
		GameObject leftSideObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
		leftSideObj.transform.position = (leftPoint + pos)/2;
		float leftWidth = Vector3.Distance(pos,leftPoint);
		leftSideObj.transform.localScale = new Vector3( leftWidth-3f,victimScale.y+5f ,victimScale.z + 9f);
		leftSideObj.AddComponent<Rigidbody>().mass = 10000f;
		leftSideObj.GetComponent<MeshRenderer>().material = mat;
        Destroy(leftSideObj.GetComponent<BoxCollider>(),0.1f);
        Destroy(leftSideObj, 2f);
        Destroy(rightSideObj, 2f);
        return true;
	}
}
