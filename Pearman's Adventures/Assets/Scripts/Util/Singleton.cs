using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour {
    
	protected bool destroyOnSceneLoad;

    private static T _instance;
 
	public static T Instance {
		get {
			if (_instance == null) {
				_instance = (T) FindObjectOfType(typeof(T));

				// multiple objects = what
				if ( FindObjectsOfType(typeof(T)).Length > 1 ) {
					Debug.LogError("[Singleton] Something went really wrong " +
						" - there should never be more than 1 singleton!" +
						" Reopenning the scene might fix it.");
					return _instance;
				}

				// FindObjectOfType returned null because the object didnt exist
				if (_instance == null) {
					GameObject singleton = new GameObject();
					_instance = singleton.AddComponent<T>();
					singleton.name = "(singleton) "+ typeof(T).ToString();
					
					// keeps globals between scene transitions
					DontDestroyOnLoad(singleton);
					
					Debug.Log("[Singleton] An instance of " + typeof(T) + 
						" is needed in the scene, so '" + singleton +
						"' was created with DontDestroyOnLoad.");
				}
			}

			return _instance;
		}
	}
}