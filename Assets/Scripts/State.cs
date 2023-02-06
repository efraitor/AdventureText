using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Es un atributo de la clase que nos permite crear ScriptableObjects de tipo State desde la ventana de Project
[CreateAssetMenu(menuName = "State")]
//Esta clase deriva ahora de los ScriptableObject
public class State : ScriptableObject
{
    //Genero un campo de texto de strings, con un tama�o espec�fico
    //[SerializeField] atributo permite que una variable o referencia siga siendo privada pero accesible desde el editor de Unity
    //[TextArea(,)] atributo que permite crear un cuadro de texto con la cantidad de l�neas escalable
    [TextArea(14, 10)] [SerializeField] string storyText;
    //Array de estados a los que podemos ir desde el estado actual
    [SerializeField] State[] nextStates; 

    //M�todo que nos devuelve el contenido de la caja de texto del ScriptableObject
    public string GetStateStory()
    {
        return storyText;
    }

    //M�todo que nos devuelve los estados a los que podemos ir desde el estado actual
    public State[] GetNextStates()
    {
        return nextStates;
    }
}
